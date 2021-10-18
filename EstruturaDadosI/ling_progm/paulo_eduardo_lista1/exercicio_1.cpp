 #include <stdio.h>
 #include <stdlib.h>
 #include <conio.h>
 #include <locale.h>
 
 int main(void) {
 	int nota[5],peso[5],i,acumulador_peso;
 	float media,m_aritmetica,p; 	
 	acumulador_peso=0;
 	setlocale(LC_ALL,"");
 	
 	for (i=1;i<=3;++i){
 		printf("Digite a %i nota: ",i);
 		scanf("%i",&nota[i]);
 		printf("Digite o peso da %i nota: ",i);
 		scanf("%i",&peso[i]);
	 }
	 
	for (i=1;i<=3;++i){
		media =	media + nota[i]*peso[i];
		acumulador_peso += peso[i];		
		m_aritmetica += nota[i];
				
	}
		p = media / acumulador_peso;
		m_aritmetica = m_aritmetica / 3.0 ;
		printf("=======================================\n");
		printf("MÉDIA PONDERADA FINAL: %.1f\n",p);
		printf("MÉDIA ARITMÉTICA FINAL(SEM OS PESOS): %.1f\n",m_aritmetica);
		printf("=======================================");
	 
 }
