#include<conio.h>
#include<stdio.h>
#include<locale.h>

int main (){
setlocale(LC_ALL, "Portuguese");

	float alturaT,base,alturaR,fachada,areaT,areaR;
	
	printf("\nConsidere uma casa onde: (A) � a altura do telhado, (B) � a base e (C) � a altura da parede. Informe valores para:\n");
	printf("A: ");
	scanf("%f",&alturaT);
	printf("B: ");
	scanf("%f",&base);
	printf("C: ");
	scanf("%f",&alturaR);
	
	areaT=(base*alturaT)/2;
	areaR=base*alturaR;
	fachada=areaT+areaR;
	
	printf("\n\nA �rea da fachada � de %.2fm�.",fachada);
	
	getch();
}
