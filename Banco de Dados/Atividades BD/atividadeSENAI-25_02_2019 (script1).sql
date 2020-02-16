create database Clinica;
use Clinica;
create table Ambulatorios (
	NroA int(3) primary key unique auto_increment,
    Andar int(2) not null,
    Capacidade int(3) not null
);
create table Medicos (
	CodMed int(3) primary key unique auto_increment,
    NomeMed varchar(40) not null,
    Idade integer(2) not null,
    CPF char(14) unique,
    Cidade varchar(30) not null,
    Especialidade varchar(50) not null,
    NroA int(3)
);
create table Pacientes (
	CodPac int(3) primary key unique auto_increment,
    NomePac varchar(40) not null,
    Idade int(2) not null,
    CPF char(14) unique,
    Cidade varchar(30) not null,
    Doenca varchar(50)
);
create table Funcionarios (
	CodFunc int(3) primary key unique auto_increment,
    NomeFunc varchar(40) not null,
    Idade int(2) not null,
    CPF char(14),
    Cidade varchar(30) not null,
    Salario int(6) not null
);
create table Consultas (
	CodConsul int(3) primary key unique auto_increment,
    CodMed int(3),
    CodPac int(3),
    _Data varchar(10),
    Hora varchar (5)
);
rename table ambulatorios to tb_ambulatorios, medicos to tb_medicos, pacientes to tb_pacientes, funcionarios to tb_funcionarios, consultas to tb_consultas;

