algoritmo "Exercício 5 - Matriz"
// Função :
// Autor :
// Data : 06/11/2018
// Seção de Declarações
var
i,j,cont: inteiro
m: vetor [0..3,0..3] de inteiro
inicio
// Seção de Comandos
cont<-0
para i de 0 ate 3 faca
   para j de 0 ate 3 faca
      escreva("Informe valores para a posição ",i,j,": ")
      leia(m[i,j])
   fimpara
fimpara
limpatela
para i de 0 ate 3 faca
   se m[2,i]%2=0 entao
      cont<-cont+1
   fimse
fimpara
escreval("Existem ",cont," número(s) par(es) na coluna 3. São eles: ")
para i de 0 ate 3 faca
   se m[2,i]%2=0 entao
      escreva(m[2,i])
   fimse
fimpara
fimalgoritmo
