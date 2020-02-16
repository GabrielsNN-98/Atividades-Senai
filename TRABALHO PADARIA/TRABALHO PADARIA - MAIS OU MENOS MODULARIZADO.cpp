#include <conio.h>
#include <stdio.h>
#include <stdlib.h>
#include <windows.h>

typedef int TipoCodigo;
typedef char TipoNome;
typedef float TipoPreco;

FILE *arq_fornecedor, *arq_produto;

typedef struct{
	TipoCodigo id;
	TipoNome nome[50], cnpj[50], tel[50];
}TipoFornecedor;

typedef struct{
	TipoCodigo id;
	TipoNome nome[50], categoria[50];
	TipoPreco preco;
	TipoFornecedor fornecedor;
}TipoProduto;

TipoFornecedor fornecedor;
TipoProduto produto;

void Ler_Fornecedor(){
	arq_fornecedor = fopen ("Fornecedores.txt", "r");
	while (!feof(arq_fornecedor)){
	fscanf (arq_fornecedor,"%i %s %s %s", &fornecedor.id, &fornecedor.nome, &fornecedor.cnpj, &fornecedor.tel);
}
	arq_fornecedor = fopen ("Fornecedores.txt", "a");
	
	scanf("%[^\n]s", &fornecedor.nome);
	scanf("%s", &fornecedor.cnpj);
	scanf("%[^\n]s", &fornecedor.tel);
	
	fprintf (arq_produtora,"%i %s %s %s\n", fornecedor.id + 1, fornecedor.nome, fornecedor.cnpj, fornecedor.tel);
	
	fclose(arq_fornecedor);
}

void Ler_Produto(){
	arq_produto = fopen ("Produtos.txt", "r");
	while (!feof(arq_produto)){
	fscanf (arq_produto,"%i %s %s %f %i", &produto.id, &produto.nome, &produto.categoria, &produto.preco, &produto.fornecedor.id);
}
	arq_produto = fopen ("Produtos.txt", "a");
	
	scanf("%[^\n]s", &produto.nome);
	scanf("%[^\n]s", &produto.categoria);
	scanf("%f", &produto.preco);
	scanf("%i", &produto.fornecedor.id);
	
	fprintf (arq_produtora,"%i %s %s %.2f %i\n", produto.id + 1, produto.nome, produto.categoria, produto.preco, produto.fornecedor.id);
	
	fclose(arq_produto);
}

int main(){
	
	arq_fornecedor = fopen ("Fornecedores.txt", "a");
	arq_produto = fopen ("Produtos.txt", "a");
	
	Ler_Fornecedor();
	Ler_Produto();
	
	fclose(arq_fornecedor);
	fclose(arq_produto);
}
