#include<conio.h>
#include<stdio.h>
#include<stdlib.h>
#include <string.h>
#include<windows.h>
#include "BibliotecaViana.c"

typedef int Tipocodigo;
typedef char Tiponome;
typedef char Tipocategoria; 
typedef float Tipopreco;
typedef char Tipotel;

typedef struct {
	Tipocodigo codigo;	
	Tiponome nome [50];
	Tipotel cnpj [50];
	Tipotel telefone [50];	
	}Tipofornecedor;

typedef struct {
	Tiponome nome [50];
	Tipocodigo codigo;	
	Tipocategoria categoria[50];
	Tipopreco preco;
	Tipofornecedor fornecedor[50];
}Tipoproduto;

int main(){
	
	FILE *fornecedores,*produtos,*fornecedores2,*produtos2; 
	//Variaveis para o fscanf do fornecedor.
	int codforn=0, resultado_Forn;
	char Forn_n2[50],Forn_n3[50],Forn_n4[50]; 
	//Variaveis para o fscanf do Produtos.
	int codProd=0, resultado_Prod;
	char Prod_n2[50],Prod_n3[50],Prod_n4[50],Prod_n5[50]; 
	//Variável para o menu.
	int menu,teste;
	
	//Variáveis ara serem usadas no Tipofornecedor.
	Tipofornecedor nomeforn,telefoneforn,cnpj;
	
	//Variáveis ara serem usadas no Tipoproduto.
	Tipoproduto nomeprod,codprod,cateprod,precoprod,forne;


	//Aqui será introduzido as informações do fornecedor. 
	printf("Informe a opcao desejada: ");
	scanf ("%i", &menu);
	
		if (menu==1){
		fornecedores2 = fopen("fornecedores.txt", "r");
		if(fornecedores2 != NULL){
		while(!feof(fornecedores2)){
		resultado_Forn = fscanf(fornecedores2, "%i %s %s %s", &codforn, &Forn_n2, &Forn_n3, &Forn_n4);
		teste = codforn; 	
	}
	}		
	
	fclose(fornecedores2);

		system("cls");
		fornecedores = fopen("fornecedores.txt", "a");
		printf("Informe o nome do fornecedor: \n");
		scanf("%s",&nomeforn.nome);
		printf("Informe o telefone do fornecedor: \n");
		scanf("%s",&telefoneforn.telefone);
		printf("Informe o cnpj do fornecedor: \n");
		scanf("%s",&cnpj.cnpj);	
		fprintf(fornecedores, "%i %s %s %s\n", codforn+1, nomeforn.nome,telefoneforn.telefone,cnpj.cnpj);
		exit(0);
}else if (menu==2){
	produtos2 = fopen("produtos.txt","r");
	if (produtos2 != NULL){
	while(!feof(produtos2)){
	resultado_Prod = fscanf(produtos2, "%d %s %s %f %d", &codProd, &Prod_n2, &Prod_n3, &Prod_n4,Prod_n5);
	
}
} 
	fclose(produtos2);
		system("cls");
		produtos = fopen("produtos.txt", "a");
		
		printf("Informe o nome do produto:\n");
		scanf("%s",&nomeprod.nome);
		
		printf("Informe a categoria do produto:\n");
		scanf("%s",&cateprod.categoria);
		
		printf("Informe o preco do produto:\n");
		scanf("%f",&precoprod.preco);
		
		printf("Informe o codigo do fornecedor:\n");
		scanf("%d",&forne.fornecedor);
		
		codforn = forne.fornecedor;
		

		
		fprintf(produtos,"%d %s %s %.2f %d\n",codProd+1, nomeprod.nome, cateprod.categoria, precoprod.preco, forne.fornecedor);
		exit(0);
		
}
fclose(fornecedores);
fclose(produtos);	
}

