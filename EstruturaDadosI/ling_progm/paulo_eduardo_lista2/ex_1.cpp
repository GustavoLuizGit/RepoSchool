 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 #include <math.h>
 
 int main(void) {
 	int n;
 	setlocale(LC_ALL,"");
 	printf("DIGITE UM N�MERO: ");
 	scanf("%i",&n);
 	
 	if(n>0) 
	 	printf("RAIZ DE %i = %.1f",n,sqrt(n));
	else
		printf("N�MERO INV�LIDO(VALOR NEGATIVO)....");
 }
