 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 #include <math.h>
 
 int main(void ){
 		int x;
 		setlocale(LC_ALL,"Portuguese");
 	
 		printf("Entre com um número qualquer: ");
 		scanf("%i",&x);
 		
 		printf("%i ... %i",x-1,x+1);
 }	
 	
