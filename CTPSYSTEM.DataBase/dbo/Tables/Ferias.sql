CREATE TABLE [dbo].[Ferias] (
    [Id]                 INT                IDENTITY (1, 1) NOT NULL,
    [IdContratoTrabalho] INT                NOT NULL,
    [PeriodoRelativo]    NVARCHAR (MAX)     NULL,
    [DataInicio]         DATETIMEOFFSET (7) NOT NULL,
    [DataTermino]        DATETIMEOFFSET (7) NOT NULL,
    [Dias]               INT                NOT NULL,
    CONSTRAINT [PK_Ferias] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ContratoTrabalho_Ferias] FOREIGN KEY ([IdContratoTrabalho]) REFERENCES [dbo].[ContratoTrabalho] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Ferias_IdContratoTrabalho]
    ON [dbo].[Ferias]([IdContratoTrabalho] ASC);

