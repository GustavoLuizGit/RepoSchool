 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 
 int main(void) {
 	setlocale(LC_ALL,"");
 	int s;
 	
 	printf("======Informe seu salário atual: ======\n");
 	scanf("%i",&s);
 	
 	printf(" Salário após 25 por cento de aumento: %.1f $reais",s * (25/100.) + s);
 }
