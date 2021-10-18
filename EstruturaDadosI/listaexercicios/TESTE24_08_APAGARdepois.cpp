 #include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>
float calc(float a,float b,float c, char op,float *m) {
	
	if(op == 'M' || op == 'm') {
		*m = (a+b+c)/3.0;
				 
	}
	else if (op == 'p' || op == 'P'){
		*m = (a*5 + b*3 + c*2 )/ 10.;				
	}	
	
}
int main(void) {
	float n1,n2,n3,x,m;
	char op;
	printf("Entre com a 1 nota: ");
	scanf("%f",&n1);
	printf("Entre com a 2 nota: ");
	scanf("%f",&n2);
	printf("Entre com a 3 nota: ");
	scanf("%f",&n3);
	printf("OPCOES || <M> MEDIA ARITMETICA || <P> MEDIA PONDERADA: ");
	scanf("%s",&op);
	x = calc(n1,n2,n3,op,&m);
	printf("%.1f",x);
	return 0;
}
