CREATE TABLE [dbo].[Estado] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [Nome]  NVARCHAR (MAX) NULL,
    [Sigla] VARCHAR (1)    NOT NULL,
    CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED ([Id] ASC)
);

