 #include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <string.h>
#include <ctype.h>
#include <locale.h>
char strcopy(char f2[20],char f1[20]){
	int i;
	for(i=0;i<strlen(f1);++i){
		f2[i]=f1[i];
	}
	f2[i]='\0';
}

int main(void){
	char f1[20],f2[20];
	int i,a;
	char ff[20],fi[20],b[20];
	printf("Frase: ");
	gets(f1);
	//strcat(f2,f1);
	printf("qn f1 : %d\n",strlen(f1));
	for(i=0;i<strlen(f1);++i){
		f2[i]=0;
	}
	printf("%s\n",f1);
	strcat(f2,f1);
	printf("%s",f2);
	
	printf("================USO DA FUNCAO NOVA ===================\n");
	printf("Frase 2 : ");
	gets(ff);
	strcopy(fi,ff);
	printf("%s",fi);
	
	return 1;
}
