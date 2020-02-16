#include<conio.h>
#include<stdio.h>
#include<locale.h>

int x,y;

void troca(){
	int aux,a,b;
	a=x;b=y;
	aux=x;x=y;y=aux;
	
	printf("X=%i e Y=%i.",x,y);
}

int main(){
	setlocale(LC_ALL,"Portuguese");
	
	printf("Informe um valor para X: ");
	scanf("%i",&x);
	printf("Informe um valor para Y: ");
	scanf("%i",&y);
	printf("\n");
	troca();
	
	getch();
}
