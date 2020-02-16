#include<stdio.h>
#include<conio.h>

typedef char TipoNome;
typedef int TipoNota;

typedef struct{
	TipoNome nome[50];
	TipoNota n1, n2, n3, n4;
}TipoAluno;

int main(){
	TipoAluno estudante;
	
	printf("Informe o nome do aluno: ");
	scanf("%s", &estudante.nome);
	
	printf("\nInforme as quatro notas do aluno: \n\n");
	scanf("%i\n", &estudante.n1);
	scanf("%i\n", &estudante.n2);
	scanf("%i\n", &estudante.n3);
	scanf("%i", &estudante.n4);
	
}
