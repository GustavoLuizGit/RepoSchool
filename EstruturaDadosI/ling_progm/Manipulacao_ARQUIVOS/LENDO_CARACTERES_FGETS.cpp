#include <iostream>

int main(void){
	FILE * arquivo;
	arquivo = fopen("fgets.txt","r");
	char text[50];
	
	if(arquivo==NULL)
		printf("Erro.\n");
	else{
		while(!feof(arquivo)){ // feof() indica o fim da cadeia de caracteres file
		
		fgets(text,10,arquivo);
		printf("%s",text);
	}
	}
	
	if (ferror(arquivo))
		printf("\nO arquivo apresenta erros.\n"); //ferror aponta falhas 
	else
		printf("\nLeitura feita corretamente\n");
		
	fclose(arquivo);
}
