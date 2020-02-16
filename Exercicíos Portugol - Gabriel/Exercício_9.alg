algoritmo "Exercício 9"
// Função :
// Autor :
// Data : 11/10/2018
// Seção de Declarações 
var
   nome: caractere
   altura,peso,pesoId,dif: real
inicio
// Seção de Comandos
   escreval("Preencha os seguintes campos:")
                      escreva("Nome: ")
                      leia(nome)
                      escreva("Altura (m): ")
                      leia(altura)
                      escreva("Peso (kg): ")
                      leia(peso)
   pesoId<-(72.2*altura)-58
   dif<-pesoId-peso
   escreval(nome,", o seu peso atual é ",peso,"kg e o seu peso ideal é ",pesoId, "kg ,seu peso está alterado em ",dif,"kg.")
fimalgoritmo
