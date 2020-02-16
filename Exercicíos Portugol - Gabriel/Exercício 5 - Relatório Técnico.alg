algoritmo "Exercício 5 - Relatório Técnico"
// Função :
// Autor :
// Data : 30/10/2018
// Seção de Declarações
var
sort,num,i,cont: inteiro
inicio
// Seção de Comandos
cont<-0
sort<-randi(100)
repita
   escreva("Informe um número: ")
   leia(num)
   se (num<sort) entao
      cont<-cont+1
      limpatela
      escreval("O número informado é MENOR que o escolhido!")
   senao
      se (num>sort) entao
         cont<-cont+1
         limpatela
         escreval("O nmúmero informador é MAIOR que o escolhido!")
      fimse
   fimse
ate num=sort
limpatela
escreval("PARABÉNS!!!, você acertou o número sorteado!")
escreval("Tentativas: ",cont)

fimalgoritmo

