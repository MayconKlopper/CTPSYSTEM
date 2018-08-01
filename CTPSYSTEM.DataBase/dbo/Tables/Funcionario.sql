CREATE TABLE [dbo].[Funcionario] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [IdEmpresa] INT            NOT NULL,
    [Nome]      NVARCHAR (MAX) NULL,
    [CPF]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Empresa_Funcionario] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[Empresa] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Funcionario_IdEmpresa]
    ON [dbo].[Funcionario]([IdEmpresa] ASC);

