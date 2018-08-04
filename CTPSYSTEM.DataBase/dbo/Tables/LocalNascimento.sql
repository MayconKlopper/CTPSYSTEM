CREATE TABLE [dbo].[LocalNascimento] (
    [Id]     INT            IDENTITY (1, 1) NOT NULL,
    [Cidade] NVARCHAR (MAX) NULL,
    [Estado] NVARCHAR (MAX) NULL,
    [Data]   DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_LocalNascimento] PRIMARY KEY CLUSTERED ([Id] ASC)
);

