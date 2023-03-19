#include <stdio.h>
#include <locale.h>

int Fibonacci(int);

int main(void) {
    setlocale(LC_ALL,"");

    int posicaoRequisitadaFibonacci = 6;
    printf("O %d° elemento da sequencia de Fibonacci é %d", posicaoRequisitadaFibonacci, Fibonacci(posicaoRequisitadaFibonacci));
    
    posicaoRequisitadaFibonacci = 10;
    printf("\nO %d° elemento da sequencia de Fibonacci é %d", posicaoRequisitadaFibonacci, Fibonacci(posicaoRequisitadaFibonacci));


}

int Fibonacci(int posicaoRequisitadaFibonacci) {
    if (posicaoRequisitadaFibonacci <= 1)
        return posicaoRequisitadaFibonacci;
    else
        return Fibonacci(posicaoRequisitadaFibonacci - 1) + Fibonacci(posicaoRequisitadaFibonacci - 2);

}