algoritmo "Exerc�cio 14 - Parte 2"
// Fun��o :
// Autor :
// Data : 18/10/2018
// Se��o de Declara��es
var
nome,sexo: caractere
p,a,r:real
inicio
// Se��o de Comandos
escreval("Preencha os campos abaixo:")
escreva("Sexo: ")
leia(sexo)
escreva("Nome: ")
leia(nome)
escreva("Peso (kg): ")
leia(p)
escreva("Altura (m): ")
leia(a)
limpatela
r<-p/(a*a)
se sexo="Masculino" entao
   se r<20 entao
      escreval(nome,", seu peso � ",p,"kg e voc� est� abaixo do seu peso ideal.")
   senao
      se (r>=20) e (r<25) entao
         escreval(nome, ", seu peso � ",p,"kg e voc� est� no seu peso ideal.")
      senao
         se r>=25 entao
            escreval(nome,", seu peso � ",p,"kg e voc� est� acima do seu peso ideal.",r)
         senao
         fimse
      fimse
   fimse
senao
   se r<19 entao
      escreval(nome,", seu peso � ",p,"kg e voc� est� abaixo do seu peso ideal.")
   senao
      se (r>=19) e (r<24) entao
         escreval(nome, ", seu peso � ",p,"kg e voc� est� no seu peso ideal.")
      senao
         se r>=24 entao
            escreval(nome,", seu peso � ",p,"kg e voc� est� acima do seu peso ideal.",r)
         fimse
      fimse
   fimse
fimse

fimalgoritmo




