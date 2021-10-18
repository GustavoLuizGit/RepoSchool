 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 
 int main(){
 	int n1,n2,troca;
 	printf("Entre com 2 numeros: ");
 	scanf("%i %i*c",&n1,&n2);
 	
 	if (n1>n2){
 		troca = n1;
 		n1 = n2;
 		n2 = troca;
	 }
	 printf(" 1o. %i  | 2o. %i",n1,n2);
	 
	 getchar(); //
	 
 }
