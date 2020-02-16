-- Parte 2: Inserção dos registros

insert into tb_aluno values (1,'Gabriel Sousa',21,15385069702,6);
insert into tb_aluno values (2,'Matheus Henrique',17,13866578903,10);
insert into tb_aluno values (3,'Breno Carvalho',29,13671230201,7);
insert into tb_aluno values (4,'Letícia Viana',15,14474552004,3);
insert into tb_aluno values (5,'Enom Resende',22,18788530002,1);
insert into tb_aluno values (6,'Patrick Bertioga',18,11200214501,4);
insert into tb_aluno values (7,'Eliane Silva',25,18925600103,8);
insert into tb_aluno values (8,'Matheus Bueno',19,17501288903,5);
insert into tb_aluno values (9,'Estéfano Júnior',14,14548572903,9);
insert into tb_aluno values (10,'Lorraine Santos',30,19014955001,2);

insert into tb_disciplina values (1,5,'Matemática',150);
insert into tb_disciplina values (2,9,'Português',150);
insert into tb_disciplina values (3,6,'História',150);
insert into tb_disciplina values (4,2,'Geografia',150);
insert into tb_disciplina values (5,10,'Biologia',150);
insert into tb_disciplina values (6,3,'Física',100);
insert into tb_disciplina values (7,7,'Química',100);
insert into tb_disciplina values (8,4,'Sociologia',75);
insert into tb_disciplina values (9,8,'Inglês',75);
insert into tb_disciplina values (10,1,'Espanhol',75);

insert into tb_professor values (1,'Daniel',2564.50);
insert into tb_professor values (2,'Marcela',2896.00);
insert into tb_professor values (3,'Rosângela',2157.89);
insert into tb_professor values (4,'Pedro',1489.52);
insert into tb_professor values (5,'João',1899.23);
insert into tb_professor values (6,'Mariana',2642.14);
insert into tb_professor values (7,'Nilton',1699.76);
insert into tb_professor values (8,'Joana',1756.86);
insert into tb_professor values (9,'Gérson',1923.92);
insert into tb_professor values (10,'Thaís',2430.00);

insert into tb_turma values (1,'M501',30,'Manhã');
insert into tb_turma values (2,'M502',30,'Manhã');
insert into tb_turma values (3,'M503',30,'Manhã');
insert into tb_turma values (4,'M504',30,'Manhã');
insert into tb_turma values (5,'T501',30,'Tarde');
insert into tb_turma values (6,'T502',30,'Tarde');
insert into tb_turma values (7,'T503',30,'Tarde');
insert into tb_turma values (8,'T504',30,'Tarde');
insert into tb_turma values (9,'N501',30,'Noite');
insert into tb_turma values (10,'N502',30,'Noite');

insert into tb_aluno_disciplina values (3,6,5,1,8,10,24);
insert into tb_aluno_disciplina values (1,4,1,3,2,9,15);
insert into tb_aluno_disciplina values (7,10,5,10,7,4,26);
insert into tb_aluno_disciplina values (2,5,1,8,3,7,19);
insert into tb_aluno_disciplina values (4,7,6,9,5,2,22);
insert into tb_aluno_disciplina values (6,9,7,1,5,6,19);
insert into tb_aluno_disciplina values (5,8,5,6,9,4,24);
insert into tb_aluno_disciplina values (8,1,8,7,8,9,32);
insert into tb_aluno_disciplina values (10,2,10,10,7,3,30);
insert into tb_aluno_disciplina values (9,3,7,6,3,10,26);

update tb_aluno_disciplina set Nota_1 = 6 where idAluno=1 and idDisciplina=4;
update tb_aluno_disciplina set Nota_2 = 9 where idAluno=1 and idDisciplina=4;
update tb_aluno_disciplina set Nota_3 = 10 where idAluno=1 and idDisciplina=4;
update tb_aluno_disciplina set Nota_4 = 5 where idAluno=1 and idDisciplina=4;
update tb_aluno_disciplina set soma_Nota = 30 where idAluno=1 and idDisciplina=4;
