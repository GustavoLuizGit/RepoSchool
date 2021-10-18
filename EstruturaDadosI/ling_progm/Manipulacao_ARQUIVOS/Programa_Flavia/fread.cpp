 #include <stdio.h>
 #include <iostream>
 #include <stdlib.h>
 
 struct dados{
 	char nome[10];
 	char end[10];
 	int idade;
 };
 
 int main(){
 	struct dados cad;
 	FILE *arq;
 	arq = fopen("clientes.txt","a+");
 	
 	
 	if(arq==NULL || ferror(arq))
 		printf("\nAlgum erro ocorreu.");
 		
 	else{
	 	//while(!feof(arq)){	 
 		fread(&cad,sizeof(struct dados),1,arq);

 		//fread(&cad.end,sizeof(struct dados),1,arq);
 		//fread(&cad.idade,sizeof(struct dados),1,arq);
 		printf("Dados gravados no arquivo:\n");		
 		printf("%s",cad.nome);
 		
 	//}
 	}
 	
 	fclose(arq);
 	return 1;
 }
