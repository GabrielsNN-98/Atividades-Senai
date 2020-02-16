algoritmo "Exercício 3 - Matriz"
// Função :
// Autor :
// Data : 06/11/2018
// Seção de Declarações
var
i,j: inteiro
m: vetor [0..2,0..2] de inteiro
media,soma: real
inicio
// Seção de Comandos
soma<-0
para i de 0 ate 2 faca
   para j de 0 ate 2 faca
      m[i,j]<-randi(100)
      soma<-soma+m[i,j]
   fimpara
   media<-soma/j
   soma<-0
   escreval("A média da linha ",i," é ",media)
fimpara

fimalgoritmo
