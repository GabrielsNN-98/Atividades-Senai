-- Parte 3: Consultas no banco

-- Consulta 1
select Nome, carga_Horaria from tb_disciplina order by Nome asc;
-- Consulta 2
select tba.idAluno, nome_Aluno as 'Nome do Aluno' from tb_aluno as tba 
left join tb_aluno_disciplina as tbad on tba.idAluno=tbad.idAluno
where tbad.idAluno is null;
-- Consulta 3
select idAluno as 'Código', nome_Aluno as 'Nome do Aluno', Idade 
from tb_aluno where Idade=(select max(Idade) from tb_aluno);
-- Consulta 4
select IdProfessor as 'Código', nome_Professor as 'Nome do Professor', Salario 
from tb_professor order by Salario desc;
-- Consulta 5
select Nome, Turno from tb_turma where qtd_Aluno<=15;
-- Consulta 6
select tba.nome_Aluno as 'Aluno', tbd.Nome as 'Disciplina', Nota_1 as 'Nota 1', Nota_2 as 'Nota 2', 
Nota_3 as 'Nota 3', Nota_4 as 'Nota 4', soma_Nota as 'Total' 
from tb_aluno as tba inner join tb_aluno_disciplina as tbad
on tba.idAluno=tbad.idAluno inner join tb_disciplina as tbd
on tbd.idDisciplina=tbad.idDisciplina where tba.idAluno=1;
-- Consulta 7
select tba.nome_Aluno as 'Aluno', tbd.Nome as 'Disciplina', Nota_1 as 'Nota 1', Nota_2 as 'Nota 2', 
Nota_3 as 'Nota 3', Nota_4 as 'Nota 4', soma_Nota as 'Total' 
from tb_aluno as tba inner join tb_aluno_disciplina as tbad
on tba.idAluno=tbad.idAluno inner join tb_disciplina as tbd
on tbd.idDisciplina=tbad.idDisciplina 
where tbad.soma_Nota=(select max(soma_nota) from tb_aluno_disciplina);
-- Consulta 8
select round((avg(Salario)),2) as 'Média Salarial dos Professores' from tb_professor;
-- Consulta 9
select sum(qtd_Aluno) as 'Total de Alunos' from tb_turma;
-- Consulta 10
select tba.nome_Aluno as Aluno, soma_Nota as Total, tbt.Nome as Turma, tbdisc.Nome as Disciplina, 
tbprof.nome_Professor as Professor from tb_professor as tbprof 
inner join tb_disciplina as tbdisc on tbprof.idProfessor=tbdisc.IdProfessor
inner join tb_aluno_disciplina as tbad on tbdisc.idDisciplina=tbad.idDisciplina
inner join tb_aluno as tba on tbad.idAluno=tba.idAluno
inner join tb_turma as tbt on tba.idTurma=tbt.idTurma
where tba.idAluno=1;
-- Consulta 11
select tbprof.nome_Professor as Professor, tbdisc.Nome as Disciplina, 
round((avg(soma_Nota)),1) as Media from tb_professor as tbprof
inner join tb_disciplina as tbdisc on tbprof.idProfessor=tbdisc.IdProfessor
inner join tb_aluno_disciplina as tbad on tbdisc.idDisciplina=tbad.idDisciplina
group by tbdisc.idDisciplina;
-- Consulta 12
select tb_aluno.nome_Aluno as Aluno from tb_aluno_disciplina
inner join tb_aluno on tb_aluno.idAluno=tb_aluno_disciplina.idAluno where 
soma_Nota>(select round((avg(soma_Nota)),1) from tb_aluno_disciplina 
inner join tb_aluno on tb_aluno.idAluno=tb_aluno_disciplina.idAluno where idTurma=2
group by idTurma);
