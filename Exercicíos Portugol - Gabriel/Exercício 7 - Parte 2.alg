algoritmo "Exercício 7 - Parte 2"
// Função :
// Autor :
// Data : 17/10/2018
// Seção de Declarações 
var
   cg,ag: inteiro
   c,a: caractere
inicio
// Seção de Comandos
   escreval("Informe o resultado do jogo entre: ")
                     escreva("Cruzeiro    ")
                     leia(cg)
                     escreval("     X")
                     escreva("Atlético-MG ")
                     leia(ag)
   c<-"CRUZEIRO"
   a<-"ATLÉTICO-MG"
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
