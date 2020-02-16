#include<conio.h>
#include<stdio.h>
#include<locale.h>

int main(){
setlocale(LC_ALL, "Portuguese");
	int b,h;
	
	printf("\nInforme a base do retângulo: ");
	scanf("%d",&b);
	
	printf("Informe a altura do retângulo: ");	
	scanf("%d",&h);
	
	printf("\nA área do retângulo é: %d \n",b*h);
	printf("O perímetro do retângulo é: %d",b+b+h+h);
	
	getch();
	
}
