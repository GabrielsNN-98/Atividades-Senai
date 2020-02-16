#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>
#include <string.h>

int main (){
	FILE *arquivo;
	char nomeAluno[100], linha[200];
	int n1, n2, n3, n4, soma, resultado;
	float media;
	
	arquivo = fopen ("alunos.txt","r");
	
	while (!feof(arquivo)){
		resultado= fscanf(arquivo, "%s %i %i %i %i", &nomeAluno, &n1, &n2, &n3, &n4);
		
		if (resultado){
			soma = n1 + n2 + n3 + n4;
			media = soma/4;
			if(media>=60){
			printf("\nAluno: %s - Media: %2.f - APROVADO!!!\n", nomeAluno, media);
		}else{
			printf("\nAluno: %s - Media: %2.f - REPROVADO!!!\n", nomeAluno, media);
		}
		}
	}
	
	fclose(arquivo);	
}
