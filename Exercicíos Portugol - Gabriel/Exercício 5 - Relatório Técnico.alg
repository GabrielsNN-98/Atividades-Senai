algoritmo "Exerc�cio 5 - Relat�rio T�cnico"
// Fun��o :
// Autor :
// Data : 30/10/2018
// Se��o de Declara��es
var
sort,num,i,cont: inteiro
inicio
// Se��o de Comandos
cont<-0
sort<-randi(100)
repita
   escreva("Informe um n�mero: ")
   leia(num)
   se (num<sort) entao
      cont<-cont+1
      limpatela
      escreval("O n�mero informado � MENOR que o escolhido!")
   senao
      se (num>sort) entao
         cont<-cont+1
         limpatela
         escreval("O nm�mero informador � MAIOR que o escolhido!")
      fimse
   fimse
ate num=sort
limpatela
escreval("PARAB�NS!!!, voc� acertou o n�mero sorteado!")
escreval("Tentativas: ",cont)

fimalgoritmo

