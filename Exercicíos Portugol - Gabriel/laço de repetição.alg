algoritmo "Exerc�cio  - La�o de repeti��o"
// Fun��o :
// Autor :
// Data : 20/10/2018
// Se��o de Declara��es
var
soma,n,i,ini,fim,cont,step: inteiro
media: real
inicio
// Se��o de Comandos
soma<-0
cont<-0
repita
   escreva("Informe um valor para iniciar o la�o: ")
   leia(ini)
   escreva("Informe um  valor para finalizar o la�o: ")
   leia(fim)
   escreva("Informe um valor para o passo do la�o: ")
   leia(step)
   se ini>=fim entao
      escreval("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@")
      escreval("@@ INFORME UM VALOR CORRETOOOOOOOOOOO @@")
      escreval("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@")

   senao
      para i de ini ate fim passo step faca
         escreva("Digite um n�mero para a posi��o ",i,": ")
         leia(n)
         soma<-soma+n
         cont<-cont+1
      fimpara
      media<-soma/cont
      limpatela
      escreval("A m�dia �: ",media)
   fimse
   limpatela
ate ini<fim

fimalgoritmo
