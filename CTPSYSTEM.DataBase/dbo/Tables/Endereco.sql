CREATE TABLE [dbo].[Endereco] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [IdEstado]  INT            NOT NULL,
    [Cidade]    NVARCHAR (MAX) NULL,
    [Rua]       NVARCHAR (MAX) NULL,
    [numero]    INT            NOT NULL,
    [Sala]      NVARCHAR (MAX) NULL,
    [EmpresaId] INT            NULL,
    CONSTRAINT [PK_Endereco] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Endereco_Empresa_EmpresaId] FOREIGN KEY ([EmpresaId]) REFERENCES [dbo].[Empresa] ([Id]),
    CONSTRAINT [FK_Estado_Endereco] FOREIGN KEY ([IdEstado]) REFERENCES [dbo].[Estado] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Endereco_EmpresaId]
    ON [dbo].[Endereco]([EmpresaId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Endereco_IdEstado]
    ON [dbo].[Endereco]([IdEstado] ASC);

