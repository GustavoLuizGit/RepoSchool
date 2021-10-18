 #include <stdio.h>
#include <stdlib.h>
#include <locale.h>

#define TAM 4

typedef struct
	{
		char M[TAM];
		int Com,Fim,Total;	
	} Fila;

void Qinit(Fila *F)
{
	F->Com = 0;
	F->Fim = 0;
	F->Total = 0;
}

void Enqueue(Fila *F, char X)
{
	if (F->Total<TAM)
	{
		F->M[F->Fim]=X;
		F->Fim++;
		if (F->Fim==TAM)
		{
			F->Fim=0;
		}
		F->Total++;
	}
}

char Dequeue(Fila *F)
{
	if (F->Total>0)
	{
		char X=F->M[F->Com];
		F->Com++;
		if (F->Com==TAM)
		{
			F->Com=0;
		}
		F->Total--;
		return X;
	}
}

int main(void)
{
	Fila F1;
	Qinit(&F1);
	Enqueue(&F1,'a');
	Enqueue(&F1,'b');
	Enqueue(&F1,'c');
	Enqueue(&F1,'d');
	Enqueue(&F1,'e');
	

	printf("%c\n",Dequeue(&F1));
	printf("%c\n",Dequeue(&F1));
	printf("%c\n",Dequeue(&F1));	
	printf("%c\n",Dequeue(&F1));
	
	return 1;
}
