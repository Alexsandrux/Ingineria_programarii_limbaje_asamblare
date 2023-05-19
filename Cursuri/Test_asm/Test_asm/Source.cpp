#include <stdio.h>

void main() {
	int a = 7, b = 5, c, r, s;

	_asm
	{
		mov eax, a
		add eax, b
		mov s, eax

		mov eax, a
		cdq
		div b
		mov c, eax
		mov r, edx
	};

	printf("\n Rezultat adunare: %d", s);
	printf("\n Cat: %d Rest: %d", c, r);

}