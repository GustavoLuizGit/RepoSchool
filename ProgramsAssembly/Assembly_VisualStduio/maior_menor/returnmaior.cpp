#include <iostream> 
using namespace std;

int maior(int x, int y)
{
	_asm
	{
		mov ebx,x
		mov ecx,y
		cmp ebx,ecx
		ja xmaior
		jb xmenor
		
		xmaior:
		mov eax,ebx
		jmp fim

		xmenor:
		mov eax,ecx
		jmp fim

		fim:

		
	}
}

int main(void)
{
	cout << maior(40, 20) << endl;
}