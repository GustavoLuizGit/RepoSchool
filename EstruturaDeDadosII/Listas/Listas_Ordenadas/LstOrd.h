#pragma once

#include <iostream>

using namespace std;

class LstOrd
{
private:
	struct no
	{
		char info;
		no* prox;
	};
	no* L;
	int tam;
public:
	LstOrd();
	void Insere(char);
	void Mostra();
	int Tamanho();
	char Remove(char);
};

LstOrd::LstOrd()
{
	L = NULL;
	tam = 0;
}

void LstOrd::Insere(char X)
{
	no* N = new no;
	N->info = X;
	if ((L == NULL) || (X < L->info))
	{
		N->prox = L;
		L = N;
	}
	else
	{
		no* P = L;
		while (P->prox!=NULL && X > P->prox->info)
		{
			P = P->prox;
		}
		N->prox = P->prox;
		P->prox = N;
	}
	tam++;
}

void LstOrd::Mostra()
{
	no* aux = L;
	if (aux != NULL)
	{
		cout << '[';
		while (aux != NULL)
		{
			cout << aux->info;
			if (aux->prox != NULL)
				cout << ',';
			aux = aux->prox;
		}
		cout << ']';
	}
	else
	{
		cout << "Fila vazia" << endl;
	}
}
char LstOrd::Remove(char X)
{
	if (L == NULL || X < L->info)
	{
		return 0;
	}
	if (X==L->info)
	{
		no* N = L;
		L = L->prox;
		delete N;
		tam--;
		return 1;
	}
	no* P = L;
	while (P->prox!=NULL && X>P->prox->info)
	{
		P = P->prox;
	}
	if (P->prox!=NULL && X==P->prox->info)
	{
		no* N = P->prox;
		P->prox = N->prox;
		delete N;
		tam--;
		return 1;
	}
	return 0;
}		

int LstOrd::Tamanho()
{
	return tam;
}