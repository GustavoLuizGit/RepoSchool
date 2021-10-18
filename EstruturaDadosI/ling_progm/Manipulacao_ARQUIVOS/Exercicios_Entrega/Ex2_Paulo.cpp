 #include <iostream>
 #include <locale.h>
 
 int main(void){
 	FILE * arqv;
 	char text[50];
 	setlocale(LC_ALL,"");
 	
 	arqv = fopen("exercicio2.txt","r");
 	if (arqv == NULL){
 		printf("Não foi possível realizar a leitura do arquivo!");
	 }
	else {
		fgets(text,50,arqv); // importante : NAO ESQUECER DO NUMERO DO MEIO INFORMANDO A QUANTIDA DE CARACTER A SER LIDA
		printf("Caracteres encontrados no arquivo: \n");
		printf("%s",text);
	}
 	fclose(arqv);
 }
