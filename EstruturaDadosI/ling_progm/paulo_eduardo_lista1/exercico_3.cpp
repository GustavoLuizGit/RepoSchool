 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 
 int main(void) {
 	int s,p;
 	float a;
 	setlocale(LC_ALL,"");
 	
 	printf("Digite o seu sal�rio: ");
 	scanf("%i",&s);
 	printf(">>Digite o percentual de aumento p/ o sal�rio de ( %.2i $reais) <<: ",s);
 	scanf("%i",&p);
 	printf("\n\n\n");
 	a = s * (p/100.);						 	
 	printf("Valor do aumento: %.2f $reais",a);
 	printf("\nNovo sal�rio: %.2f $reais",s+a);
 	
 }
