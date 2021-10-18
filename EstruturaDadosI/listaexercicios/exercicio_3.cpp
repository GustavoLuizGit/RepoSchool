 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 char calc(int a) {
 	if (a % 2 == 0){
 	return 1;
	 }
	 else {
	 	return 0;
	 }	    
 }
 int main(void) {
 	int n;
 	printf("ENTRE COM UM VALOR: ");
 	scanf("%i",&n);
 	if(calc(n)) {
 		printf("NUM PAR!!");
	 }
	else {
		printf("NUM IMPAR !! ");
	}
 	
 }
