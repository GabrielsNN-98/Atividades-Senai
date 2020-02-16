-- Consultas

-- Utilizar uma operação matemática:
select round(preco-(preco*0.30),2) as 'Valores 30% de Desconto' from tb_produto;
-- Utilizar a função de soma (sum):
select idCliente, sum(valor_Parcial) as 'Valor Total' from tb_compra where idCliente=1;
-- Utilizar a função de média (avg):
select idCliente, round(avg(valor_Parcial),2) as 'Média dos valores pagos em compras por Cliente' from tb_compra where idCliente=1; 
-- Utilizar a função 'count':
select count(qtd_Produto) as 'Total de produtos vendidos até o momento' from tb_compra;
-- Utilizar a função 'group by':
select idCliente, sum(valor_Parcial) from tb_compra group by idCliente;
-- Utilizar 'having':
select* from tb_categoria group by idCategoria having qtd_Produto < 150;
-- Utilizar 'order by':
select* from tb_compra order by _Data;
-- Utilizar 'inner join':
select nome_Cliente as Cliente,
cpf as CPF,
nome_Prod as Produto,
qtd_Produto as Quantidade,
valor_Parcial as Valor,
Hora as 'Hora da Compra',
_Data as 'Data da Compra'
from tb_compra as tbco 
inner join tb_cliente as tbcl
on tbco.idCliente = tbcl.idCliente 
inner join tb_produto as tbp on tbco.idProduto = tbp.idProduto
where valor_Parcial<2550 order by Produto;
-- Utilizar 'left join':
select nome_Prod as Produto,
nome as Categoria,
preco as 'Preço do Produto' from tb_produto as tbp 
left join tb_categoria as tbc on tbp.idCategoria = tbc.idCategoria
order by Produto;
-- Utilizar 'where com and':





 
