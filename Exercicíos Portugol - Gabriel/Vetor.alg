algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 30/10/2018
// Se��o de Declara��es
var
nome: vetor [0..2] de caractere
idade: vetor [0..2] de inteiro
salario: vetor [0..2] de real
i,code: inteiro
inicio
// Se��o de Comandos
para i de 0 ate 2 faca
   escreva("Informe o nome do funcion�rio", i,": ")
   leia(nome[i])
   escreva("Informe a idade do funcion�rio", i,": ")
   leia(idade[i])
   escreva("Informe o sal�rio do funcion�rio", i,": ")
   leia(salario[i])
limpatela
fimpara
escreva("Informe o c�digo do funcion�rio: ")
leia(code)
limpatela
escreval("O funcion�rio ",nome[code]," tem ",idade[code]," anos e seu sal�rio � de R$",salario[code])

fimalgoritmo
