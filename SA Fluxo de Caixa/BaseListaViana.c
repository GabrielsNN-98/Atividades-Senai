//Biblioteca contendo as função referente ao Controle de Estoque

#define INICIOARRANJO 0
#define MAXTAM 500

typedef char TipoNmProduto;
typedef char TipoNmFornecedor;
typedef int TipoQtdEstoque;
typedef int TipoData;
typedef float TipoValor;
typedef int Apontador;

typedef struct{
	TipoData Dia;
	TipoData Mes;
	TipoData Ano;	
}DataDt;

typedef struct {
    TipoNmProduto NmProduto[60];
	TipoNmFornecedor NmFornecedor[60];
	TipoQtdEstoque QtdEstoque;
	DataDt Data;
	TipoValor Valor;
} TipoItem;

typedef struct {
        TipoItem Item[MAXTAM];
        Apontador Primeiro, Ultimo;
} TipoLista;

void FLVazia(TipoLista *Lista)
{
     Lista->Primeiro = INICIOARRANJO;
     Lista->Ultimo = Lista->Primeiro;
} 

int Vazia(TipoLista Lista)
{
    return (Lista.Primeiro == Lista.Ultimo);
} 

int PositionMaisCaro(TipoLista Lista)
{
	int Aux, PosicaoMaiorValor = 0;
    float MaiorValor = 0;


	for (Aux=Lista.Primeiro; Aux<=(Lista.Ultimo - 1); Aux++)
	{
	  	if (Lista.Item[Aux].Valor > MaiorValor)
	   	{
			MaiorValor = Lista.Item[Aux].Valor;
			PosicaoMaiorValor = Aux;
	   	}	         
	}
	 	 
	return PosicaoMaiorValor;
}

void Imprime(TipoLista Lista)
{
     int Aux, linhaI;
     linhaI = 4;
     cor(63);
     
	 for (Aux=Lista.Primeiro; Aux<=(Lista.Ultimo - 1); Aux++)
	 {	  
	 	janelaDados(linhaI)	;	 
		 gotoxy(linhaI+1,2);
		 printf("%s", Lista.Item[Aux].NmProduto);
		
		 gotoxy(linhaI+1,41);
		 printf("%s", Lista.Item[Aux].NmFornecedor);
		
		 gotoxy(linhaI+3,2);
		 printf("R$ ");
		 printf("%.2f", Lista.Item[Aux].Valor);
		
		 gotoxy(linhaI+3,30);
	     printf("%d/%d/%d", Lista.Item[Aux].Data.Dia, Lista.Item[Aux].Data.Mes, Lista.Item[Aux].Data.Ano);	
		
		 gotoxy(linhaI+3,57);
		 printf("%d", Lista.Item[Aux].QtdEstoque);
		 
		 linhaI = linhaI+6;
	 }	 
}

void ImprimeMaior(TipoLista Lista)
{
     int Aux, PosicaoMaiorValor = 0;
     float MaiorValor = 0;
     PosicaoMaiorValor = PositionMaisCaro(Lista);
     
     cor(63);
	 gotoxy(5,2);
	 printf("%s", Lista.Item[PosicaoMaiorValor].NmProduto);
	
	 gotoxy(5,41);
	 printf("%s", Lista.Item[PosicaoMaiorValor].NmFornecedor);
	
	 gotoxy(7,2);
	 printf("R$ ");
	 printf("%.2f", Lista.Item[PosicaoMaiorValor].Valor);
	
	 gotoxy(7,30);
     printf("%d/%d/%d", Lista.Item[PosicaoMaiorValor].Data.Dia, Lista.Item[PosicaoMaiorValor].Data.Mes, Lista.Item[PosicaoMaiorValor].Data.Ano);	
	
	 gotoxy(7,57);
	 printf("%d", Lista.Item[PosicaoMaiorValor].QtdEstoque);		
}

void Insere(TipoItem x, TipoLista *Lista)
{
     if (Lista->Ultimo >= MAXTAM) 
        printf("Lista esta cheia\n");
     else 
     { 
          Lista->Item[Lista->Ultimo] = x;
          Lista->Ultimo++;
     }
} 

void RecebeDados(TipoItem *Item)
{
	fflush(stdin);
	cor(57);
	gotoxy(5,2);
	gets(Item->NmProduto);
	
	gotoxy(5,41);
	gets(Item->NmFornecedor);
	
	gotoxy(7,2);
	printf("R$ ");
	scanf("%f",&Item->Valor);
	
	gotoxy(7,30);
	scanf("%d/%d/%d",&Item->Data.Dia,&Item->Data.Mes,&Item->Data.Ano);	
	
	gotoxy(7,57);
	scanf("%d",&Item->QtdEstoque);		
	fflush(stdin);
}      

void Ordena(TipoLista Lista)
{
	int j, i;
	char aux[100];

 	for(j=1; j<Lista.Ultimo; j++)
 	{
	 	strcpy(aux,Lista.Item[j].NmProduto);
	 	i = j-1;
	 	while(i >= 0 && strcmp(Lista.Item[i].NmProduto, aux) > 0)
	 	{
		 	strcpy(Lista.Item[i+1].NmProduto,Lista.Item[i].NmProduto);
		 	i--;
	 	}
	 	strcpy(Lista.Item[i+1].NmProduto,aux);
 	}
 	
 	Imprime(Lista);
} 
