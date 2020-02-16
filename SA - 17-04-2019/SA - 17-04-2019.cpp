#include<conio.h>
#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
#include<string.h>

//Em relação às funcionalidades do sistema o mesmo deve apresentar menu/submenu com os seguintes casos: 
//manter clientes, manter venda, manter produtos, média de vendas , maior venda, menor venda, produto mais vendido, 
//produto menos vendido, vendas por cliente, vendas por produtos, saldo final.

typedef char TipoTexto;
typedef int TipoNum;
typedef float TipoPreco;

typedef struct{
	TipoNum id;
	TipoTexto nome[50];
}TipoCliente;

typedef struct{
	TipoNum id, qtdProd;
	TipoTexto nome[50];
}TipoProduto;

typedef struct{
	TipoNum id;
	TipoCliente cliente;
	TipoProduto produto[20];
	TipoPreco valorTotal;
}TipoVenda;

TipoCliente cliente[100];
TipoProduto produto[100];
TipoVenda venda[100];

int escolha, a, cont;

void Menu(){
	printf(" _________________________________\n");
	printf("|        Padaria Pão do Céu       |\n");
	printf("|_________________________________|\n");
	printf("|                                 |\n");
	printf("|    1 - Cadastro de Clientes     |\n");
	printf("|    2 - Cadastro de Produtos     |\n");
	printf("|    3 - Cadastro de Vendas       |\n");
	printf("|    0 - Fechar o Programa        |\n");
	printf("|_________________________________|\n\n");
	printf(": ");
	scanf("%i", &escolha);
}

int main(){
	system("mode 90,30");	
	setlocale(LC_ALL,"Portuguese");
			
	do{
		Menu();
		system("cls");
					
		switch(escolha){
			case 1: 
				printf("Insira a quantidade de clientes que você quer registrar: ");
				scanf("%i", &cont);
	
				for(a=1;a<=cont;a++){
				printf("Insira os dados do cliente %i:\n\n", a);
				cliente[a].id=a;
				printf("Nome: ");
				fflush(stdin);
				scanf("%[^\n]s", &cliente[a].nome);
				system("cls");
				}
			system("cls");
			break;
			
			case 2:
				printf("Insira a quantidade de produtos que você quer registrar: ");
				scanf("%i", &cont);
	
				for(a=1;a<=cont;a++){
				printf("Insira os dados do produto %i:\n\n", a);
				produto[a].id=a;
				printf("Nome: ");
				fflush(stdin);
				scanf("%[^\n]s", &produto[a].nome);
				printf("Estoque: ");
				scanf("%i", &produto[a].qtdProd);
				system("cls");
				}
			system("cls");
			break;
			
			case 3:
				int contador;
				float valorUnit[100], valorParcial[100];
	
				printf("Insira a quantidade de vendas que você quer registrar: ");
				scanf("%i", &cont);
	
				for(a=1;a<=cont;a++){
				printf("Insira  dados da venda %i.\n\n", a);
				venda[a].id=a;
				printf("\nCódigo do Cliente: ");
				fflush(stdin);
				scanf("%i", &cliente[a].id);
				
				printf("\nInsira a quantidade de produtos que você quer registrar: ");
				scanf("%i", &contador);
				
					for(a=1;a<=contador;a++){	
					printf("\nCódigo do Produto: ");
					scanf("%i", &produto[a].id);
					printf("\nValor Unitário: ");
					scanf("%f", &valorUnit[a]);
					printf("\nQuantidade: ");
					scanf("%i", &produto[a].qtdProd);
					
					setlocale(LC_ALL, "C");
					
					valorParcial[a]=(valorUnit[a]*produto[a].qtdProd);
					
					setlocale(LC_ALL, "Portuguese");
					}
				}
			for(a=1;a<=cont;a++){
				
				setlocale(LC_ALL, "C");
				venda[a].valorTotal=valorParcial[a];
				setlocale(LC_ALL, "Portuguese");
				
				printf("\nValor Total: %.2f", venda[a].valorTotal);
			}
			system("cls");
			break;
				
			case 0:
				exit(0);
			break;
				
			default:
				printf("Operação inválida. Tente novamente.");
				getch();
				system("cls");
			break;
		}	
	}while (escolha!=0);	
}
