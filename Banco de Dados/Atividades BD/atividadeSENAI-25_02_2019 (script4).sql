/* TRANSAÇÕES */

select* from tb_funcionarios where CodFunc=2;

start transaction;
update tb_funcionarios set salario=2000
where CodFunc=2;
rollback;
