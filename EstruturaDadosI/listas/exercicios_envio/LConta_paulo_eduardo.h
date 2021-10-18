int Lconta(Lista *pl,char X){
    int i,cont=0;

    for (i=0;i<pl->Fim;i++){
        if(X==pl->M[i]){
            cont++;
        }
    }
    return cont;
}
