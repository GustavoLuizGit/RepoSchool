#include <iostream>
#include "Filas.h"

using namespace std;

int main()
{
	Fila<int>* F1 = new Fila<int>();
	F1->Enqueue(1);
	F1->Enqueue(2);
	F1->Enqueini(3);
	F1->Mostrar();
	return 0;
}