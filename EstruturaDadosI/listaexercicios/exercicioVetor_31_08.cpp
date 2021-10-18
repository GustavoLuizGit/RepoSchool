#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>
int soma(int *vet,int qn){
 	int i,soma;
 	soma = 0;
 	for (i=0 ;i<qn;++i) {
 		soma+=vet[i];
	 }
	return soma;
 }
int media(int *vet ,int qn){
	int i;
	float m,s;
 	for (i=0 ;i<qn;++i) {
 		s+=vet[i];
	 }
 	m=(s/qn);
 	
	return m;	
}
 
 int main(void) {
 	int vetor[4];
 	int i,qn,s;
 	setlocale(LC_ALL,"Portuguese");
 	printf("Digite quantos números terá o vetor: ");
 	scanf("%d",&qn);
 	for (i=0 ; i<qn;++i) {
 		printf("Entre com o %d numero: ",i+1);
 		scanf("%d",&vetor[i]);
	 }
	for (i=0 ; i<qn ; ++i){	
		printf("%d ",vetor[i]);
}		
	printf("Soma dos valores: %d",soma(vetor,qn));
	printf("\nMédia do vetor: %d",media(vetor,qn));
 }
