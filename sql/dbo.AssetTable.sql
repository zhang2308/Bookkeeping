CREATE TABLE [dbo].[AssetTable] (
    [AssetType] NCHAR (32)      NOT NULL,
    [Amount]    DECIMAL (14, 4) NOT NULL,
    [Value]     DECIMAL (14, 4) NOT NULL,
    [QueryCode] INT             NULL,
    PRIMARY KEY CLUSTERED ([AssetType] ASC)
);

