 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 
 int main(void) {
 	int h,s,imp;
 	float s1;
 	setlocale(LC_ALL,"");
 	printf("Digite a quantidade de horas trabalhadas: ");
 	scanf("%i",&h);
 	printf("Digite o salário mínimo atual: ");
 	scanf("%i",&s);
 	
 	s1 = h * (s/h);
	imp = (s1 / 100)*3;
 	printf("SALÁRIO A RECEBER = $%.2f reais",s1-imp);
 	
 }
