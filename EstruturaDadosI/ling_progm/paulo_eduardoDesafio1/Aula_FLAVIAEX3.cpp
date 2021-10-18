 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 #include <math.h>
 
 int main(void) {
 	setlocale(LC_ALL,"");
 	float op;
 	int x1,x2,y1,y2;
 	printf("Insira o x1 : ");
 	scanf("%i",&x1);
 	printf("Insira o x2 : ");
 	scanf("%i",&x2);
 	
 	printf("Insira o y1 : ");
 	scanf("%i",&y1);
 	printf("Insira o y2 : ");
 	scanf("%i",&y2);
 	
 	op = sqrt(pow(x2-x1,2)+pow(y2-y1,2));
 	
 	printf("A distancia entre o ponto é: %.2f",op);
 }
