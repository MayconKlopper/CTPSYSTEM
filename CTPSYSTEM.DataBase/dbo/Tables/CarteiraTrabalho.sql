CREATE TABLE [dbo].[CarteiraTrabalho] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [IdFuncionario]     INT            NOT NULL,
    [IdLocalNascimento] INT            NOT NULL,
    [Numero]            INT            NOT NULL,
    [Serie]             NVARCHAR (MAX) NULL,
    [DataEmissao]       DATETIME2 (7)  NOT NULL,
    [Foto]              NVARCHAR (MAX) NULL,
    [FiliacaoPai]       NVARCHAR (MAX) NULL,
    [FiliacaoMae]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_CarteiraTrabalho] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Funcionario_CarteiraTrabalho] FOREIGN KEY ([IdFuncionario]) REFERENCES [dbo].[Funcionario] ([Id]),
    CONSTRAINT [FK_LocalNascimento_CarteiraTrabalho] FOREIGN KEY ([IdLocalNascimento]) REFERENCES [dbo].[LocalNascimento] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_CarteiraTrabalho_IdFuncionario]
    ON [dbo].[CarteiraTrabalho]([IdFuncionario] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_CarteiraTrabalho_IdLocalNascimento]
    ON [dbo].[CarteiraTrabalho]([IdLocalNascimento] ASC);

