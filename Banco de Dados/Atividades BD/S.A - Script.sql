-- Parte 1: Criação do banco e das tabelas

drop database situacao_aprendizado;
create database if not exists situacao_aprendizado;
use situacao_aprendizado;
create table if not exists tb_aluno(

idAluno integer unique not null primary key,
nome_Aluno varchar(70) not null,
Idade tinyint not null,
CPF_Aluno double not null unique,
idTurma integer,
constraint idTurmaFK foreign key (idTurma) references tb_turma (idTurma)

);
create table if not exists tb_disciplina(

idDisciplina integer unique not null primary key,
Nome varchar(50) not null,
carga_Horaria int(4) not null,
IdProfessor integer,
constraint idProfessorFK foreign key (idProfessor) references tb_professor (idProfessor)

);
create table if not exists tb_turma(

idTurma integer unique not null primary key,
Nome varchar(60) not null,
qtd_Aluno integer not null,
Turno varchar(25) not null

);
create table if not exists tb_professor(

idProfessor integer unique not null primary key,
nome_Professor varchar(70) not null,
Salario decimal (8,2) not null

);
create table if not exists tb_aluno_disciplina(

soma_Nota decimal (2,2) not null,
Nota_1 decimal (2,2) not null,
Nota_2 decimal (2,2) not null,
Nota_3 decimal (2,2) not null,
Nota_4 decimal (2,2) not null,
idAluno integer,
idDisciplina integer,
constraint idAlunoPFK foreign key (idAluno) references tb_aluno (idAluno),
constraint idDisciplinaPFK foreign key (idDisciplina) references tb_disciplina (idDisciplina)

);


/* Ligações:tb_professortb_disciplina

Aluno para Turma: N - 1
Aluno para Disciplina: N - N (já criado)
Disciplina para Professor: N - 1
 
*/
