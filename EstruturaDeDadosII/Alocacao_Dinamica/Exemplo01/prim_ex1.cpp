#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

int* subvet(int*, int);

void main(void)
{
	int N;
	FILE *arq = fopen("dados.txt","r");

	fscanf(arq,"%d", &N);
	int* V = new int[N];

	for (int I = 0; I < N; I++)
	{
		fscanf(arq,"%d", &V[I]);
	}
	

	printf("Vetor lido do arquivo : \n");
	for (int I = 0; I < N; I++)
	{
		printf("%d ", V[I]);
	}
	
	int* SV = subvet(V, N);
	printf("\nSub_Vetor gerado pela função : \n");
	for (int I = 0; I < N/2; I++)
	{
		printf("%d ", SV[I]);
	}
}
int* subvet(int* pV, int T)
{
	int QTD = T / 2;
	
	int* AUX = new int[QTD]; //Iniciou Vetor

	for (int I = 0; I < QTD; I++)
	{
		AUX[I] = pV[I];
	}
	return AUX;

}