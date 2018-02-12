CREATE TABLE [dbo].[Respondent] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [User]     NVARCHAR (50)  NOT NULL,
    [Password] NVARCHAR (250) NOT NULL,
    [Email]    NVARCHAR (250) NULL,
    [WorksFor] INT            NOT NULL,
    [Role]     INT            NOT NULL,
    [Salary]   MONEY          NOT NULL,
    CONSTRAINT [PK_Encuestado] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Respondent_Company] FOREIGN KEY ([WorksFor]) REFERENCES [dbo].[Company] ([ID]),
    CONSTRAINT [FK_Respondent_Position] FOREIGN KEY ([Role]) REFERENCES [dbo].[Position] ([ID])
);

