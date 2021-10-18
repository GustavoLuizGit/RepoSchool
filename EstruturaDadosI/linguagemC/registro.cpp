 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <string.h>
 typedef struct {
 	char nome[10];
 	int matricula;
 	float nota[4];
 } aluno;
 
 void read(aluno *preg){
 	int i;
 	printf("Digite o nome: ");
 	scanf("%s",&preg->nome);
 	printf("Digite a matricula: ");
 	scanf("%d",&preg->matricula);
 	for (i=0;i<4;++i){
 		printf("Digite a %d nota: ",i+1);
 		scanf("%f",&preg->nota[i]);
	 }
}
  float calcmedia(aluno *preg){
  	int i,nota=0;
  	float media;
  	for (i=0;i<4;++i){
  		nota+=preg->nota[i];
	  }
	media = nota/4.;
	return media;
  }

 int main(void){
 	int i;
 	float media;
 	aluno reg;
 	read(&reg);
 	printf("Seu nome: %s\n",reg.nome);
 	printf("Numero da sua matricula: %d\n",reg.matricula);
 	for(i=0;i<4;++i)
		printf("%d nota: %.1f\n",i+1,reg.nota[i]);
	media = calcmedia(&reg);
	printf("Sua media e: %f",media);
	
 }
