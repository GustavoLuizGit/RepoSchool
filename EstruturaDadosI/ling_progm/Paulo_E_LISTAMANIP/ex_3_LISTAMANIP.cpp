#include <ctype.h>
#include <stdio.h>
#include <string.h>
#include <locale.h>

int main(void)
{
    char frase[50], frase_nova[50];
    char palavra[50];
    int tam, i, j, cont;
    printf("\n Digite uma Frase: ");
    gets(frase);
    tam = strlen(frase);
    i = 0;
    cont = 0;
    while (i<tam)
    {
        j=i;
        while (j <tam && frase[j] != ' ')
        {
            palavra[cont] = frase[j];
            cont++;
            j++;
        }
        palavra[cont] = '\0';
        cont = 0;
        if (strcmp(palavra, "TECLADO")==0)
        {
            strcat(frase_nova, "TECLADO OU MOUSE");
        }
        else
        {
            strcat(frase_nova, palavra);
        }
        if (j < tam)
            strcat(frase_nova, " ");
        i = j + 1;
    }
    strcat(frase_nova, "\0");
    printf("\n nova frase = %s", frase_nova);
    getchar();
    return 1;
}
