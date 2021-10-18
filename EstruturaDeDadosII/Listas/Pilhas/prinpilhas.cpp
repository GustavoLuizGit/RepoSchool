#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

using namespace std;

struct no
{
	char info;
	no* prox;
};

void Push(no**, char);
char Pop(no**);
void Kill(no**);
void Mostra(no**);

int main()
{
	no* P1 = NULL; //INICIA A PILHA, SUBSTITUINDO O INIT ANTIGO 
	Push(&P1, 'a');
	Push(&P1, 'b');
	Push(&P1, 'c');
	//char Y = Pop(&P1);
	Mostra(&P1);
	//cout << "Elementos do topo :" << Y << endl;
	//Kill(&P1);
	

	
	
	return 0;
}

void Push(no** P, char X)
{
	no* aux = new no;
	aux->info = X;
	aux->prox = *P;
	*P = aux;
}

char Pop(no** P)
{
	char X;
	if (*P != NULL)
	{
		X = (*P)->info;
		no* aux = *P;
		*P = aux->prox;
		delete aux;
	}
	return X;
}

void Kill(no** P)
{
	while (*P != NULL)
	{
		no* aux = *P;
		*P = aux->prox;
		delete aux;
	}
}

void Mostra(no** P)
{
	no* aux = *P;
	while (aux != NULL)
	{
		cout << "," << aux->info;
		aux = aux->prox;
	}
	// ou
	// aqui passa apenas o p1
	/*cout << '[';
	while (aux != NULL)
	{
		cout << aux->info;
		if (aux->prox != NULL)
			cout << ',';
		aux = aux->prox;
	}
	cout << ']';*/
}

