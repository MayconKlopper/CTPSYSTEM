CREATE TABLE [dbo].[ContribuicaoSindical] (
    [Id]                 INT             IDENTITY (1, 1) NOT NULL,
    [IdContratoTrabalho] INT             NOT NULL,
    [ValorContribuicao]  DECIMAL (18, 2) NOT NULL,
    [NomeSindicato]      NVARCHAR (MAX)  NULL,
    [Ano]                INT             NOT NULL,
    CONSTRAINT [PK_ContribuicaoSindical] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ContratoTrabalho_ContribuicaoSindical] FOREIGN KEY ([IdContratoTrabalho]) REFERENCES [dbo].[ContratoTrabalho] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_ContribuicaoSindical_IdContratoTrabalho]
    ON [dbo].[ContribuicaoSindical]([IdContratoTrabalho] ASC);

