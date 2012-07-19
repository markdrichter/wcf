CREATE TABLE [dbo].[vw_aspnet_Applications] (
    [ApplicationName]        NVARCHAR (256)   NOT NULL,
    [LoweredApplicationName] NVARCHAR (256)   NOT NULL,
    [ApplicationId]          UNIQUEIDENTIFIER NOT NULL,
    [Description]            NVARCHAR (256)   NULL
);

