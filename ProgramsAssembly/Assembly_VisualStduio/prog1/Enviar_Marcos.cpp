#include <iostream> 
using namespace std;

int conta(char* s, char c)
{
	_asm
	{
		mov eax, 0
		mov ebx, s
		mov cl, c
		repita :
		cmp[ebx], cl
			jnz proximo
			inc eax
			proximo :
		add ebx, 1
			cmp[ebx], 0
			jnz repita
	}
}

void maiusculo(char* S)
{
	_asm
	{
		mov ebx, S
		inicio :
		cmp[ebx], 97
			jb proximo 
			cmp[ebx], 122
			ja proximo
			sub[ebx], 32
			proximo :
			inc ebx
			cmp[ebx], 0
			jnz inicio

	}
}

int main()
{
	/*char s[30] = "Universidade de Alfenasss";
	cout << conta(s, 's') << endl;
	char texto[30] = "gustavo luiz de oliveira";
	maiusculo(texto);
	cout << texto << endl;*/

	char x[30] = "A arara que canta";
	cout << "Ocorrencias com a letra a : " << conta_mai_min(x, 'a') << endl;
	cout << "Ocorrencias com a letra R : " << conta_mai_min(x, 'R') << endl;

	return 1;
}