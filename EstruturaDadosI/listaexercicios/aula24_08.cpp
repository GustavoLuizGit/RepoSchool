#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>
#include <ctype.h>

float calc(float a,float b,float c,char op) {
	float m;
	if(toupper(op)=='M') {
		m = (a+b+c)/3.0;		 
	}
	else {
		m = (a*5. + b*3. + c*2. )/ 10.;
				
	}	
	return m; //return deve ser o ultimo comando da função !
}
int main(void) {
	float n1,n2,n3,x;
	char opc;

	printf("Entre com a 1 nota: ");
	scanf("%f",&n1);
	printf("Entre com a 2 nota: ");
	scanf("%f",&n2);
	printf("Entre com a 3 nota: ");
	scanf("%f",&n3);
	printf("OPCOES || <M> MEDIA ARITMETICA || <P> MEDIA PONDERADA: ");
	scanf(" %c",&opc); // olhaaaaaaaaaaa o es pa co onde ficaaaaaaaaaaaa
	
	printf("%f ",calc(n1,n2,n3,opc));
	
}
