algoritmo "Exercício 3"
// Função :
// Autor :
// Data : 10/10/2018
// Seção de Declarações 
var
   marcaAuto: caractere
   precoAutofab,precoAuto: real
inicio
// Seção de Comandos
   escreval("Informe a marca do automóvel: ")
   leia (marcaAuto)
   escreval("Informe o preço de fábrica do automóvel: ")
   leia(precoAutofab)
   precoAuto <-precoAutofab+(0.45*precoAutofab)+(0.28*precoAutofab)
   escreval("O preço do automóvel da marca ",marcaAuto," é ",precoAuto)
   
fimalgoritmo
