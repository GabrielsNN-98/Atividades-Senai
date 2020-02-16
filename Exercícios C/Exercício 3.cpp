#include<conio.h>
#include<stdio.h>
#include<locale.h>

int main (){
setlocale(LC_ALL, "Portuguese");

	char marcaAuto [10];
	float precoAutofab,precoAuto;
	
	printf("\nInforme a marca do automóvel: ");
	scanf("%s",&marcaAuto);
	printf("Informe o preço de fábrica do automóvel (R$): ");
	scanf("%f",&precoAutofab);
	
	precoAuto=precoAutofab+(0.45*precoAutofab)+(0.28*precoAutofab);
	
	printf("\n\nO preço do automóvel da marca %s é R$ %.2f.",marcaAuto,precoAuto);
	
	getch();
}
