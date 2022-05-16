CREATE TABLE [dbo].[Sold] (
    [S_ID]        INT          NOT NULL,
    [Email]       VARCHAR (50) NOT NULL,
    [Stock_Name]  VARCHAR (50) NOT NULL,
    [Sold_Price]  INT          NULL,
    [Sold_Qty]    INT          NULL,
    [Total_Price] INT          NULL,
    [P&L]         INT          NULL,
    PRIMARY KEY CLUSTERED ([S_ID] ASC), 
    CONSTRAINT [FK_Sold_Stocks] FOREIGN KEY ([Stock_Name]) REFERENCES [Stocks]([Stock_Name])
);

