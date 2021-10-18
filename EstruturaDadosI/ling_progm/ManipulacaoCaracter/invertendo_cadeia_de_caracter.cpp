 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <string.h>
 
 int main(void){
 	char text[20],aux_text[20];
 	int i,a;
 	printf("Digite uma frase: ");
 	gets(text);
 	a=0;
		for (i=strlen(text)-1;i>=0;--i){
			aux_text[a]=text[i];
			a++;			
		}
	aux_text[a] = '\0';
	printf("= Frase invertida = ");	
	printf("--- %s\n",aux_text);
	
	system("pause");
 }
