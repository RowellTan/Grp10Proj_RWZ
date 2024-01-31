CREATE TABLE [dbo].[Cars] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [CarType]   NVARCHAR (MAX) NULL,
    [DriverId]  INT            NOT NULL,
    [CarStatus] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cars_Drivers_DriverId] FOREIGN KEY ([DriverId]) REFERENCES [dbo].[Drivers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Cars_DriverId]
    ON [dbo].[Cars]([DriverId] ASC);

