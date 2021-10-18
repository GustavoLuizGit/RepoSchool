#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <time.h>

int main(void){
	time_t data;
	data = time(NULL);
	struct tm *dat = localtime(&data); //ler sobre o struct e struct tm
	

	printf("%d /",dat -> tm_mday);
	printf("%d /",dat -> tm_mon +1);
	printf("%d ",dat -> tm_year+1900);
	printf(" / %d:",dat -> tm_hour);
	printf("%d",dat -> tm_min);
	

}
