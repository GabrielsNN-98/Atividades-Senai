delimiter $$

create trigger atualizar_qtd_Aluno_after_insert after insert 
on tb_aluno for each row 
begin
	update tb_turma set qtd_Aluno = qtd_Aluno+1
    where tb_turma.idTurma=new.idTurma;
    
end
$$

delimiter ;