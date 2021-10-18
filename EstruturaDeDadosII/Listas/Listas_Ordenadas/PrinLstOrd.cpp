#include <iostream>
#include "LstOrd.h"

using namespace std;

int main()
{
	LstOrd *L1 = new LstOrd();
	L1->Insere('b');
	L1->Insere('d');
	L1->Insere('e');
	L1->Insere('g');
	L1->Insere('m');
	L1->Mostra();
	
	cout << endl;
	cout << "Tamanho da Lista : " << L1->Tamanho() << endl;
	if (L1->Remove('d'))
	{
		cout << "Elemento removido com sucesso!" << endl;
	}
	else
	{
		cout << "Elemento Inexistente!" << endl;
	}
	L1->Mostra();
	cout << endl;
	cout << "Tamanho da Lista : " << L1->Tamanho() << endl;
	return 1;
}