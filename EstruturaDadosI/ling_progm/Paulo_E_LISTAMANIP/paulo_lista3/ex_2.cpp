 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 
 int main() {
 	int i,n[5],troca,j,a;
 	setlocale(LC_ALL,"");
 	for (i=1;i<=3;++i){
 	printf("Digite o %i número: ",i);
 	scanf("%i",&n[i]);		
 	}
 		for (i=1; i<=3 ; ++i) {
 			a=i;
 			for (j=i+1 ; j<=3 ; ++j) {
 				if(n[a] > n[j]) {
 					troca = n[a];
 					n[a] = n[j];
 					n[j] = troca;
				   }
			 	}
			printf("%i",n[i]);
		   }
		
}
