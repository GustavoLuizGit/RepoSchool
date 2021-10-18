#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>

int main(void) {
	int b,h;
	float a;
	printf("Digite a base e a altura do triangulo: ");
	scanf("%i %i",&b,&h);
	a = (b*h )/2.;
	printf("Area = %.1f",a);
}
