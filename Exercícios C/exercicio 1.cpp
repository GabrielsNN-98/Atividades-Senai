// 1) Implemente um programa em C que leia o nome, a idade e o endereço de uma pessoa e armazene os dados em uma estrutura.

#include <stdio.h>
#include <conio.h>
#include <locale.h>
#include <stdlib.h>

typedef char TipoNome;
typedef int TipoIdade;

typedef struct{
	TipoNome nome[40], endereco[120];
	TipoIdade idade;
}TipoPessoa;

TipoPessoa pessoa;

int main (){
	
	setlocale(LC_ALL, "Portuguese");
	
	printf("Informe os dados a seguir:\n");
	printf("\nNome: ");
	scanf("%[^\n]s", &pessoa.nome);
	printf("\nIdade: ");
	scanf("%i", &pessoa.idade);
	fflush(stdin);
	printf("\nEndereço: ");
	scanf("%[^\n]s", &pessoa.endereco);
	
	system("cls");
	
	printf("%s tem %i anos e mora no endereço %s", pessoa.nome, pessoa.idade, pessoa.endereco);
	
}
