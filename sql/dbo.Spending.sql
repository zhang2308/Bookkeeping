CREATE TABLE [dbo].[Spending] (
    [SpendType]     NCHAR (32)      NOT NULL,
    [Count]         DECIMAL (14, 4) NOT NULL,
    [FromAssetType] NCHAR (32)      NOT NULL,
    [Note]          NCHAR (256)     NULL,
    PRIMARY KEY CLUSTERED ([SpendType] ASC)
);

