algoritmo "Exerc�cio 12 - Parte 2"
// Fun��o :
// Autor :
// Data : 18/10/2018
// Se��o de Declara��es 
var
   n1,n2,n3: real
inicio
// Se��o de Comandos
   escreval("Informe tr�s n�meros:")
   leia(n1)
   leia(n2)
   leia(n3)
   limpatela
   se (n1>n2) e (n1>n3) entao
      escreval("Dos n�meros informados, ",n1," � o maior deles.")
   fimse
   se (n2>n1) e (n2>n3) entao
      escreval("Dos n�meros informados, ",n2," � o maior deles.")
   fimse
   se (n3>n1) e (n3>n2) entao
      escreval("Dos n�meros informados, ",n3," � o maior deles.")
   fimse
   
fimalgoritmo
