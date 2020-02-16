#include<conio.h>
#include<stdio.h>
#include<locale.h>

char txt[50];
int n;

void lerDados(){
	printf("Informe um texto: ");
	scanf("%[^\n]s",&txt);
	printf("\nInforme um número: ");
	scanf("%i",&n);
}

void nomeNx (){
	int i;
	for (i=0;i<n;i++){
		printf("\n%s\n",txt);
	}
}


int main(){
	setlocale(LC_ALL,"Portuguese");
	
	lerDados();
	nomeNx();
	
	getch();
	
}
