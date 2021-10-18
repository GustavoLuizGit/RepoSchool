 #include <stdio.h>
 #include <iostream>
 #include <string.h>
 #include <locale.h>
 #include <unistd.h>
 
 struct clientes{
 	char email[20];
 	char telefone[10];
 	char nome[20];
 	
 	
 };
 
 void adc_ctt(){  //função adc_ctt #1
 	FILE * arq = fopen("menu_teste.txt","ab+"); 
	clientes cli;
	int i;
	
	 	
 	if ( arq == NULL || ferror(arq))
 		printf("Arquivo não encontrado.\n");
 	else{
 		i=0;
 		fflush(stdin);
 		printf("Digite seu email: ");
 		gets(cli.email);
 		
 		fflush(stdin);
 		printf("Digite seu telefone: ");
 		gets(cli.telefone);
 		
 		fflush(stdin);
 		printf("Digite seu nome: ");
 		gets(cli.nome);

 	
 		fwrite(&cli,sizeof(struct clientes),1,arq);
 		
 		printf("\nDados gravados com sucesso!\n");
 		system("pause");
	 }
	 
	 fclose(arq);
 }           //fim adc_ctt#1
 
  void list(){//inicio list #2
 	FILE *arq = fopen("menu_teste.txt","rb");
 	clientes cli;
 	if(arq == NULL || ferror(arq))
 		printf("Houve um erro na abertura !");
 	else{
 		while(fread(&cli,sizeof(struct clientes),1,arq)==1){
 			printf("----------------------------------------\n");
 			printf("Email: %s \n",cli.email);
 			printf("Telefone: %s",cli.telefone);
 			printf("\nNome: %s\n",cli.nome);
 			printf("----------------------------------------\n");
		 }
	 }
 	fclose(arq);
 	system("pause");
 } //fim list #2
 
 void buscar(){//inicio buscar #3
 	FILE * arq = fopen("menu_teste.txt","rb");
 	clientes cli;
 	int cont;
 	char name[20];
 	
 	if(arq==NULL || ferror(arq))
 		printf("Houve um erro ao abrir o arquivo \n");
 	else{
 		fflush(stdin);
 		printf("Digite o nome do contato: ");
 		gets(name);
 		cont=0;
 		while(fread(&cli,sizeof(struct clientes),1,arq)==1){
 			if(strcmp(name,cli.nome)==0){
 				printf("---------------------------------------\n");
 				printf("Email: %s\n",cli.email);
 				printf("Telefone: %s\n",cli.telefone);
 				printf("Nome: %s\n",cli.nome);
 				printf("---------------------------------------\n");
 				cont=1;
			 }
		 }
		 if(cont==0)
		 	printf("Nenhum contato foi localizado !\n");
	 }
 system("pause");
 }//fim buscar #3
 
 void list_inicial(){ //inicio list_inicial #4
 	FILE * arq = fopen("menu_teste.txt","rb");
 	char l;
 	char aux;
 	clientes cli;
 	
 	if (arq == NULL || ferror(arq))
 		printf("\nHouve um erro na abertura do arquivo.");
 		
 	else{
 		fflush(stdin);
 		printf("Digite a primeira letra do contato que deseja buscar: ");
 		scanf("%c",&l);
 			while(fread(&cli,sizeof(struct clientes),1,arq)==1){
 			aux = cli.nome[0];
 				if(aux==l){
 					printf("--------------------------------------------------\n");
 					printf("Email: %s\n",cli.email);
 					printf("Telefone: %s\n",cli.telefone);
 					printf("Nome: %s\n",cli.nome);
 					printf("--------------------------------------------------\n");
				 }
				 
			 }
 		
	 }
 	fclose(arq);
 	system("pause");
 }// fim list_inicial #4
 
 void remover(){ 	// inicio remover #5
	FILE * arq = fopen("menu_teste.txt","rb");
	FILE * arq2 = fopen("menu_teste2.txt","wb");
	char name[20];
	int a=0,cont=0;
	clientes cli;
	
	printf("\n");
	
		if(arq==NULL || ferror(arq))
			printf("Houve um erro na abertura do arquivo!\n");
			
		else{
			printf("Digite o nome do contato que deseja remover da agenda: ");
			fflush(stdin);
			gets(name);
			
			while(fread(&cli,sizeof(struct clientes),1,arq)==1){
				if(strcmp(cli.nome,name) != 0){
						fwrite(&cli,sizeof(struct clientes),1,arq2);
				}
				if(strcmp(cli.nome,name)==0)
					cont++;
							
			}
			if(cont==0)
				printf("  CONTATO INEXISTENTE,TENTE NOVAMENTE  !\n");		
		}
	fclose(arq);
	fclose(arq2);
	a=remove("menu_teste.txt");
	rename("menu_teste2.txt","menu_teste.txt");	
	system("pause");
			
	
 } 				// fim remover #5
 
