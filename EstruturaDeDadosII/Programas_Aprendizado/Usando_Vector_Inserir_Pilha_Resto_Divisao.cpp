#include <iostream>
#include <stack>
using namespace std;

void mostra(stack<int> x)
{
	do
	{
		cout<<" "<<x.top();
		x.pop();
	}while(!x.empty());
}
int main()
{
	int numero;
	stack<int> pilha;
	cout<<"Entre com um numero :";
	scanf("%d",&numero);
	
	do
	{
		pilha.push(numero % 2);
		numero = numero / 2;
	}while(numero>0);
	
	cout <<"Imprimindo a pilha : ";
	mostra(pilha);
}
