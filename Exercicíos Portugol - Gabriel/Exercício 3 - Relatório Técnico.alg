algoritmo "Exerc�cio 3 - Relat�rio T�cnico"
// Fun��o :
// Autor :
// Data : 29/10/2018
// Se��o de Declara��es
var
n1,n2,cont,i: inteiro
inicio
// Se��o de Comandos
cont<-0
escreval("Informe dois n�meros:")
leia(n1)
leia(n2)
para i de n1+1 ate n2-1 passo 1 faca
   se i%2<>0 entao
      cont<-cont+1
   fimse
fimpara
escreval("A quantidade de n�meros �mpares entre",n1," e",n2," �",cont,".")
fimalgoritmo
