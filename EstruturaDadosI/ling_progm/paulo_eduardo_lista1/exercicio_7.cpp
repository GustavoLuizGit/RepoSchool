 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 
 int main(void) {
 	setlocale(LC_ALL,"");
 	float s;
 	printf("........Digite seu sal�rio atual:  .......\n");
 	scanf("%f",&s);
	printf("SAL�RIO AP�S DESCONTO DO IMPOSTO DE 10 POR CENTO: $%.1f \n",s-(s/100) * 10);
	printf("SAL�RIO FINAL GRATIFICA��O DE $50 == $%.1f",s-(s/100) * 10 + 50.);
 	
 	
 }
