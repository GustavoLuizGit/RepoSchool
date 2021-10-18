 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 int main(void){
 	int i,ac;
 	do{
 		++i;
 		if(i % 2==0)
 			ac+=i;
	 } while(i<=100);
	printf("A soma é : %d",ac);
 }
