#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include "BibliotecaViana.c"
#include "BaseListaViana.c"

int main()
{
    TipoLista lista;
    TipoItem item; 
    int i,j, resp;
    
    FLVazia(&lista);
    
	corFundo(63);
	    
do{    
    
    system("color 3F");
    janela1(1,3,7,27);
    
    resp = menu(111,63,2,4);
    
    switch (resp)
    {
           case 1: //Cadastro de Produtos;
           		system("cls");
           		corFundo(63);
                janelaBase("CADASTRO DE PRODUTOS");
                janelaDados(4);
                RecebeDados(&item); 
                Insere(item, &lista); 
                system("cls");
                break;
           case 2: //Exibe os produtos Ordenados (A-Z);
                system("cls");              
                corFundo(63);
                
                if (! Vazia(lista))
				{				                	
	                janelaBase("TODOS OS PRODUTOS (A-Z)");
	                Ordena(lista);
					getch(); 
	                system("cls");
	        	}
	        	else
	        	{
	        		gotoxy(15,34);
	        		printf("Lista Vazia!");
	        		getch();
                	system("cls"); 
				}
                break;
           case 3: //Exibe o produto mais caro;   
		   		system("cls");              
                corFundo(63);
                
                if (! Vazia(lista))
				{				                	
	                janelaBase(" PRODUTOS MAIS CARO");
	                janelaDados(4);
	                ImprimeMaior(lista);
					getch(); 
	                system("cls");
	        	}
	        	else
	        	{
	        		gotoxy(15,34);
	        		printf("Lista Vazia!");
	        		getch();
                	system("cls"); 
				}
                break;
           case 4: //Exibe todos os Produtos;
                system("cls");              
                corFundo(63);
                
                if (! Vazia(lista))
				{				                	
	                janelaBase(" TODOS OS PRODUTOS ");
	                Imprime(lista);
					getch(); 
	                system("cls");
	        	}
	        	else
	        	{
	        		gotoxy(15,34);
	        		printf("Lista Vazia!");
	        		getch();
                	system("cls"); 
				}
                break;
          default: //Finalizar o sistema
          		system("cls");
          		system("color 3F");
                janela1(11,18,15,68);
                gotoxy(13,25);
                printf("       FINALIZANDO...          ");                
                for (int fim=0;fim<10;fim++)
                {
                    gotoxy(13,52); printf("%c",196); delay(50);
                    gotoxy(13,52); printf("%c",92); delay(50);
                    gotoxy(13,52); printf("%c",179); delay(50);
                    gotoxy(13,52); printf("%c",47); delay(50);
                }
                janela1(11,18,15,68);
                gotoxy(13,25);
                printf("DIGITE UMA TECLA PARA FINALIZAR");  
				gotoxy(21,1);              
                getch();
    }
}while(resp!=5);
    
}
