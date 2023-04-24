-- db_a98226_servicos.dbo.Clientes definition

-- Drop table

-- DROP TABLE db_a98226_servicos.dbo.Clientes;

CREATE TABLE db_a98226_servicos.dbo.Clientes (
	Id int IDENTITY(1,1) NOT NULL,
	cpf nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Telefone nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Logradouro nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Bairro nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Numero nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Cidade nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	UF nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CEP nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	UsuarioId int NOT NULL,
	CONSTRAINT PK_Clientes PRIMARY KEY (Id)
);


-- db_a98226_servicos.dbo.Fornecedores definition

-- Drop table

-- DROP TABLE db_a98226_servicos.dbo.Fornecedores;

CREATE TABLE db_a98226_servicos.dbo.Fornecedores (
	Id int IDENTITY(1,1) NOT NULL,
	cpf nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Telefone nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Logradouro nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Bairro nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Numero nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Cidade nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	UF nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CEP nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	UsuarioId int NOT NULL,
	CONSTRAINT PK_Fornecedores PRIMARY KEY (Id)
);


-- db_a98226_servicos.dbo.Orçamento definition

-- Drop table

-- DROP TABLE db_a98226_servicos.dbo.Orçamento;

CREATE TABLE db_a98226_servicos.dbo.Orçamento (
	Id int IDENTITY(1,1) NOT NULL,
	Pedido nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ValorOrcamento nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Fornecedor nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	orcamentoAprovado nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Data] nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK_Orçamento PRIMARY KEY (Id)
);


-- db_a98226_servicos.dbo.Pedidos definition

-- Drop table

-- DROP TABLE db_a98226_servicos.dbo.Pedidos;

CREATE TABLE db_a98226_servicos.dbo.Pedidos (
	Id int IDENTITY(1,1) NOT NULL,
	Cliente nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	TipoServico nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Descricao nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	UsuarioId int NOT NULL,
	CONSTRAINT PK_Pedidos PRIMARY KEY (Id)
);


-- db_a98226_servicos.dbo.TipoServico definition

-- Drop table

-- DROP TABLE db_a98226_servicos.dbo.TipoServico;

CREATE TABLE db_a98226_servicos.dbo.TipoServico (
	Id int IDENTITY(1,1) NOT NULL,
	descricaoServico nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK_TipoServico PRIMARY KEY (Id)
);


-- db_a98226_servicos.dbo.servico definition

-- Drop table

-- DROP TABLE db_a98226_servicos.dbo.servico;

CREATE TABLE db_a98226_servicos.dbo.servico (
	Id int IDENTITY(1,1) NOT NULL,
	NomeServico nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DescricaoServico nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Orcamento nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ValorEstimadoServico nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DataAprovacaoOrcamento nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	DataConclusaoDoServico nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK_servico PRIMARY KEY (Id)
);


-- db_a98226_servicos.dbo.usuarios definition

-- Drop table

-- DROP TABLE db_a98226_servicos.dbo.usuarios;

CREATE TABLE db_a98226_servicos.dbo.usuarios (
	Id int IDENTITY(1,1) NOT NULL,
	Nome nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Email nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Senha nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Role] nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS DEFAULT N'' NOT NULL,
	CONSTRAINT PK_usuarios PRIMARY KEY (Id)
);