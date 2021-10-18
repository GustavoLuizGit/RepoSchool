#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>
#include "listas.h"
 int main(void){
 	Lista L1;
 	Linity(&L1);
 	setlocale(LC_ALL,"");
 	int OP;
 	char X,XI,XF;
 	do{
 		system("cls");
 		printf("===========LISTAS===========\n");
 		printf("1.Inserir\n");
 		printf("2.Remover \n");
 		printf("3.Contar ocorrencias\n");
 		printf("4.Mostra intervalo\n");
 		printf("5.\n");
 		printf("6.Sair ");
 		printf("\n===============================");
 		printf("Lista:");
 		Lmostra(&L1);
 		printf("\n=============================");
 		printf("Sua opção: ");
 		scanf("%d",&OP);
 			switch(OP){
 				case 1:
 					printf("Entre com um elemento: ");
 					scanf(" %c",&X);
 					Lins(&L1,X);
 					break;
 					
 				case 2:
 						printf("Entre com o elemento: ");
 						scanf(" %c",&X);
 						if(l_rem)
 							l_rem(&L1,X);
 							
 						else
 							printf("O elemento nao existe!\n");
 					break;
 					
 				case 3:
 					printf("Entre com um elemento: ");
 					scanf(" %c",&X);
 					printf("Numero de ocorrencias: %d \n",Lconta(&L1,X));
 					system("pause");
 					break;
 				case 4:
 					printf("Digite o primeiro local: ");
 					scanf(" %c",&XI);
 					printf("Digite o ultimo local: ");
 					scanf(" %c",&XF);
 					printf("\n");
 					intervalo(&L1,XI,XF);
 					printf("\n");
 					system("pause");
 					break;
			 }
 		
	 }while(OP!=6);
 	return 1;
 }
