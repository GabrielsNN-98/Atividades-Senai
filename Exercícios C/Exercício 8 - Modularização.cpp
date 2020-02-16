#include<conio.h>
#include<stdio.h>
#include<stdlib.h>
#include<locale.h>

int vetor[30],i;
int vetorM[30];

float metade(){
	for (i=0;i<30;i++){
		vetorM[i]=vetor[i]/2;
		printf("%i\n\n",vetorM[i]);
	}
}
int main(){
	printf("Informe valores: \n\n");
	for (i=0;i<30;i++){
		scanf("%i\n",&vetor[i]);
	}	
		system("cls");
		
	metade();
	
getch();

}
