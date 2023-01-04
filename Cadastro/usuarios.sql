--create database usuarios
--use usuarios

create table tblPessoas (
	codPessoa int,
	nome varchar,
	telefone varchar,
	rua varchar,
	bairro varchar,
	numCasa int
)

select * from tblPessoas