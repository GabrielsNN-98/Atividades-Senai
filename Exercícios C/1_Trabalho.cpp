#include <stdlib.h>
#include <stdio.h>
#include <conio.h>
#include <locale.h>

int i, a, b, c, cod;

typedef char TipoNome[10];
typedef int TipoNota;
typedef float TipoSalario;
typedef int TipoCH;

typedef struct{
	TipoNome *nome;
	TipoSalario *salario;
}TipoProfessor;

typedef struct{
	TipoNome *nome;
	TipoCH cargaHoraria;
	TipoProfessor professor;
}TipoDisciplina;

typedef struct{
	TipoNome *nome;
	TipoNota n1, n2, n3, n4;
	TipoDisciplina disciplina;
}TipoAluno;

TipoProfessor professor[4];
TipoAluno aluno[4];
TipoDisciplina disciplina[4];

void Nome_Professor(){
	
	for (i = 1; i < 5; i++)
	{
	printf("Informe o nome do professor %i: ",i);
	scanf ("%s", &professor[i].nome);
	printf("\nInforme o salário do professor %i: ",i);
	scanf("%f", &professor[i].salario);
	system ("cls");
	}
}

void Nome_Disciplina(){
	for (i = 1; i < 5; i++)
	{
	printf("Informe o nome da disciplina %i: ",i);
	scanf ("%s", &disciplina[i].nome);
	printf("\nInforme a carga horária da disciplina %i: ",i);
	scanf("%i", &disciplina[i].cargaHoraria);
	printf("\n\nInforme o código do professor que será ligado a disciplina: ");
	scanf("%i", &cod);
	disciplina[i].professor = professor[cod];
	system ("cls");
	}

}

void Nome_Aluno(){

	for (i = 1; i < 5; i++)
	{
	printf("Informe o nome do aluno %i: ",i);
	scanf ("%s", &aluno[i].nome);
	printf("\nInforme as notas do aluno %i:\n\n",i);
	printf("Nota 1: ");
	scanf("%i", &aluno[i].n1);
	printf("\nNota 2: ");
	scanf("%i", &aluno[i].n2);
	printf("\nNota 3: ");
	scanf("%i", &aluno[i].n3);
	printf("\nNota 4: ");
	scanf("%i", &aluno[i].n4);
	printf("\n\nInforme o código da disciplina que será ligado ao aluno: ");
	scanf("%i", &cod);	
	aluno[i].disciplina = disciplina[cod];
	system("cls");
	}
	
}

int main(){
	
	setlocale (LC_ALL, "Portuguese");
	
	Nome_Professor();
	Nome_Disciplina();
	Nome_Aluno();
	

	
    printf("%s", disciplina[1].professor.nome);
    printf("%s", aluno[1].disciplina.nome);

	//printf ("%s, %s, %s", professor[a].nome, aluno[b].nome, disciplina[c].nome);
	
	//a=i;
	//b=i;
	//c=i;
	
	//if(a==i and b==i and c==i)
	//{
	//disciplina[i].professor[i].nome = professor[i].nome;
	//aluno[i].disciplina.nome = disciplina[i].nome;
	//}
}

	
