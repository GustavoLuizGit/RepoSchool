 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <math.h>
 #include <locale.h>
 
 int main(void){
 	int p,l,i,test1,test2;
 	setlocale(LC_ALL,"");
 	printf("Digite o pre�o de f�brica do ve�culo: ");
 	scanf("%i",&p);
 	printf("Digite o percentual de lucro do distribuidor: ");
 	scanf("%i",&l);
 	printf("Digite o percentual de imposto: ");
 	scanf("%i",&i);
 	printf("----------------------------\n");
 	printf("==== A) LUCRO DO DISTRIBUIDOR: %i reais\n",test1 = (p / 100)*l);
 	printf("==== B) VALOR CORRESPONDENTE AO IMPOSTO: %i reais\n",test2 = (p / 100)*i);
 	printf("==== C) VALOR FINAL DO VE�CULO: %i",test1 + test2 + p);
	  }
