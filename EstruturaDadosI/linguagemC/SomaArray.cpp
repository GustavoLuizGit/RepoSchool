 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 int main(void){
 	int i,ac,n[6];
 	ac=0;
 	for (i=1;i<=5;++i){
	printf("Digite o %d valor: ",i);
	scanf("%d",&n[i]);
	ac+=n[i];	
	}
	printf("SOMA: %d\n",ac);
	system("pause");
 }
