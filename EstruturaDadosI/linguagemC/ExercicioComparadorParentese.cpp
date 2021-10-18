 #include <stdio.h>
 #include <stdlib.h>
 #include "pilhas.h"
 #include <conio.h>
 
 int main(){
 	char exp[40];
 	char flag;
 	flag=1;
 	int i;
 	Pilha P;
 	Inity(&P);
 	printf("Digite a expressao: ");
 	scanf("%s",&exp);
 		for (i=0;exp[i];++i){
 			if (exp[i]=='(')
 				Push(&P,1);
 			
 			else 
			 	if (exp[i]==')'){
			 		if(!Empty(&P)){
					 
			 			Pop(&P);
			 		}
			 		else{
			 			flag=0;
			 			break;
					 }
			 		
			}
		 }
		if (Empty(&P)&& flag == 1)
			printf("A expressao esta correta .");
		
		else 
			printf("Expressao incorreta .");
 	
 }
