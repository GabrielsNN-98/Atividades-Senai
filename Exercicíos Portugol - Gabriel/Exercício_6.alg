algoritmo "Exerc�cio 6"
// Fun��o :
// Autor :
// Data : 10/10/2018
// Se��o de Declara��es 
var
   alturaT,base,alturaR,fachada,areaT,areaR: real
   
inicio
// Se��o de Comandos
   escreval("Considere uma casa onde: (A) � a altura do telhado, (B) � a base e (C) � a altura da parede. Informe valores para:")
                     escreva("A: ")
                     leia(alturaT)
                     escreva("B: ")
                     leia(base)
                     escreva("C: ")
                     leia(alturaR)
   areaT<-(base*alturaT)/2
   areaR<-base*alturaR
   fachada<-areaT+areaR
   escreval("A �rea da fachada � de ",fachada,"m�.")

fimalgoritmo
