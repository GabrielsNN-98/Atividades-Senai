algoritmo "semnome"
// Função :
// Autor :
// Data : 30/10/2018
// Seção de Declarações
var
nome: vetor [0..2] de caractere
idade: vetor [0..2] de inteiro
salario: vetor [0..2] de real
i,code: inteiro
inicio
// Seção de Comandos
para i de 0 ate 2 faca
   escreva("Informe o nome do funcionário", i,": ")
   leia(nome[i])
   escreva("Informe a idade do funcionário", i,": ")
   leia(idade[i])
   escreva("Informe o salário do funcionário", i,": ")
   leia(salario[i])
limpatela
fimpara
escreva("Informe o código do funcionário: ")
leia(code)
limpatela
escreval("O funcionário ",nome[code]," tem ",idade[code]," anos e seu salário é de R$",salario[code])

fimalgoritmo
