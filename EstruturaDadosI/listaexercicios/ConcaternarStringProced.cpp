 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 void concatenador(char *ps1,char *ps2,char *ps3){
  int i,j;
  for (i=0;ps1[i]!=0;++i){
  	ps3[j]=ps1[i];
  	++j;
  	printf("%c",ps1[i]);
  }
  for (i=0;ps2[i]!=0;++i){
  	ps3[j]=ps2[i];
  	printf("%c",ps2[i]);
  	++j;
  }
  ps3[j]=0;	
 }
 
 int main(void){
 	char nome[15],snome[15],soma[31];
 	
 	
 	printf("Digite o nome: ");
 	scanf("%s",&nome);
 	printf("Digite o sobrenome: ");
 	scanf("%s",&snome);
	//concatenador(nome,snome,soma);
	
 	//printf("Nomes: %s",soma);
 	
 	
	
 }
