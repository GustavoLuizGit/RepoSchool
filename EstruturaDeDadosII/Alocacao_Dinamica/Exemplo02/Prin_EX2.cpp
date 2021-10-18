
#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
int* diag(int**, int);

void main(void)
{
	int NL, NC;
	setlocale(LC_ALL, "");
	FILE* arq = fopen("dados.txt", "r");

	fscanf(arq, "%d %d", &NL, &NC);

	int** M;
	M = new int* [NL];
	for (int I = 0; I < NL; I++)
	{
		M[I] = new int[NC];
	}
	for (int I = 0; I < NL; I++) //linhas
	{
		for (int J = 0; J < NC; J++)
			fscanf(arq, "%d", &M[I][J]);

	}

	for (int I = 0; I < NL; I++)
	{
		for (int J = 0; J < NC; J++)
			printf("%4d", M[I][J]);
		printf("\n");
	}

	int* V = diag(M, NL);

	//imprimir vetor
	printf("\n Mostrar vetor da diagonal da matriz : \n");
	for (int i = 0; i < NL; i++)
	{
		printf("%d ", V[i]);
	}
}

int* diag(int** P, int T)
{
	int* AUX = new int[T];	//Iniciou Vetor
	for (int i = 0; i < T; i++)
	{
		for (int j = 0; j < T; j++)
		{
			if (i == j)
			{
				AUX[i] = P[i][j];
			}
		}
	}
	return AUX;
}
/*
* Correção professor
* #define _CRT_SECURE_NO_WARNINGS
#include <iostream>
int* subvet(int*, int);

void main(void)
{
	int N;
	setlocale(LC_ALL, "");
	FILE* arq = fopen("dadox.txt", "r");

	fscanf(arq, % d", &N);
	int* V = new int[N];

	for (int I = 0; I < N; I++)
	{
		fscanf(arq, "%d", &V[I]);
	}
	int* SV = subvet(V, N);
	printf("Vetor lido do arquivo:\n");
	for (int I = 0; I < N; I++)
	{
		printf("%d ", V[I]);
	}
	printf("Subvetor gerado pela função:\n");
	for (int I = 0; I < N / 2; I++)
	{
		printf("%d ", SV[I]);
	}
}
int* subvet(int* pV, int T)
{
	int QTD = T / 2;
	int AUX = new int[QTD];
	for (int i = 0; i < QTD; i++)
	{
		*AUX[i] = pV[i];
	}
	return AUX;
}

*/
