 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 #include <string.h>
 
 
  struct conta{
 	char nome[50];
 	int num;
 	float saldo;
 };
 
 int main(){
 	setlocale(LC_ALL,"");
 	int op,i,cont=0,j,posi=0;
 	char x[50];
 	conta Dados[15];
 	do{
	system("cls");
 	printf("================MENU DE OPÇÕES =============\n");
 	printf("1.Cadastrar contas.\n");
 	printf("2.Visualizar todas contas do clientes.\n");
 	printf("3.Excluir conta com menor saldo.\n");
 	printf("4.Sair.\n");
 	scanf("%d",&op);
 
 		
 		if(op==1){
 		for(i=0;i<3;++i){
 			printf("%d.o nome: ",i+1);
 			scanf("%s",Dados[i].nome);
 			printf("\nNumero da %d.a conta : ",i+1);
 			scanf("%d",&Dados[i].num);
 			printf("\nSaldo da %d.a conta : ",i+1);
 			scanf("%f",&Dados[i].saldo);
		 }
	}
		if(op==2){
			printf("Digite o nome da conta do cliente: ");
			scanf("%s",&x);
			for(i=0;i<3;++i){
				if(strcmp(Dados[i].nome,x)==0){
		
				posi=i;
				printf("Conta registrada com esse numero: SALDO %.2f | NOME %s\n",Dados[posi].saldo,Dados[posi].nome);
				system("pause");
			}
			
		}
		if(posi==0){
		
			printf("\nNão ha nenhuma conta regristrada nesse dominio.\n");
			system("pause");
		}
	}
	}while(op<4);
		 
 	
 }
