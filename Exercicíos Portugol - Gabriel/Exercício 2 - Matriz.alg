algoritmo "Exerc�cio 2 - Matriz"
// Fun��o :
// Autor :
// Data : 06/11/2018
// Se��o de Declara��es
var
i,j,soma: inteiro
m: vetor [0..2,0..2] de inteiro
inicio
// Se��o de Comandos
soma<-0
para i de 0 ate 2 faca
   para j de 0 ate 2 faca
      escreva("Informe um n�mero: ")
      leia(m[i,j])
soma<-soma+m[i,j]
   fimpara
fimpara
limpatela
      escreval("A soma dos n�meros digitados �: ",soma)
fimalgoritmo
