CREATE TABLE [dbo].[CustomerType]
(
	[Id]                       INT				IDENTITY (1, 1) NOT NULL,
    [Code] VARCHAR(75) NOT NULL, 
    [Description] VARCHAR(150) NOT NULL,
	[IsDeleted] BIT NOT NULL,
	[SortOrder] BIGINT NOT NULL,
	[AuditCreatedBy]        VARCHAR (75)     NOT NULL,
    [AuditCreatedDate]      DATETIME         NOT NULL,
    [AuditLastUpdatedDate]  DATETIME         NOT NULL,
    [AuditLastUpdatedBy]    VARCHAR (75)     NOT NULL,
	[RowVersion] ROWVERSION NOT NULL,
	CONSTRAINT [PK_CustomerType] PRIMARY KEY CLUSTERED ([Id] ASC),
)
