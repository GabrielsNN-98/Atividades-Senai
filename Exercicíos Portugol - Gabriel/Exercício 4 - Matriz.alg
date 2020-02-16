algoritmo "Exercício 4 - Matriz"
// Função :
// Autor :
// Data : 06/11/2018
// Seção de Declarações
var
i,j,cont: inteiro
m: vetor [0..2,0..3] de inteiro
n: vetor [0..2,0..3] de inteiro
inicio
// Seção de Comandos
cont<-0
para i de 0 ate 2 faca
   para j de 0 ate 3 faca
      escreva("Informe um número para ",i,j,": ")
      leia(m[i,j])
      limpatela
      se m[i,j]>=0 entao
         cont<-cont+1
         n[i,j]<-m[i,j]
      senao
         n[i,j]<-0
      fimse
   fimpara
fimpara
limpatela
escreval("Dos números digitados, ",cont," deles são positivos. São eles:")
para i de 0 ate 2 faca
   para j de 0 ate 3 faca
      escreva(" ",n[i,j])
   fimpara
fimpara
fimalgoritmo

