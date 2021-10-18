 int Dequeue_fim(Fila *premover){
	if(premover->Total>0){
		int X = premover->M[premover->Fim-1];
		premover->Fim++;
		if(premover->Fim==TAM){
			premover->Fim=0;
		}
		premover->Total--;
		return X;
	}
}	
