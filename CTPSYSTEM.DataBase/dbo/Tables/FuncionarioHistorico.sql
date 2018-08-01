CREATE TABLE [dbo].[FuncionarioHistorico] (
    [Id]            INT                IDENTITY (1, 1) NOT NULL,
    [IdEmpresa]     INT                NULL,
    [IdFuncionario] INT                NOT NULL,
    [Nome]          NVARCHAR (MAX)     NULL,
    [CPF]           NVARCHAR (MAX)     NULL,
    [Data]          DATETIMEOFFSET (7) NOT NULL,
    CONSTRAINT [PK_FuncionarioHistorico] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Empresa_FuncionarioHistorico] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[Empresa] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_FuncionarioHistorico_IdEmpresa]
    ON [dbo].[FuncionarioHistorico]([IdEmpresa] ASC);

