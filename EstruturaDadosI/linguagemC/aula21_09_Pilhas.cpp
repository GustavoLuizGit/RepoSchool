 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <stdbool.h>
 #define TAM 10
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
 
 char Empty(Pilha *top){

 	if (top->Topo == 0){
 		return  1;
	 }
	else
		return 0;
 }
 char IsFull (Pilha *p){
 	if (p->Topo == TAM)
 	 return 1;
 	 
 	else 
 	 return 0;
 }
 
 int main(void){
 	int i=0,n,r,a;
 	int m[8];
 	Pilha P;
 	Inity(&P);
	printf("Entre com um numero: ");
	scanf("%d",&n);
		while(n>0){
			r=n%2;
		if (!IsFull(&P)){
		
			Push(&P,r);
		}
		else{
		
			printf("\n PILHA CHEIA \n");
			exit(1);
		}
		n=n/2;	
		}
		
		while(!Empty(&P)){
			printf("%d",Pop(&P));
		}
 		
 }
