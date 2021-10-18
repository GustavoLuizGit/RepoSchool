 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h> 
 float retorno(int x) {
 	float y;
 	y = (x * 25) /100 + x;
 	return y;	
 }
 
 
 int main(void){
 	int s,a;
 	setlocale(LC_ALL,"");
 	printf("===...CALCULADOR DE SALÁRIO...===\n");
 	printf("Funcionário,digite seu salario atual: ");
 	scanf("%i",&s);
	printf("\nSeu salário pós aumento de 25 por cento = %.2i $reais",a=retorno(s));
 }
