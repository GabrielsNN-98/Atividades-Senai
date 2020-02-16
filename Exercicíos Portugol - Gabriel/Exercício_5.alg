algoritmo "Exercício 5"
// Função :
// Autor :
// Data : 10/10/2018
// Seção de Declarações 
var
   dist,vlitro,combgasto,valort: real
inicio
// Seção de Comandos
   escreval("Informe a distância a ser percorrida e o valor do litro de combustível:")
                     escreva("distância (KM): ")
                     leia(dist)
                     escreva("valor do litro de combustível (R$): ")
                     leia(vlitro)
   combgasto<- dist/11.5
   valort<-(dist/11.5)*vlitro
   escreval("Serão gastos ",combgasto,"L de combustível e o valor total será de ",valort," R$.")

   
fimalgoritmo
