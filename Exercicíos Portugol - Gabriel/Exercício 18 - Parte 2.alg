algoritmo "Exercício 18 - Parte 2"
// Função :
// Autor :
// Data : 18/10/2018
// Seção de Declarações 
var
   a,b,r: real
   op: caractere
   
inicio
// Seção de Comandos
   escreval("Informe dois números:")
   leia(a)
   leia(b)
   escreval("Informe a operação:")
   leia(op)
   se (op="+") ou (op="soma") entao
   r<-a+b
         escreval(a," ",op,b," =",r)
   fimse
   se (op="-") ou (op="subtração") entao
   r<-a-b
         escreval(a," ",op,b," =",r)
   fimse
   se (op="*") ou (op="multiplicação") entao
   r<-a*b
         escreval(a," ",op,b," =",r)
   fimse
   se (op="/") ou (op="divisão") entao
   r<-a/b
         escreval(a," ",op,b," =",r)
   fimse
   
fimalgoritmo
