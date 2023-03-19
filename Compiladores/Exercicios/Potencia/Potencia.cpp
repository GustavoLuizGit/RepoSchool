#include <stdio.h>

int pot(int, int);

int main(void) {
	int numero = 4, potencia = 3;

	printf("O numero %d elevado a %d e %d", numero, potencia, pot(numero, potencia));

	return 1;
}

int  pot(int x, int y) {
	if (y == 0)
		return 1;
	else
		if (y == 1)
			return x;
		else
			return x * pot(x, y - 1);
}
