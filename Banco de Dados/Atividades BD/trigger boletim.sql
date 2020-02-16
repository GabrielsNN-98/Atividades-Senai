delimiter $$

create trigger tb_boletim_before_update before update   
on tb_boletim for each row 
begin
	set new.soma_Nota= new.Nota_1 + new.Nota_2 + new.Nota_3 + new.Nota_4;
    
    if new.soma_Nota > 25 then 
		set new.Resultado = 'Aprovado';
    else
		set new.Resultado = 'Reprovado';
	end if;
    
end
$$

delimiter ;