# Katir

Bu uygulamada crud işlemi ve iki tarih arasındaki verileri alma işlemi yapılmıştır.

## Tablo yapısı
```
CREATE TABLE [dbo].[Table] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Ibm]   VARCHAR (70) NULL,
    [Masa]  VARCHAR (7)  NULL,
    [adet]  INT          NULL,
    [Tarih] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

```
