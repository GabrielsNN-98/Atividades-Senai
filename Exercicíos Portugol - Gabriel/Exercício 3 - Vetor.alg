algoritmo "Exerc�cio 3 - Vetor"
// Disciplina: [Linguagem e L�gica de Programa��o]
// Professor(a): Antonio Carlos Nicolodi
// Fun��o :
// Autor :
// Data : 31/10/2018
// Se��o de Declara��es
var
a: vetor [0..9] de inteiro
i,x,cont: inteiro
media,soma: real
inicio
// Se��o de Comandos
soma<-0
cont<-0
para i de 0 ate 9 faca
   escreva("Informe a idade do aluno ",i,": ")
   leia(a[i])
   soma<-soma+a[i]
   limpatela
   escreva("As idades digitadas foram: ")
   para i de 0 ate 9 faca
   escreva(a[i])
   fimpara
fimpara
media<-soma/i
escreval("")
escreval("A m�dia de idade �: ",media)
escreva("A quantidade de pessoas com idade maior que a m�dia s�o: ")
para x de 0 ate 9 faca
   se a[x]>media entao
      cont<-cont+1
   fimse
fimpara
escreva(cont)
fimalgoritmo
