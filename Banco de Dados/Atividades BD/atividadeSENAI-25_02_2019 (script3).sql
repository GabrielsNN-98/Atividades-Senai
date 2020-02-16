select Sexo, count(Sexo) as Quantidade from tb_medicos group by Sexo;
-- Questão 1
select* from tb_pacientes;
-- Questão 2
select NomeMed as 'Nome do Médico', CPF_Med 'CPF' from tb_medicos where Idade_Med<40 or Especialidade!='Traumatologia';
-- Questão 3
select NomeMed as 'Nome do Médico', NomePac as 'Nome do Paciente', _Data, Hora from tb_consultas as tbc 
inner join tb_pacientes as tbp on tbc.CodPac=tbp.CodPac 
inner join tb_medicos as tbm on tbc.CodMed=tbm.CodMed 
where _Data>'19/10/2010' and Hora>'12:00' and Hora<'18:30';
-- Questão 4
select NomePac as 'Nome do Paciente', Idade_Pac as 'Idade' from tb_pacientes where cidade='Florianópolis';
-- Questão 5
select NomePac as 'Nome do Paciente', Idade_Pac as 'Idade' from tb_pacientes where cidade!='Florianópolis';
-- Questão 6
select NomePac as 'Nome do Paciente', Idade_Pac as 'Idade' from tb_pacientes;
-- Questão 7
select Cidade from tb_funcionarios;
-- Questão 8
select min(Salario) as 'Menor Salário', max(Salario) as 'Maior Salário' from tb_funcionarios;
-- Questão 9
select round(avg (Salario),2)  as 'Média Salarial' from tb_funcionarios;
-- Questão 10
select round(avg (Idade_Med),2) as 'Média de Idade' from tb_medicos;
-- Questão 11
select NomeMed as 'Nome do Médico', count(NroA) as Quantidade from tb_medicos group by NomeMed; 
-- Questão 12 
select NomeFunc as 'Nome do Funcionário' from tb_funcionarios where NomeFunc like '%a';
-- Questão 13 - Já feita
-- Questão 14
select CodPac, NomePac as 'Nome do Paciente' from tb_pacientes where Idade_Pac>25 and (Doenca='Tendinite' or Doenca='Sarampo' or Doenca='Gripe');
-- Questão 15
select* from tb_consultas
inner join tb_pacientes on tb_consultas.CodPac=tb_pacientes.CodPac
where NomePac='Carlos';
-- Questão 16
select NomeMed as 'Nome do Médico' from tb_medicos
inner join tb_consultas on tb_consultas.CodMed=tb_medicos.CodMed
inner join tb_pacientes on tb_consultas.CodPac=tb_pacientes.CodPac
where NomePac='Ana';
-- Questão 17
select* from tb_pacientes
left join tb_consultas on tb_pacientes.CodPac=tb_consultas.CodPac
where CodConsul is null;
-- Questão 18
-- Questão 19 
-- Questão 20, faltam as consultas anteriores
select count(*)  as 'Quantidade de Consultas' from tb_consultas;
-- Questão 21
select max(NroA) as 'Ambulatório de Maior Capacidade' from tb_ambulatorios;
-- Questão 22
select min(NroA) as 'Ambulatório de Menor Capacidade' from tb_ambulatorios;
-- Questão 23
select sum(Capacidade) as 'Capacidade Total' from tb_ambulatorios;
-- Questão 24
select CodMed, NomeMed as 'Nome do Médico' from tb_medicos where NroA=(select NroA from tb_medicos where NomeMed='Pedro');
-- Questão 25
select NomePac as 'Nome do Paciente', CPF_Pac as 'CPF', Idade_Pac as 'Idade' from tb_pacientes
inner join tb_consultas on tb_pacientes.CodPac=tb_consultas.CodPac
inner join tb_medicos on tb_medicos.CodMed=tb_consultas.CodMed
where Especialidade='Pediatria';
-- Questão 26
select NomeFunc as 'Nome do Funcionário', Salario from tb_funcionarios where Cidade=(select cidade from tb_funcionarios where NomeFunc='Carlos'); 
-- Questão 27
select NomeMed as 'Nome do Médico', Idade_Med as 'Idade' from tb_medicos
inner join tb_consultas on tb_medicos.CodMed=tb_consultas.CodMed
where CodPac='1';
-- Questão 28
select NomeFunc as 'Nome do Funcionário', Salario from tb_funcionarios where Cidade=(select cidade from tb_funcionarios where NomeFunc='Carlos') 
and Salario>(select salario from tb_funcionarios where NomeFunc='Carlos');

-- Questão 29 (a ser feita)






