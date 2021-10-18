#include <locale.h>
#include <iostream>
#include <list>
using namespace std; 
int main()
{
	setlocale(LC_ALL, "");	// codigo para adptar os caracteres, acentuações e etc 
	// criando uma lista de int vazia e um iterador de int
	list<int> List_STL;
	list<int>::iterator i;
	
	//inserindo elementos no final da fila	
	List_STL.push_back(7);
	List_STL.push_back(12);
	List_STL.push_back(8);
	//inserindo elemtnos no inicio da fila
	List_STL.push_front(34);
	List_STL.push_front(69);
	
	// imprimindo lista
	cout << "Imprimindo lista : ";
	for ( i = List_STL.begin(); i != List_STL.end(); i++ )
    	cout << " " << *i ;
    cout << endl;
    
    //inserdino o numero 1 como ultimo elemento na fila  E  removendo o numero 7 
    List_STL.insert( List_STL.end(), 1);
    List_STL.remove(7);
    
	//imprimindo a lista apos as modificações 
    cout << "Imprimindo lista após as modificações feita no codigo ao lado: ";
	for ( i = List_STL.begin(); i != List_STL.end(); i++ )
    	cout << " " << *i ;
    cout << endl;
    //codigo para ordenar a lista
    List_STL.sort();
    
    cout << "Imprimindo lista após a ondenação : ";
	for ( i = List_STL.begin(); i != List_STL.end(); i++ )
    	cout << " " << *i ;
	
	
	return 1;
}
