CREATE TABLE [dbo].[WikipediaArticle] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [Title]        NVARCHAR (MAX) NULL,
    [DisplayTitle] NVARCHAR (MAX) NULL,
    [PageID]       INT            NULL,
    [Description]  NVARCHAR (MAX) NULL,
    [Latitude]     FLOAT (53)     NULL,
    [Longtitude]   FLOAT (53)     NULL,
    [URL]          NVARCHAR (MAX) NULL,
    [Extract]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_WikipediaArticle] PRIMARY KEY CLUSTERED ([ID] ASC)
);

