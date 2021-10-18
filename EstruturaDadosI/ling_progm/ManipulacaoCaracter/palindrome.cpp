#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <ctype.h>
#include <locale.h>
char strcopy(char receb[20],char emp[20]){
	int i=0,a=0,tam;
	tam=strlen(emp);
	
	for(i=tam-1;i>=0;--i){
		receb[a]=emp[i];
		++a;
	}
	receb[a]='\0';
}

int main(void){
	char f1[20],f2[20];
	int i,a,cont=0;
	char ff[20],fi[20],b[20];
	setlocale(LC_ALL,"");
	//printf("Frase: ");
	//gets(f1);
	//strcat(f2,f1);
	
	for(i=0;i<strlen(f1);++i){
		f1[i]=0;
		f2[i]=0;
		ff[i]=0;
		fi[i]=0;
	}
	
	strcat(f2,f1);
	
	
	printf("================USO DA FUNCAO NOVA ===================\n");
	printf("Frase 2 : ");
	gets(ff);
	strcopy(fi,ff);
	a=strlen(ff);
	printf("Frase inversa: %s\n",fi);
//		for(i=0;i<strlen(ff);++i){
//		
//		if(ff[i]==fi[i]){
//			
//			cont++;                      ////USO SEM A FUNÇÃO STRCMP
//		}					
//		--a;
//	}
//		if(cont==strlen(ff)){
//			printf("É um palindrome...");
//		}
//		else	
//			printf("Não e um palindrome...");
		for(i=0;i<strlen(ff);++i){
			if(toupper(ff[i])==toupper(fi[i])){
				cont++;
			}
		}
		if(strlen(ff)==cont){
			printf("É palindrome !");
		}
		else
			printf("Não é um palindrome %d!",cont);
		
//		if(toupper(strcmp(ff,fi)==0)){
//			printf("É palindrome!");
//		}									///USO DA FUNCAO STRCMP,POREM SEM DISTINGUIR
											///MAIUSCULO DO MINUSCULO
//		else
//			printf("Nem é palindromeee");
	
}
