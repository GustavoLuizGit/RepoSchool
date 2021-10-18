#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include <ctype.h>

int main(void){
	char frase[50],aux[50],nova_frase[50];
	int a,b,i,j,p=0,tam,c;
	int vet[20],vazio=0;
	char caracter_maior,test[]={'o'};
	char vetchar[50];
	printf("Digite uma frase: ");
	gets(frase);
	
	tam=strlen(frase);
	
	strcpy(aux,frase);
	for(i=0;i<tam;++i){
		
		if(frase[c]!=' ' && vazio ==0){
			vetchar[p]=frase[c];
			++p;
			++c;
				if(frase[c]==' ')
					++vazio;
		}
		else if(vazio>1 && frase[i]>vetchar[p]){
			
		}		
	
	}
	printf("\n vetchar: %s",vetchar);
	
}
