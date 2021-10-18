 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 
 int main(void) {
 	int i;
 	printf("DIGITE SUA IDADE: ");
 	scanf("%i",&i);
 	
 	if (i >=18 && i <=67)
 		printf("VOCE PODE DOAR SANGUE .");
 	else 
 		printf("VOCE NAO PODE DOAR SANGUE .");
 }
