#include <iostream>

using namespace std;

int pot(int, int);


int main(void)
{
	cout <<pot(20,2);
	cout <<"Isadora gata!";
}


int pot(int x, int y)
{
	if (y==0)
	{
		return 1;
	}
	else
		if (y==1)
		{
			return x;
		}
		else
		{
			return (x*pot(x,y-1));
		}
}
