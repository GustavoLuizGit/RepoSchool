#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>
#include <math.h>

int main(void) {
	int op,n1,n2;
	setlocale(LC_ALL,"");
	printf("====MENU====\n");
	printf("1. SOMAR DOIS N�MEROS: \n");
	printf("2. RAIZ QUADRADA DE UM N�MERO: \n");
	scanf("%i",&op);
	
	switch(op) {
	case	1: printf("Digite dois n�meros: ");
	       scanf("%i %i",&n1,&n2);
	       printf("\nResultado: %i",n1+n2);
	       break;
	case    2: printf("Digite um n�mero: ");
	       scanf("%i",&n1);
	       printf("\nRaiz de %i = %i",n1,sqrt(n1));
	       break;
	    default : printf("Op��o inv�lida . Tente novamente ....");
	}
}
