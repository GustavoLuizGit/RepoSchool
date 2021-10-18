#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

void retorno(int n){
	int i,r;
	for(i=0;i<10;++i)
		printf("%d x %d = %d \n",n,i,n * i);
}
int main(void){
	int n,i,r;
	printf("Insira um valor entre 0 e 9: ");
	scanf("%d",&n);
	
	printf("=== TABUADA == \n");

		retorno(n);
		

}
