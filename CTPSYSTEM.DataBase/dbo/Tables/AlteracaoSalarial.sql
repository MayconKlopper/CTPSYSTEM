CREATE TABLE [dbo].[AlteracaoSalarial] (
    [Id]                 INT             IDENTITY (1, 1) NOT NULL,
    [IdContratoTrabalho] INT             NOT NULL,
    [DataAumento]        DATETIME2 (7)   NOT NULL,
    [Remuneracao]        DECIMAL (18, 2) NOT NULL,
    [RemuneracaoExtenso] NVARCHAR (MAX)  NULL,
    [Cargo]              NVARCHAR (MAX)  NULL,
    [Motivo]             NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_AlteracaoSalarial] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ContratoTrabalho_AlteracaoSalarial] FOREIGN KEY ([IdContratoTrabalho]) REFERENCES [dbo].[ContratoTrabalho] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_AlteracaoSalarial_IdContratoTrabalho]
    ON [dbo].[AlteracaoSalarial]([IdContratoTrabalho] ASC);

