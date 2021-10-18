#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

struct no
{
	char info;
	no* prox;
};

int main(void)
{
	no* L1;
	L1 = new no;
	L1->info = 'a';
	L1->prox = NULL;
	
	no* aux = new no;
	aux->info = 'b';
	aux->prox = NULL;
	L1->prox = aux;
	printf("%c", L1->info);
	printf("%c", L1->prox->info);
	return 0;
}