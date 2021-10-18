#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main(void){
	int qn,i,j,auxiliar[10];

	printf("Entre com a quantidade de numeros que serao lidos: ");
	scanf("%d",&qn);
	int num[qn],fat,fatorial[qn];
		for (i=1;i<=qn;++i){
			printf("Entre com o %d numero: ",i);
			scanf("%d",&num[i]);
			auxiliar[i]=num[i];			
		}
		for (i=1;i<=qn;++i){
			fat=1;
			for (j=num[i];num[i]>=2;--num[i]){
				//printf("%d\n",num[i]);
				fat*=num[i];				
			}
			fatorial[i]=fat;						
		}
		for (i=1;i<=qn;++i)	{	
		printf("%d.o: %d = %d\n",i,auxiliar[i],fatorial[i]);
		
		}
		
		
} 
