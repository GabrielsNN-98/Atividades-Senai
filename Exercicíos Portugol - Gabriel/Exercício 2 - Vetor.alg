algoritmo "Exerc�cio 2 - Vetor"
// Disciplina: [Linguagem e L�gica de Programa��o]
// Professor(a): Antonio Carlos Nicolodi
// Fun��o :
// Autor :
// Data : 31/10/2018
// Se��o de Declara��es
var
a: vetor [0..19] de real
i: inteiro
media,soma: real
inicio
// Se��o de Comandos
soma<-0
para i de 0 ate 19 faca
   escreva("Informe um n�mero para a posi��o: ",i)
   leia(a[i])
   soma<-soma+a[i]
   limpatela
fimpara
media<-soma/i
escreval("A m�dia �: ",media)
escreva("Os valores maiores que a m�dia s�o: ")
para i de 0 ate 19 faca
   se a[i]>media entao
      escreva(a[i,])
fimse
fimpara
fimalgoritmo
