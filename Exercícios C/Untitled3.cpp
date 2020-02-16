#include<conio.h>
#include<stdio.h>

int main(){
	int n1,n2,n3;
	int soma;
	printf("Informe 3 numeros: \n\n");
	scanf("%d", &n1);
	scanf("%d,", &n2);
	scanf("%d,", &n3);
	
	soma=n1+n2+n3;
	printf("\nA soma dos numeros informados e %d",soma);
	getch();
	
}
