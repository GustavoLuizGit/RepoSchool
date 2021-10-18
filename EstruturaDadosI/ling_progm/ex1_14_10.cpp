 #include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include <ctype.h>

int main(void){
	char frase[50],aux[50],nova_frase[50];
	int a,b,c,d,e,f,i,j,tam,p,cont;
	int vet[20];
	char caracter_maior,test[]={'o'};
	printf("Digite uma frase: ");
	gets(frase);
	
	tam=strlen(frase);
	
	strcpy(aux,frase);
	
	for(i=0;i<tam;++i){
		
		if(frase[i]==' '){
		if(a==0){
		
			p=i+1; //posicao do space
			while(a<p){
				if(frase[a])
				aux[a]=frase[a];
				++a;
				
			}
		}
		 if(a>=1 || frase[i]>aux[0]){
			aux[a]=frase[i];
			++a;
		}
		}	
	
	}

	for (i=0;i<a;++i){
		printf("\n %c ",aux[i]);
		
	}
	printf("%s",aux);


	
	
}
