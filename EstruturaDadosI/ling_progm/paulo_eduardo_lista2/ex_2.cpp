#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int main(void) {
	int n;
	printf("DIGITE UM NUMERO: ");
	scanf("%i",&n);
	
	if (n % 5 ==0) 
		printf("O VALOR E MULTIPLO DE 5...");
		
	else
		printf("O VALOR NAO E MULTIPLO DE 5!!!");
		
	
}
