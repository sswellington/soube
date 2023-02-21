CREATE TABLE [dbo].[WeatherForecast] (
    [Id]          INT          NOT NULL,
    [Date]        DATE         NOT NULL,
    [Temperature] INT          NOT NULL,
    [Summary]     VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

