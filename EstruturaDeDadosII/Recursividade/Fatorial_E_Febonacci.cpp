#include <iostream>

using namespace std;

int fat(int n)
{
	if (n==0 or n==1)
	{
		return 1;
	}
	else
	{
		return n * fat(n-1);
	}
}

int fib(int n)
{
	if (n==0) 
		return 0 ;
	else 
		if(n==1) 
			return 1;
		else
			return fib(n-1)+fib(n-2);	
}

int main()
{
    int x;
    cout <<"Entre com um valor : ";
    cin >> x;
    cout << "Fibonacci:" <<fib(x);

    return 0;
}

