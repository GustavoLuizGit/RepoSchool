 void intervalo(Lista *pl,char X,char F){
	
	int i,a=0;
	
	while(i<pl->Fim && X != pl->M[i])
		++i;
		
	printf("[")	;
	while(i<pl->Fim && pl->M[i]<=F){
		printf("%c ",pl->M[i]);
		++i;
	}
	printf("]");

}
