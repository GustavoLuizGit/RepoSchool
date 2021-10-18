#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#define TAM 20

 typedef struct {
 int	M[TAM];
 int	Topo;
 }Pilha;
 
 void Inity(Pilha *p){ //1
 	p->Topo=0;
 }
 
 void Push(Pilha *p,int r){//2
	if (p->Topo<TAM){
 	p->M[p->Topo] = r;
 	p->Topo++; 
	}	 	
 }
 int Pop(Pilha *m){//3
 		if (m->Topo>0){		
 		m->Topo--;
 		return m->M[m->Topo];
 		} 			 
 }
 
 char Empty(Pilha *top){//4

 	if (top->Topo == 0){
 		return  1;
	 }
	else
		return 0;
 }
 char IsFull (Pilha *p){//5
 	if (p->Topo == TAM)
 	 return 1;
 	 
 	else 
 	 return 0;
 }

 
