#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
int main(void){
	int i,j,b,a,produto;
	int m1[3][3],m2[3][3],r[3][3];
	printf("--INSIRA OS VALORES DA PRIMEIRA MATRIZ--\n");
	for (i=0;i<3;++i){
		for(j=0;j<3;++j){
			printf("[%d][%d]: ",i+1,j+1);
			scanf("%d",&m1[i][j]);		
		}		
	}
	printf("--INSIRA OS VALORES DA SEGUNDA MATRIZ--\n");
	for (i=0;i<3;++i){
		for(j=0;j<3;++j){
			printf("[%d][%d]: ",i+1,j+1);
			scanf("%d",&m2[i][j]);		
		}		
	}
	produto=0;
	
	for (a=0;a<3;++a){
		
		for (i=0;i<3;++i){
			for(j=0;j<3;++j){
			produto+=m1[a][j]*m2[j][i];
			//printf("%d ----- %d \n",m1[j][i],m2[i][j])	;
			}
		r[a][i]=produto;
		
		}
	}
	printf("TERCEIRA MATRIZ -- \n");
	for (i=0;i<3;++i){
		//b++;
		for (j=0;j<3;++j){
		printf("%d ",r[a][i]);
		//a++;
		}
		printf("\n");
	}
	
}
