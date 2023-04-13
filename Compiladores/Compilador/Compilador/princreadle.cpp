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

char look; /* O caracter lido "antecipadamente" (lookahead) */

/* protótipos */
void init();
void nextChar();
void error(const char* fmt, ...);
void fatal(const char* fmt, ...);
void expected(const char* fmt, ...);
void match(char c);
char getName();
char getNum();
void emit(const char* fmt, ...);
void expression();
void term();
void add();
void subtract();

/* PROGRAMA PRINCIPAL */
int main()
{
	init();
	expression();
	return 0;
}

void expression()
{
	term();

	while (look == '+' || look == '-') {
		emit("MOV BX,AX");
		
		switch (look) {
		case '+':
			add();
			break;
		case '-':
			subtract();
			break;
		default:
			expected("AddOP");
		}
	}
}

void add()
{
	match('+');
	term();
	emit("ADD AX,BX");
}
void subtract()
{
	match('-');
	term();
	emit("SUB AX,BX");
	emit("NEG AX");
}

void term()
{
	emit("MOV AX,%c", getNum());
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
char getNum()
{
	char num;
	if (!isdigit(look))
		expected("Integer");
	num = look;
	nextChar();
	return num;
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