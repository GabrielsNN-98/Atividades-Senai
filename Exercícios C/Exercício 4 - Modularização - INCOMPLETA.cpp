#include<conio.h>
#include<stdio.h>
#include<locale.h>

int n;

float volumeEsfera(){
	int a;
	a=(4*3.14*n*n*n)/3;
	return a;
}
int equacao(){
	
}


int main (){
	setlocale(LC_ALL,"Portuguese");
	printf("Informe um valor para raio (m): ");
	scanf("%i",&n);
	printf("\n\nO volume da esfera é de %.2fm³",volumeEsfera());
	

	getch();
}
