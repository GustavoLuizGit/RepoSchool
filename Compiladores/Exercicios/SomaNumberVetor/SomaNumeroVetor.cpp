#include <stdio.h>

int somaNumerosArray(int arrayNumeros[], int qtdPrimeirosNumerosCalcular) {
    if (qtdPrimeirosNumerosCalcular == 1) 
        return arrayNumeros[0];
    else 
        return arrayNumeros[qtdPrimeirosNumerosCalcular - 1] + somaNumerosArray(arrayNumeros, qtdPrimeirosNumerosCalcular - 1);
}

int main(void) {
    int qtdPrimeirosNumerosCalcular = 3;
    int arrayNumeros[] = { 3, 2, 1, 5, 4 };

    printf("A soma dos %d primeiros numeros do array e %d", qtdPrimeirosNumerosCalcular, somaNumerosArray(arrayNumeros, qtdPrimeirosNumerosCalcular));
}

