algoritmo "Exercício 2 - Vetor"
// Disciplina: [Linguagem e Lógica de Programação]
// Professor(a): Antonio Carlos Nicolodi
// Função :
// Autor :
// Data : 31/10/2018
// Seção de Declarações
var
a: vetor [0..19] de real
i: inteiro
media,soma: real
inicio
// Seção de Comandos
soma<-0
para i de 0 ate 19 faca
   escreva("Informe um número para a posição: ",i)
   leia(a[i])
   soma<-soma+a[i]
   limpatela
fimpara
media<-soma/i
escreval("A média é: ",media)
escreva("Os valores maiores que a média são: ")
para i de 0 ate 19 faca
   se a[i]>media entao
      escreva(a[i,])
fimse
fimpara
fimalgoritmo
