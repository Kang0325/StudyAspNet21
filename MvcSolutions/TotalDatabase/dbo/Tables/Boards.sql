CREATE TABLE [dbo].[Boards] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Writer]    NVARCHAR (25)  NOT NULL,
    [Subject]   NVARCHAR (250) NULL,
    [Contents]  NVARCHAR (MAX) NOT NULL,
    [RegDate]   DATETIME       CONSTRAINT [DF_Boards_RegDate] DEFAULT (getdate()) NULL,
    [ReadCount] INT            NULL,
    CONSTRAINT [PK_Boards] PRIMARY KEY CLUSTERED ([Id] ASC)
);

