algoritmo "Exerc�cio 7 - CasaHachurada"
// Disciplina: [Linguagem e L�gica de Programa��o] 
// Professor(a): Antonio Carlos Nicolodi 
// Fun��o :
// Autor :
// Data : 10/10/2018
// Se��o de Declara��es 
var
   alturaT,base,alturaR,fachada,areaT,areaR,areaJ: real
   
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
   areaJ<-(alturaR/3)*(alturaR/3)*2
   fachada<-areaT+areaR-areaJ
   escreval("A �rea da fachada � de ",fachada,"m�.")

fimalgoritmo
