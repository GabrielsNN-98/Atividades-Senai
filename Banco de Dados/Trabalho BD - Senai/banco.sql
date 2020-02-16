drop database banco;
create database banco;
use banco;

create table tb_banco (
	idBanco integer unique not null auto_increment primary key,
    cnpj integer not null,
    codigo integer not null
);
create table tb_cliente (
	idCliente integer unique not null auto_increment primary key,
    nome varchar(100) not null,
    cpf integer not null
);
create table tb_agencia (
	idAgencia integer unique not null auto_increment primary key,
    codigo integer not null,
    gerente varchar(100) not null,
    telefone varchar(14) not null
);
create table tb_conta (
	idConta integer unique not null auto_increment primary key,
    numConta integer not null,
    idCliente integer
);
create table tb_endereco (
	idEndereco integer unique not null auto_increment primary key,
	rua varchar(100) not null,
    numRua tinyint not null,
    cidade varchar(100) not null,
    estado varchar(50) not null
);
