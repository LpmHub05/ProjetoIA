CREATE TABLE [dbo].[IA] (
    [id_IA]         INT             IDENTITY (1, 1) NOT NULL,
    [nm_IA]       VARCHAR (65)    NOT NULL,
    [AnoLanc_IA]    DATE            NOT NULL,
    [Logo_IA]       VARBINARY (MAX) NOT NULL,
    [Fabricante_IA] VARCHAR (65)    NOT NULL,
    [Aparelho_IA]   VARCHAR (65)    NOT NULL,
    PRIMARY KEY CLUSTERED ([id_IA] ASC)
);

