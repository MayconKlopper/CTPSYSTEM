CREATE TABLE [dbo].[EmpresaHistorico] (
    [Id]            INT                IDENTITY (1, 1) NOT NULL,
    [IdFuncionario] INT                NULL,
    [IdEmpresa]     INT                NOT NULL,
    [CNPJ]          NVARCHAR (MAX)     NULL,
    [NomeFantasia]  NVARCHAR (MAX)     NULL,
    [RazaoSocial]   NVARCHAR (MAX)     NULL,
    [Data]          DATETIMEOFFSET (7) NOT NULL,
    CONSTRAINT [PK_EmpresaHistorico] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Funcionario_EmpresaHistorico] FOREIGN KEY ([IdFuncionario]) REFERENCES [dbo].[Funcionario] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_EmpresaHistorico_IdFuncionario]
    ON [dbo].[EmpresaHistorico]([IdFuncionario] ASC);

