algoritmo "Exercício 13 - Parte 2"
// Função :
// Autor :
// Data : 18/10/2018
// Seção de Declarações 
var
   nome: caractere
   p,a,r:real
inicio
// Seção de Comandos
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
      escreval(nome,", seu peso é ",p,"kg e você está abaixo do seu peso ideal.")
   fimse
   se (r=20) e (r<25) entao
      escreval(nome, ", seu peso é ",p,"kg e você está no seu peso ideal.")
   fimse
   se r>=25 entao
      escreval(nome,", seu peso é ",p,"kg e você está acima do seu peso ideal.",)
   fimse

fimalgoritmo



