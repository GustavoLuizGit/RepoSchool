#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>

int strtam(char string[20]){


	int i,cont,tam;
	tam=strlen(string);
		for(i=0;i<tam;++i){
			if(string[i]!='\0'&& string[i]!=' '){
				cont++;
			}		
		}
	return cont;
}

int main(void){
	char string[20];
	int a;
	printf("Digite uma string: ");
	gets(string);
	
	a=strtam(string);
	printf("%d",a);
}
