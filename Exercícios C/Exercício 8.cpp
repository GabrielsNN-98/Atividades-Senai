#include<conio.h>
#include<stdio.h>
#include<stdlib.h>
#include<locale.h>

int main (){
setlocale(LC_ALL, "Portuguese");

	char nomeF[20];
	int qtdHoras;
	float valorS,salarioB,salarioL,salario;

	printf ("\nPreencha os seguintes campos: \n");
	printf("\nNome: ");
	scanf("%s",&nomeF);
	printf("Quantidade de horas trabalhadas: ");
	scanf("%d",&qtdHoras);
	printf("Valor do sal�rio/hora: ");
	scanf("%f",&valorS);

	system("cls");
	
	salarioB=valorS*qtdHoras;
	salario=salarioB*0.18;
	salarioL=salarioB-salario;
	
	printf("Nome do funcion�rio: %s\n",nomeF);
	printf("Sal�rio Bruto: R$ %.2f\n",salarioB);
	printf("Sal�rio L�quido: R$ %.2f\n",salarioL);
	printf("Total Descontado: R$ %.2f",salario);



getch();
}
