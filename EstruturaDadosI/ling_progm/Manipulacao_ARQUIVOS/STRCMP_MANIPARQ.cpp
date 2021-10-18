 #include <iostream>
 #include <locale.h>
 #include <string.h>
 
 int main(void){
 	FILE * arquivo;
 	char text[50];
 	setlocale(LC_ALL,"");
 	arquivo = fopen("texto1.txt","a");
 	
 	if(arquivo==NULL){
 		printf("Arquivo não executado!\n");
	 }
	 else{
	 	printf("\nInsira um texto para anexar ao arquivo: ");
	 	gets(text);
	 	while(strcmp(text,"fim")!=0){
	 		//fputs(text,arquivo);
	 		
	 		fprintf(arquivo,"%s\n",text);
	 		printf("Digite outro texto: ");
	 		gets(text);	 		
	 		printf("\nDigite   <fim>    para sair\n");
	 		
		 }
	 }
	 if (ferror(arquivo))
	 	printf("O arquivo não pode ser inicializado!\n");
 	fclose(arquivo);
 }
