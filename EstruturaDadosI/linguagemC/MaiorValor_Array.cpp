 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 
 int main(void){
 	int v[6],i,j,aux,maior,a;
 	i=0;
 	j=0;
 	a=0;
 	for (i=0;i<5;++i){	 
 	printf("Digite o %d valor: ",i+1);
 	scanf("%d",&v[i]);
 	
 	}
 	for (i=0;i<5;++i){
 		a=i;
 	if(i==0)
	 	maior=v[0];
 		for (j=i+1;j<5;++j){			
 			if(v[j]>maior) {
			 maior = v[j];			 
			}
			else if (v[a]>maior)
				maior=v[a]	;				
	 	}
	}	 
	 printf("Maior valor: %d",maior);
 }
