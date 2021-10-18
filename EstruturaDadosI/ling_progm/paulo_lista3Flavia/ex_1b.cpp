#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main(void){
	int qn,i=0,j,auxiliar[10],num[20],fat[20];
	int r[20];
	printf("Quantos numeros serao armazenados ? : ");
	scanf("%d",&qn);
	while(i<qn){
		++i;
		printf("Digite o %d numero: ",i);
		scanf("%d",&num[i]);
		auxiliar[i]=num[i]; // criei porque o num[i] perdia seu valor ao longo do progma		
		}
	
	for (i=1;i<=qn;++i){
		fat[i]=1;
	while (num[i]>1){
		fat[i]*=num[i];
		--num[i];
		printf("%d\n",num[i]);
				
		}
	}
	for (i=1;i<=qn;++i){
		printf("Fatorial de %d e = %d\n",auxiliar[i],fat[i]);
	}
		
} 
