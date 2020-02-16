algoritmo "Exercício 2 - Matriz"
// Função :
// Autor :
// Data : 06/11/2018
// Seção de Declarações
var
i,j,soma: inteiro
m: vetor [0..2,0..2] de inteiro
inicio
// Seção de Comandos
soma<-0
para i de 0 ate 2 faca
   para j de 0 ate 2 faca
      escreva("Informe um número: ")
      leia(m[i,j])
soma<-soma+m[i,j]
   fimpara
fimpara
limpatela
      escreval("A soma dos números digitados é: ",soma)
fimalgoritmo
