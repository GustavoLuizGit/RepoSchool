 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 int main(void) {
 	int alt[11],i,j,a,maior;
 	setlocale(LC_ALL,"");
 	for(i=0;i<10;++i){
 	printf("Digite a %d altura: ",i+1);
 	scanf("%d",&alt[i]);
 	}
 	for(i=0;i<10;++i){
 		a=i;
 		for (j=i+1;j<10;++j){
 			if (alt[a]< alt[j]){
 				maior = alt[j];
			 }
		 }
 	}
 	printf("Maior altura: %d",maior);
 	
 }
