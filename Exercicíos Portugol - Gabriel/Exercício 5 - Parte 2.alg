algoritmo "Exercício 5 - Parte 2"
// Função :
// Autor :
// Data : 17/10/2018
// Seção de Declarações 
var
   h,s,p1,p2: real
inicio
// Seção de Comandos
   escreval("Preencha os campos abaixo: ")
                      escreva("Sexo (1 para Feminino; 2 para Masculino): ")
                      leia(s)
                      escreva("Altura: ")
                      leia(h)
   limpatela
   se s=1 entao
      p1<-(62.1*h)-44.7
      escreval("Seu peso ideal é ",p1,"kg.")
   senao
   se s=2 entao
      p2<-(72.7*h)-58
      escreval("Seu peso ideal é ",p2,"kg.")
   senao
        escreval("Sexo inválido")
   fimse
   fimse
   


fimalgoritmo
