CREATE TABLE [dbo].[CustomerCustomerType]
(
	[Id]                       INT          NOT NULL,
    [CustomerTypeId]                  INT          NOT NULL,
    [AuditCreatedDate]              DATETIME     NOT NULL,
    [AuditCreatedBy]                VARCHAR (75) NOT NULL,
    [AuditLastUpdatedDate]          DATETIME     NOT NULL,
    [AuditLastUpdatedBy]            VARCHAR (75) NOT NULL,
	[RowVersion] ROWVERSION NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC, [CustomerTypeId] ASC),
    CONSTRAINT [fk_CustomerCustomerType_CustomerTypeId] FOREIGN KEY ([CustomerTypeId]) REFERENCES [dbo].[CustomerType] ([Id]),
    CONSTRAINT [fk_CustomerCustomerType_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[Customer] ([Id])
)
