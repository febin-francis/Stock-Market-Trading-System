CREATE TABLE [dbo].[Purchased] (
    [P_ID]            INT          NOT NULL,
    [Email]           VARCHAR (50) NULL,
    [Stock_Name]      VARCHAR (50) NULL,
    [Purchased_Price] INT          NULL,
    [Purchased_Qty]   INT          NULL,
    [Total_Price]     INT          NULL,
    PRIMARY KEY CLUSTERED ([P_ID] ASC), 
    CONSTRAINT [FK_Purchased_Stocks] FOREIGN KEY ([Stock_Name]) REFERENCES [Stocks]([Stock_Name])

);

