algoritmo "Exercício 12 - Parte 2"
// Função :
// Autor :
// Data : 18/10/2018
// Seção de Declarações 
var
   n1,n2,n3: real
inicio
// Seção de Comandos
   escreval("Informe três números:")
   leia(n1)
   leia(n2)
   leia(n3)
   limpatela
   se (n1>n2) e (n1>n3) entao
      escreval("Dos números informados, ",n1," é o maior deles.")
   fimse
   se (n2>n1) e (n2>n3) entao
      escreval("Dos números informados, ",n2," é o maior deles.")
   fimse
   se (n3>n1) e (n3>n2) entao
      escreval("Dos números informados, ",n3," é o maior deles.")
   fimse
   
fimalgoritmo
