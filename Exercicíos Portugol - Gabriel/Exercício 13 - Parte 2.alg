algoritmo "Exerc�cio 13 - Parte 2"
// Fun��o :
// Autor :
// Data : 18/10/2018
// Se��o de Declara��es 
var
   nome: caractere
   p,a,r:real
inicio
// Se��o de Comandos
   escreval("Preencha os campos abaixo:")
                      escreva("Nome: ")
                      leia(nome)
                      escreva("Peso (kg): ")
                      leia(p)
                      escreva("Altura (m): ")
                      leia(a)
   limpatela
   r<-p/(a*a)
   se r<20 entao
      escreval(nome,", seu peso � ",p,"kg e voc� est� abaixo do seu peso ideal.")
   fimse
   se (r=20) e (r<25) entao
      escreval(nome, ", seu peso � ",p,"kg e voc� est� no seu peso ideal.")
   fimse
   se r>=25 entao
      escreval(nome,", seu peso � ",p,"kg e voc� est� acima do seu peso ideal.",)
   fimse

fimalgoritmo



