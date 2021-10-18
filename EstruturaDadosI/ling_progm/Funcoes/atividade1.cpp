 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 void retorno(int num){
 	if (num>0){
 		printf("Valor positivo: 1");
	 }
	else 
		printf("Valor negativo: 0");
 }
 int main(void){
 	int num;
 	printf("Insira um num: ");
 	scanf("%d",&num);
 	retorno(num);
 }
