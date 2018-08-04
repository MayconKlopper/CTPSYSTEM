CREATE TABLE [dbo].[ContratoTrabalho] (
    [Id]                 INT                IDENTITY (1, 1) NOT NULL,
    [IdCarteiraTrabalho] INT                NOT NULL,
    [IdEmpresa]          INT                NOT NULL,
    [Cargo]              NVARCHAR (MAX)     NULL,
    [CBONumero]          INT                NOT NULL,
    [DataAdmissao]       DATETIMEOFFSET (7) NOT NULL,
    [DataSaida]          DATETIMEOFFSET (7) NOT NULL,
    [Remuneracao]        DECIMAL (18, 2)    NOT NULL,
    [RemuneracaoExtenso] NVARCHAR (MAX)     NULL,
    [FlsFicha]           INT                NOT NULL,
    [RegistroNumero]     INT                NOT NULL,
    [EmpresaId]          INT                NULL,
    [CarteiraTrabalhoId] INT                NULL,
    CONSTRAINT [PK_ContratoTrabalho] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ContratoTrabalho_CarteiraTrabalho_CarteiraTrabalhoId] FOREIGN KEY ([CarteiraTrabalhoId]) REFERENCES [dbo].[CarteiraTrabalho] ([Id]),
    CONSTRAINT [FK_ContratoTrabalho_Empresa_EmpresaId] FOREIGN KEY ([EmpresaId]) REFERENCES [dbo].[Empresa] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_ContratoTrabalho_CarteiraTrabalhoId]
    ON [dbo].[ContratoTrabalho]([CarteiraTrabalhoId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_ContratoTrabalho_EmpresaId]
    ON [dbo].[ContratoTrabalho]([EmpresaId] ASC);

