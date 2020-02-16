Algoritmo "Exercício 5 - Estrutura Condicional"
// Disciplina  : [] 
// Professor(a):  
// Descrição   : Aqui você descreve o que o programa faz! (função)
// Autor(a)    : Nome do(a) aluno(a)
// Data atual  : 15/10/2018
Var
// Seção de Declarações das variáveis 
   n1,n2,n3: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc... 
   escreval("Informe três números: ")
   leia(n1)
   leia(n2)
   leia(n3)
   se (n1<n2) e (n1<n3) entao
      escreval(n1," é o menor de todos os números informados.")
   fimse
   se (n2<n1) e (n2<n3) entao
      escreval(n2," é o menor de todos os números informados.")
   fimse
   se (n3<n1) e (n3<n2) entao
      escreval(n3," é o menor de todos os números informados.")
   fimse

Fimalgoritmo