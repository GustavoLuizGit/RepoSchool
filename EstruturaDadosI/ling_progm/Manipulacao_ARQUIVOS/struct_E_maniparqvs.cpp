#include <iostream>
#include <stdio.h>
#include <locale.h>
 int main(){
 	FILE * arquivo;
 	char t[50];
 	setlocale(LC_ALL,"");
 	
 	arquivo = fopen("texto1.txt","a");
 	if(arquivo==NULL){
 		printf("Não foi possivel abrir o arquivo...");
	 }
	else{
 	printf("Digite um texto para inserir no arquivo: ");
 	gets(t);
 	fputs(t,arquivo);
 	}
 	fclose(arquivo);
 }
 
