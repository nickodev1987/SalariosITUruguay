CREATE TABLE [dbo].[Company] (
    [ID]          INT            IDENTITY (1, 1) NOT NULL,
    [CompanyName] NVARCHAR (250) NOT NULL,
    CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED ([ID] ASC)
);

