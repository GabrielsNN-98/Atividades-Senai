algoritmo "Exercício  - Laço de repetição"
// Função :
// Autor :
// Data : 20/10/2018
// Seção de Declarações
var
soma,n,i,ini,fim,cont,step: inteiro
media: real
inicio
// Seção de Comandos
soma<-0
cont<-0
repita
   escreva("Informe um valor para iniciar o laço: ")
   leia(ini)
   escreva("Informe um  valor para finalizar o laço: ")
   leia(fim)
   escreva("Informe um valor para o passo do laço: ")
   leia(step)
   se ini>=fim entao
      escreval("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@")
      escreval("@@ INFORME UM VALOR CORRETOOOOOOOOOOO @@")
      escreval("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@")

   senao
      para i de ini ate fim passo step faca
         escreva("Digite um número para a posição ",i,": ")
         leia(n)
         soma<-soma+n
         cont<-cont+1
      fimpara
      media<-soma/cont
      limpatela
      escreval("A média é: ",media)
   fimse
   limpatela
ate ini<fim

fimalgoritmo
