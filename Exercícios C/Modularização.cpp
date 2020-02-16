#include<conio.h>
#include<stdio.h>

int idade;

void recebeIdade(){
	printf ("Informe a idade: ");
	scanf("%d",&idade);
}
	
int main(){
	
	recebeIdade();
	printf("A idade e %d.",idade);
	
	getch();
	
}
