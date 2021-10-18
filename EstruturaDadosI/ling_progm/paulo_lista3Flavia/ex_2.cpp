 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 
 int main(void){
 	setlocale(LC_ALL,"");
 	int cod[5],veic[5],acid[5];
 	int i,j,a,maior_ac,cod_menor,cod_maior,menor_ac,p;
 	float total_veiculos,media_ac,media_aux;
 	printf("------ COLETOR DE ESTATÍSTICAS URBANA ----\n");
 	for (i=0;i<4;++i){
 		printf("Digite o código da %d.o cidade: ",i+1);
 		scanf("%d",&cod[i]);
 		printf("Digite número de veículos de passeio: ");
 		scanf("%d",&veic[i]);
 		total_veiculos+=veic[i];
 		printf("Digite o número de acidentes com vítimas na cidade: ");
 		scanf("%d",&acid[i]);
 		printf("============================================\n");
	 }
	 for (i=1;i<4;++i){ 
	 	a=i;
	 	for (j=i+1;j<4;++j) { //INICIO DA COMPARACAO MAIOR N DE ACIDENTES
	 		if(acid[a]>acid[j]){
	 			maior_ac=acid[a];
	 			cod_maior=cod[a];
	 		}
	 		else {
			 maior_ac=acid[j];
			 cod_maior=cod[j];			 
			}					
			if (acid[a]<acid[j]){ //INICIO COMPARACAO MENOR N ACIDENTES 
				menor_ac=acid[a];
				cod_menor=cod[a];
			}
			else {
				menor_ac=acid[j];
				cod_menor=cod[j];
			}
			if (veic[i]<=2000){ // INCIO TESTE DE ACIDENTES COM - DE 2000 VEIC
			 media_aux += acid[i];
			 p++; 	
			}
		 }
	 }	
	 	printf("A ) Maior taxa de acidente %d  \n",maior_ac);
	 	printf("Código da MAIOR cidade em taxa de acidente %d\n",cod_maior);
	 	printf("A.2 )Menor taxa de acidente %d  \n",menor_ac);
	 	printf("Codigo da MENOR cidade em taxa de acidente: %d \n",cod_menor);
	 	printf("B)Média d veículos das cidades: %.1f veículos\n",total_veiculos/4.);
	 	printf("C)Média de acidentes em cidades com menos de 2000 veiculos: %.1f",media_aux/p);
	 }

