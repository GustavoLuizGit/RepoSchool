#include <iostream> 


using namespace std;

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

void maiusculo(char* S)
{
	_asm
	{
		mov ebx, S
		inicio :
		cmp[ebx], 97
			jb proximo // jb = verifica se é menor que o comparado que nessa ocasiao é o 97
			cmp[ebx], 122
			ja proximo// ja = verifica se é maior que o comparado que nessa ocasiao é o 122
			sub[ebx], 32
			proximo :
			inc ebx
			cmp[ebx], 0
			jnz inicio

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

int main(void)
{
	/*cout << "Fatorial : " << fat(4) << endl;

	char nome[30] = "Universidade Alfenas";
	cout << "Tamanho : " << tam(nome) << endl;

	int V[4] = { 2,2,3,5};
	cout << "Soma : " << soma(V,4) << endl;*/

	char texto[30] = "gustavo luiz de oliveira";
	maiusculo(texto);
	cout << texto << endl;

	char endereco[50] = "Rua Tiradentes, 237454454 - Apto 01";
	limpanum(endereco);
	cout << endereco << endl;

	int x = 10;
	cout << x;
	return 1;

}