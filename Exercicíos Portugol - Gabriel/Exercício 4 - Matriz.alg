algoritmo "Exerc�cio 4 - Matriz"
// Fun��o :
// Autor :
// Data : 06/11/2018
// Se��o de Declara��es
var
i,j,cont: inteiro
m: vetor [0..2,0..3] de inteiro
n: vetor [0..2,0..3] de inteiro
inicio
// Se��o de Comandos
cont<-0
para i de 0 ate 2 faca
   para j de 0 ate 3 faca
      escreva("Informe um n�mero para ",i,j,": ")
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
escreval("Dos n�meros digitados, ",cont," deles s�o positivos. S�o eles:")
para i de 0 ate 2 faca
   para j de 0 ate 3 faca
      escreva(" ",n[i,j])
   fimpara
fimpara
fimalgoritmo

