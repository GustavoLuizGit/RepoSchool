 int Lconta(Lista *pl,char X){
	int i=0,cont=0;
	//char Aux;
	if(pl->Fim<TAM){ 
		
		if(pl->M[i]!=X){ //percorre ate NAO encontrar o caracter
		++i;
			while(pl->M[i] == X){ // se achou faz o while enquanto o valor continuar igual
			cont++;
			++i;
			}
		}
		else //else que testa se o primeiro valor é igual a X,no caso de ter apenas um caracter na lista
			cont++;
		
	}
	return cont;
}
