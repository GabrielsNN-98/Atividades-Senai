#include<conio.h>
#include<stdio.h>
#include<locale.h>

int main(){
setlocale(LC_ALL, "Portuguese");

	float area,volume,pi,raio;
	
	pi=3.14;

	printf("\nInforme um valor para o raio de uma esfera: ");
	scanf("%f",&raio);
	
	area=4*pi*raio*raio; volume=4/3*pi*raio*raio;
	
	printf("\nA área da esfera é %.2f e, o volume da esfera é %.2f.",area,volume);
	
	getch();
	}
	
