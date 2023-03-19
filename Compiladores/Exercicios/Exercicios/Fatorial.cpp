#include <stdio.h>

int fat(int);

int main(void) {
    int numero = 3;
    printf("Fatorial de %d = %d", numero, fat(numero));
}

int fat(int n)
{
    if (n <= 1)
        return 1;
    else
        return n * fat(n - 1);
}