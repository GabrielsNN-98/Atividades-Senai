#include<conio.h>
#include<stdio.h>
#include<locale.h>

int n,id;

void lerDados (){
	printf("\nInforme um n�mero: ");
	scanf("%i",&n);
}
void lerIdade(){
	printf("\nInforme sua idade: ");
	scanf("%i",&id);
}
int dias(){
	int n;
	n=id*365;
	return n;
}
int cubo(){
	int a;
	a=(n*n*n);
	return a;
}

int main(){
	setlocale(LC_ALL,"Portuguese");
	printf("\t\t\t\tRaio\n");
	lerDados();
	printf("%i ao cubo � %i.\n\n",n,cubo());
	printf("\t\t\t\tIdade\n");
	lerIdade();
	printf("Voc� viveu %i dias at� o seu atual anivers�rio.",dias());
	
	getch();
}

