/*
The Cradle - O Berço
O código abaixo foi escrito por Felipo Soranz e é uma adaptação
do código original em Pascal escrito por Jack W. Crenshaw em sua
série "Let's Build a Compiler".
Este código é de livre distribuição e uso.
*/
#include <stdio.h>
#include <stdlib.h>
#include <stdarg.h>
#include <ctype.h>
#define MAXNAME 30
#define MAXNUM 5

char look; /* O caracter lido "antecipadamente" (lookahead) */

/* protótipos */
void init();
void nextChar();
void error(const char* fmt, ...);
void fatal(const char* fmt, ...);
void expected(const char* fmt, ...);
void match(char c);
void getName(char*);
void getNum(char*);
void emit(const char* fmt, ...);
void expression();
void term();
void add();
void subtract();
void factor();
void multiply();
void divide();
void ident();
void assignment();
int isAddOp(char);

/* PROGRAMA PRINCIPAL */
int main()
{
	init();
	assignment();
	if (look !='\n')
		expected("NewLine");
	return 0;
}

void expression()
{
	if (isAddOp(look))
		emit("XOR AX, AX");
	else
		term();
	while (isAddOp(look)) {
		emit("PUSH AX");
		switch (look) {
		case '+':
			add();
			break;
		case '-':
			subtract();
			break;
		default:
			expected("AddOp");
			break;
		}
	}
}

int isAddOp(char c)
{
	return (c == '+' || c == '-');
}

void term()
{
	factor();
	while (look == '*' || look == '/') {
		emit("PUSH AX");
		switch (look) {
		case '*':
			multiply();
			break;
		case '/':
			divide();
			break;
		default:
			expected("MulOp");
			break;
		}
	}
}

void factor()
{
	char num[MAXNUM + 1];
	if (look == '(') {
		match('(');
		expression();
		match(')');
	}
	else if (isalpha(look)) {
		ident();
	}
	else {
		getNum(num);
		emit("MOV AX, %s", num);
	}
}

void assignment()
{
	char name[MAXNAME + 1];
	getName(name);
	match('=');
	expression();
	emit("MOV [%s], AX", name);
}

void ident()
{
	char name[MAXNAME + 1];
	getName(name);
	if (look == '(') {
		match('(');
		match(')');
		emit("CALL %s", name);
	}
	else
		emit("MOV AX, [%s]", name);
}

void multiply() {
	match('*');
	factor();
	emit("POP BX");
	emit("IMUL BX");
}

void divide() {
	match('/');
	factor();
	emit("POP BX");
	emit("CWD");
	emit("XCHG AX, BX");
	emit("IDIV BX");
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
	emit("SUB AX, BX");
	emit("NEG AX");
}

/* inicialização do compilador */
void init()
{
	nextChar();
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
}
/* recebe o nome de um identificador */
void getName(char* name)
{
	int i;
	if (!isalpha(look))
		expected("Name");
	for (i = 0; isalnum(look); i++) {
		if (i >= MAXNAME)
			fatal("Identifier too long!");
		name[i] = toupper(look);
		nextChar();
	}
	name[i] = '\0';
}
/* recebe um número inteiro */
void getNum(char* num)
{
	int i;
	if (!isdigit(look))
		expected("Integer");
	for (i = 0; isdigit(look); i++) {
		if (i >= MAXNUM)
			fatal("Integer too long!");
		num[i] = look;
		nextChar();
	}
	num[i] = '\0';
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