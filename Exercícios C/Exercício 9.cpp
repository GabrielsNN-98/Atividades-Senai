#include<conio.h>
#include<stdio.h>
#include<stdlib.h>
#include<locale.h>

int main (){
setlocale(LC_ALL, "Portuguese");

	char nome[20];
	float altura,peso,pesoId,dif;

	printf("Preencha os seguintes campos: \n");
	printf("\nNome: ");
	scanf("%s",&nome);
	printf("Altura (m): ");
	scanf("%f",&altura);
	printf("Peso (kg): ");
	scanf("%f",&peso);
	
	pesoId=(72.2*altura)-58;
	dif=peso-pesoId;
	
	printf("%s, o seu peso atual é %.2fkg e o seu peso ideal seria de %.2fkg. Seu peso está alterado em %.2fkg.",nome,peso,pesoId,dif);
	

	getch();
}

