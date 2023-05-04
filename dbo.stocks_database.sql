CREATE TABLE [dbo].[stocks_database] (
    [ID]                 INT           IDENTITY (1, 1) NOT NULL,
    [Product_ID_Barcode] NCHAR (10)    NOT NULL,
    [Name]               NCHAR (10)    NOT NULL,
    [Supplier_Name]      NCHAR (10)    NOT NULL,
    [Quantity]           INT           NOT NULL,
    [Status]             NCHAR (10)    NOT NULL,
    [Date]               NVARCHAR (50) NOT NULL,
    [Expiration_Date]    NCHAR (10)    NOT NULL,
    [Month]              NCHAR (10)    NOT NULL,
    [Year]               NCHAR (10)    NOT NULL,
    [Remarks]            NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_stocks_database] PRIMARY KEY CLUSTERED ([ID] ASC)
);

