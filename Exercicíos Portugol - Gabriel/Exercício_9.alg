algoritmo "Exerc�cio 9"
// Fun��o :
// Autor :
// Data : 11/10/2018
// Se��o de Declara��es 
var
   nome: caractere
   altura,peso,pesoId,dif: real
inicio
// Se��o de Comandos
   escreval("Preencha os seguintes campos:")
                      escreva("Nome: ")
                      leia(nome)
                      escreva("Altura (m): ")
                      leia(altura)
                      escreva("Peso (kg): ")
                      leia(peso)
   pesoId<-(72.2*altura)-58
   dif<-pesoId-peso
   escreval(nome,", o seu peso atual � ",peso,"kg e o seu peso ideal � ",pesoId, "kg ,seu peso est� alterado em ",dif,"kg.")
fimalgoritmo
