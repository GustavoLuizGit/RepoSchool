 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 int barra(int x) {
 	int i;
 	for (i=1;i<=x;++i) {
 		printf("=");
	 }
	 printf("\n");
 }
 int main(void) {
 	setlocale(LC_ALL,"");
 	int dep,j;
 	printf("DIGITE O VALOR DO DEPÓSITO: ");
 	scanf("%i",&dep);
 	printf("DIGITE A TAXA DE JUROS: ");
 	scanf("%i",&j);
 	system("cls || clear");
 	barra(40);
 	printf("TAXA DE RENDIMENTOS: $%.1i \n",(dep / 100 ) * j);
 	printf("VALOR TOTAL COM RENDIMENTOS: $%.1i \n",(dep/100)*j + dep);
 	barra(40);
 }
