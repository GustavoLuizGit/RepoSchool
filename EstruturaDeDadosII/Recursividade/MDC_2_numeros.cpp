#include <iostream>

using namespace std;

int mdc(int, int);

int main(void)
{
	cout<<mdc(60, 192)<<endl;
}

int mdc(int x, int y)
{
	if(x==y)
	{
		return x;
	}
	if(x<y)
	{
		return mdc(y,x);
	}
	if(x>y)
	{
		return mdc(x-y,y);
	}
}
