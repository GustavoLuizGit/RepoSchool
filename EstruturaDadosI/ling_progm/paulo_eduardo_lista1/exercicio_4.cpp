 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 
 int main(void) {
 	setlocale(LC_ALL,"");
 	int s;
 	
 	printf("======Informe seu sal�rio atual: ======\n");
 	scanf("%i",&s);
 	
 	printf(" Sal�rio ap�s 25 por cento de aumento: %.1f $reais",s * (25/100.) + s);
 }
