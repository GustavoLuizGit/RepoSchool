#include <stdio.h>
#include <stdlib.h>
#include <stdarg.h>
#include <ctype.h>

#define MAXNAME 30
#define MAXNUM 5
#define MAXVAR 26

char look; /* O caracter lido "antecipadamente" (lookahead) */
int var[MAXVAR];

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

/* PROGRAMA PRINCIPAL */
int main()
{

	InitVar();
	init();
	
	do {
		switch (look)
		{
			case '?' :
				input();
				break;
			case '!' :
				output();
				break;
			case '\n':
				newLine();
				break;
			default :
				assignment();
		}
		newLine();
	} while (look != ',');
	
	printf("%d", var[0]);
	
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
	nextChar();
	skipWhite();
}

/* lê próximo caracter da entrada */
void nextChar()
{
	look = getchar();
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