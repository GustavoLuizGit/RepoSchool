#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
 
 int main(void) {
 	int q;
 	printf("DIGITE A QUANTIDADE DO PUBLICO DA PARTIDA: ");
 	scanf("%i",&q);
 	
 	if(q <= 1000)
 		printf("PUBLICO BAIXO.");
 		
 	else if (q>=1001 && q<=10000) 
 		printf("PUBLICO MEDIO.");
 	else if( q >=10000)
 		printf("PUBLICO BOM");
 }
