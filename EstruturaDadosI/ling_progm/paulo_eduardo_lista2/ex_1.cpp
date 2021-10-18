 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 #include <math.h>
 
 int main(void) {
 	int n;
 	setlocale(LC_ALL,"");
 	printf("DIGITE UM NÚMERO: ");
 	scanf("%i",&n);
 	
 	if(n>0) 
	 	printf("RAIZ DE %i = %.1f",n,sqrt(n));
	else
		printf("NÚMERO INVÁLIDO(VALOR NEGATIVO)....");
 }
