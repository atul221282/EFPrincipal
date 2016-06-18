CREATE TABLE [dbo].[Customer]
(
	[Id]                   INT           NOT NULL,
    [FirstName]            VARCHAR (50)  NOT NULL,
    [MiddleName]           VARCHAR (50)  NULL,
    [LastName]             VARCHAR (50)  NOT NULL,
	[UserGuid]			   NVARCHAR(100) NULL,
	[IsDeleted]            BIT           CONSTRAINT [DF_Users_IsDeleted] DEFAULT ((0)) NOT NULL,
    [AuditCreatedDate]     DATETIME      NOT NULL,
    [AuditCreatedBy]       VARCHAR (75)  NOT NULL,
    [AuditLastUpdatedDate] DATETIME      NOT NULL,
    [AuditLastUpdatedBy]   VARCHAR (75)  NOT NULL,
	[RowVersion] ROWVERSION NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([Id] ASC),
)
