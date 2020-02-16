#include<stdio.h>
#include<conio.h>
#include<locale.h>
#include<stdlib.h>

int main (){
setlocale(LC_ALL, "Portuguese");

	float n1,n2,media;

	printf("Informe a nota das duas avaliações: \n");
	printf("\nAvaliação 1: ");
	scanf("%f",&n1);
	printf("Avaliação 2: ");
	scanf("%f",&n2);

	system("cls");

	media=(n1+n2)/2;
	
	if (media>=6.0)
	{
		printf("PARABÉNS! Você foi aprovado.");
	}
		else
	{
		printf("Você foi REPROVADO!");
	}

getch();
}


