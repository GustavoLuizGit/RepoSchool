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
 	printf("1.	Escrituário\n");	
 	printf("2.	Secretário\n");
 	printf("3.	Caixa\n");
 	printf("4.	Gerente\n");
 	printf("5.	Diretor\n");
 	printf("6. SAIR DO PROGRAMA\n");
 	printf("Porfavor,entre com o < código > do seu cargo: ");
 	scanf("%i",&c);
 	system("cls");
 	
 	if (c <=5 ){	 
 	printf("Digite seu salário atual: ");
 	scanf("%f",&s);	
 	}
	
 	switch (c) {
 		case 1: 
 			printf("Escrituário:aumento de %.2f reais\n",s*0.5);
 			printf("Salário total: %.2f reais\n",s*0.5 + s);
 		break;
		case 2:
			printf("Secretário:aumento de %.2f reais\n",s*0.35);
			printf("Salário total: %.2f reais",s*0.35+s);
		break;
		case 3:
			printf("Caixa:aumento de %.2f reais\n",s*0.2);
			printf("Salário total: %.2f reais\n",s*0.2+s);
		break;
		case 4:
			printf("Gerente:aumento de %.2f reais\n",s*0.1);
			printf("Salário total: %.2f reais\n",s*0.1+s);
		break;
		case 5:
			printf("Cargo de diretoria não sofrerá aumentos.\n");
			printf("Salário atual : %.2f reais\n",s);
		break;
		default :
			printf("CÓDIGO INVÁLIDO,TENTE NOVAMENTE!");
							
	 }

	} while(c<=5);
 	
 	
 }
