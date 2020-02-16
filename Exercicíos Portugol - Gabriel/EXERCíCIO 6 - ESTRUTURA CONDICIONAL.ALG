Algoritmo "Exercício 6 - Estrutura Condicional"
// Disciplina  :
// Professor(a):  
// Descrição   :
// Autor(a)    :
// Data atual  :
Var
// Seção de Declarações das variáveis 
   n1,n2,n3,n4,n5,media,qtd,soma: real
   
   
Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 

   escreval("Informe cinco números: ")
   leia(n1)
   leia(n2)
   leia(n3)
   leia(n4)
   leia(n5)
   soma<-0
   qtd<-0
   se n1>4 entao
      soma<-soma+n1
      qtd<-qtd+1
   fimse
   se n2>4 entao
      soma<-soma+n2
      qtd<-qtd+1
   fimse
   se n3>4 entao
      soma<-soma+n3
      qtd<-qtd+1
   fimse
   se n4>4 entao
      soma<-soma+n4
      qtd<-qtd+1
   fimse
   se n5>4 entao
      soma<-soma+n5
      qtd<-qtd+1
   fimse
      media<-soma/qtd
      escreval("A média dos números maiores que 4 é: ",media)
   
Fimalgoritmo
