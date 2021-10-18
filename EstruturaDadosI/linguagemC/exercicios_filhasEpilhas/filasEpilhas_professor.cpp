#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include "filas.h"
#include "pilha2PAULO.h"

int main(void)
{
	Pilha2 P;
	Fila FI,FP;
	int X;
	
	Inity(&P);
	Qinity(&FI);
	Qinity(&FP);
	setlocale(LC_ALL,""); 
	
	printf("Entre com um número:");
	scanf("%d",&X);
	
	while (X!=0)
	{
	  	if (X%2==0) 
	 		Enqueue(&FP,X);
	  	else
	    	Enqueue(&FI,X);
	  printf("Entre com um número:");
	  scanf("%d",&X);	
	}
	while (!Qisempty(&FI) || !Qisempty(&FP))
	{
		if (!Qisempty(&FI))
		{
			X=Dequeue(&FI);
			printf("%d ",X);
			if (X>0)
				Push(&P,X);
		}
	
		if (!Qisempty(&FP))
		{
			X=Dequeue(&FP);
			printf("%d ",X);
			if (X>0)
				Push(&P,X);
		}
	}
	
	return 1;
}
