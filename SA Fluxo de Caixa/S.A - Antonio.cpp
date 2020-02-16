#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h>
#include "BibliotecaViana.C"
#include <string.h>

                                     
//Integrantes: Gabriel Sousa /\/ Jhon Kennedy /\/ Carlos Omar.

float lucro, frete, cartaoCred, perdaProd, inadimp, margemNego, taxaFinan, imposto, perdaVenda, gastoTotal, producao, soma;

//Esse m�todo cont�m todos os c�lculos presentes no programa.
void calculos(){
	
	float pontoFatura, pontoEqui, valorUnitReal, valorUnitPorc, precoVendA, precoVendB, precoVendC, subTotalreal, subTotalporc, resultLucroReal, resultLucroPorc, lucA, freA, ccA, ppA, inA, mnA, tfA, imA, pvA, lucB, freB, ccB, ppB, inB, mnB, tfB, imB, pvB, lucC, freC, cC, ppC, inC, mnC, tfC, imC, pvC, a, b, c, d, e, f, g, h, i;
	a=lucro/100; b=frete/100; c=cartaoCred/100; d=perdaProd/100; e=inadimp/100; f=margemNego/100; g=taxaFinan/100; h=imposto/100; i=perdaVenda/100;
	
	valorUnitReal=gastoTotal/producao;
	
	precoVendA=valorUnitReal/(1-(a+b+c+d+e+f+g+h+i));
	
	valorUnitPorc=(valorUnitReal/precoVendA)*100;
	
	lucA=precoVendA*a;
	freA=precoVendA*b;
	ccA=precoVendA*c;
	ppA=precoVendA*d;
	inA=precoVendA*e;
	mnA=precoVendA*f;
	tfA=precoVendA*g;
	imA=precoVendA*h;
	pvA=precoVendA*i;
	
	subTotalreal=precoVendA-(freA+ccA+ppA+inA+mnA+tfA+imA+pvA);
	subTotalporc=100-(soma-lucro);
	
	resultLucroReal=subTotalreal-valorUnitReal;
	resultLucroPorc=subTotalporc-valorUnitPorc;
	
	pontoEqui=gastoTotal/subTotalreal;
	
	pontoFatura=pontoEqui*subTotalreal;
	
	precoVendB=pontoEqui*precoVendA;
	lucB=precoVendB*a;
	freB=precoVendB*b;
	ccB=precoVendB*c;
	ppB=precoVendB*d;
	inB=precoVendB*e;
	mnB=precoVendB*f;
	tfB=precoVendB*g;
	imB=precoVendB*h;
	pvB=precoVendB*i;
	
	precoVendC=producao*precoVendA;
	lucC=precoVendC*a;
	freC=precoVendC*b;
	cC=precoVendC*c;
	ppC=precoVendC*d;
	inC=precoVendC*e;
	mnC=precoVendC*f;
	tfC=precoVendC*g;
	imC=precoVendC*h;
	pvC=precoVendC*i;
	//Esta parte � respons�vel pelo posicionamento do cursor no CMD e onde � feita a entrada de dados do primeiro relat�rio.
	
	/* O gotoxy representado abaixo pega o eixo X e Y e posiciona o cursor na posi��o desejada. Tamb�m � realizada a entrada de dados pelo scanf*/
	gotoxy(6,50);
	printf("R$ %.2f",precoVendA);
	gotoxy(6,70);
	printf("100.00 %%");
	gotoxy(9,50);
	printf("R$ %.2f",freA);
	gotoxy(9,70);
	printf("%.2f %%",frete);
	gotoxy(12,50);
	printf("R$ %.2f",ccA);
	gotoxy(12,70);
	printf("%.2f %%",cartaoCred);	
	gotoxy(15,50);
	printf("R$ %.2f",ppA);
	gotoxy(15,70);
	printf("%.2f %%",perdaProd);
	gotoxy(18,50);
	printf("R$ %.2f",inA);
	gotoxy(18,70);
	printf("%.2f %%",inadimp);
	gotoxy(21,50);
	printf("R$ %.2f",mnA);
	gotoxy(21,70);
	printf("%.2f %%",margemNego);
	gotoxy(24,50);
	printf("R$ %.2f",tfA);
	gotoxy(24,70);
	printf("%.2f %%",taxaFinan);
	gotoxy(27,50);
	printf("R$ %.2f",imA);
	gotoxy(27,70);
	printf("%.2f %%",imposto);
	gotoxy(30,50);
	printf("R$ %.2f",pvA);
	gotoxy(30,70);
	printf("%.2f %%",perdaVenda);
	gotoxy(48,50);
	printf("R$ %.2f",subTotalreal);
	gotoxy(48,70);
	printf("%.2f %%",subTotalporc);
	gotoxy(51,50);
	printf("R$ %.2f",valorUnitReal);
	gotoxy(51,70);
	printf("%.2f %%",valorUnitPorc);
	gotoxy(55,50);
	printf("R$ %.2f",resultLucroReal);
	gotoxy(55,70);
	printf("%.2f %%",resultLucroPorc);	
	gotoxy(59,59);
	printf("%.2f qtd",pontoEqui);
	gotoxy(62,59);
	printf("R$ %.4f",pontoFatura);
	//Esta parte � responsavel pelo posicionamento do cursor no CMD e onde � feita a entrada de dados do segundo relat�rio.
	/* O gotoxy representado abaixo pega o eixo X e Y e posiciona o cursor na posi��o desejada. Tamb�m � realizado a entrada de dados pelo scanf*/
	gotoxy(6,127);
	printf("R$ %.2f",precoVendB);
	gotoxy(6,146);
	printf("100.00 %%");
	gotoxy(9,127);
	printf("R$ %.2f",freB);
	gotoxy(9,146);
	printf("%.2f %%",frete);
	gotoxy(12,127);
	printf("R$ %.2f",ccB);
	gotoxy(12,146);
	printf("%.2f %%",cartaoCred);	
	gotoxy(15,127);
	printf("R$ %.2f",ppB);
	gotoxy(15,146);
	printf("%.2f %%",perdaProd);
	gotoxy(18,127);
	printf("R$ %.2f",inB);
	gotoxy(18,146);
	printf("%.2f %%",inadimp);
	gotoxy(21,127);
	printf("R$ %.2f",mnB);
	gotoxy(21,146);
	printf("%.2f %%",margemNego);
	gotoxy(24,127);
	printf("R$ %.2f",tfB);
	gotoxy(24,146);
	printf("%.2f %%",taxaFinan);
	gotoxy(27,127);
	printf("R$ %.2f",imB);
	gotoxy(27,146);
	printf("%.2f %%",imposto);
	gotoxy(30,127);
	printf("R$ %.2f",pvB);
	gotoxy(30,146);
	printf("%.2f %%",perdaVenda);
	//Esta parte � respons�vel pelo posicionamento do cursor no CMD e onde � feita a entrada de dados do terceiro relat�rio.
	/* O gotoxy representado abaixo pega o eixo x, e o eixo y e posiciona o cursor na posi��o desejada. Tamb�m � realizada a entrada de dados pelo scanf*/
	gotoxy(38,127);
	printf("R$ %.2f",precoVendC);
	gotoxy(38,146);
	printf("100.00 %%");
	gotoxy(41,127);
	printf("R$ %.2f",freC);
	gotoxy(41,146);
	printf("%.2f %%",frete);
	gotoxy(44,127);
	printf("R$ %.2f",cC);
	gotoxy(44,146);
	printf("%.2f %%",cartaoCred);	
	gotoxy(47,127);
	printf("R$ %.2f",ppC);
	gotoxy(47,146);
	printf("%.2f %%",perdaProd);
	gotoxy(50,127);
	printf("R$ %.2f",inC);
	gotoxy(50,146);
	printf("%.2f %%",inadimp);
	gotoxy(53,127);
	printf("R$ %.2f",mnC);
	gotoxy(53,146);
	printf("%.2f %%",margemNego);
	gotoxy(56,127);
	printf("R$ %.2f",tfC);
	gotoxy(56,146);
	printf("%.2f %%",taxaFinan);
	gotoxy(59,127);
	printf("R$ %.2f",imC);
	gotoxy(59,146);
	printf("%.2f %%",imposto);
	gotoxy(62,127);
	printf("R$ %.2f",pvC);
	gotoxy(62,146);
	printf("%.2f %%\n",perdaVenda);
	printf("\n\n\n");
	
	//Esta � a parte respons�vel por gerar o arquivo de texto contendo a entrada de dados dos relat�rios acima.
	FILE *arquivo; /* Nessa parte foi criado um ponteiro apontando para um arquivo espec�fico.*/
	char nome[20]; /*Vari�vel respons�vel por capturar o nome do arquivo .txt a ser gerado*/
	system("pause");/*Nesta linha � passado um comando no DOS do Windows.*/
	system("cls");/*Nesta linha � passado um comando no DOS do Windows.*/
	system("mode 68,20");/*Nesta linha � passado um comando no DOS do Windows para rendimensionar a tela do DOS.*/
	gotoxy(9,70); /*Esse gotoxy posiciona o cursor onde ser� imprimido na tela.*/
	setlocale(LC_ALL,"Portuguese");
	printf("Escreva o nome do relat�rio a ser gerado: ");
	gotoxy(10,70); /* Esse gotoxy posiciona o curso onde os dados ser�o inseridos*/
	scanf("%s", nome); /*Captura o nome do arquivo.*/
	strcat(nome, ".txt");
	arquivo = fopen(nome, "w+");/* Parte onde o ponteiro apontar� para o arquivo*/
	setlocale(LC_ALL,"C");
	
	
	/*Na parte abaixo sera gerado o txt, e que receber� o ponteiro arquivo*/	
	
	fprintf(arquivo, "              ########################################################################\n");
	fprintf(arquivo, "              ##########################| Relat�rio A |###############################\n");
	fprintf(arquivo, "              ########################################################################\n");
	fprintf(arquivo, "               _______________________________________________________________________\n");
	fprintf(arquivo, "              |                           											\n");
	fprintf(arquivo, "              |       Pre�o de Venda       \tR$ %.2f | 100,00 %%\n",precoVendA);
	fprintf(arquivo, "              |_______________________________________________________________________\n");
	fprintf(arquivo, "              |                             											\n");
	fprintf(arquivo, "              |            Frete           \tR$ %.2f | %.2f %%\n",freA,frete);
	fprintf(arquivo, "              |_______________________________________________________________________\n");
	fprintf(arquivo, "              |                             											\n");
	fprintf(arquivo, "              |  Taxa de Cart�o de Cr�dito \tR$ %.2f | %.2f %%\n", ccA,cartaoCred);
	fprintf(arquivo, "              |_______________________________________________________________________\n");
	fprintf(arquivo, "              |                             											\n");
	fprintf(arquivo, "              |       Perda de Produ��o    \tR$ %.2f | %.2f %%\n", ppA,perdaProd);
	fprintf(arquivo, "              |_______________________________________________________________________\n");
	fprintf(arquivo, "              |                             											\n");	
	fprintf(arquivo, "              |        Inadimpl�ncia       \tR$ %f.2 | %.2f %%\n", inA, inadimp);
	fprintf(arquivo, "              |_______________________________________________________________________\n");
	fprintf(arquivo, "              |                             											\n");
	fprintf(arquivo, "              |     Margem de Negocia��o   \tR$ %f.2 | %.2f %%,\n", mnA, margemNego);
	fprintf(arquivo, "              |_______________________________________________________________________\n");
	fprintf(arquivo, "              |                             											\n");
	fprintf(arquivo, "              |     Taxa de Financiamento  \tR$ %f.2 | %.2f %%,\n", tfA, taxaFinan);
	fprintf(arquivo, "              |_______________________________________________________________________\n");
	fprintf(arquivo, "              |                             											\n");
	fprintf(arquivo, "              |          Impostos          \tR$ %f.2 | %.2f %%,\n", imA, imposto);
	fprintf(arquivo, "              |_______________________________________________________________________\n");
	fprintf(arquivo, "              |                             											\n");
	fprintf(arquivo, "              |       Perda de Venda       \tR$ %f.2 | %.2f %%,\n", pvA, perdaVenda);
	fprintf(arquivo, "              |_______________________________________________________________________\n");
	fprintf(arquivo, "\n");
	fprintf(arquivo, "\n");
	fprintf(arquivo, "\n");
	fprintf(arquivo, "                                             								   		    \n");
	fprintf(arquivo, "               ________________________________________________________________________\n");
	fprintf(arquivo, "              |                             \n");
	fprintf(arquivo, "              |   Margem de Contribui��o   \tR$ %f.2 | %.2f %%,\n", subTotalreal, subTotalporc);
	fprintf(arquivo, "              |________________________________________________________________________\n");
	fprintf(arquivo, "              |                             \n");
	fprintf(arquivo, "              |     Custo unit. Produto    \tR$ %f.2 | %.2f %%,\n", valorUnitReal, valorUnitPorc);
	fprintf(arquivo, "              |________________________________________________________________________\n");
	fprintf(arquivo, "               ________________________________________________________________________\n");
	fprintf(arquivo, "              |                             \n");
	fprintf(arquivo, "              |       Resultado Lucro      \tR$ %f.2 | %.2f %%,\n", resultLucroReal, resultLucroPorc);
	fprintf(arquivo, "              |________________________________________________________________________\n");
	fprintf(arquivo, "               ________________________________________________________________________\n");
	fprintf(arquivo, "              |                             \n");
	fprintf(arquivo, "              |     Ponto de Equil�brio    \t\t%f.2 qtd\n", pontoEqui);
	fprintf(arquivo, "              |________________________________________________________________________\n");
	fprintf(arquivo, "              |                             \n");
	fprintf(arquivo, "              |     Ponto de Faturamento   \t\tR$ %f.4\n", pontoFatura);
	fprintf(arquivo, "              |________________________________________________________________________\n");
	
	fprintf(arquivo, "              ####################################################################\n");
	fprintf(arquivo, "              #########################| Relat�rio B |############################\n");
	fprintf(arquivo, "              ####################################################################\n");
	fprintf(arquivo, "              ___________________________________________________________________ \n");
	fprintf(arquivo, "              |                             \n");
	fprintf(arquivo, "              |       Pre�o de Venda       \tR$ %.2f | 100,00 %%\n",precoVendB);
	fprintf(arquivo, "              |__________________________________________________________________\n");
	fprintf(arquivo, "              |                             \n");
	fprintf(arquivo, "              |            Frete           \tR$ %.2f | %.2f %%\n",freB,frete);
	fprintf(arquivo, "              |__________________________________________________________________\n");
	fprintf(arquivo, "              |                            	\n");
	fprintf(arquivo, "              |  Taxa de Cart�o de Cr�dito  \tR$ %.2f | %.2f %%\n",ccB,cartaoCred);
	fprintf(arquivo, "              |__________________________________________________________________\n");
	fprintf(arquivo, "              |                             \n");
	fprintf(arquivo, "              |       Perda de Produ��o    \tR$ %.2f | %.2f %%\n",ppB, perdaProd);
	fprintf(arquivo, "              |__________________________________________________________________\n");
	fprintf(arquivo, "              |                             \n");
	fprintf(arquivo, "              |        Inadimpl�ncia       \tR$ %.2f | %.2f %%\n",inB, inadimp);
	fprintf(arquivo, "              |__________________________________________________________________\n");
	fprintf(arquivo, "              |                             \n");
	fprintf(arquivo, "              |     Margem de Negocia��o   \tR$ %.2f | %.2f %%\n", mnB, margemNego);
	fprintf(arquivo, "              |__________________________________________________________________\n");
	fprintf(arquivo, "              |                             \n");
	fprintf(arquivo, "              |     Taxa de Financiamento  \tR$ %.2f | %.2f %%\n", tfB, taxaFinan);
	fprintf(arquivo, "              |__________________________________________________________________\n");
	fprintf(arquivo, "              |                             \n");
	fprintf(arquivo, "              |          Impostos          \tR$ %.2f | %.2f %%\n", imB, imposto);
	fprintf(arquivo, "              |__________________________________________________________________\n");
	fprintf(arquivo, "              |                             \n");
	fprintf(arquivo, "              |       Perda de Venda       \tR$ %.2f | %.2f %%\n", pvB, perdaVenda);
	fprintf(arquivo, "              |___________________________________________________________________\n");
	fprintf(arquivo, "              ####################################################################\n");
	fprintf(arquivo, "              #########################| Relat�rio C |############################\n");
	fprintf(arquivo, "              ####################################################################\n");
	fprintf(arquivo, "              ___________________________________________________________________\n");
	fprintf(arquivo, "             |                             \n");
	fprintf(arquivo, "             |       Pre�o de Venda       \tR$ %.2f | 100,00 %%\n", precoVendC);
	fprintf(arquivo, "             |__________________________________________________________________\n");
	fprintf(arquivo, "             |                             \n");
	fprintf(arquivo, "             |            Frete           \tR$ %.2f | %.2f %%\n", freC, frete);
	fprintf(arquivo, "             |__________________________________________________________________\n");
	fprintf(arquivo, "             |                             \n");
	fprintf(arquivo, "             |  Taxa de Cart�o de Cr�dito \tR$ %.2f | %.2f %%\n", cC, cartaoCred);
	fprintf(arquivo, "             |__________________________________________________________________\n");
	fprintf(arquivo, "             |                             \n");
	fprintf(arquivo, "             |       Perda de Produ��o    \tR$ %.2f | %.2f %%\n", ppC, perdaProd);
	fprintf(arquivo, "             |__________________________________________________________________\n");
	fprintf(arquivo, "             |                             \n");
	fprintf(arquivo, "             |        Inadimpl�ncia       \tR$ %.2f | %.2f %%\n", inC, inadimp);
	fprintf(arquivo, "             |__________________________________________________________________\n");
	fprintf(arquivo, "             |                             \n");
	fprintf(arquivo, "             |     Margem de Negocia��o   \tR$ %.2f | %.2f %%\n", mnC, margemNego);
	fprintf(arquivo, "             |__________________________________________________________________\n");
	fprintf(arquivo, "             |                             \n");
	fprintf(arquivo, "             |     Taxa de Financiamento  \tR$ %.2f | %.2f %%\n", tfC, taxaFinan);
	fprintf(arquivo, "             |__________________________________________________________________\n");
	fprintf(arquivo, "             |                             \n");
	fprintf(arquivo, "             |          Impostos          \tR$ %.2f | %.2f %%\n", imC, imposto);
	fprintf(arquivo, "             |__________________________________________________________________\n");
	fprintf(arquivo, "             |                             \n");
	fprintf(arquivo, "             |       Perda de Venda       \tR$ %.2f | %.2f %%\n", pvC, perdaVenda);
	fprintf(arquivo, "             |__________________________________________________________________\n");
	
	fclose(arquivo);
	
	
}
void lerDados(){
//Esta parte � respons�vel pela entrada das v�riaveis estrat�gicas
	/*O gotoxy posiciona o cursor aonde o scanf ser� respons�vel por capturar a entrda de arquivos.*/	
	gotoxy(6,40);
	scanf("%f",&gastoTotal);
	gotoxy(6,71);
	scanf("%f",&producao);
	gotoxy(14,27);
	scanf("%f",&lucro);
	gotoxy(14,56);
	scanf("%f",&frete);
	gotoxy(14,81);
	scanf("%f",&cartaoCred);
	gotoxy(18,36);
	scanf("%f",&perdaProd);
	gotoxy(18,59);
	scanf("%f",&inadimp);
	gotoxy(18,85);
	scanf("%f",&margemNego);
	gotoxy(22,38);
	scanf("%f",&taxaFinan);
	gotoxy(22,59);
	scanf("%f",&imposto);
	gotoxy(22,83);
	scanf("%f",&perdaVenda);
}	 
void title(){
	/*Nesta parte fica as interfaces que receber�o os valores que ser�o mostrados na tela.*/
	system("color 3F");/*Muda a cor do DOS */ 
	system("mode 110,40"); /*Esse comando � respos�vel pelo redimensionamento da janela do CMD.*/
	
	printf("              #################################################################################\n");
	printf("              #############################| S.A C�lculo Aplicado |############################\n");
	printf("              #################################################################################\n");
	
	printf("               _______________________________________________________________________________\n");
	printf("              |                                       |                                       |\n");
	printf("              |Gasto Total Anual (R$):                |Vol. Produ��o:                         |\n");
	printf("              |_______________________________________|_______________________________________|\n");
	
	printf("\n");
	printf("              #################################################################################\n");
	printf("              ###########################| Variav�is Estrat�gicas |############################\n");
	printf("              #################################################################################\n");
	printf("               _______________________________________________________________________________\n");
	printf("              |                            |                   |                              |\n");
	printf("              |Lucro (%%):                  |Frete (%%):         | T. Cart�o (%%):               |\n");
	printf("              |____________________________|___________________|______________________________|\n");
	printf("               _______________________________________________________________________________\n");
	printf("              |                            |                   |                              |\n");
	printf("              |P. de Produ��o (%%):         |Inadimp. (%%):      | M. Negocia��o (%%):           |\n");
	printf("              |____________________________|___________________|______________________________|\n");
	printf("               _______________________________________________________________________________\n");
	printf("              |                            |                   |                              |\n");
	printf("              |T. Financiamento (%%):       |Impostos (%%):      | P. de Venda (%%):             |\n");
	printf("              |____________________________|___________________|______________________________|\n");	
}
void relatorios(){
	system("mode 175,70");
	//Esta parte � respons�vel por exibir os relat�rios na tela. 
	/*Essa parte � onde recebe os c�lculos digitados e exibe na tela o resultado de todas as opera��es feitas.*/
	
	system("cls");
	printf("              #####################################################################        ####################################################################\n");
	printf("              ########################| Relat�rio Unit�rio |#######################        ################| Relat�rio sobre Ponto de Equil�brio |#############\n");
	printf("              #####################################################################        ####################################################################\n");
	printf("               ___________________________________________________________________          __________________________________________________________________ \n");
	printf("              |                             |                     |               |        |                             |                    |               |\n");
	printf("              |       Pre�o de Venda        |                     |               |        |       Pre�o de Venda        |                    |               |\n");
	printf("              |_____________________________|_____________________|_______________|        |_____________________________|____________________|_______________|\n");
	printf("              |                             |                     |               |        |                             |                    |               |\n");
	printf("              |            Frete            |                     |               |        |            Frete            |                    |               |\n");
	printf("              |_____________________________|_____________________|_______________|        |_____________________________|____________________|_______________|\n");
	printf("              |                             |                     |               |        |                             |                    |               |\n");
	printf("              |  Taxa de Cart�o de Cr�dito  |                     |               |        |  Taxa de Cart�o de Cr�dito  |                    |               |\n");
	printf("              |_____________________________|_____________________|_______________|        |_____________________________|____________________|_______________|\n");
	printf("              |                             |                     |               |        |                             |                    |               |\n");
	printf("              |       Perda de Produ��o     |                     |               |        |       Perda de Produ��o     |                    |               |\n");
	printf("              |_____________________________|_____________________|_______________|        |_____________________________|____________________|_______________|\n");
	printf("              |                             |                     |               |        |                             |                    |               |\n");
	printf("              |        Inadimpl�ncia        |                     |               |        |        Inadimpl�ncia        |                    |               |\n");
	printf("              |_____________________________|_____________________|_______________|        |_____________________________|____________________|_______________|\n");
	printf("              |                             |                     |               |        |                             |                    |               |\n");
	printf("              |     Margem de Negocia��o    |                     |               |        |     Margem de Negocia��o    |                    |               |\n");
	printf("              |_____________________________|_____________________|_______________|        |_____________________________|____________________|_______________|\n");
	printf("              |                             |                     |               |        |                             |                    |               |\n");
	printf("              |     Taxa de Financiamento   |                     |               |        |     Taxa de Financiamento   |                    |               |\n");
	printf("              |_____________________________|_____________________|_______________|        |_____________________________|____________________|_______________|\n");
	printf("              |                             |                     |               |        |                             |                    |               |\n");
	printf("              |          Impostos           |                     |               |        |          Impostos           |                    |               |\n");
	printf("              |_____________________________|_____________________|_______________|        |_____________________________|____________________|_______________|\n");
	printf("              |                             |                     |               |        |                             |                    |               |\n");
	printf("              |       Perda de Venda        |                     |               |        |       Perda de Venda        |                    |               |\n");
	printf("              |_____________________________|_____________________|_______________|        |_____________________________|____________________|_______________|\n");
	printf("\n");
	printf("                                                                                           ####################################################################\n");
	printf("                                                                                           ################| Relat�rio sobre Volume de Produ��o  |#############\n");
	printf("                                                                                           ####################################################################\n");
	printf("                                                                                            __________________________________________________________________\n");
	printf("                                                                                           |                             |                    |               |\n");
	printf("                                                                                           |       Pre�o de Venda        |                    |               |\n");
	printf("                                                                                           |_____________________________|____________________|_______________|\n");
	printf("                                                                                           |                             |                    |               |\n");
	printf("                                                                                           |            Frete            |                    |               |\n");
	printf("                                                                                           |_____________________________|____________________|_______________|\n");
	printf("                                                                                           |                             |                    |               |\n");
	printf("                                                                                           |  Taxa de Cart�o de Cr�dito  |                    |               |\n");
	printf("                                                                                           |_____________________________|____________________|_______________|\n");
	printf("               ___________________________________________________________________         |                             |                    |               |\n");
	printf("              |                             |                     |               |        |       Perda de Produ��o     |                    |               |\n");
	printf("              |   Margem de Contribui��o    |                     |               |        |_____________________________|____________________|_______________|\n");
	printf("              |_____________________________|_____________________|_______________|        |                             |                    |               |\n");
	printf("              |                             |                     |               |        |        Inadimpl�ncia        |                    |               |\n");
	printf("              |     Custo unit. Produto     |                     |               |        |_____________________________|____________________|_______________|\n");
	printf("              |_____________________________|_____________________|_______________|        |                             |                    |               |\n");
	printf("               ___________________________________________________________________         |     Margem de Negocia��o    |                    |               |\n");
	printf("              |                             |                     |               |        |_____________________________|____________________|_______________|\n");
	printf("              |       Resultado Lucro       |                     |               |        |                             |                    |               |\n");
	printf("              |_____________________________|_____________________|_______________|        |     Taxa de Financiamento   |                    |               |\n");
	printf("               ___________________________________________________________________         |_____________________________|____________________|_______________|\n");
	printf("              |                             |                                     |        |                             |                    |               |\n");
	printf("              |     Ponto de Equil�brio     |                                     |        |          Impostos           |                    |               |\n");
	printf("              |_____________________________|_____________________________________|        |_____________________________|____________________|_______________|\n");
	printf("              |                             |                                     |        |                             |                    |               |\n");
	printf("              |     Ponto de Faturamento    |                                     |        |       Perda de Venda        |                    |               |\n");
	printf("              |_____________________________|_____________________________________|        |_____________________________|____________________|_______________|\n");

}
int main(){
	//Esta parte � respons�vel por chamar e executar os m�todos do programa e tamb�m o m�todo principal.
	system("title ");
	setlocale(LC_ALL,"Portuguese");
	title(); /*Chama o m�todo title*/
	lerDados();/*Chama o m�todo lerDados*/
	setlocale(LC_ALL,"C");/*Muda a linguagem do programa para o ingl�s*/
	soma=lucro+frete+cartaoCred+perdaProd+inadimp+margemNego+taxaFinan+imposto+perdaVenda; /*Realiza a soma de todas a vari�veis estrat�gicas*/
	/*A parte abaixo cria um loop caso as vari�veis somadas juntas passe de 100, o programa repetir� para inserir os dados novamente*/ 
	if(soma>100){
		while(soma>101){
			setlocale(LC_ALL,"Portuguese"); /*Muda a linguagem do programa para portugues*/
			printf("\n\n\n\n\n\n\A somat�ria das variav�is estrat�gicas est� igual ou maior que 100%%. Favor informar novamente.\n");
			setlocale(LC_ALL,"C");/*Muda a linguagem do programa para o ingles*/
			system("pause");/*Entrega o comando de pausa no DOS do Windows*/
			main() ;/*Aqui o loop chama o m�todo main novamente caso a soma das vari�veis seja maior que 100*/
		}
		system("pause");/*Chama o comando de pausa no DOS do Windows*/
		system("cls");/*Chama o comando de limpar a tela no DOS do Windows*/
		title();/*Chama o m�todo title, onde ser� inserido novamente os dados*/
		lerDados();/*Chama o m�todo lerDados para capturar as vari�veis estrat�gicas*/
		}
system("cls");/*Passa o comando de limpar a tela no DOS do Windows*/
    system("color 3F");/*Muda a cor do DOS*/
    	/*Esta parte � respons�vel por criar a janela gerando relat�rio*/
        janela1(16,30,22,80); /*Posicionamento da caixa*/
        gotoxy(19,36); /*Posi��o da caixa de texto*/
        setlocale(LC_ALL,"Portuguese");/*Muda a linguagem do programa para portugu�s*/
        printf("\t    Gerando Relat�rio...          ");/*Exibe na tela esta mensagem*/                
    	for (int fim=0;fim<600;fim++){/*Cria um la�o de repeti��o para fazer a barra de carregamento girar*/
            setlocale(LC_ALL,"C");/*Muda a linguagem do programa para o ingl�s*/
            gotoxy(19,70); printf("%c",196); delay(10);/*Parte respons�vel pelo delay que as barras ir�o girar*/
            gotoxy(19,70); printf("%c",92); delay(10);/*Parte respons�vel pelo delay que as barras ir�o girar*/
            gotoxy(19,70); printf("%c",179); delay(10);/*Parte respons�vel pelo delay que as barras ir�o girar*/
            gotoxy(19,70); printf("%c",47); delay(10);/*Parte respons�vel pelo delay que as barras ir�o girar*/
            }
            janela1(16,30,22,80);/*Posicionamento da caixa*/
            gotoxy(19,36);/*Posi��o da caixa de texto*/
            setlocale(LC_ALL,"Portuguese");/*Muda a linguagem do programa para portugu�s*/
            printf("\tRELAT�RIO GERADO COM SUCESSO!!!");/*Exibe na tela esta mensagem*/  
			setlocale(LC_ALL,"C"); /*Muda a linguagem do programa para o ingles*/
			gotoxy(23,1);  
			fflush(stdin);            
            getch();/*Finaliza o la�o*/
setlocale(LC_ALL,"Portuguese");/*Muda a linguagem do programa para portugu�s*/
	relatorios();/*Chama o m�todo relat�rios*/
	setlocale(LC_ALL,"C");/*Muda a linguagem do programa para o ingl�s*/
	calculos();/*Chama o m�todo c�lculos*/
	printf("\n\n\n\n\n\n\n\n\n\n");/*Parte respons�vel pelos enters na tela do DOS*/
	system("pause");/*Entrega o comando de pausa no DOS do Windows*/
	setlocale(LC_ALL,"Portuguese");/*Muda a linguagem do programa para portugu�s*/
	printf("\n\n\n\n");/*Parte respons�vel pelos enters na tela do DOS*/
	
}
