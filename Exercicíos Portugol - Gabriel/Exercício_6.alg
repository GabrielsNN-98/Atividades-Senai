algoritmo "Exercício 6"
// Função :
// Autor :
// Data : 10/10/2018
// Seção de Declarações 
var
   alturaT,base,alturaR,fachada,areaT,areaR: real
   
inicio
// Seção de Comandos
   escreval("Considere uma casa onde: (A) é a altura do telhado, (B) é a base e (C) é a altura da parede. Informe valores para:")
                     escreva("A: ")
                     leia(alturaT)
                     escreva("B: ")
                     leia(base)
                     escreva("C: ")
                     leia(alturaR)
   areaT<-(base*alturaT)/2
   areaR<-base*alturaR
   fachada<-areaT+areaR
   escreval("A área da fachada é de ",fachada,"m².")

fimalgoritmo
