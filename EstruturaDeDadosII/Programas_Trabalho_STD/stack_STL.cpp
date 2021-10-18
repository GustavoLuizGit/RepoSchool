#include <iostream>
#include <stack>
#include <locale.h>
using namespace std;
// função que imprimi a stack
void Mostra(stack<int> x)
{
	while (!x.empty())
	{
		cout << " " << x.top();
		x.pop();
	}
}
int main(void)
{
	setlocale(LC_ALL,"");
	//criando a stack
	stack<int> pilha_STL;
    
    //inserindo elementos a stack criada
	pilha_STL.push(1);
    pilha_STL.push(2);
    pilha_STL.push(3);
    pilha_STL.push(4);
    
    //mostrando o tamanho da stack e imprimindo a stack
    cout << "Tamanho da pilha : " << pilha_STL.size() << endl;
    cout << "Imprimindo a pilha : ";
    Mostra(pilha_STL);
    cout<<endl;
    //removendo elementos "superior" da stack
	pilha_STL.pop();
    pilha_STL.pop();
    
    //mostrando o tamanho da stack e imprimindo a stack
    cout << "Tamanho da pilha : " << pilha_STL.size() << endl;
    cout << "Imprimindo a pilha após a remoção : ";
    Mostra(pilha_STL);
}
