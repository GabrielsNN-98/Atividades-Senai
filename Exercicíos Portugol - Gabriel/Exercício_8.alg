algoritmo "Exerc�cio 8"
// Disciplina: [Linguagem e L�gica de Programa��o] 
// Professor(a): Antonio Carlos Nicolodi 
// Fun��o :
// Autor :
// Data : 11/10/2018
// Se��o de Declara��es 
var
   nomeF: caractere
   qtdHoras: inteiro
   valorS,salarioB,salarioL,salario: real
inicio
// Se��o de Comandos
   escreval("Preencha os seguintes campos:")
                      escreva ("Nome: ")
                      leia(nomeF)
                      escreva("Quantidade de horas trabalhadas: ")
                      leia(qtdHoras)
                      escreva("Valor do sal�rio/hora: ")
                      leia(valorS)
   limpatela

   salarioB<-valorS*qtdHoras
   salario<-salarioB*0.18
   salarioL<-salarioB-salario
   escreval("Nome do Funcion�rio: ",nomeF)
   escreval("Sal�rio Bruto: ",salarioB," R$")
   escreval("Sal�rio L�quido: ",salarioL," R$")
   escreval("Total Descontado:",salario," R$")
fimalgoritmo
