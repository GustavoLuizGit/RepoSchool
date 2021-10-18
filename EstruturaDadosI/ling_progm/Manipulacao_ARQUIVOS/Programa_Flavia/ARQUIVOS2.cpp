#include <iostream>

int main(void){
	FILE * arquivo;
	char nome[50];
	//fopen abre um arquivo || ou cria ,como no caso
	arquivo = fopen("teste.txt","a"); //a anexa arqv de texto
					//1.o parametro que criará um arquvivo teste.txt, nesse caso,na pasta do programa cpp
	if ( arquivo == NULL)
		printf("\nErro na abertura...");
		
	else {
		printf("\nDigite o nome: ");
		gets(nome);
		fputs(nome,arquivo);
		
		fputc('\n',arquivo);
	}
	fclose(arquivo);
	system("pause");
	return 1;
}
