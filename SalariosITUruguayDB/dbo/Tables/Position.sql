CREATE TABLE [dbo].[Position] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Position] NVARCHAR (250) NOT NULL,
    CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED ([ID] ASC)
);

