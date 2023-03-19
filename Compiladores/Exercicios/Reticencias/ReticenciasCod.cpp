#include <stdio.h>
#include <stdarg.h>

void write(const char* fmt, ...)
{
    va_list args;
    va_start(args, fmt);
    vprintf(fmt, args);
    va_end(args);
}

int main(void)
{
    write("Ola mundo\n");
    write("Meu nome é %s", "Gustavo\n");
    write("A soma de 2+5 = %d. A multiplicação de 3*6=%d\n", 2 + 5, 3 * 6);
    return 1;
}