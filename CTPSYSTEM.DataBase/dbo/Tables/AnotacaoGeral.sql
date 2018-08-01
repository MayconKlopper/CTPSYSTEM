CREATE TABLE [dbo].[AnotacaoGeral] (
    [Id]                 INT            IDENTITY (1, 1) NOT NULL,
    [IdContratoTrabalho] INT            NOT NULL,
    [Texto]              NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_AnotacaoGeral] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ContratoTrabalho_AnotacaoGeral] FOREIGN KEY ([IdContratoTrabalho]) REFERENCES [dbo].[ContratoTrabalho] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_AnotacaoGeral_IdContratoTrabalho]
    ON [dbo].[AnotacaoGeral]([IdContratoTrabalho] ASC);

