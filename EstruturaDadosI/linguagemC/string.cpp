 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <ctype.h>
 #include <string.h>
 
 int main(void){
 	char nome[20],arroba[20],juncao[41];
 	int i,j;
 	printf("Nome: ");
 	gets(nome);
 	printf("\n%s",nome);
 	strcpy(arroba,"@hotmail.com");
 	if (strcasecmp(nome,"paulo eduardo")==0){//==0 nao confundir ==1;
 		printf("Nome completo digitado.\n");
	 }
	else if (strcasecmp(nome,"paulo")==0){
		printf("Primeiro nome digitado.\n");
	}
	for (i=0;nome[i]!=0;++i){
		juncao[j]=nome[i];
		++j;			
	}
	for (i=0;arroba[i]!=0;++i){
		juncao[j]=arroba[i];
		++j;			
	}
	j=0;
	for (j=0;juncao[j]!=0;++j){
		printf("%c",juncao[j]);		
	}
 }
