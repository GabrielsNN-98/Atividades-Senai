algoritmo "Exerc�cio 3"
// Fun��o :
// Autor :
// Data : 10/10/2018
// Se��o de Declara��es 
var
   marcaAuto: caractere
   precoAutofab,precoAuto: real
inicio
// Se��o de Comandos
   escreval("Informe a marca do autom�vel: ")
   leia (marcaAuto)
   escreval("Informe o pre�o de f�brica do autom�vel: ")
   leia(precoAutofab)
   precoAuto <-precoAutofab+(0.45*precoAutofab)+(0.28*precoAutofab)
   escreval("O pre�o do autom�vel da marca ",marcaAuto," � ",precoAuto)
   
fimalgoritmo
