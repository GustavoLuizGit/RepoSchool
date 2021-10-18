 #include <stdio.h>
 #include <stdlib.h>
 #include <iostream>
 
 int main(void){
 	FILE *f1;
 	
	 char c;	
 	f1 = fopen("f2.txt","r");
 	if ( f1 == NULL)
 		printf("Arqv desconhecido");
 	else {
 		while(!feof(f1)){
 			c = fgetc(f1);
 			printf("%c",c); // é possivel fazer sem o %c ,usando o %s direto 			
		 }
	 }
 	
 	fclose(f1);
 }
