 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 int soma(int n1,int n2){
 	
 	return n1+n2;
 }
 int main(){
 	int n1,n2;
 	printf("Digite dois numeros: ");
 	scanf("%d %d",&n1,&n2);
 	
 	printf("\nSOMA: %d",soma(n1,n2));
 }
