CREATE TABLE AJ_ALUNO (
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NOME varchar(200) NOT NULL,
	EMAIL varchar(250) NOT NULL,
	CPF varchar(11) NOT NULL,
	SENHA varchar(100) NOT NULL,
	IMAGEM varbinary(max) NULL,
	STATUS bit default(1) NOT NULL,
	DATA_CRIACAO datetime NOT NULL,
	USUARIO_CRIACAO varchar(200) NOT NULL,
	DATA_ALTERACAO datetime NULL,
	USUARIO_ALTERACAO varchar(200) NULL,
	)

CREATE TABLE AJ_CATEGORIA(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NOME varchar(200) NOT NULL,
	DESCRICAO varchar(MAX) NOT NULL,
	STATUS bit default(1) NOT NULL,
	DATA_CRIACAO datetime NOT NULL,
	USUARIO_CRIACAO varchar(200) NOT NULL,
	DATA_ALTERACAO datetime NULL,
	USUARIO_ALTERACAO varchar(200) NULL,
)


CREATE TABLE AJ_CURSO(
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ID_CATEGORIA INT NOT NULL,
	NOME varchar(200) NOT NULL,
	DESCRICAO varchar(MAX) NOT NULL,
	IMAGEM varbinary(max) NULL,
	STATUS bit default(1) NOT NULL,
	DATA_CRIACAO datetime NOT NULL,
	USUARIO_CRIACAO varchar(200) NOT NULL,
	DATA_ALTERACAO datetime NULL,
	USUARIO_ALTERACAO varchar(200) NULL,

	CONSTRAINT FK_CATEGORIA FOREIGN KEY (ID_CATEGORIA) REFERENCES AJ_CATEGORIA (ID)	
)

CREATE TABLE AJ_MODULO(
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NOME varchar(200) NOT NULL,
	DESCRICAO varchar(MAX) NOT NULL,
	STATUS bit default(1) NOT NULL,
	DATA_CRIACAO datetime NOT NULL,
	USUARIO_CRIACAO varchar(200) NOT NULL,
	DATA_ALTERACAO datetime NULL,
	USUARIO_ALTERACAO varchar(200) NULL,
)


CREATE TABLE AJ_CURSO_MODULO(
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ID_CURSO INT NOT NULL,
	ID_MODULO INT NOT NULL,
	STATUS bit default(1) NOT NULL,
	DATA_CRIACAO datetime NOT NULL,
	USUARIO_CRIACAO varchar(200) NOT NULL,
	DATA_ALTERACAO datetime NULL,
	USUARIO_ALTERACAO varchar(200) NULL,

	CONSTRAINT FK_CURSO FOREIGN KEY (ID_CURSO) REFERENCES  AJ_CURSO (ID),
	CONSTRAINT FK_MODULO FOREIGN KEY (ID_MODULO) REFERENCES  AJ_MODULO (ID)
)

CREATE TABLE AJ_TIPO_AULA (
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	NOME varchar(200) NOT NULL,
	STATUS bit default(1) NOT NULL,
	DATA_CRIACAO datetime NOT NULL,
	USUARIO_CRIACAO varchar(200) NOT NULL,
	DATA_ALTERACAO datetime NULL,
	USUARIO_ALTERACAO varchar(200) NULL,
)

create table AJ_AULA(
	ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ID_MODULO INT NOT NULL,
	ID_TIPO_AULA INT NOT NULL,
	NOME VARCHAR (MAX) NOT NULL,
	DESCRICAO VARCHAR(MAX) NOT NULL,
	ORDEM_AULA INT NOT NULL,
	VIDEO VARCHAR(MAX) NULL,
	TEXTO VARCHAR(MAX) NULL,
	NOME_ARQUIVO VARCHAR(MAX) NULL,
	TIPO_ARQUIVO VARCHAR(MAX) NULL,
	DATA VARBINARY(MAX) NULL
	
	CONSTRAINT FK_AULA_MODULO FOREIGN KEY (ID_MODULO) REFERENCES  AJ_MODULO (ID),
	CONSTRAINT FK_TIPO_AULA FOREIGN KEY (ID_TIPO_AULA) REFERENCES  AJ_TIPO_AULA (ID)
)