create database if not exists loja;
use loja;

create table tb_produto(

idProduto integer not null primary key,
nome_Prod varchar(80) not null,
preco decimal(6,2) not null,
idCategoria integer,
constraint idCategoriaFK foreign key (idCategoria) references tb_categoria (idCategoria)

);

create table tb_categoria(

idCategoria integer not null primary key,
nome varchar(65) not null,
qtd_Produto double not null
 
);

create table tb_cliente(

idCliente integer not null primary key,
nome_Cliente varchar(80) not null,
cpf varchar(12)

);

create table tb_compra(

idCompra integer not null primary key,
idProduto integer,
idCliente integer,
constraint idProdutoPFK foreign key (idProduto) references tb_produto (idProduto),
constraint idClientePFK foreign key (idCliente) references tb_cliente (idCliente),
qtd_Produto double not null,
valor_Parcial double not null,
_Data varchar(10) not null,
Hora varchar(5) not null,

);
