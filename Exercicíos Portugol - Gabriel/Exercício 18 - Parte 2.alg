algoritmo "Exerc�cio 18 - Parte 2"
// Fun��o :
// Autor :
// Data : 18/10/2018
// Se��o de Declara��es 
var
   a,b,r: real
   op: caractere
   
inicio
// Se��o de Comandos
   escreval("Informe dois n�meros:")
   leia(a)
   leia(b)
   escreval("Informe a opera��o:")
   leia(op)
   se (op="+") ou (op="soma") entao
   r<-a+b
         escreval(a," ",op,b," =",r)
   fimse
   se (op="-") ou (op="subtra��o") entao
   r<-a-b
         escreval(a," ",op,b," =",r)
   fimse
   se (op="*") ou (op="multiplica��o") entao
   r<-a*b
         escreval(a," ",op,b," =",r)
   fimse
   se (op="/") ou (op="divis�o") entao
   r<-a/b
         escreval(a," ",op,b," =",r)
   fimse
   
fimalgoritmo
