 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <string.h>
 
 int main(void){
 	char text[20],aux_text[20];
 	int i,j,a;
 	printf("Digite uma frase: ");
 	gets(text);
 	a=0;
 	j=strlen(text);
 	printf("%d",j);
 	for(i=0;i<=j;++i){	
 		printf("j=%d \ni=%d",j,i);
 		text[i]=text[j];
		 --j;					
	 }
	 for(i=0;i<=j;++i){	
 		printf("%c",text[i]);
	 }
	//printf("\n %s",text);
 }
