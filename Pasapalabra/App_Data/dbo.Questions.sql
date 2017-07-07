CREATE TABLE [dbo].[Questions] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Description] NVARCHAR (255) NOT NULL,
    [RightAnswer] NVARCHAR (30)  NOT NULL,
    [Letter]      NVARCHAR (1)   NOT NULL,
    [IsCorrect]   BIT            NULL,
    CONSTRAINT [PK_dbo.Questions] PRIMARY KEY CLUSTERED ([Id] ASC)
);

