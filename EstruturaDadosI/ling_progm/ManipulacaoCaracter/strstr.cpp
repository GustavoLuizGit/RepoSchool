 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <string.h>
 
 int main(){
 	char texto1[] = "PAULO DE MELOS";
 	char texto2[] = "DE";
 	int posi,tam;
 	tam = strlen(texto1);
 	posi = strstr(texto1, texto2) - texto1;
 	printf("Posicao de encontro = %d",posi);//funcao strstr pode retornar
 	//um valor int ou se chamar função(text1,text2) retorna o inicio da localização de encontro apenas;
 	printf("\nTamanho text1 = %d",tam);
 }
