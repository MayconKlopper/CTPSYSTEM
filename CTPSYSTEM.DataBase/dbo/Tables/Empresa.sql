CREATE TABLE [dbo].[Empresa] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [CNPJ]         NVARCHAR (MAX) NULL,
    [NomeFantasia] NVARCHAR (MAX) NULL,
    [RazaoSocial]  NVARCHAR (MAX) NULL,
    [Seguimento]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED ([Id] ASC)
);

