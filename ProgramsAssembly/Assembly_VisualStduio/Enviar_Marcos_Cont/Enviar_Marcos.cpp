#include <iostream> 
using namespace std;

int contamai_mi(char* s, char c)
{
	_asm
	{
		mov eax, 0
		mov cl, c
		mov ebx, s
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

			//ini transformando a letra em maiuscula
			cmp cl, 97
			jb pro
			cmp cl, 122
			ja pro
			sub cl, 32
			//fim trans 
			pro:

		//ini ocorrencias
		mov ebx, s
			repita :
		cmp[ebx], cl
			jnz prox
			inc eax
			prox :
		inc ebx
			cmp[ebx], 0
			jnz repita
			//fim oco
	}
}

int conta2(char* s, char x)
{
	_asm
	{
		mov eax, 0
		mov ebx, s
		mov cl, x
		cmp x, 65
		jb naoletra
		cmp x, 90
		ja compara1
		mov ch, x  //maiusculo
		mov cl, x
		add cl, 32 //minusculo
		jmp inicio1
		compara1 :
		cmp x, 97
			jb naoletra
			cmp x, 122
			ja naoletra
			mov cl, x //minusculo
			mov ch, x
			sub ch, 32 //maiusculo
			inicio1:
		cmp[ebx], cl
			jne compara2
			inc eax
			jmp proximo1
			compara2 :
		cmp[ebx], ch
			jne proximo1
			inc eax
			proximo1 :
		inc ebx
			cmp[ebx], 0
			jnz inicio1
			jmp fim
			naoletra :
		cmp[ebx], cl
			jnz proximo2
			inc eax
			proximo2 :
		inc ebx
			cmp[ebx], 0
			jnz naoletra
			fim :
	}
}

void limpanum(char* S)
{
	_asm
	{
		mov ebx, S
		inicio :
		cmp[ebx], 48
			jb proximo // jb = verifica se é menor que o comparado que nessa ocasiao é o 97
			cmp[ebx], 57
			ja proximo// ja = verifica se é maior que o comparado que nessa ocasiao é o 122
			mov[ebx], ' '
			proximo :
			add ebx, 1
			cmp[ebx], 0
			jnz inicio

	}
}

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

int fat(int V)
{
	_asm
	{
		mov eax, V
		mov cx, ax
		dec cx
		inicio :
		imul cx
			loop inicio
	}
}

int tam(char* N)
{
	_asm
	{
		mov eax, 0
		mov ebx, N
		repita :
		cmp[ebx], 0
			je fim
			inc ax
			inc ebx
			jmp repita
			fim :
	}
}

int soma(int* V, int Tam)
{
	_asm
	{
		mov eax, 0
		mov ebx, V
		mov ecx, Tam
		repita :
		add eax, [ebx]
			add ebx, 4
			loop repita
	}
}
int main()
{
	char x[30] = "A arara que canta";
	cout << "Ocorrencias com a letra a : " << conta2(x, 'a') << endl;
	cout << "Ocorrencias com a letra R : " << conta2(x, 'R') << endl;

	return 1;
}