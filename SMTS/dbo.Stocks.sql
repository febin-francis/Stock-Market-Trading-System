CREATE TABLE [dbo].[Stocks] (
    [Stock_Name] VARCHAR (50) NOT NULL,
    [Buy_Price]  NUMERIC (6)  NOT NULL,
    [Sell_Price] NUMERIC (6)  NOT NULL,
    [Total_qty]  NUMERIC (10) NULL,
    PRIMARY KEY CLUSTERED ([Stock_Name] ASC)
);

