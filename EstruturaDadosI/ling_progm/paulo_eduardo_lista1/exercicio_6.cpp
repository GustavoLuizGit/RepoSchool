 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 float calc(int s) {
 	int s_final;
 	s = s * (5/100.) + s ; //salario com gratificacao; + 5%
 	s_final = (s/100) * 7 ; //desconto imposto;	-7%
	return (s - s_final);	
 }
 
 int main(void) { //f principal
 	int a,b;
 	printf("Informe seu salario base : ");
 	scanf("%i",&a);
 	b = calc(a);
 	printf("Salario base apos reajuste e desconto: %i $reais",b);
 }
