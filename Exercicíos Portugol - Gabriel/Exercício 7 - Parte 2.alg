algoritmo "Exerc�cio 7 - Parte 2"
// Fun��o :
// Autor :
// Data : 17/10/2018
// Se��o de Declara��es 
var
   cg,ag: inteiro
   c,a: caractere
inicio
// Se��o de Comandos
   escreval("Informe o resultado do jogo entre: ")
                     escreva("Cruzeiro    ")
                     leia(cg)
                     escreval("     X")
                     escreva("Atl�tico-MG ")
                     leia(ag)
   c<-"CRUZEIRO"
   a<-"ATL�TICO-MG"
   limpatela
   se cg=ag entao
      escreval("EMPATE")
   senao
   se cg>ag entao
      escreval("O vencedor do jogo foi o ",c,".")
   senao
        escreval("O vencedor do jogo foi o ",a,".")
   fimse
   fimse

fimalgoritmo
