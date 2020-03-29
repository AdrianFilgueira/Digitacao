CREATE TABLE [dbo].[aluno] (
    [id_aluno]       INT            NOT NULL IDENTITY,
    [nome]           VARCHAR (100)  NOT NULL,
    [linhas]         INT            NOT NULL,
    [licao]          INT            DEFAULT ('0') NULL,
    [licaoFeitaEm]   DATETIME       DEFAULT (NULL) NULL,
    [aproveitamento] INT            DEFAULT (NULL) NULL,
    [tempoDecorrido] INT            DEFAULT (NULL) NULL,
    [erros]          INT            DEFAULT (NULL) NULL,
    [toques]         INT            DEFAULT (NULL) NULL,
    [feita]          VARCHAR (2100) DEFAULT (NULL) NULL,
    [dataCad]        DATETIME       DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([id_aluno] ASC)
);

