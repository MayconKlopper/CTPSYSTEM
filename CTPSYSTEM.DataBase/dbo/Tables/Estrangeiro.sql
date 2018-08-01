CREATE TABLE [dbo].[Estrangeiro] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [IdCarteiraTrabalho]  INT            NOT NULL,
    [Chegada]             DATETIME2 (7)  NOT NULL,
    [DocumentoIdentidade] NVARCHAR (MAX) NULL,
    [Expedicao]           DATETIME2 (7)  NOT NULL,
    [Estado]              NVARCHAR (MAX) NULL,
    [Observacao]          NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Estrangeiro] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CarteiraTrabalho_Estrangeiro] FOREIGN KEY ([IdCarteiraTrabalho]) REFERENCES [dbo].[CarteiraTrabalho] ([Id])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Estrangeiro_IdCarteiraTrabalho]
    ON [dbo].[Estrangeiro]([IdCarteiraTrabalho] ASC);

