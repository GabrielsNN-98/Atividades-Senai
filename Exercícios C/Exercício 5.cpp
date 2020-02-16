#include<conio.h>
#include<stdio.h>
#include<locale.h>

int main (){
setlocale(LC_ALL, "Portuguese");

	float dist,vlitro,combgasto,valort;
	
	printf("\nInforma a distância a ser percorrida e o valor do litro de combustível:\n");
	printf("\ndistância (KM): ");
	scanf("%f",&dist);
	printf("valor do litro de combustível (R$): ");
	scanf("%f",&vlitro);
	
	combgasto=dist/11.5; valort=(dist/11.5)*vlitro;
	
	printf("\nSerão gastos %.2fL de combustível e o valor total será de R$ %.2f.",combgasto,valort);
	
	getch();
}
