#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
char* inverte(char*);

int main(void)
{
	char antes[30]=" ";
	char* depois;

	printf("Entre com um nome : ");
	scanf("%[^\n]",&antes);

	depois = inverte(antes);

	printf("Seu nome : %s", antes);
	printf("\nSeu nome ao contrario : %s", depois);
	return 0;
}

char* inverte(char* ant)
{
	int t = strlen(ant);
	char* aux = new char[t];
	int j = t-1;
	for(int i = 0; i < t; i++)
	{
		aux[i] = ant[j];
		j--;
	}
	aux[t] = 0;
	return aux;
}