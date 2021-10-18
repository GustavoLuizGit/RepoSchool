#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

int main(void)
{
	//variaveis
	int i,j; // fazer o campo
	char m[50][50]; // tamanho total do campo
	int l,c; // largura e comprimento do campo
	char n;// nome do personagem
	int lc,cc;//linha e coluna do personagem
	char opp;// dizer se vai colocar mais personagens 
	//variaveis
	
		
	//criação do campo
	printf("Tamanho da largura do campo : ");
	scanf("%d",&l);
	printf("Tamanho do comprimento do campo : ");
	scanf("%d",&c);
	system("cls");
	
	for(i=0;i<l;i++)
	{
		for(j=0;j<c;j++)
		{
			m[i][j]=' ';
		}
	}
	//criação do campo
	
	//adicionar personagens
	fflush(stdin);
	printf("Vai adicionar personagens(S,N) : ");
	scanf("%c",&opp);
	if(opp=='S' || opp=='s')
	{
		do
		{
			system("cls");
			//mostrar o campo
			for(i=0;i<c;i++)
			{
				printf("    %d",i);
			}
			printf("\n");
			for(i=0;i<l;i++)
			{
				if(i<=9)
				{
					printf("0");
				}
				printf("%d",i);r
				for(j=0;j<c;j++)
				{
					printf("  %c  ",m[i][j]);
				}
				printf("\n");
			}		
			//mostrar o campo
			fflush(stdin);
			printf("\nEntre com a primeira letra do personagem : ");
			scanf("%c",&n);
			fflush(stdin);
			printf("Qual linha quer coloca-lo : ");
			scanf("%d",&lc);
			fflush(stdin);
			printf("Qual coluna quer coloca-lo : ");
			scanf("%d",&cc);
			m[lc][cc]=n;
			fflush(stdin);
			printf("Colocar mais personagens (S/N): ");
			scanf("%c",&opp);
		}while((opp=='S' || opp=='s'));
	}
	
	//adicionar personagens
	
	 
	//mostrar o campo
	for(i=0;i<c;i++)
	{
		printf("    %d",i+1);
	}
	printf("\n");
	for(i=0;i<l;i++)
	{
		if(i<9)
		{
			printf("0");
		}
		printf("%d",i+1);
		for(j=0;j<c;j++)
		{
			printf("  %c  ",m[i][j]);
		}
		printf("\n");
	}	
	//mostrar o campo
}
