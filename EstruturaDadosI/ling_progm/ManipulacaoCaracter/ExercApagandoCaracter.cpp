#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>

int main(void){
	char texto1[] = "CIENCIA DA COMPUTACAO";
	char texto2[] = "DA";
	char texto3[20];
	int posi,tam,tam2,i,j;
	tam = strlen(texto1);
	tam2 = strlen(texto2);
	posi = strstr(texto1,texto2)-texto1;
	printf("POSI = %d\n",posi);
	
	for(i=0;i<posi;++i)
	{
		texto3[i]=texto1[i];
		j=i;
	}
	
	for(i=posi + tam2;i<=tam;++i){
		texto3[j]=texto1[i];
		j=j+1;
	}
	printf("\nTEXTO3 : %s",texto3);
	
}
