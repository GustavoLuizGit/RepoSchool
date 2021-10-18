#include <iostream>
#include <queue>

using namespace std;

struct no
{
	char info;
	no* esq, * dir;
};

void Tins(no**, char);
void EmOrdem(no*);
void PosOrdem(no*);
void PreOrdem(no*);
void EmNivel(no*);
void NP(no*);
int altura(no*);
int Max(int x, int y);
char Pesquisa(no**, char X);
char Remover(no**, char);
no* getmax(no**);

int main()
{
	no* T1 = NULL;
	Tins(&T1, 10);
	Tins(&T1, 5);
	Tins(&T1, 15);
	Tins(&T1, 4);
	Tins(&T1, 16);
	Tins(&T1, 3);
	Tins(&T1, 2);
	Tins(&T1, 1);
	
	
	NP(T1);
	cout << endl;

	return 0;

}

void Tins(no** T, char X)
{
	if (*T == NULL)
	{
		
		*T = new no;
		(*T)->info = X;
		(*T)->dir = (*T)->esq = NULL;
	}
	else
		if (X < (*T)->info)
			Tins(&((*T)->esq), X);
		else
			Tins(&((*T)->dir), X);
}

void PreOrdem(no* T)
{
	if (T != NULL)
	{
		cout << (int)T->info << " ";
		PreOrdem(T->esq);
		PreOrdem(T->dir);
	}
}

void NP(no* T)
{
	if (T != NULL)
	{
		cout << (int)T->info << " ";
		NP(T->esq);
		NP(T->dir);
	}
	else
	{
		cout << ".";
	}
}

void EmOrdem(no* T)
{
	if (T != NULL)
	{
		EmOrdem(T->esq);
		cout << (int)T->info << " ";
		EmOrdem(T->dir);
	}
}

void PosOrdem(no* T)
{
	if (T != NULL)
	{
		PosOrdem(T->esq);
		PosOrdem(T->dir);
		cout << (int)T->info << " ";
	}
}

void EmNivel(no* T)
{
	queue<no*> F;
	if (T != NULL)
	{
		F.push(T);
		no* aux;
		while (!F.empty())
		{
			aux = F.front();
			F.pop();
			cout << (int)aux->info << " ";
			if (aux->esq != NULL)
				F.push(aux->esq);
			if (aux->dir != NULL)
				F.push(aux->dir);

			
		}
	}
}

int altura(no* T)
{
	if (T == NULL)
		return 0;
	else
		return 1 + Max(altura(T->esq), altura(T->dir));
}

int Max(int x, int y)
{
	if (x >= y)
	{
		return x;
	}
	else
	{
		return y;
	}
}

char Pesquisa(no** T, char X)
{
	if (*T == NULL) 
		return 0;
	else
		if (X < (*T)->info)
			Pesquisa(&(*T)->esq, X);
	else
		if (X > (*T)->info)
			Pesquisa(&(*T)->dir, X);
		else //X = T->info
			return 1;
}

char Remover(no** T, char X)
{
	if (*T==NULL) return 0;
	if ((*T)->info == X) //elemento para ser retirado esta na raiz 
	{
		no* P = *T;
		if ((*T)->dir == NULL)
			*T = (*T)->esq;
		else 
			if ((*T)->esq == NULL)
				*T = (*T)->dir;
			else
			{
				P = getmax(&(*T)->esq);
				(*T)->info = P->info;
			}
		delete P;
		return 1;
	}
	if (X < (*T)->info)
		return Remover(&(*T)->esq, X);
	else
		return Remover(&(*T)->dir, X);
}

no* getmax(no** T)
{
	if ((*T)->dir == NULL)
	{
		no* P = *T;
		*T = P->esq;
		return P;
	}
	else
		return getmax(&(*T)->dir);
}