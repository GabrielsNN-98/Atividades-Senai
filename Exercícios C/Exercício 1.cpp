#include<conio.h>
#include<stdio.h>
#include<locale.h>

int main(){
setlocale(LC_ALL, "Portuguese");
	int b,h;
	
	printf("\nInforme a base do ret�ngulo: ");
	scanf("%d",&b);
	
	printf("Informe a altura do ret�ngulo: ");	
	scanf("%d",&h);
	
	printf("\nA �rea do ret�ngulo �: %d \n",b*h);
	printf("O per�metro do ret�ngulo �: %d",b+b+h+h);
	
	getch();
	
}
