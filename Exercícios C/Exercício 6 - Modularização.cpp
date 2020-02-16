#include<conio.h>
#include<stdio.h>
#include<math.h>
#include<locale.h>

int x,y;

void lerDados(){
	printf("Informe dois valores: \n");
	scanf("%i\n",&x);
	scanf("%i",&y);
}

int potencia(){
	int a;
	a=pow(x,y);
}
int main(){
	setlocale(LC_ALL,"Portuguese");
	lerDados();
	printf("\n%i elevado a %i é %i.",x,y,potencia());
	
	getch();
}
