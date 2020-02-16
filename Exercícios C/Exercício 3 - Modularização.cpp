#include<conio.h>
#include<stdio.h>
#include<locale.h>

int n;

void lerDados (){
	printf("Informe um número: ");
	scanf("%i",&n);
}
int cubo(){
	int a;
	a=(n*n*n);
	return a;
}
int main(){
	setlocale(LC_ALL,"Portuguese");
	
	lerDados();
	printf("%i ao cubo é %i.",n,cubo());
	
	getch();
}
