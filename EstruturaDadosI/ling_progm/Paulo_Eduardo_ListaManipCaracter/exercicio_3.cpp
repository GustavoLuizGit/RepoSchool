#include <stdio.h>
#include <string.h>
#include <conio.h>

#define n 10000

int main (){

	int i=0, p=0;
	char f[n];

	printf ("entre com uma frase :\n ");
	gets(f);

    for(i=0;i<strlen(f);i++)
	{
    	
    	if(f[i]==' ')
		{
    		p++;
		}
	}
 
	printf (" Quantidade de Palavras : %d ",p+1);
	return 1;
}
