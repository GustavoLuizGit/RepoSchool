#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>

int main(void){
	char texto1[20] = "PROGRAMA COMPUTADOR";
	char texto2[20] = "PARA";
	char texto3[25];
	int i,j,tam,aux_espaco=0;
	
	tam = strlen(texto1);
	i=0;
	while(i<tam && aux_espaco==0){
		if(texto1[i]== ' '){
			aux_espaco=1;
		}
		else
			++i;
	}
	strcpy(texto3,texto1);
	texto3[i+1]='\0';
	printf("\n TEXTO3: %s",texto3);
}
