 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <string.h>
 #include <ctype.h>
 #include <locale.h>
 
 int main(){
 	setlocale(LC_ALL,"");
 	char n[50],n2[50],aux[100];
 	int i,j;
 	
 	printf(" ");
 	gets(n);
 	
 	printf(" ");
 	gets(n2);
		if(n[0]>n2[0]){
			printf("%s\n",n2);
			printf("%s",n);
		}
 		else {
		 
 			printf("%s\n",n);
 			printf("%s",n2);
 		}
 	 }
