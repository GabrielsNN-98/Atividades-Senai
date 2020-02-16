CREATE DATABASE bdClubeTDS;

USE bdClubeTDS;

CREATE TABLE socio(
	id   INT         NOT NULL PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50) NOT NULL,
	cpf  VARCHAR(14) NOT NULL,
);

CREATE TABLE dependente(
	id       INT         NOT NULL PRIMARY KEY IDENTITY(1,1),
	nome     VARCHAR(50) NOT NULL,
	dataNasc DATE        NOT NULL,
	idSocio  INT         NOT NULL,
	FOREIGN KEY (idSocio) REFERENCES socio(id),
);

INSERT INTO socio (nome, cpf) 
VALUES ('Gabriel', '14440085601');

DELETE FROM socio WHERE id = 5;

DELETE FROM dependente WHERE id = 1;

INSERT INTO dependente (nome, dataNasc, idSocio) 
VALUES ('Rogério', '12/05/2012', 1);

SELECT * FROM socio;


