#include<conio.h>
#include<stdio.h>
#include<locale.h>

int n1,n2,op;


void lerDados(){
	printf("Informe dois n�meros: \n\n");
	scanf("\n\n%d %d",&n1,&n2);
	printf("\n\nAgora, informe o tipo de opera��o que queira fazer digitando o n�mero correspondente a mesma. \n(1=Soma, 2=Subtra��o, 3=Multiplica��o e 4=Divis�o.): ");
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
		printf("\nO resultado da soma entre %d e %d � %d.",n1,n2,soma());
	}
	else if (op==2){
		printf("\nO resultado da subtra��o entre %d e %d � %d.",n1,n2,subt());
	}
	else if (op==3){
		printf("\nO resultado da multiplica��o entre %d e %d � %d.",n1,n2,mult());
	}
	else if (op==4){
		printf("\nO resultado da divis�o entre %d e %d � %.2f.",n1,n2,div());
	}
	
	getch();
}


