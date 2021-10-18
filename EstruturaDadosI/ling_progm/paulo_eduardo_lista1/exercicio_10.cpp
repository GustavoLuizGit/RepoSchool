#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>
#include <math.h>

int main(void) {
	setlocale(LC_ALL,"");
	int n,opc;
	printf("Por favor,informe um número: \n");
	scanf("%i",&n);
	system("cls");
	do {
	
	printf("========MENU========\n");
	printf("===== 1. NÚMERO DIGITADO AO QUADRADO: ");
	printf("\n===== 2. NÚMERO DIGITADO AO CUBO: \n");
	printf("===== 3. RAIZ QUADRADA DO NÚMERO DIGITADO: \n");
	printf("===== 4. RAIZ CÚBICA DO NÚMERO DIGITADO: \n");
	printf("====== 5. SAIR\n");
	scanf("%i",&opc);
		if (opc == 1) {n = pow(n,2);
		printf(" 1. = %i\n",n);
		}
		else if ( opc == 2) {
			n = pow(n,3);
			printf("2. = %i \n",n);
		}
		else if ( opc ==3) {
			n = sqrt(n);
			printf("3. = %i \n",n);
		}
		else if ( opc==4) {
			n = cbrt(n);
			printf("4. = %i\n",n);
		}
	
		
	
	} while(opc <= 4);
}
