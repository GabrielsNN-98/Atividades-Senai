#include<conio.h>
#include<stdio.h>
#include<locale.h>

int main (){
setlocale(LC_ALL, "Portuguese");

	float alturaT,base,alturaR,fachada,areaT,areaR,areaJ;
	
	printf("\nConsidere uma casa onde: (A) é a altura do telhado, (B) é a base e (C) é a altura da parede. Informe valores para:\n");
	printf("A: ");
	scanf("%f",&alturaT);
	printf("B: ");
	scanf("%f",&base);
	printf("C: ");
	scanf("%f",&alturaR);
	
	areaT=(base*alturaT)/2;
	areaR=base*alturaR;
	areaJ=(alturaR/3)*(alturaR/3)*2;
	fachada=areaT+areaR-areaJ;
	
	printf("\n\nA área da fachada é de %.2fm².",fachada);
	
	getch();
}
