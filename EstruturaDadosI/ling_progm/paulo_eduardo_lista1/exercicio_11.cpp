#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>
#include <math.h>

int main(void) {
	int i,a,b,y;
	printf("Digite seu ano de nascimento: ");
	scanf("%i",&i);
	
	printf("Digite o ano atual: ");
	scanf("%i",&a);
	b = a - i;
	printf("Sua idade: %i anos\n",b);
	y = (2050 - i);
	printf("Em 2050 voce tera %i anos.",y);
}