void conta_ctt(){ // inicio conta_ctt #6
	 FILE * arq = fopen("menu_teste.txt","rb");
	clientes cli;
	int cont=0;
		if(arq==NULL || ferror(arq))
			printf("Houve um erro na abertura do arquivo\n");
		else{
			while(fread(&cli,sizeof(struct clientes),1,arq)==1){
				cont++;
			}
			printf("Contatos salvos : %d",cont);
		}
	fclose(arq);
	
}	// fim conta_ctt #6

void inativar(){ // inicio inativar #7
	
} // fim inativar #7

void adc_arq(){ // inicio adc_arq #8

	FILE * arq = fopen("menu_teste.txt","r");	
	clientes cli;
	char name[20];
	fflush(stdin);
	printf("Digite o nome do arquivo a ser gerado: ");
	scanf("%s",name);
	strcat(name,".txt");
	
	FILE * arq2 = fopen(name,"w");
		if(arq==NULL)
			printf("Erro na abertura do arquivo \n");	
		else{							
			while(fread(&cli,sizeof(struct clientes),1,arq)==1){
				 fprintf(arq2," ( -Email: %s |-Telefone: %s |-Nome: %s  ) \n",cli.email,cli.telefone,cli.nome);
			}
			printf("ARQUIVO .txt GERADO COM SUCESSO , DISPONÍVEL NA PASTA DO PROGRAMA \n");				
		}
		
	fclose(arq);
	fclose(arq2);
	system("pause");
		
} //fim adc_arq #8
 
 int main(void){
 	int OP;
	int cont; 
 	setlocale(LC_ALL,"");
 	clientes cli;
 	//FILE * arq = fopen("menu_teste.txt","rb"); // criar um arquivo na função main com o destino do txt impedi a remoção
 												//com remove();			
 	do{
		 
 	system("cls");
 	printf("-----------------AGENDA MÓVEL----------------------\n");
 	printf("1.Adicionar um contato       2.Listar\n");
 	printf("3.Buscar um contato          4.Buscar pela inicial \n");
 	printf("5.Remover um contato         6.Gerar um arquivo \n");
 	printf("  	     		7.Sair do programa  \n");
 	
 	conta_ctt();
 	printf("\n----------------------------------------------------\n");

 	scanf("%d",&OP);
	 				
 		switch(OP){
 			case 1:
 					adc_ctt();		
 				break;
 				
 			case 2:
 					list();
 				break;
 				
 			case 3:
 					buscar();
 				break;
 			case 4:
 					list_inicial();
 				break;
 			case 5:
 		
 					remover();
 				break;
 			
 			case 6:
 					adc_arq();
 				break;
 			default:
 				if(OP > 7){				 
			 		printf("\nOpção inválida !\n");
					system("pause");
				}
				if(OP == 7){
					printf("\nPrograma encerrado com sucesso.\n");
					system("pause");
					sleep(5);
				}
		 }
 	}while(OP!=7);
 	//fclose(arq);
 }
