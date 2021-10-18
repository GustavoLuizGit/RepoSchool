 #include <iostream>
 
 int main(){
 	char nome[50];char ok;
 	
 	FILE * arquivo;
 	
 	arquivo = fopen("texto.txt", "r");
 	if(arquivo == NULL){
 		printf("Arquivo texto nao localizado..");
	 }
	 else{
	 	fgets(nome,30,arquivo);
	 	printf("\nNome: %s",nome);
	 	
	 }
	 fclose(arquivo);
	 system("pause");
	 getchar();
 }
