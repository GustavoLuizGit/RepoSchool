#include <iostream>
#include <vector>
using std::cin;
using std::endl;
using std::cout;
int main()
{
	std::vector<int> Vetor_STL;
	std::vector<int>::iterator i; 
	
	//COMANDOS PARA INCLUIR NO FINAL DO VETOR
	Vetor_STL.push_back(1);
	Vetor_STL.push_back(12);
	Vetor_STL.push_back(50);
	
	//COMANDOS PARA IMPRIMIR O VETOR
	cout << "Imprimindo vetor : ";
	for ( i = Vetor_STL.begin(); i != Vetor_STL.end(); i++ )
		cout << " " << *i;
	cout << endl;
	
	//COMANDOS QUE INSEREM UM NUMERO COMO SEGUNDO ELEMENTO DO VETOR
	Vetor_STL.insert( Vetor_STL.begin() + 1, 36);
	
	//COMAMNDO PARA IMPRIMIR VETOR
	cout << "Imprimindo vetor : ";
	for ( i = Vetor_STL.begin(); i != Vetor_STL.end(); i++ )
		cout << " " << *i ;
	cout << endl;
	
	//RETIRANDO O TERCEIRO ELEMENTO DO VETOR 
	Vetor_STL.erase( Vetor_STL.begin() + 2);
	//COMANDOS PARA IMPRIMIR O VETOR
	cout << "Imprimindo vetor : ";
	for ( i = Vetor_STL.begin(); i != Vetor_STL.end(); i++ )
		cout << " " << *i ;
		
	Vetor_STL.insert();
	cout << "Imprimindo vetor : ";
	for ( i = Vetor_STL.begin(); i != Vetor_STL.end(); i++ )
		cout << " " << *i ;
	//LIMPA O VETOR
	
	
	Vetor_STL.clear(); 
	return 0;
}

