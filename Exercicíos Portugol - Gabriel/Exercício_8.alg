algoritmo "Exercício 8"
// Disciplina: [Linguagem e Lógica de Programação] 
// Professor(a): Antonio Carlos Nicolodi 
// Função :
// Autor :
// Data : 11/10/2018
// Seção de Declarações 
var
   nomeF: caractere
   qtdHoras: inteiro
   valorS,salarioB,salarioL,salario: real
inicio
// Seção de Comandos
   escreval("Preencha os seguintes campos:")
                      escreva ("Nome: ")
                      leia(nomeF)
                      escreva("Quantidade de horas trabalhadas: ")
                      leia(qtdHoras)
                      escreva("Valor do salário/hora: ")
                      leia(valorS)
   limpatela

   salarioB<-valorS*qtdHoras
   salario<-salarioB*0.18
   salarioL<-salarioB-salario
   escreval("Nome do Funcionário: ",nomeF)
   escreval("Salário Bruto: ",salarioB," R$")
   escreval("Salário Líquido: ",salarioL," R$")
   escreval("Total Descontado:",salario," R$")
fimalgoritmo
