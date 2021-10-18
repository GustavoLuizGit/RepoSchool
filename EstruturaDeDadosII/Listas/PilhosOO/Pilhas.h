#pragma once

#include <iostream>

using namespace std;
template <class Elem>
class Pilha
{
private:
	struct no
	{
		Elem info;
		no* prox;
	} *P;
	int tam;
public:
	Pilha();
	void Push(Elem);
	Elem Pop();
	void Mostra();
	int Tamanho();
};
template <class Elem>
Pilha<Elem>::Pilha()
{
	P = NULL;
	tam = 0;
}
template <class Elem>
void Pilha<Elem>::Push(Elem X)
{
	no* aux = new no;
	aux->info = X;
	aux->prox = P;
	P = aux;
	tam++;
}
template <class Elem>
Elem Pilha<Elem>::Pop()
{
	Elem X;
	if (P != NULL)
	{
		no* aux = P;
		X = aux->info;
		P = aux->prox;
		delete aux;
		tam--;
	}
	return X;
}
template <class Elem>
void Pilha<Elem>::Mostra()
{
	no* aux = P;
	while (aux != NULL)
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
}
template <class Elem>
int Pilha<Elem>::Tamanho()
{
	return tam;
}
