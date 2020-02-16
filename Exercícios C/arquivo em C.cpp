#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>
#include <string.h>

int main (){
	FILE *arq_alunos;
	typedef char TipoNome;
	typedef int TipoNota;
	
	typedef struct{
		TipoNome nome[100];
		TipoNota n1, n2, n3, n4;
	}TipoAluno;
	
	TipoAluno estudante;
	
	arq_alunos = fopen ("alunos.txt","w");
	
	do{
		printf("Informe o nome: ");
		scanf("%s", &estudante.nome);
		
		if (strcmp(estudante.nome, "000") != 0){
			printf("\n\nInforme as notas do aluno:\n\n");
			scanf("%i\n", &estudante.n1);
			scanf("%i\n", &estudante.n2);
			scanf("%i\n", &estudante.n3);
			scanf("%i", &estudante.n4);
			
			system("cls");
			
			fprintf(arq_alunos,"%s %i %i %i %i\n", estudante.nome, estudante.n1, estudante.n2, estudante.n3, estudante.n4);
			printf("%s, %i - %i - %i - %i\n", estudante.nome, estudante.n1, estudante.n2, estudante.n3, estudante.n4);	
			system("\n\n\npause");
			system("cls");	
			}
	}while (strcmp(estudante.nome,"000") != 0);
	
	fclose(arq_alunos);
	}
