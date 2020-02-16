#include<stdio.h>
#include<conio.h>
#include<windows.h>
#include<string.h>
#include<stdlib.h>
#include<locale.h>
#include "filmes.c"
#include<time.h>
#include "BibliotecaViana.c"

void suspense(){
	int a;
	srand(time(NULL));
	a=rand() % 4;
	switch(a){
		case 0: amnesia();
		break;
		
		case 1: cloverfield();
		break;
		
		case 2: paranoia();
		break;
		
		case 3: numero();
		break;
	}
	system("\n\npause");
}
void acaoAventura(){
	int a;
	srand(time(NULL));
	a=rand() % 4;
	switch(a){
		case 0: lotr();
		break;
		
		case 1: limiteAmanha();
		break;
		
		case 2: lucy();
		break;
		
		case 3: jumper();
		break;
	}
	system("\n\npause");	
}
void drama(){
	int a;
	srand(time(NULL));
	a=rand()% 4;
	switch(a){
		case 0: theGodfather();
		break;
		
		case 1: abutre();
		break;
		
		case 2: kevin();
		break;
		
		case 3: cidadeSonhos();
		break;
	}
	system("\n\npause");
	
}
void fantasiaSCIFI(){
	int a;
	srand(time(NULL));
	a=rand()% 4;
	switch(a){
		case 0: dozeMacacos();
		break;
		
		case 1: lunar();
		break;
		
		case 2: apostolo();
		break;
		
		case 3: eragon();
		break;
	}
	system("\n\npause");
}


int main(){
	int num;
	
	setlocale(LC_ALL,"Portuguese");

	system("mode 95,15");
	system("color 1B");
	
	printf("   #########################################################################################\n");
	printf("   #########################| S.A. Poster - Indicação de Filmes |###########################\n");
	printf("   #########################################################################################\n");
	printf("   |                                                   |  | 1 - Suspense                   |\n");
	printf("   |  Digite o número correspondente ao gênero:        |  | 2 - Açao/Aventura              |\n");
	printf("   |___________________________________________________|  | 3 - Drama                      |\n");
	printf("                                                          | 4 - Fantasia/Ficção Científica |\n");
	printf("                                                          |________________________________|\n");
	
	gotoxy(5,49);
	scanf("%i",&num);
	
	system("cls");
	
	system("mode 120,40");
	
	if (num<1 or num>4){
		system("mode 95,15");
		printf("\n\n\  Você digitou errado, tente novamente por favor. ");
		system("pause");
		main();
	}
	else if(num==1){
		suspense();
	}
	else if (num==2){
		acaoAventura();
	}
	else if (num==3){
		drama();
	}
	else if (num==4){
		fantasiaSCIFI();
	}
if ("\n" or "\t"){
	main();
}
}
