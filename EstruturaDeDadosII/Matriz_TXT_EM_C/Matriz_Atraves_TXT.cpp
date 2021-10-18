#include <iostream>

int main()
{
	FILE *arq=fopen("dados.txt","r");
	
	int nl,nc;
	
	fscanf(arq,"%d",&nl);
	fscanf(arq,"%d",&nc);
	
	printf("Número de linhas : %d\n",nl);
	printf("Numero de colunas : %d\n",nc);
	
}
