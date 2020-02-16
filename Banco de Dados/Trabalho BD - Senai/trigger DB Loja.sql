delimiter ##

create trigger atualizar_before_update before update
on tb_compra for each row
begin
	set new.valor_Parcial = (select preco from tb_produto where idProduto=new.idProduto) * new.qtd_Produto;
end;

##
delimiter ;
