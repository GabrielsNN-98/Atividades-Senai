#include<conio.h>
#include<stdio.h>
#include<locale.h>

int main (){
setlocale(LC_ALL, "Portuguese");

	char marcaAuto [10];
	float precoAutofab,precoAuto;
	
	printf("\nInforme a marca do autom�vel: ");
	scanf("%s",&marcaAuto);
	printf("Informe o pre�o de f�brica do autom�vel (R$): ");
	scanf("%f",&precoAutofab);
	
	precoAuto=precoAutofab+(0.45*precoAutofab)+(0.28*precoAutofab);
	
	printf("\n\nO pre�o do autom�vel da marca %s � R$ %.2f.",marcaAuto,precoAuto);
	
	getch();
}
