 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <string.h>
 
 int main(void){
 	char string1[10],string2[10];
 	char conc1[10],conc2[10],result[20];
 	char texto1[] = "PAULO DE MELOS";

	char texto2[] = "DE";
	int posi, i, j, tam;
	char texto3[25];
 	printf("Preencha a cadeia de caracter com 10 caracteres: ");
 	gets(string1);
 	
 	strcpy(string2,string1); //primeiro coloque a variavel que recebera os caracteres
 	printf("%s\n",string2);
 	printf("Preencha p/ concatenar: ");
 	gets(conc1);
 	strcat(string1,conc1); // parametro 1 + parametro 2 retornando pro parametro 1
 	printf("\n%s",string1);
 	
 	printf("\nNumero de caracter da primeira cadeia concatenada: %d",strlen(string1));
 	printf("\nPosicao %s",strrchr(string1,'u'));
 	
 	printf("\nString1 = %s",string1);
 	printf("\nString1 + conc = %s",strstr(string1,conc1));//posicao alfebetica onde
 	//parametro1(carro) se encontra com o parametro2(rro) = strstr return (rro)

	posi = strstr(texto1, texto2) - texto1 ;
	// A função strlen retorna o tamanho da cadeia armazenada
	// na variável texto1
	tam = strlen(texto1);
	printf("\n\nTESTE2: tamanho(%d),posi(%d)",tam,posi);
 	return 1;
 	
 }
