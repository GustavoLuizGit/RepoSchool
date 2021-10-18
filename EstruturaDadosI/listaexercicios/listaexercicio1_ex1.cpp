 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 #include <math.h>
 float calculo (float n1,float n2,float n3,char op,float *x){
	float media,mp,nv;
	
	if (op =='M'||op=='m'){
	
	*x = (n1 + n2 + n3) / 3.0;
	}
	}

 
 int main(void) {
 	int i,n1,n2,n3,y;
 	 char op;
	float media,x,p;
	
	printf("Para obter media press <M> ... media ponderada <P>");
	scanf("%s",&op);
 	
 	printf("Digite a 1 nota: ");
	scanf("%i",&n1);
	printf("Digite a 2 nota: ");
	scanf("%i",&n2);
	printf("Digite a 3 nota: ");
	scanf("%i",&n3);
	
		 //implementar switch e for 
	p = calculo(n1,n2,n3,op,&x);
	printf("%f",p);
 	
 	
 }
