-- Otel Yönetim Otomasyonu - veritabanı şeması (SQL Server)
-- Uygulamadaki sorgulardan çıkarılmıştır. SSMS'te çalıştırın.

IF DB_ID('YMKotelOtomasyonu') IS NULL
    CREATE DATABASE YMKotelOtomasyonu;
GO
USE YMKotelOtomasyonu;
GO

CREATE TABLE MusteriEkle (
    MusteriID INT IDENTITY(1,1) PRIMARY KEY,
    Adi       NVARCHAR(50)  NOT NULL,
    Soyadi    NVARCHAR(50)  NOT NULL,
    Cinsiyeti NVARCHAR(10),
    Telefon   NVARCHAR(20),
    Adres     NVARCHAR(250),
    Mail      NVARCHAR(100),
    TCno      NVARCHAR(11),
    OdaNo     NVARCHAR(10),
    Ucret     NVARCHAR(20)
);
GO

CREATE TABLE IsTakvimi (
    ID             INT IDENTITY(1,1) PRIMARY KEY,
    YapılacakIs    NVARCHAR(250) NOT NULL,
    GorevliIsim    NVARCHAR(100),
    BaslangicTarih NVARCHAR(30),
    TeslimTarih    NVARCHAR(30)
);
GO

CREATE TABLE Oda101 (
    ID              INT IDENTITY(1,1) PRIMARY KEY,
    AdiSoyadi       NVARCHAR(100),
    TemizlikDurumu  NVARCHAR(30),
    MusaitlikDurumu NVARCHAR(30),
    SiparisDurumu   NVARCHAR(30),
    IhtiyacDurumu   NVARCHAR(50),
    OdemeBilgisi    NVARCHAR(30)
);
GO

CREATE TABLE Oda102 (
    ID              INT IDENTITY(1,1) PRIMARY KEY,
    AdiSoyadi       NVARCHAR(100),
    TemizlikDurumu  NVARCHAR(30),
    MusaitlikDurumu NVARCHAR(30),
    SiparisDurumu   NVARCHAR(30),
    IhtiyacDurumu   NVARCHAR(50),
    OdemeBilgisi    NVARCHAR(30)
);
GO

CREATE TABLE Oda103 (
    ID              INT IDENTITY(1,1) PRIMARY KEY,
    AdiSoyadi       NVARCHAR(100),
    TemizlikDurumu  NVARCHAR(30),
    MusaitlikDurumu NVARCHAR(30),
    SiparisDurumu   NVARCHAR(30),
    IhtiyacDurumu   NVARCHAR(50),
    OdemeBilgisi    NVARCHAR(30)
);
GO

CREATE TABLE Oda104 (
    ID              INT IDENTITY(1,1) PRIMARY KEY,
    AdiSoyadi       NVARCHAR(100),
    TemizlikDurumu  NVARCHAR(30),
    MusaitlikDurumu NVARCHAR(30),
    SiparisDurumu   NVARCHAR(30),
    IhtiyacDurumu   NVARCHAR(50),
    OdemeBilgisi    NVARCHAR(30)
);
GO
