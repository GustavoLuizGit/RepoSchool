#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#define TAM 20
#include "pilhas.h"

int main(void){
	int qn,r;
	int num,aux;
	Pilha PB;
	Pilha PO;
	Inity(&PB);
	Inity(&PO);
	
			printf("Insira um numero decimal: ");
			scanf("%d",&num);
			aux=num;
			while(num>0){
				r=num%2;
				Push(&PB,r);
				num=num/2;	
			}
			while (aux>0){
				r=aux%8;
				Push(&PO,r);
				aux=aux/8;
			}
	printf("Numero BASE binaria: ");
		while(!Empty(&PB))
		printf(" %d",Pop(&PB));
	printf("\nNumero BASE octal: ");
		while(!Empty(&PO))
		printf("%d",Pop(&PO));
		

	}
