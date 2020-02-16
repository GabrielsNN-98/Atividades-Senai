insert into tb_produto values (1,'Computador',2699.99,1);
insert into tb_produto values (2,'Tablet',850.65,1); 
insert into tb_produto values (3,'Fogão',1599.99,2); 
insert into tb_produto values (4,'Micro-Ondas',959.69,2); 
insert into tb_produto values (5,'Liquidificador',189.99,3); 
insert into tb_produto values (6,'Aspirador de Pó',289.90,3); 
insert into tb_produto values (7,'Sofá',388.99,4); 
insert into tb_produto values (8,'Guarda-Roupa',1250.80,4); 

insert into tb_categoria values (1,'Informática',100);
insert into tb_categoria values (2,'Eletrodomésticos',100);
insert into tb_categoria values (3,'Eletroportáteis',100);
insert into tb_categoria values (4,'Móveis',100);

insert into tb_cliente values (1,'Gabriel','15698760001');
insert into tb_cliente values (2,'Ana Luiza','18965212001');
insert into tb_cliente values (3,'Alex','14620085002');
insert into tb_cliente values (4,'Vitória','13685290003');

insert into tb_compra (idCompra, idProduto, idCliente, qtd_Produto,_Data, Hora) values (1,6,3,2,'15/01/2019','15:46');
insert into tb_compra (idCompra, idProduto, idCliente, qtd_Produto,_Data, Hora) values (2,2,3,3,'15/01/2019','15:46');
insert into tb_compra (idCompra, idProduto, idCliente, qtd_Produto,_Data, Hora) values (3,1,1,2,'09/05/2018','20:39');
insert into tb_compra (idCompra, idProduto, idCliente, qtd_Produto,_Data, Hora) values (4,4,1,1,'10/03/2019','10:42');
insert into tb_compra (idCompra, idProduto, idCliente, qtd_Produto,_Data, Hora) values (5,3,2,3,'05/06/2017','21:19');
insert into tb_compra (idCompra, idProduto, idCliente, qtd_Produto,_Data, Hora) values (6,8,2,2,'05/06/2017','21:19');
insert into tb_compra (idCompra, idProduto, idCliente, qtd_Produto,_Data, Hora) values (7,5,4,1,'19/03/2019','09:42');
insert into tb_compra (idCompra, idProduto, idCliente, qtd_Produto,_Data, Hora) values (8,7,4,1,'10/01/2019','18:10');

