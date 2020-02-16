insert into tb_ator values (1, 'Clint Eastwood', 'Masculino');
insert into tb_ator values (2, 'Sean Penn', 'Masculino');
insert into tb_ator values (3, 'Emile Hirsch', 'Masculino');
insert into tb_ator values (4, 'Mel Gibson', 'Masculino');
insert into tb_ator values (5, 'Taika Waititi', 'Masculino');
insert into tb_ator values (6, 'Selton Mello', 'Masculino');

insert into tb_filme values (1, 'Sobre Meninos e Lobos', '137 Minutos', '14', '21/11/2003',2, 1, 1);
insert into tb_filme values (2, 'Na Natureza Selvagem', '148 Minutos', '12', '27/10/2007', 3, 2, 2);
insert into tb_filme values (3, 'Os Imperdoáveis', '131 Minutos', '16', '23/10/1992', 1, 1, 3);
insert into tb_filme values (4, 'Coração Valente', '177 Minutos', '16', '14/07/1995', 4, 4, 4); 
insert into tb_filme values (5, 'O Que Fazemos nas Sombras', '85 Minutos', '16', '19/06/2014', 5, 5, 5);
insert into tb_filme values (6, 'O Palhaço', '90 Minutos', 10, '28/10/2011', 6, 6, 1); 

insert into tb_genero values (1, 'Drama');
insert into tb_genero values (2, 'Aventura');
insert into tb_genero values (3, 'Faroeste');
insert into tb_genero values (4, 'Épico');
insert into tb_genero values (5, 'Comédia');

insert into tb_cinema values (1, 100, 'São Paulo - SP', 2);
insert into tb_cinema values (2, 75, 'Belo Horizonte - MG', 4);
insert into tb_cinema values (3, 80, 'Curitiba - PR', 6);
insert into tb_cinema values (4, 50, 'Rio de Janeiro - RJ', 1);
insert into tb_cinema values (5, 85, 'Salvador - BA', 5);

insert into tb_filme_estrangeiro values ('Delart', 'Americano', 1, 1, 1);
insert into tb_filme_estrangeiro values ('Herbert Richers', 'Americano', 2, 2, 2);
insert into tb_filme_estrangeiro values ('Herbert Richers', 'Americano', 3, 1, 3);
insert into tb_filme_estrangeiro values ('Herbert Richers', 'Americano', 4, 4, 4);
insert into tb_filme_estrangeiro values ('UniDub', 'Neozelândes', 5, 5, 5);

insert into tb_filme_nacional values (6, 6, 1);

-- A Listar todos os dados de uma tabela;
select * from tb_ator;

-- B Listar dados específicos de uma tabela;
select nome_Ator,sexo_Ator from tb_ator;

-- C Listar dados de uma tabela restringindo linhas (WHERE com operadores de lógicos)
select Duracao,Classificacao_Ind from tb_filme
where Duracao > 130 and Classificacao_Ind > 14;

-- D Listar dados utilizando operadores lógicos (E, OU, NOT)
select Duracao,Classificacao_Ind from tb_filme
where Duracao < 130 and Classificacao_Ind = 16;

select Duracao,Classificacao_Ind from tb_filme
where Duracao < 130 or Classificacao_Ind = 16;

select Duracao,Classificacao_Ind from tb_filme
where Duracao < 130 and not Classificacao_Ind = 16;

-- E Listar dados utilizando operações básicas: +,-* e /

select Capacidade + 200 as 'Capacidade_+_200' from tb_cinema;

select Capacidade - 78 as 'Capacidade_-_78' from tb_cinema;

select Capacidade * 2 as 'Capacidade_*_2' from tb_cinema;

select Capacidade / 4 as 'Capacidade_/_4' from tb_cinema;

-- F Listar dados utilizando operadores BETWEEN e NOT BETWEEN

select Capacidade from tb_cinema where Capacidade between '80' and '100';

select Capacidade from tb_cinema where Capacidade not between '80' and '100';

-- G Listar dados utilizando operadores LIKE e NOT LIKE

select estudio_Dublagem from tb_filme_estrangeiro  where estudio_Dublagem like 'h%';

select estudio_Dublagem from tb_filme_estrangeiro  where estudio_Dublagem not like 'h%';

-- H Listar dados utilizando operadores IN e NOT IN

select Capacidade from tb_cinema where Capacidade in (50,85);

select Capacidade from tb_cinema where Capacidade not in (50,85);

-- I Listar dados empregando ordenação: ORDER BY
select Classificacao_Ind, nome_Filme from tb_filme
order by Classificacao_Ind desc, nome_Filme asc;

-- J Listar dados empregando funções de Agregação (SUM, COUNT, MAX, MIN, AVG)
select sum(Duracao) from tb_filme ;

select count(*) from tb_filme where Duracao <130; 

select nome_Filme, max(Duracao) from tb_filme where Classificacao_Ind = '16';

select nome_Filme, min(Duracao) from tb_filme where Classificacao_Ind = '16';

select avg(Duracao) from tb_filme;

-- k Retornar apenas um item de cada para evitar repetição desnecessária com o DISTINCT

select distinct Nacionalidade from tb_filme_estrangeiro order by Nacionalidade;






