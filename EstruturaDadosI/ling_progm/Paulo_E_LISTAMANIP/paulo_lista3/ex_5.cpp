 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 #include <ctype.h>
 
 int main() {
 	int c;
 	float s;
 	 
 	setlocale(LC_ALL,"");
 	//menu inicio
 	do {
 	printf("\n============TABELA DE CARGOS==========\n");
 	printf("1.	Escritu�rio\n");	
 	printf("2.	Secret�rio\n");
 	printf("3.	Caixa\n");
 	printf("4.	Gerente\n");
 	printf("5.	Diretor\n");
 	printf("6. SAIR DO PROGRAMA\n");
 	printf("Porfavor,entre com o < c�digo > do seu cargo: ");
 	scanf("%i",&c);
 	system("cls");
 	
 	if (c <=5 ){	 
 	printf("Digite seu sal�rio atual: ");
 	scanf("%f",&s);	
 	}
	
 	switch (c) {
 		case 1: 
 			printf("Escritu�rio:aumento de %.2f reais\n",s*0.5);
 			printf("Sal�rio total: %.2f reais\n",s*0.5 + s);
 		break;
		case 2:
			printf("Secret�rio:aumento de %.2f reais\n",s*0.35);
			printf("Sal�rio total: %.2f reais",s*0.35+s);
		break;
		case 3:
			printf("Caixa:aumento de %.2f reais\n",s*0.2);
			printf("Sal�rio total: %.2f reais\n",s*0.2+s);
		break;
		case 4:
			printf("Gerente:aumento de %.2f reais\n",s*0.1);
			printf("Sal�rio total: %.2f reais\n",s*0.1+s);
		break;
		case 5:
			printf("Cargo de diretoria n�o sofrer� aumentos.\n");
			printf("Sal�rio atual : %.2f reais\n",s);
		break;
		default :
			printf("C�DIGO INV�LIDO,TENTE NOVAMENTE!");
							
	 }

	} while(c<=5);
 	
 	
 }
