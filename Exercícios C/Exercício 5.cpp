#include<conio.h>
#include<stdio.h>
#include<locale.h>

int main (){
setlocale(LC_ALL, "Portuguese");

	float dist,vlitro,combgasto,valort;
	
	printf("\nInforma a dist�ncia a ser percorrida e o valor do litro de combust�vel:\n");
	printf("\ndist�ncia (KM): ");
	scanf("%f",&dist);
	printf("valor do litro de combust�vel (R$): ");
	scanf("%f",&vlitro);
	
	combgasto=dist/11.5; valort=(dist/11.5)*vlitro;
	
	printf("\nSer�o gastos %.2fL de combust�vel e o valor total ser� de R$ %.2f.",combgasto,valort);
	
	getch();
}
