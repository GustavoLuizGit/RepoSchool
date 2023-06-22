#include <stdio.h>
#include <stdlib.h>
#include <stdarg.h>
#include <ctype.h>

#define MAXNAME 30
#define MAXVAR 26

char look; /* O caracter lido "antecipadamente" (lookahead) */
int var[MAXVAR];
FILE* file;

/* Funções */
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
int factor();
void assignment();
void skipWhite();
void initVar();
void newLine();
void input();
void output();
void lerArquivoInformado(int, char* arq[]);
/* PROGRAMA PRINCIPAL */
int main(int args, char* arq[])
{
    lerArquivoInformado(args, arq);

    initVar();
    init();

    do {
        switch (look) {
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

    fclose(file);
    return 0;
}

void lerArquivoInformado(int, char* arq[])
{
    file = fopen(arq[1], "r");

    if (file == NULL) {
        fatal("erro ao abrir arquivo", arq[1]);
    }
}

void input() {
    char buffer[20];
    match('?');
    char name = getName();
    printf("%c? ", name);
    fgets(buffer, 20, stdin);
    var[name - 'A'] = atoi(buffer);
}

void output()
{
    match('!');
    char name = getName();
    printf("%c->%d", name, var[name - 'A']);
}

/* Analisa e traduz um comando de atribuição */
void assignment()
{
    char name = getName();
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

    skipWhite();

    return val;
}

void init()
{
    nextChar();
    skipWhite();
}

void nextChar()
{
    look = fgetc(file);
}

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

void match(char c)
{
    if (look != c)
        expected("'%c'", c);
    nextChar();
    skipWhite();
}

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

void emit(const char* fmt, ...)
{
    va_list args;

    putchar('\t');

    va_start(args, fmt);
    vprintf(fmt, args);
    va_end(args);

    putchar('\n');
}

void skipWhite()
{
    while (look == ' ' || look == '\t')
        nextChar();
}

void initVar()
{
    for (int i = 0; i < MAXVAR; i++)
    {
        var[i] = 0;
    }
}

void newLine()
{
    while (look == '\n')
        nextChar();
}