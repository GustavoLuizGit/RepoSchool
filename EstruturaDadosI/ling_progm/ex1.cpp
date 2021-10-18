 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 int main(void){
 	int i,ac,a;
 	ac = 0;
 	do{
 		
 	if(i % 2==0)
 	{
 	ac+=i;		
 	printf("%d.\n",i);
 	
 	}
 	++i;
	 } while(i<100);
	printf("======A soma e : %d =========",ac);
 }
