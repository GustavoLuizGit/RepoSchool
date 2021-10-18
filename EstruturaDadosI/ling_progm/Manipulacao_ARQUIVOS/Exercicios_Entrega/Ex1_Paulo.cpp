 #include <iostream>
 #include <locale.h>
 
 int main(void){
 	char text[50];
 	FILE * arqv;
 	int a;
 	setlocale(LC_ALL,"");
 	arqv = fopen("exercicio1.txt","a");
 	
 	if (arqv == NULL)
 		printf("Arquivo não localizado !");
 		
 	else {
 		printf("ESSE TEXTO SERÁ GRAVADO NO ARQUIVO\n Digite um texto:");
 		gets(text);
 		fprintf(arqv,"%s",text); // variavel FILE , tipo de dado %s , variavel que contem o texto lido
	 } // f print f
 	fclose(arqv);
 }
