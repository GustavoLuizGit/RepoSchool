#include <stdio.h>
#include <stdlib.h>
#include <stdarg.h>
#include <ctype.h>

#define MAXNAME 30
#define MAXNUM 5
#define MAXVAR 26
char look; /* O caracter lido "antecipadamente" (lookahead) */
int var[MAXVAR];
int posicaoVetor = 0;
char* content;

/* protótipos */
void init();
void nextChar();
void error(const char* fmt, ...);
void fatal(const char* fmt, ...);
void expected(const char* fmt, ...);
void match(char c);
char getName();
int getNum();
void emit(const char* fmt, ...);
int expression();
int term();
void add();
void subtract();
int factor();
void multiply();
void divide();
void ident();
void assignment();
void skipWhite();
void InitVar();
void newLine();
void input();
void output();
void lendoArquivo();
/* PROGRAMA PRINCIPAL */
int main()
{
	InitVar();
	init();
	do {
		switch (look)
		{
		case '?':
			input();
			break;
		case '!':
			output();
			break;
		case '\n':
			newLine();
			break;
		default:
			assignment();
		}
	} while (look != '.');
	return 0;
}

void input() {
	char buffer[20];
	match('?');
	char name = getName();
	printf("%c? ", name);
	fgets(buffer, 20, stdin);
	var[name - 'A'] = atoi(buffer);
}

void output() {
	match('!');
	char name = getName();
	printf("%c -> %d", name, var[name - 'A']);
}

/* analisa e traduz um comando de atribuição */
void assignment()
{
	char name;
	name = getName();
	match('=');
	var[name - 'A'] = expression();
	skipWhite();
}

int expression()
{
	int val;
	if (look == '+' || look == '-')
		val = 0;
	else
		val = term();

	while (look == '+' || look == '-')
	{
		switch (look)
		{
		case '+':
			match('+');
			val += term();
			break;
		case '-':
			match('-');
			val -= term();
			break;
		}
	}

	return val;
}

int term()
{
	int val = factor();
	
	skipWhite();

	while (look == '*' || look == '/')
	{
		switch (look)
		{
		case '*':
			match('*');
			val *= factor();
			break;
		case '/':
			match('/');
			val /= factor();
			break;
		}
	}

	return val;
}

void add()
{
	match('+');
	term();
	emit("POP BX");
	emit("ADD AX,BX");
}
void subtract()
{
	match('-');
	term();
	emit("POP BX");
	emit("SUB AX,BX");
	emit("NEG AX");
}
void multiply()
{
	match('*');
	factor();
	emit("POP BX");
	emit("IMUL BX");
}
void divide()
{
	match('/');
	factor();
	emit("POP BX");
	emit("XCHG AX,BX");
	emit("CWD");
	emit("IDIV BX");
}

/* analisa e traduz um fator */
int factor()
{
	int val;

	if (look == '(')
	{
		match('(');
		val = expression();
		match(')');
	}
	else
		if (isalpha(look)) {
			val = var[getName() - 'A'];
		}
		else
			val = getNum();

	return val;
}


/* analisa e traduz um identificador */

void ident()
{
	char name[MAXNAME + 1];

	getName();
	if (look == '(') {
		match('(');
		match(')');
		emit("CALL %s", name);
	}
	else
		emit("MOV AX, [%s]", name);
}



/* inicialização do compilador */
void init()
{
	lendoArquivo();
	nextChar();
	skipWhite();
}

/* lê próximo caracter da entrada */
void nextChar()
{
	look = content[posicaoVetor];
	posicaoVetor++;
}

#include <stdio.h>
#include <stdlib.h>

void lendoArquivo() {
	FILE* file;
	errno_t err;

	// Abrir o arquivo em modo de leitura
	err = fopen_s(&file, "C:\\Users\\gusta\\Documents\\GitHubRepositorios\\RepoSchool\\Compiladores\\Compilador\\VersãoLarge\\arquivoLarge.txt", "r");
	if (err != 0)
		fatal("Erro ao abrir o arquivo!");

	// Contar o número de caracteres
	int count = 0;
	int ch;

	while ((ch = fgetc(file)) != EOF) {
		count++;
	}

	// Alocar memória para content com o tamanho adequado
	content = (char*)malloc((count + 1) * sizeof(char));  // +1 para o caractere nulo

	// Verificar se a alocação de memória foi bem-sucedida
	if (content == NULL) 
		fatal("Erro ao alocar memória!");

	// Voltar ao início do arquivo
	fseek(file, 0, SEEK_SET);

	// Ler o conteúdo do arquivo para a variável content
	fread(content, sizeof(char), count, file);
	content[count] = '.'; // Adicionar o caractere nulo ao final do conteúdo

	// Fechar o arquivo
	fclose(file);
}


/* exibe uma mensagem de erro formatada */
void error(const char* fmt, ...)
{
	va_list args;

	fputs("Error: ", stderr);

	va_start(args, fmt);
	vfprintf(stderr, fmt, args);
	va_end(args);

	fputc('\n', stderr);
}

/* exibe uma mensagem de erro formatada e sai */
void fatal(const char* fmt, ...)
{
	va_list args;

	fputs("Error: ", stderr);

	va_start(args, fmt);
	vfprintf(stderr, fmt, args);
	va_end(args);

	fputc('\n', stderr);

	exit(1);
}

/* alerta sobre alguma entrada esperada */
void expected(const char* fmt, ...)
{
	va_list args;

	fputs("Error: ", stderr);

	va_start(args, fmt);
	vfprintf(stderr, fmt, args);
	va_end(args);

	fputs(" expected!\n", stderr);

	exit(1);
}

/* verifica se entrada combina com o esperado */
void match(char c)
{
	if (look != c)
		expected("'%c'", c);
	nextChar();
	skipWhite();
}

/* recebe o nome de um identificador */
char getName()
{
	char name;

	if (!isalpha(look))
		expected("Name");
	name = toupper(look);
	nextChar();
	skipWhite();
	return name;
}


/* recebe um número inteiro */
int getNum()
{
	int i = 0;

	if (!isdigit(look))
		expected("Integer");

	while (isdigit(look))
	{
		i *= 10;
		i += look - '0';
		nextChar();
	}
	return i;
}

/* emite uma instrução seguida por uma nova linha */
void emit(const char* fmt, ...)
{
	va_list args;

	putchar('\t');

	va_start(args, fmt);
	vprintf(fmt, args);
	va_end(args);

	putchar('\n');
}
/* pula caracteres de espaço */
void skipWhite()
{
	while (look == ' ' || look == '\t')
		nextChar();
}

void InitVar()
{
	for (int i = 0; i < MAXVAR; i++)
		var[i] = 0;
}

void newLine()
{
	while (look == '\n')
		nextChar();
}