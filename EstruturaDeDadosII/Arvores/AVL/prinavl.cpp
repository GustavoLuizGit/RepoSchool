#include <iostream>
using namespace std;

struct no_avl
{
	char info;
	char fb;
	no_avl* esq, * dir;
};

void RD(no_avl**);
void RE(no_avl**);

void insavl(no_avl** T, char x, char* h)
{
	if (*T == NULL)
	{
		*T = new no_avl;
		(*T)->info = x;
		(*T)->esq = (*T)->dir = NULL;
		(*T)->fb = 0;
		*h = 1;
 	}
	else
	{
		if (x < (*T)->info)
		{
			insavl(&(*T)->esq, x, h);
			if (*h)
			{
				switch ((*T)->fb)
				{
					case 1:
						(*T)->fb = 0; *h = 0;
						break;
					case 0:
						(*T)->fb = -1;
						break;
					case -1:
						RD(T); *h = 0;
						break;
				}
			}
		}
		else
		{
			if (x > (*T)->info)
			{
				insavl(&(*T)->dir, x, h);
				if (*h)
				{
					switch ((*T)->fb)
					{
						case -1:
							(*T)->fb = 0; *h = 0;
							break;
						case 0:
							(*T)->fb = 1;
							break;
						case 1:RE(T); 
							break;
						
					}
				}
			}
		}
	}
}

void RD(no_avl** T)
{
	no_avl* pB = (*T)->esq;
	if (pB->fb == -1) // rotação simples
	{
		(*T)->esq = pB->dir;
		pB->dir = *T;
		(*T)->fb = 0;
		*T = pB;
	}
	else // rotação dupla
	{
		no_avl* pC = pB->dir;
		pB->dir = pC->esq;
		pC->esq = pB;
		(*T)->esq = pC->dir;
		pC->dir = *T;
		if (pC->fb == -1) (*T)->fb = 1;
		else (*T)->fb = 0;
		if (pC->fb == 1) pB->fb = -1;
		else pB->fb = 0;
		*T = pC;
	}
}

void RE(no_avl** T)
{
	no_avl* pB = (*T)->dir;
	if (pB->fb == 1) //rotação simples
	{
		(*T)->dir = pB->esq;
		pB->esq = *T;
		(*T)->fb = 0;
		*T = pB;
	}
	else //rotação dupla
	{
		no_avl* pC = pB->esq;
		pB->esq = pC->dir;
		pC->dir = pB;
		(*T)->dir = pC->esq;
		pC->esq = *T;
		if (pC->fb == 1) (*T)->fb = -1;
		else (*T)->fb = 0;
		if (pC->fb == -1) pB->fb = 1;
		else pB->fb = 0;
		*T = pC;
	}
	(*T)->fb = 0;
}

void NP(no_avl* T)
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

void main()
{
	no_avl* T1 = NULL;
	char H;
	insavl(&T1, 10, &H);
	insavl(&T1, 5, &H);
	insavl(&T1, 15, &H);
	insavl(&T1, 4, &H);
	insavl(&T1, 16, &H);
	insavl(&T1, 3, &H);
	insavl(&T1, 2, &H);
	insavl(&T1, 1, &H);

	NP(T1);
	cout << endl;
	system("pause");
}