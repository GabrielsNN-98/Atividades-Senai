#include<conio.h>
#include<stdio.h>
#include<locale.h>

int x,y,z;
void lerDados(){
	printf("Informe valores para:\n\n");
	printf("X: ");
	scanf("%i",&x);
	printf("\nY: ");
	scanf("%i",&y);
	printf("\nZ: ");
	scanf("%i",&z);
	
}

float media(){
	int a;
	a=(x+y+z)/3;
	return a;
}
int main(){
	setlocale(LC_ALL,"Portuguese");
	lerDados();
	printf("\n\nA média dos números digitados é %.1f.",media());
	
	
	getch();
	
}
