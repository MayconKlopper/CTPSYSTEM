CREATE TABLE [dbo].[Internacao] (
    [Id]                 INT                IDENTITY (1, 1) NOT NULL,
    [IdCarteiraTrabalho] INT                NOT NULL,
    [Hospital]           NVARCHAR (MAX)     NULL,
    [Registro]           NVARCHAR (MAX)     NULL,
    [Matricula]          NVARCHAR (MAX)     NULL,
    [DataInternacao]     DATETIMEOFFSET (7) NOT NULL,
    [DataAlta]           DATETIMEOFFSET (7) NOT NULL,
    CONSTRAINT [PK_Internacao] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CarteiraTrabalho_Internacao] FOREIGN KEY ([IdCarteiraTrabalho]) REFERENCES [dbo].[CarteiraTrabalho] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Internacao_IdCarteiraTrabalho]
    ON [dbo].[Internacao]([IdCarteiraTrabalho] ASC);

