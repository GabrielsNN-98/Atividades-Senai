algoritmo "Exerc�cio 3 - Matriz"
// Fun��o :
// Autor :
// Data : 06/11/2018
// Se��o de Declara��es
var
i,j: inteiro
m: vetor [0..2,0..2] de inteiro
media,soma: real
inicio
// Se��o de Comandos
soma<-0
para i de 0 ate 2 faca
   para j de 0 ate 2 faca
      m[i,j]<-randi(100)
      soma<-soma+m[i,j]
   fimpara
   media<-soma/j
   soma<-0
   escreval("A m�dia da linha ",i," � ",media)
fimpara

fimalgoritmo
