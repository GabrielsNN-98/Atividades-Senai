#include<conio.h>
#include<stdio.h>
#include<locale.h>

int n1,n2,op;


void lerDados(){
	printf("Informe dois números: \n\n");
	scanf("\n\n%d %d",&n1,&n2);
	printf("\n\nAgora, informe o tipo de operação que queira fazer digitando o número correspondente a mesma. \n(1=Soma, 2=Subtração, 3=Multiplicação e 4=Divisão.): ");
	scanf("%d",&op);
}
	
int soma (){
	return n1+n2;
}
int subt(){
	return n1-n2;
}
int mult(){
	return n1*n2;
}
float div(){
	return n1/n2;
}	

int main(){
	
setlocale(LC_ALL, "Portuguese");

	lerDados();
	
	if(op==1){
		printf("\nO resultado da soma entre %d e %d é %d.",n1,n2,soma());
	}
	else if (op==2){
		printf("\nO resultado da subtração entre %d e %d é %d.",n1,n2,subt());
	}
	else if (op==3){
		printf("\nO resultado da multiplicação entre %d e %d é %d.",n1,n2,mult());
	}
	else if (op==4){
		printf("\nO resultado da divisão entre %d e %d é %.2f.",n1,n2,div());
	}
	
	getch();
}


