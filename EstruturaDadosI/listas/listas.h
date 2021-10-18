#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#define TAM 15

typedef struct{
 	char M[TAM];
 	int Fim;
}Lista;
 
void Linity(Lista *PL){
	PL->Fim=0;
}

void Lins(Lista *PL,char X){ // X é o caracter
	int i=PL->Fim;
	if(PL->Fim<TAM){ // A lista nao esta cheia
		//PL->M[i]=X;
		//++i;
		while( (i>0)  &&  (X<PL->M[i-1]) ){
			PL->M[i]=PL->M[i-1];
			i--;
		}
		PL->M[i]=X;
		PL->Fim++;
	}
	//PL->M[i]=X;
	//PL->Fim++;
}

void Lmostra (Lista *L)
{
    printf ("[");
    int i;

    for (i=0;i<L->Fim;i++)
    {
        printf("%c",L->M[i]);
        if (i+1 < L->Fim)
            printf(",");
    }
    printf ("]");
}

int Lconta(Lista *pl,char X){
	int i=0,cont=0;
//  for (i=0;i<pl->Fim;i++){
//        if(X==pl->M[i]){
//            cont++;
//        }
//    }
	while((i<pl->Fim) && (X > pl->M[i]))
		i++;
	while((i<pl->Fim) && X == pl->M[i]){
		cont++;
		i++;
	}
    return cont;
}

void intervalo(Lista *pl,char X,char F){
	
	int i=0,a=0;
	
	while(i<pl->Fim && X > pl->M[i])
		++i;
		
	printf("[")	;
	while(i<pl->Fim && pl->M[i]<=F){
		printf("%c ",pl->M[i]);
		++i;
	}
	printf("]");

}
char l_rem(Lista *pl,char X){
	int i=0;
	
		while(i < pl->Fim  &&  X > pl->M[i])
			++i;
		
		if(i < pl->Fim && X == pl->M[i]){
			while(i < (pl->Fim - 1)){
				pl->M[i] = pl->M[i+1];
				++i;
			}
			pl->Fim--;
			return 1;
		}
		
		else
			return 0;
}
