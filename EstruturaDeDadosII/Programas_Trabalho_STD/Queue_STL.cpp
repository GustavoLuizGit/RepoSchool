#include <locale.h>
#include <iostream>
#include <queue>
using namespace std;
//fun��o que imprimi a queue 
void Mostra(queue<int> x)
{
    while (!x.empty()) 
	{
        cout << " " << x.front();
        x.pop();
    }
}

int main()
{
	setlocale(LC_ALL,"");
	//crian��o da queue
	queue<int> queue_STL;
	//inserindo elementos na queue
	queue_STL.push(3);
	queue_STL.push(5);
	queue_STL.push(6);
	//imprimindo a queue
	cout <<"Imprmindo a queue : ";
	Mostra(queue_STL);
	cout <<endl;
	//mostrando o tamanho da queue
	cout <<"Tamanho da fila : " << queue_STL.size();
	cout <<endl;
	//codigo que retira o primeiro elemento da queue  
	queue_STL.pop();
	//imprimindo a queue
	cout <<"Imprmindo a queue ap�s a remo��o : ";
	Mostra(queue_STL);
	cout <<endl;
	//mostrando o tamanho da queue
	cout <<"Tamanho da fila : " << queue_STL.size();
	cout <<endl;
	queue_STL.push(11);
	queue_STL.push(12);
	queue_STL.push(13);
	cout <<"Imprmindo a queue ap�s a inser��o: ";
	Mostra(queue_STL);
	cout <<endl;
	//codigo que mostra o primeiro e o ultimo da fila
    cout << "Primeiro da fila : " << queue_STL.front() <<endl;
    cout << "Ultimo da fila : " << queue_STL.back()<<endl;
    cout <<"Imprmindo a queue ap�s a inser��o: ";
	Mostra(queue_STL);
	cout <<endl;
	return 1;
}
