CREATE database teste1
go

use teste
go

create table area(
cod int primary key,
nome varchar(100) 
);

create table precoVenda(
cod int primary key,
valor float not null,
data varchar(100) not null 
);

create table precoCompra(
cod int primary key,
valor float not null,
data varchar(100) not null 
);

create table produto(
cod int primary key,
nome varchar(100) not null,
descricao varchar(1000) not null,
tipo varchar(100) not null,
codArea int not null
);

create table produto_preco(
cod int primary key,
codProduto int not null,
codPrecoVenda int not null,
codPrecoCompra int not null
)
go

insert into area(cod,nome) values (1,'supermercado');
go
insert into area(cod,nome) values (2,'acougue');
go