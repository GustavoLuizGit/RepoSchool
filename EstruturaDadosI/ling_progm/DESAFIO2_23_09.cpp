#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
int main(void){
	int i,j;
	int m[3][2];
	for (i=0;i<3;++i){
		for(j=0;j<2;++j){
			printf("[%d][%d]: ",i+1,j+1);
			scanf("%d",&m[i][j]);		
		}		
	}
		printf("----MATRIZ NORMAL ---\n");
		for (i=0;i<3;++i){
		for(j=0;j<2;++j){
			printf("%d ",m[i][j]);
					
		}
		printf("\n");		
	}
	printf("---MATRIZ TRANSPOSTA---\n");
	for(j=0;j<2;++j){
		for(i=0;i<3;++i){
			printf("%d ",m[i][j]);
		}
		printf("\n");
	}
	
}
