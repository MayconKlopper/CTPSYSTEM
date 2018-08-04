CREATE TABLE [dbo].[Licenca] (
    [Id]                 INT                IDENTITY (1, 1) NOT NULL,
    [IdCarteiraTrabalho] INT                NOT NULL,
    [DataInicio]         DATETIMEOFFSET (7) NOT NULL,
    [DataTermino]        DATETIMEOFFSET (7) NOT NULL,
    [Dias]               INT                NOT NULL,
    [CodigoPosto]        INT                NOT NULL,
    [Motivo]             NVARCHAR (MAX)     NULL,
    CONSTRAINT [PK_Licenca] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CarteiraTrabalho_Licenca] FOREIGN KEY ([IdCarteiraTrabalho]) REFERENCES [dbo].[CarteiraTrabalho] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Licenca_IdCarteiraTrabalho]
    ON [dbo].[Licenca]([IdCarteiraTrabalho] ASC);

