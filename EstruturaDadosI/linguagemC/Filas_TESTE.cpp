 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 
 #define TAM 4
typedef struct{
	int M[TAM];
	int C,F,Total;	
}Fila_;

 
void Qinity(Fila_ *pfila){
 	pfila->C=0;
 	pfila->F=0;
 	pfila->Total=0;
 }
void Enqueue(Fila_ *pfila,int elemento){
	if(pfila->Total<TAM){
		pfila->M[pfila->F] = elemento;
		pfila->F++;
		if(pfila->Total==TAM){
			pfila->F=0;
		}
	}
	pfila->Total++;
	
} 	

int Dequeue(Fila_ *pfila){
	int i=pfila->C;
	int X;
	if(pfila->Total>0){
		int X = pfila->M[pfila->C];
				
	}
}

void Mostra(Fila_ *pfila){
		printf("[");
	int i=pfila->C;
	for(i=0;i<pfila->Total;++i){
		printf("%d,",pfila->M[i]);
		++i;
	}
	printf("]");
}
//char Qisempty(){ //empty em ingles é vazio
//
//}
 
 
int main(){
	Fila_ filateste;
	int OP,X;
	Qinity(&filateste);
	setlocale(LC_ALL,"");
	
	Enqueue(&filateste,4);
	Enqueue(&filateste,6);
	Enqueue(&filateste,7);
	Enqueue(&filateste,9);
	
	printf("%d\n",Dequeue(&filateste));
	printf("%d\n",Dequeue(&filateste));
	
	
	
//	do{
//		system("cls");
//		printf("===========FILAS======\n");
//		printf("1.Inserir\n");
//		printf("2.Remover \n");
//		printf("3.Mostrar \n");
//		printf("4.Ocorrencia de um elemento\n");
//		printf("5.Inserir no inicio\n");
//		printf("6.Remover do final \n");
//		printf("7.\n");
//		printf("8.Sair\n");
//		printf("======================\n");
//		printf("Fila: ");
//		Mostra(&filateste);
//		printf("\n");
//		printf("=======================\n");
//		printf("Sua opção:");
//		scanf("%d",&OP);
		
// 		switch(OP){
// 			case 1:
// 					printf("Digite um valor: ");
// 					scanf("%d",&X);
// 					Enqueue(&filateste,X);
// 				break;
// 				
// 			case 3:
// 					
// 				break;
//		 }
 
 
 //}while(OP<=8);
 }


