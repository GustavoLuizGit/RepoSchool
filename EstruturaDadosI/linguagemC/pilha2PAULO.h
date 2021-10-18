 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 
 #define TAMANHO 40
 typedef struct{
 	int Vetor[40];
 	int Indice;
 }Pilha2; // CRIACAO STRUCT
   
 void Inity(Pilha2 *i){
 	i->Indice=0;
 }
 int Pop(Pilha2 *pimp){
 	if (pimp->Indice > 0) {
 		pimp->Indice--;
 		return pimp->Vetor[pimp->Indice];
 		//returno do  valor NUMERO diretamente . OBS .n precisa do for no MAIN
	 }
 }
 void Push(Pilha2 *ppush,int alvo){
 	if(ppush->Indice<TAMANHO){
 		ppush->Vetor[ppush->Indice]=alvo;
 		++ppush->Indice;
	 }
 }
 int Empty(Pilha2 *pindice){
 	if(pindice->Indice==0)
 		return 1;
 	else 
	 	return 0;
 }
 int IsFull(Pilha2 *pindice){
 	if(pindice->Indice==TAM){
 		return 1;
	 }
	else
	 	return 0;
 }
 
 
