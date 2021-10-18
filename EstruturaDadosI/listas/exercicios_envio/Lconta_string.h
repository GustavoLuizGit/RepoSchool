 int Lconta(Lista *pl,Elem X){
	int i=0,cont=0;

	while( i<pl->Fim && strcmp(X , pl->M[i])>0)
		i++;
	while((i<pl->Fim) && strcmp(X , pl->M[i])==0){
		cont++;
		i++;
	}
    return cont;
}
