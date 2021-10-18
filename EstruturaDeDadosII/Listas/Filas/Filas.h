#pragma once

#include <iostream>

using namespace std;
template <class Elem>
class Fila
{
private:
	struct no
	{
		Elem info;
		no* prox;
	}*F,*I;
	int tam;
public:
	Fila();
	void Enqueue(Elem);
	Elem Dequeue();
	int Tamanho();
	void Mostrar();
	Elem DequeFim();
	void Enqueini(Elem);
};
template <class Elem>
Fila<Elem>::Fila()
{
	tam = 0;
	F = NULL;
	I = NULL;
}
template <class Elem>
void Fila<Elem>::Enqueue(Elem X)
{
	no* aux = new no;
	aux->prox = NULL;
	aux->info = X;
	if (tam==0)
	{
		F = aux;
		I = aux;
	}
	else
	{
		F->prox = aux;
		F = aux;
	}
	tam++;
}
template <class Elem>
Elem Fila<Elem>::Dequeue()
{
	Elem X;
	if (tam!=0)
	{
		no* aux = I;
		I = aux->prox;
		if (I == NULL)
		{
			F = NULL;
		}
		X = aux->info;
		delete aux;
		tam--;
	}
	else
	{
		X = ' ';
		cout << "A fila ja esta vazia" << endl;
	}
	return X;
}
template <class Elem>
int Fila<Elem>::Tamanho()
{
	return tam;
}
template <class Elem>
void Fila<Elem>::Mostrar()
{
	if (tam>0)
	{
		no* aux = I;
		cout << '[';
		while (aux != NULL)
		{
			cout << aux->info;
			if (aux->prox != NULL)
			{
				cout << ',';
			}
			aux = aux->prox;
		}
		cout << ']';
	}
	else
	{
		cout << "A fila esta vazia ..." << endl;
	}
}
template <class Elem>
Elem Fila<Elem>::DequeFim()
{
	Elem X;
	if (tam > 0)
	{
		if (tam==1)
		{
			X = I->info;
			delete I;
			I = NULL;
			F = NULL;
		}
		else
		{
			no* aux = I;
			while (aux->prox != F)
			{
				aux = aux->prox;
			}
			X = F->info;
			F = aux;
			delete aux->prox;
			F->prox = NULL;
		}
		tam--;
	}
	else
	{
		X = ' ';
		cout << "A fila esta vazia" << endl;
	}
	return X;
}
template <class Elem>
void Fila<Elem>::Enqueini(Elem X)
{
	no* aux = new no;
	aux->info = X;
	aux->prox = I;
	if (tam==0)
	{
		F = aux;
		I = aux;
	}
	else
	{
		I = aux;
	}
	tam++;
}



