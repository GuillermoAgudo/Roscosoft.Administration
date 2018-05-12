CREATE TABLE [dbo].[New] (
    [IdNew]       INT           IDENTITY (1, 1) NOT NULL,
    [Title]       VARCHAR (MAX) NOT NULL,
    [Description] VARCHAR (MAX) NOT NULL,
    [Author]      VARCHAR (150) NOT NULL,
    [Language]    INT           NOT NULL,
    [PublishDate] DATETIME      DEFAULT (getdate()) NOT NULL,
    [Category]    VARCHAR (MAX) NOT NULL
);

