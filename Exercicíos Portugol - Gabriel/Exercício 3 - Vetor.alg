algoritmo "Exercício 3 - Vetor"
// Disciplina: [Linguagem e Lógica de Programação]
// Professor(a): Antonio Carlos Nicolodi
// Função :
// Autor :
// Data : 31/10/2018
// Seção de Declarações
var
a: vetor [0..9] de inteiro
i,x,cont: inteiro
media,soma: real
inicio
// Seção de Comandos
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
escreval("A média de idade é: ",media)
escreva("A quantidade de pessoas com idade maior que a média são: ")
para x de 0 ate 9 faca
   se a[x]>media entao
      cont<-cont+1
   fimse
fimpara
escreva(cont)
fimalgoritmo
