CREATE DATABASE db_ordemServico;
USE db_ordemServico;

CREATE TABLE tb_Servico(

	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	cliente VARCHAR NOT NULL,
	respTecnico VARCHAR NOT NULL,
	descricao TEXT NOT NULL,
	diagTecnico TEXT NOT NULL,
	abertura DATETIME NOT NULL,
	fechamento DATETIME NOT NULL

);