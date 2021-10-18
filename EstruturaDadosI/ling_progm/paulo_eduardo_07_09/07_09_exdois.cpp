 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 
 int main(void){
 	int i,n;
 	for (i=1;i<=999;++i){
 		n=1000+rand() %1999;
 		if (n % 11 == 5)
 				printf("%d\n",n);			
 	}
 	
 }
