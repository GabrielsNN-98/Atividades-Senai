drop table tb_boletim;


create table if not exists tb_boletim(

idBoletim integer primary key not null,
idAluno integer,
idDisciplina integer,
constraint idAlunoPFK foreign key (idAluno) references tb_aluno (idAluno),
constraint idDisciplinaPFK foreign key (idDisciplina) references tb_disciplina (idDisciplina),
Nota_1 double not null,
Nota_2 double not null,
Nota_3 double not null,
Nota_4 double not null,
soma_Nota double not null,
Resultado varchar(15) not null

);

insert into tb_boletim (idBoletim, idAluno, idDisciplina, Nota_1, Nota_2, Nota_3, Nota_4)  values (1,3,6,5,1,8,10);
insert into tb_boletim (idBoletim, idAluno, idDisciplina, Nota_1, Nota_2, Nota_3, Nota_4)  values (2,1,4,6,9,10,5);
insert into tb_boletim (idBoletim, idAluno, idDisciplina, Nota_1, Nota_2, Nota_3, Nota_4)  values (3,7,10,5,10,7,4);
insert into tb_boletim (idBoletim, idAluno, idDisciplina, Nota_1, Nota_2, Nota_3, Nota_4)  values (4,2,5,1,8,3,7);
insert into tb_boletim (idBoletim, idAluno, idDisciplina, Nota_1, Nota_2, Nota_3, Nota_4)  values (5,4,7,6,9,5,2);
insert into tb_boletim (idBoletim, idAluno, idDisciplina, Nota_1, Nota_2, Nota_3, Nota_4)  values (6,6,9,7,1,5,6);
insert into tb_boletim (idBoletim, idAluno, idDisciplina, Nota_1, Nota_2, Nota_3, Nota_4)  values (7,5,8,5,6,9,4);
insert into tb_boletim (idBoletim, idAluno, idDisciplina, Nota_1, Nota_2, Nota_3, Nota_4)  values (8,8,1,8,7,8,9);
insert into tb_boletim (idBoletim, idAluno, idDisciplina, Nota_1, Nota_2, Nota_3, Nota_4)  values (9,10,2,10,10,7,3);
insert into tb_boletim (idBoletim, idAluno, idDisciplina, Nota_1, Nota_2, Nota_3, Nota_4)  values (10,9,3,7,6,3,10);