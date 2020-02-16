algoritmo "Exercício 3 - Relatório Técnico"
// Função :
// Autor :
// Data : 29/10/2018
// Seção de Declarações
var
n1,n2,cont,i: inteiro
inicio
// Seção de Comandos
cont<-0
escreval("Informe dois números:")
leia(n1)
leia(n2)
para i de n1+1 ate n2-1 passo 1 faca
   se i%2<>0 entao
      cont<-cont+1
   fimse
fimpara
escreval("A quantidade de números ímpares entre",n1," e",n2," é",cont,".")
fimalgoritmo
