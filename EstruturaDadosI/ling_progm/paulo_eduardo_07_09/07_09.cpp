  #include <stdio.h>
  #include <stdlib.h>
  #include <conio.h>
  
int main(){	
  	int i,n,ac;
  	printf("Digite um numero inteiro: ");
  	scanf("%d",&n);
  	ac=0; // se nao zerar o acumulador ele entra no programa com lixo (1 ja na posicao)
  	for (i=n-1;i>0;--i){		
  		if(n % i == 0){
  			ac+=i;
  			printf("%d\n",i); 			
		  }
	}
	if(ac==n)
		printf("O numero e perfeito.");		
	else
		printf("O numero nao e perfeito.");				    
  }
