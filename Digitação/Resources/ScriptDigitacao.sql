USE [digitacao]
GO
/****** Object:  Table [dbo].[aluno]    Script Date: 18/12/2018 22:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[aluno](
	[id_aluno] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[linhas] [int] NOT NULL,
	[licao] [int] NULL,
	[licaoFeitaEm] [datetime] NULL,
	[aproveitamento] [int] NULL,
	[tempoDecorrido] [int] NULL,
	[erros] [int] NULL,
	[toques] [int] NULL,
	[feita] [varchar](2100) NULL,
	[dataCad] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_aluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[aula]    Script Date: 18/12/2018 22:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[aula](
	[id_aula] [int] IDENTITY(1,1) NOT NULL,
	[aluno] [int] NOT NULL,
	[licao] [int] NOT NULL,
	[licaoFeitaEm] [datetime] NOT NULL,
	[aproveitamento] [int] NOT NULL,
	[tempoDecorrido] [int] NOT NULL,
	[erros] [int] NOT NULL,
	[toques] [int] NULL,
	[feita] [varchar](2100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_aula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[licoes]    Script Date: 18/12/2018 22:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[licoes](
	[id_licao] [int] NOT NULL,
	[numero] [int] NOT NULL,
	[licao] [varchar](70) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_licao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[aluno] ADD  DEFAULT ('0') FOR [licao]
GO
ALTER TABLE [dbo].[aluno] ADD  DEFAULT (getdate()) FOR [licaoFeitaEm]
GO
ALTER TABLE [dbo].[aluno] ADD  DEFAULT (NULL) FOR [aproveitamento]
GO
ALTER TABLE [dbo].[aluno] ADD  DEFAULT (NULL) FOR [tempoDecorrido]
GO
ALTER TABLE [dbo].[aluno] ADD  DEFAULT (NULL) FOR [erros]
GO
ALTER TABLE [dbo].[aluno] ADD  DEFAULT (NULL) FOR [toques]
GO
ALTER TABLE [dbo].[aluno] ADD  DEFAULT (NULL) FOR [feita]
GO
ALTER TABLE [dbo].[aluno] ADD  DEFAULT (getdate()) FOR [dataCad]
GO
ALTER TABLE [dbo].[aula] ADD  DEFAULT (NULL) FOR [toques]
GO
