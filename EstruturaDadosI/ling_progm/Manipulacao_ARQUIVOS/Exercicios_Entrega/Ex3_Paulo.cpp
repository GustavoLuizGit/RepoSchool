 #include <iostream>
 
 int main(){
 	FILE * arqv;
 	int i=0;
 	
 	
 	/////
 	arqv = fopen("resultado.txt","a");
 	
 	if (arqv == NULL){
 		printf("Nao foi possivel criar o arquivo");
	 }
	else {
		for(i=0;i<=10;++i){
		fprintf(arqv,"%d\n",i);	//file printf
	
		}
		//fgets() e fprintf() possuem 3 paramentro
	
	}
	fclose(arqv);
 }
