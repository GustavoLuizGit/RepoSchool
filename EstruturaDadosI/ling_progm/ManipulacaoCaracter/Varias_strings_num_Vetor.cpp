 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <string.h>
 struct Dados{
 char	nome[50];
 };
 
 int main(void){
 	char str[50][50];
 	int i,j,aux,a=0;
 	Dados Show[50];
 	
 	for(i=0;i<2;++i){

 	printf(" ");
 	scanf("%s",&Show[a].nome);
 	++a;		
 	printf(" ");
 	scanf("%s",&Show[a].nome);
 	++a;
 	}
 	a=0;
 	for(i=0;i<=1;++i){
 	printf("[%s %d]",Show[i].nome,i);
 	//++a;
 	
 	
 	}
 }
