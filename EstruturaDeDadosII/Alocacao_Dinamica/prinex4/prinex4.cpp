#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
int* MAX(int* pV1, int* pV2 , int N);
int main(void)
{
	int V1[5] = { 2,5,3,8,6 };
	int V2[5] = { 8,2,0,5,6 };

	int* M = MAX(V1, V2, 5);
	for (int i = 0; i < 5; i++)
	{
		printf("%d ", M[i]);
	}
	return 0;
}

int* MAX(int* pV1, int* pV2, int N)
{
	int* pVmax = new int[N];
	for (int i = 0; i < N; i++)
	{
		if (pV1[i]>pV2[i])
		{
			pVmax[i] = pV1[i];
		}
		else
		{
			pVmax[i] = pV2[i];
		}
	}
	return pVmax;
}