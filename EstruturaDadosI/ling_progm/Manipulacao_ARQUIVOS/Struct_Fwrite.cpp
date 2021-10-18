 #include <string.h>
 #include <iostream>
 #include <stdio.h>
 
 struct clientes{
 	
 	int num;
 	char nome[20];
 	
 };
 
 int main(){
// 	struct clientes{
// 		int num;
// 		char nome[20];
//	 };
 	FILE * arquivo;
  	clientes cli;
 	cli.num=0;
 	fflush(stdin);
 	arquivo = fopen("teste_fwrite.txt","a+");
 	
 		if(arquivo==NULL)
 			printf("\nErro no arquivo.");
 			
 		else{
 			printf("\nDigite o numero do cliente: ");
 			scanf("%d%*c",&cli.num);
 			printf("Digite o nome do cliente: ");
 			gets(cli.nome);
 			fwrite(&cli,sizeof(struct clientes),1,arquivo);
 			
 			
		 }
		 if(ferror(arquivo))
		 	printf("\nErro no arquivo.");
		else
			printf("\nDados gravados com sucesso.");
 		fclose(arquivo);
 	
 	system("pause");
 	return 1;
 }
