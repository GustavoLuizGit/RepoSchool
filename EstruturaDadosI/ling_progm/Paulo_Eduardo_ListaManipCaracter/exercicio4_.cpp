#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include <ctype.h>

int main(void){
char frase[20],aux[]={'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
	int i,j,a,b,p,tam_aux,tam_frase;
	char cont;
	int vetor_num[20];
	char vetor_letra[20],frase2[20];
	char vet_test[50];
	vetor_num[3]=0;
	vetor_num[2]=0;
	
	printf("Entre com uma frase: ");
	gets(frase);
	tam_aux=strlen(aux);
	tam_frase=strlen(frase);
	strcpy(frase2,frase);
	strcpy(vet_test,frase);
	
	for(i=0;frase[i]!='\0';++i){
		
	cont=frase[i];	
	while(cont==frase[i]){
		vetor_letra[p]=cont;
		vetor_num[p]+=1;
		++p;
		//printf("TESTE");
	}
	}
	
	for(i=0;i<p;++i){
		p=i;
		printf("%c : %d",vetor_letra[p],vetor_num[p]);
	}
	
}
