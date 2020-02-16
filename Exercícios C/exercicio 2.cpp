// 2) Crie uma estrutura representando os alunos do curso de Desenvolvimento de Sistemas. A estrutura deve conter a matrícula do aluno, nome, nota da primeira prova, 
// nota da segunda prova e nota da terceira prova.

// a) Permita ao usuário entrar com os dados de 5 alunos;
// b) Encontre o aluno com maior nota da primeira prova;
// c) Encontre o aluno com maior média geral;
// d) Encontre o aluno com menor média geral;
// e) Para cada aluno diga se ele foi aprovado ou reprovado, considerando o valor 6 para aprovação.

#include <stdio.h>
#include <conio.h>
#include <locale.h>
#include <stdlib.h>
#include <string.h>

typedef int TipoNum;
typedef char TipoNome;
typedef float TipoMedia;

typedef struct{
	TipoNum matricula, nota1, nota2, nota3;
	TipoNome nome[50];
	TipoMedia media;
}TipoAluno;

TipoAluno aluno[5];

int main(){
	int maiorNota = 0;
	char nomeMaiorNota[50];
	
	setlocale(LC_ALL, "Portuguese");
	
	for(int i=1; i<=5; i++){
		printf("Informe os dados a seguir do aluno %i:\n", i);
		printf("\nNome: ");
		fflush(stdin);
		scanf("%[^\n]s", &aluno[i].nome);
		fflush(stdin);
		printf("\nMatrícula: ");
		scanf("%[^\n]s", &aluno[i].matricula);
		printf("\nNota 1: ");
		scanf("%i", &aluno[i].nota1);
		printf("\nNota 2: ");
		scanf("%i", &aluno[i].nota2);
		printf("\nNota 3: ");
		scanf("%i", &aluno[i].nota3);
		
		
		
		system("cls");
	}
	
	for (int i=1; i<=5; i++){
        if (aluno[i].nota1 > maiorNota){
        	maiorNota = aluno[i].nota1;
        	strcpy(nomeMaiorNota, aluno[i].nome);
        }
    } 
    printf("O aluno %s tem a maior nota da primeira prova que é de %i pontos.",nomeMaiorNota, maiorNota);
	
}
