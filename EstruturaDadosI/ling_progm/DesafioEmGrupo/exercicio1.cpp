#include <stdlib.h>
#include <stdio.h>

int main(void){
	
	int m[3][6], i, j,vet[18];
	
		for(i=0;i<3;i++){
		
		for(j=0;j<6;j++){			
			printf("%d: ",j+1);
			scanf("%d",&vet[j]);
			m[i][j]=vet[j];
		}
		
	}
	
	
//	for(i=0;i<3;i++){
//		
//		for(j=0;j<6;j++){			
//			
//			m[i][j]=vet[j];
//		}
//	}
		
	
	for(i=0;i<3;i++){
		
		for(j=0;j<6;j++){			
			printf("%d\n",m[i][j]);
			
		}
		printf("\n");
	}
	
	return 1;
	
	
}
