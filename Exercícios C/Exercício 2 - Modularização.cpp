#include<conio.h>
#include<stdio.h>
#include<locale.h>

float b,h;

void lerDados(){
	printf("Informe a base e a altura de um triângulo.\n");
	printf("\nBase: ");
	scanf("%f",&b);
	printf("Altura: ");
	scanf("%f",&h);
}

float area(){
	int a;
	a=(b*h)/2;
	return a;
}

int main(){
	setlocale(LC_ALL,"Portuguese");
	lerDados();
	printf("A área do triângulo é %.2f",area());
	
	getch();
}
