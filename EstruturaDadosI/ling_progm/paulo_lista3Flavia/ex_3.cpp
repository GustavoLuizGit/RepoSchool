 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 void barra (int qn){
 	int i;
 	for (i=1;i<qn;++i){
 		printf("-");
	 }
 }
 int main(void){
 	setlocale(LC_ALL,"");
 	int i=0,j,a,cont_reprov=0,cont_exame=0,cont_aprov=0;
 	float nota[15],media[10],ac,media_classe;
 	for (i=0;i<6;++i){
 	 barra(30);
 	 printf("\n");
		ac=0;	
 		for (j=0;j<2;++j){
 		printf("Aluno %d. Digite sua %d.a nota: ",i+1,j+1);
 		scanf("%f",&nota[i]);
 		ac+=nota[i];
	}
		media[i]=ac/2;
		media_classe+=media[i];
		barra(30);
		printf("\n");
	}
	
	for (i=0;i<6;++i){
	if (media[i]<=3){
		
		printf("Aluno %d: situação(REPROVADO) | Sua media é %.1f pontos\n\n",i+1,media[i]);
		cont_reprov+=1;
		}
	else if(media[i]>3 && media[i]<=7){
		printf("Aluno %d: situação(EXAME) | Sua media é %.1f pontos\n\n ",i+1,media[i]);
		cont_exame+=1;
		}
	else if(media[i]>7){
		printf("Aluno %d: situação(APROVADO) | Sua media é %.1f pontos\n\n",i+1,media[i]);
		cont_aprov+=1;
		}
	}
	printf("\n\n\n");
	printf("====QUANTIDADE DE ALUNOS APROVADOS: %d alunos =======\n\n",cont_aprov);
	printf("====QUANTIDADE DE ALUNOS DE EXAME: %d alunos =======\n\n",cont_exame);
	printf("====QUANTIDADE DE ALUNOS REPROVADOS: %d alunos =======\n\n",cont_reprov);
	printf("====MÉDIA DE NOTAS DA CLASSE: %.2f pontos",media_classe/6);
 }
