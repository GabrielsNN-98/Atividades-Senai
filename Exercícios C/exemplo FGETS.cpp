#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <locale.h>
#include <string.h>

int main (){
	FILE *arquivo;
	char nomeAluno[100], linha[200], *resultado;
	int n1, n2, n3, n4;
	
	arquivo = fopen ("alunos.txt","r");
	
	while (!feof(arquivo)){
		resultado= fgets(linha, 200, arquivo);
		if (resultado){
			printf("%s\n", linha);
		}
	}
	
	fclose(arquivo);	
}
