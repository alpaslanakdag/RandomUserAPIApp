CREATE TABLE [dbo].[User] (
    [ID]                 INT            IDENTITY (1, 1) NOT NULL,
    [Title]              NCHAR (10)     NULL,
    [FirstName]          NVARCHAR (50)  NULL,
    [LastName]           NVARCHAR (50)  NULL,
    [StreetName]         NVARCHAR (50)  NULL,
    [StreetNumber]       INT            NULL,
    [City]               NVARCHAR (50)  NULL,
    [Country]            NVARCHAR (50)  NULL,
    [PostCode]           NVARCHAR (50)  NULL,
    [Latitude]           FLOAT (53)     NULL,
    [Longtitude]         FLOAT (53)     NULL,
    [Email]              NVARCHAR (50)  NULL,
    [UuId]               INT            NULL,
    [UserName]           NVARCHAR (50)  NULL,
    [DateOfBirth]        DATE           NULL,
    [PictureThumbnail]   NVARCHAR (MAX) NOT NULL,
    [Picture]            NVARCHAR (MAX) NULL,
    [WikipediaArticleId] INT            NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_User_WikipediaArticle1] FOREIGN KEY ([WikipediaArticleId]) REFERENCES [dbo].[WikipediaArticle] ([ID])
);

