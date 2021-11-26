CREATE TABLE [dbo].[Earning] (
    [EarnType]    NCHAR (32)      NOT NULL,
    [Count]       DECIMAL (14, 4) NOT NULL,
    [ToAssetType] NCHAR (32)      NOT NULL,
    [Note]        NCHAR (256)     NULL,
    PRIMARY KEY CLUSTERED ([EarnType] ASC)
);

