  #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 #include <math.h>
 void barra(int qn) {
 	int i;
 	for (i=1 ; i<= qn ; ++i){
	 
	 printf("=");
	}
 }
 int main(void) {
 	int n;
 	setlocale(LC_ALL,"");
 	
 	barra(30);
 	printf("\n");
 	printf("Entre com um número: \n");
 	barra(30);
 	printf("\n");
 	scanf("%i",&n);
 	
 	
 	printf("A terça parte desse número é %i",n/3);
 }
