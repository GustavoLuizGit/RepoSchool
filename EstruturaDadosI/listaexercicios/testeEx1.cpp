 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 #include <math.h>
 
// float calc(int n1,int n2,int n3) {
// 	float m;
// 	m = (n1+n2+n3) / 3.;
// 	return m;
// }
 
 int main(void) {
 	int a,b,c;
 	float media;
 	char op;
 	printf("OP: ");
 	scanf("%c",&op);
 	printf("NOTA1: ");
 	scanf("%i",&a);
 	printf("NOTA2: ");
 	scanf("%i",&b);
 	printf("NOTA3: ");
 	scanf("%i",&c);
 	
 	if (op == 'm') {
 		media = (a+b+c) / 3.0;
 		printf("MEDIA AR: %f",media);
	 }
 	
 	
 }
