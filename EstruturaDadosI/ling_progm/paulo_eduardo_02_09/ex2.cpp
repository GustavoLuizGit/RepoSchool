#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <math.h>
int main(void) {
	int p,i;
	float b,r;
	printf("Entre com a base: ");
	scanf("%f",&b);
	printf("Entre com a potencia: ");
	scanf("%d",&p);
	
	while(i<p){
		++i;
		r = pow(b,i);
		printf("A potencia de %.0f exponeciado a %d = %.1f\n",b,i,r);
	}
	
}
