------------------------------------- CRIAÇÃO DATABASE -------------------------------------
CREATE DATABASE INVESTMENTNOW
GO
USE INVESTMENTNOW
GO

------------------------------------- CRIAÇÃO DE TABELAS -------------------------------------
CREATE TABLE Cliente(

codCliente integer identity primary key Not null,

nome varchar(50) Not null,

cpf	varchar (11)	 Not null,

email	varchar (100) Not null,

celular 	varchar (11) Not null,	

senha varchar(12) Not null,

codConta integer
)




CREATE TABLE Conta_Bancaria(

codConta integer identity primary key Not null,

banco varchar(50) Not null,

agencia varchar(5) Not null,

conta varchar(15) Not null,

)




CREATE TABLE Carteira(

codCarteira integer identity primary key Not null,

endereco_carteira varchar (50) Not null,

saldo decimal(10,2) Not null,

codCliente integer,

)




CREATE TABLE Criptomoeda(

codMoeda integer identity primary key Not null,

nome_moeda varchar (50) Not null,

valor_moeda decimal(20,2) Not null,

status_moeda bit Not null
)




CREATE TABLE Tarifa(

codTarifa integer identity primary key Not null,

valor_tarifa decimal(10,2) Not null,

descricao_tarifa varchar (20) Not null,

)




CREATE TABLE Transacao(

codTransacao integer identity primary key Not null,

valor_investido decimal(10,2) Not null,

quantidade_moedas decimal(10,2) Not null,

codCarteira integer ,

codMoeda integer ,

codTarifa integer ,

codCliente integer
)



CREATE TABLE Rendimento(

codRendimento integer identity primary key Not null,

valor_rendimento decimal Not null,

codTransacao integer 
)




CREATE TABLE Funcionario (

codFunc integer identity primary key Not null,

nome varchar(50) Not null,

sexo varchar(50) Not null,

data_nasc date Not null,

data_admissao date Not null,

email varchar (100) Not null,

cpf	varchar (11)	 Not null,

celular 	varchar (11)	 Not null,

salario decimal (10,2) Not null,

cep	    varchar (8)	Not null,

uf	varchar	(2)	Not null,

cidade	varchar	(50)	Not null,

bairro	varchar	(50)	Not null,

logradouro	varchar	(100)	Not null,

num_residencia	varchar (10)	Not null,

status_func bit Not null

)

CREATE TABLE Login(

usuario varchar(50) Not null,

senha varchar(12) Not null
)

-------------------------------------- CONSTRAINTS -------------------------------------------

ALTER TABLE Cliente ADD CONSTRAINT Conta_Bancaria_Cliente_FK
FOREIGN KEY(CodConta) REFERENCES Conta_Bancaria(CodConta)

ALTER TABLE Carteira ADD CONSTRAINT Carteira_Cliente_FK
FOREIGN KEY(codCliente) REFERENCES Cliente(codCliente)

ALTER TABLE Transacao ADD CONSTRAINT Transacao_Carteira_FK
FOREIGN KEY(codCarteira) REFERENCES Carteira(codCarteira)

ALTER TABLE Transacao ADD CONSTRAINT Transacao_Cliente_FK
FOREIGN KEY(codCliente) REFERENCES Cliente(codCliente)

ALTER TABLE Transacao ADD CONSTRAINT Transacao_Criptomoeda_FK
FOREIGN KEY(codMoeda) REFERENCES Criptomoeda(codMoeda)

ALTER TABLE Transacao ADD CONSTRAINT Transacao_Tarifa_FK
FOREIGN KEY(codTarifa) REFERENCES Tarifa(codTarifa)

ALTER TABLE Rendimento ADD CONSTRAINT Rendimento_Transacao_FK
FOREIGN KEY(codTransacao) REFERENCES Transacao(codTransacao)


------------------------------------- Popular Base de Dados -------------------------------------

INSERT INTO Conta_Bancaria values ('Itaú', '6986', '189965')

INSERT INTO Cliente values ('Erik Rocha', '48067166958', 'eriksantos@gmail.com', '11954865952', 'senha123', 1 )

INSERT INTO Criptomoeda values ('Bitcoin', 1000.00, 1)

INSERT INTO Tarifa values ( 3.00 , 'Compra')

INSERT INTO Carteira values ('12W3JC715P2L', 1200.00, '1')

INSERT INTO Transacao values ( 3000.00, 3,'1','1','1', '1')

INSERT INTO Transacao values ( 100.00, 0.1,'1','1','1','1')

INSERT INTO Rendimento values (200.00,'1')

INSERT INTO Funcionario values ('Valdir da Silva','Masculino','25/02/1985','20/05/2020','valdirsilva@gmail.com', '48068988954','11954268568', 1500.00,
'06989569','SP','Osasco', 'Rochdalle','Rua das Flores','267', 1)

INSERT INTO Login VALUES('admin','12345')
