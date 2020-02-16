CREATE DATABASE Ianes;

USE Ianes;

CREATE TABLE funcionario(
	id			INT				NOT NULL	IDENTITY(1,1)	PRIMARY KEY,
	nome  		VARCHAR(100)  	NOT NULL,
	cpf  		VARCHAR(11)  	NOT NULL	UNIQUE,
    email		VARCHAR(100)	NOT NULL,
    telefone	VARCHAR(11)		NOT NULL,
    tipo		VARCHAR(30)		NOT NULL,
    login  		VARCHAR(10)  	NOT NULL	UNIQUE,
    senha  		VARCHAR(15)  	NOT NULL
);

CREATE TABLE requisitante(
	id   		INT	    		NOT NULL	IDENTITY(1,1)	PRIMARY KEY,
	nome  		VARCHAR(100)  	NOT NULL,
    email  		VARCHAR(100)	NOT NULL,
	telefone 	VARCHAR(11)  	NOT NULL,
	tipo  		VARCHAR(30)  	NOT NULL
);

CREATE TABLE equipamento(
	id   			INT				NOT NULL	IDENTITY(1,1)	PRIMARY KEY,
	serialFabrica	VARCHAR(50)		NOT NULL	UNIQUE,	
	status			VARCHAR(15)		NOT NULL,
	marca			VARCHAR(30)		NOT NULL,
	tipo			VARCHAR(30)		NOT NULL,
    descricao		TEXT,
);

CREATE TABLE emprestimo(
	id   				INT				NOT NULL	IDENTITY(1,1)	PRIMARY KEY,
    local 				VARCHAR(100)	NOT NULL,
	dataHora			DATE     		NOT NULL,
	dataFinal			DATE     		NOT NULL,
	status				VARCHAR(30)		NOT NULL,
	descricao			TEXT,

    idFuncionario  INT   FOREIGN KEY   REFERENCES funcionario(id),
    
	idRequisitante INT   FOREIGN KEY   REFERENCES requisitante(id)
);

CREATE TABLE item(
	id			   INT	 NOT NULL      IDENTITY(1,1)		PRIMARY	KEY,
    
    idEmprestimo   INT   FOREIGN KEY   REFERENCES emprestimo(id),
    idEquipamento  INT   FOREIGN KEY   REFERENCES equipamento(id)
);

SELECT dbo.equipamento.id, dbo.equipamento.tipo, dbo.emprestimo.idRequisitante FROM dbo.equipamento 
INNER JOIN dbo.item ON dbo.equipamento.id = dbo.item.idEquipamento 
INNER JOIN dbo.emprestimo ON dbo.emprestimo.id = dbo.item.idEmprestimo WHERE dbo.emprestimo.id = 2
 
 SELECT dbo.emprestimo.local FROM dbo.emprestimo
 INNER JOIN dbo.item ON dbo.emprestimo.id = dbo.item.idEmprestimo;

 SELECT dbo.equipamento.id, dbo.equipamento.tipo FROM dbo.equipamento  
 INNER JOIN dbo.item ON dbo.equipamento.id = dbo.item.idEquipamento  
 INNER JOIN dbo.emprestimo ON dbo.emprestimo.id = dbo.item.idEmprestimo;

 SELECT status, dataFinal FROM emprestimo WHERE status = 'Pendente';

 SELECT * FROM emprestimo WHERE status != 'Entregue';


 SELECT MAX (id) FROM dbo.emprestimo;
 UPDATE emprestimo SET status = 'Entregue' WHERE Id= '1';
 UPDATE emprestimo SET status = 'Atrasado' WHERE dataFinal = '12-02-2020' AND status = 'Pendente'; 
 
 SELECT dbo.equipamento.id, dbo.equipamento.status FROM dbo.equipamento  
 INNER JOIN dbo.item ON dbo.equipamento.id = dbo.item.idEquipamento  
 
UPDATE dbo.equipamento
        INNER JOIN
    dbo.item ON employees.performance = merits.performance 
SET 
    salary = salary + salary * percentage;

	SELECT dbo.item.idEmprestimo

	UPDATE employees
        INNER JOIN
    merits ON employees.performance = merits.performance 
SET 
    salary = salary + salary * percentage;


UPDATE TOP (1) item  SET idEmprestimo  = (SELECT TOP 1 (id) FROM emprestimo ORDER BY id desc);
UPDATE TOP (1) item  SET idEmprestimo  = (SELECT TOP 1 (id) FROM emprestimo ORDER BY id desc) WHERE id ORDER BY id desc;
UPDATE item  SET idEmprestimo = (SELECT TOP 1 (id) FROM emprestimo ORDER BY id desc);
UPDATE item 
	SET item.idEmprestimo = (select emprestimo.id from emprestimo order by id desc limit 1)
	ORDER BY item.id DESC
	LIMIT 1;



	UPDATE item SET item.idEmprestimo = emprestimo.id FROM emprestimo WHERE item.id = (SELECT MAX(id) FROM item) AND emprestimo.id = (SELECT MAX(id) FROM emprestimo);



	UPDATE equipamento SET equipamento.marca = "Indisponível" WHERE equipamento.id = 1;