CREATE TABLE [dbo].[CustomerOrder]
(
	[Id]                   INT           NOT NULL,
    [OrderName]				VARCHAR(100) NOT NULL,
	[OrderById]				INT NOT NULL,
	[IsDeleted]            BIT           CONSTRAINT [DF_Order_IsDeleted] DEFAULT ((0)) NOT NULL,
    [AuditCreatedDate]     DATETIME      NOT NULL,
    [AuditCreatedBy]       VARCHAR (75)  NOT NULL,
    [AuditLastUpdatedDate] DATETIME      NOT NULL,
    [AuditLastUpdatedBy]   VARCHAR (75)  NOT NULL,
	[RowVersion] ROWVERSION NOT NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [fk_Order_OrderById] FOREIGN KEY ([OrderById]) REFERENCES [dbo].[Customer] ([Id])
)
