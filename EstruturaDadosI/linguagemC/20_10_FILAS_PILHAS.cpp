#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include "filas.h"
#include "pilha2PAULO.h"

int main(){
	int OP,X;
	Pilha2 P;
	Fila FI,FP;
	Inity(&P);
	Qinity(&FI);
	Qinity(&FP);
	printf("\nDigite um numero DIFERENTE DE 0 : ");
	scanf("%d",&X);
	
	do{
		
			if(X % 2 == 0 && X !=0)
				Enqueue(&FP,X);
			
			else if( X % 2 == 1 && X !=0)
				Enqueue(&FI,X);
				
		printf("\nEntre com outro numero: ");
		scanf("%d",&X);
	}while(X!=0);
	
	while(!Qisempty(&FP) || !Qisempty(&FI)){
	
		if(!Qisempty(&FI)){
			X=Dequeue(&FI);
			printf("%d",X);
			if(X>0)
				Push(&P,X);
		}
	
		if(!Qisempty(&FP)){
			X=Dequeue(&FP);
			printf("%d",X);
			if(X>0)
				Push(&P,X); //mostrar e a pilha e testar no Enqueue se a fila nao esta cheia
		}	
	}
	printf("\nPilha:");
	while(!Empty(&P)){
		printf("%d ",Pop(&P));
	}
}
