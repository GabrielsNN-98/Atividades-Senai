algoritmo "Exercício 6 - Matriz"
// Função :
// Autor :
// Data : 08/11/2018
// Seção de Declarações
var
i,j,soma1,soma2: inteiro
a: vetor [0..4,0..2] de inteiro
b: vetor [0..4,0..2] de inteiro
c: vetor [0..4,0..2] de inteiro
inicio
// Seção de Comandos
soma1<-0
soma2<-0
para i de 0 ate 4 faca
   para j de 0 ate 2 faca
      leia(a[i,j])
   fimpara
fimpara
para i de 0 ate 4 faca
   para j de 0 ate 2 faca
      leia(b[i,j])
   fimpara
fimpara
para i de 0 ate 4 faca
   para j de 0 ate 2 faca
      soma1<-soma1+(a[i]+b[i])
      soma2<-soma2+(a[j]+b[j])
   fimpara
fimpara
escreval(soma1," ",soma2)
fimalgoritmo
