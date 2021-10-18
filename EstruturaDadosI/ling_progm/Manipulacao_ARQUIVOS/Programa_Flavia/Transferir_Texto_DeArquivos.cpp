#include <iostream>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

int main(){
	FILE *f1,*f2;
	char texto[50];
	
	f1 = fopen ("f1.txt","r");
	f2 = fopen ("f2.txt","w");
	char c = fgetc(f1);
	if (f1 == NULL || f2 == NULL)
		printf("Erro na leitura");
	
	else{
		//fgets(texto,50,f1);	
		while(c != EOF){ // eofimmmm
			fputc(toupper(c),f2);
			c = fgetc (f1);
		}
		
	}
	
	if(ferror(f1)||ferror(f2))
		printf("Erro no arquivo");
	
	else
		printf("\nLeitura e gravacao concluidas.");
		
	fclose(f1);
	fclose(f2);
}
