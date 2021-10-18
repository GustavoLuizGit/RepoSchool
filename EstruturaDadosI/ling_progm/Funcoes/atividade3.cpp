#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
int callback(int n1,int n2,int n3){
	int r;
	if (n2%n1==0 || n3%n1==0){
		printf("%d",r=n2+n3);
	}
}
int main(void){
	int n1,n2,n3;
	printf("Digite tres numeros: ");
	scanf("%d %d %d",&n1,&n2,&n3);
	callback(n1,n2,n3);
	
}
