#include <iostream>
#include "Pilhas.h"

using namespace std;

int main()
{
	Pilha<int>* P1 = new Pilha<int>();

	P1->Push(1);
	P1->Push(2);
	P1->Push(3);
	
	cout << P1->Pop() << endl;

	return 0;
}