#include<conio.h>
#include<stdio.h>
#include<locale.h>

int n,id;

void lerDados (){
	printf("\nInforme um número: ");
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
	printf("%i ao cubo é %i.\n\n",n,cubo());
	printf("\t\t\t\tIdade\n");
	lerIdade();
	printf("Você viveu %i dias até o seu atual aniversário.",dias());
	
	getch();
}

