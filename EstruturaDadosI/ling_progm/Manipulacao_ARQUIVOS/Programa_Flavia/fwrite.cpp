#include <stdio.h>
 int main()
 { struct cliente
 { int numero;
 char nome[20];
 };
 
 FILE *cli;
 struct cliente c;
 cli = fopen("fwrite.txt", "ab+");
 
 if (cli == NULL)
 printf("\nErro na abertura do arquivo");
 
 else
 { printf("\nDigite o n�mero do cliente a ser inclu�do");
 scanf("%d%*c", &c.numero);
 printf("Digite o nome do cliente a ser inclu�do ");
 gets(c.nome);
 fwrite(&c, sizeof(struct cliente), 1, cli);
 
 
 if (ferror(cli))
 printf("Erro na grava��o ");
 else printf("Grava��o realizada com sucesso ");
 fclose(cli);
 }
 getchar();
 return 0;
}

