 #include <iostream>
#include <stdio.h>
 int main()
 { FILE *p;
 char carac;
 p = fopen("teste1.txt","a");
 if (p == NULL)
 printf("\nErro na abertura");
else
 { printf("\nDigite um caractere: ");
 scanf("%c", &carac);
 while (carac != 'f')  //fputc(p,carac);
 { fprintf(p,"%c",carac); //fprintf vs fputc e fputs
 if (ferror(p))
 printf("\nErro na gravação do caractere");
 else printf("\nGravação realizada com sucesso");
 printf("\nDigite outro caractere: ");
 scanf("%c", &carac);
 }
  
 }
 
 fclose(p);
 return 0;
}
