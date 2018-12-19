USE [master]
GO
CREATE LOGIN [araba] WITH PASSWORD=N'arabaparola', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[Türkçe], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER SERVER ROLE [dbcreator] ADD MEMBER [araba]
GO
/****** Object:  Database [araba]    Script Date: 19.12.2018 23:26:16 ******/
CREATE DATABASE [araba]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'araba', FILENAME = N'D:\kodlar\sql-project-db\araba.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'araba_log', FILENAME = N'D:\kodlar\sql-project-db\araba_log.ldf' , SIZE = 427392KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [araba] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [araba].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [araba] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [araba] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [araba] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [araba] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [araba] SET ARITHABORT OFF 
GO
ALTER DATABASE [araba] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [araba] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [araba] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [araba] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [araba] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [araba] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [araba] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [araba] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [araba] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [araba] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [araba] SET  DISABLE_BROKER 
GO
ALTER DATABASE [araba] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [araba] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [araba] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [araba] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [araba] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [araba] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [araba] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [araba] SET RECOVERY FULL 
GO
ALTER DATABASE [araba] SET  MULTI_USER 
GO
ALTER DATABASE [araba] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [araba] SET DB_CHAINING OFF 
GO
ALTER DATABASE [araba] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [araba] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [araba]
GO
EXEC dbo.sp_changedbowner @loginame = N'araba', @map = false
GO
/****** Object:  StoredProcedure [dbo].[spParcaEkleGuncelle]    Script Date: 19.12.2018 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spParcaEkleGuncelle] ( @kodu nvarchar(20), @adi nvarchar(50), @iscilik float, @tutar money )
AS
	IF EXISTS(SELECT * FROM parca WHERE parcaKodu = @kodu)
	BEGIN
		UPDATE parca SET parcaAdi = @adi, parcaIscilik = @iscilik, parcaTutari = @tutar
	END
	ELSE
	BEGIN
		INSERT INTO parca (parcaKodu, parcaAdi, parcaIscilik, parcaTutari)
			VALUES (@kodu, @adi, @iscilik, @tutar)
	END

GO
/****** Object:  StoredProcedure [dbo].[spPersonelEkleGuncelle]    Script Date: 19.12.2018 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spPersonelEkleGuncelle] (
	@perno int, 
	@adi nvarchar(50), 
	@soyadi nvarchar(50), 
	@tckNo char(11),
	@telefon char(17),
	@eposta varchar(50),
	@adres nvarchar(250),
	@kAdi varchar(50),
	@parola char(40) )
AS
	IF EXISTS(SELECT * FROM personel WHERE perNo = @perno)
	BEGIN
		UPDATE personel SET 
			ad = @adi, 
			soyad = @soyadi, 
			tckNo = @tckNo,
			telefon = @telefon,
			eposta = @eposta,
			adres = @adres,
			kullaniciAdi = @kAdi,
			parola = @parola
			WHERE perNo = @perno
	END
	ELSE
	BEGIN
		INSERT INTO personel
			(ad, soyad, tckNo, telefon, eposta, adres, kullaniciAdi, parola)
		VALUES
			(@adi, @soyadi, @tckNo, @telefon, @eposta, @adres, @kAdi, @parola)
		SELECT SCOPE_IDENTITY()
	END

GO
/****** Object:  Table [dbo].[araba]    Script Date: 19.12.2018 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[araba](
	[sasiNo] [varchar](50) NOT NULL,
	[motorNo] [varchar](50) NOT NULL,
	[plaka] [nchar](8) NULL,
	[model] [varchar](50) NULL,
	[marka] [varchar](50) NULL,
	[renk] [nvarchar](50) NULL,
 CONSTRAINT [PK_araba] PRIMARY KEY CLUSTERED 
(
	[sasiNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_araba] UNIQUE NONCLUSTERED 
(
	[plaka] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[degisim]    Script Date: 19.12.2018 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[degisim](
	[degisimNo] [int] IDENTITY(1,1) NOT NULL,
	[isEmriNo] [int] NULL,
	[parcaKodu] [nvarchar](20) NULL,
 CONSTRAINT [PK_degisim] PRIMARY KEY CLUSTERED 
(
	[degisimNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[musteri]    Script Date: 19.12.2018 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[musteri](
	[musNo] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NULL,
	[tckNo] [char](11) NULL,
	[telefon] [char](17) NULL,
	[eposta] [varchar](50) NULL,
	[adres] [nvarchar](250) NULL,
 CONSTRAINT [PK_musteri] PRIMARY KEY CLUSTERED 
(
	[musNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_musteri] UNIQUE NONCLUSTERED 
(
	[tckNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[parca]    Script Date: 19.12.2018 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parca](
	[parcaKodu] [nvarchar](20) NOT NULL,
	[parcaAdi] [nvarchar](50) NULL,
	[parcaIscilik] [float] NULL,
	[parcaTutari] [money] NULL,
 CONSTRAINT [PK_parca] PRIMARY KEY CLUSTERED 
(
	[parcaKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[parcaSilinen]    Script Date: 19.12.2018 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parcaSilinen](
	[parcaKodu] [nvarchar](20) NOT NULL,
	[parcaAdi] [nvarchar](50) NULL,
	[parcaIscilik] [float] NULL,
	[parcaTutari] [money] NULL,
 CONSTRAINT [PK_parcaSilinen] PRIMARY KEY CLUSTERED 
(
	[parcaKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[personel]    Script Date: 19.12.2018 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[personel](
	[perNo] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NULL,
	[tckNo] [char](11) NULL,
	[telefon] [char](17) NULL,
	[eposta] [varchar](50) NULL,
	[adres] [nvarchar](250) NULL,
	[kullaniciAdi] [varchar](50) NULL,
	[parola] [char](40) NULL,
 CONSTRAINT [PK_personel] PRIMARY KEY CLUSTERED 
(
	[perNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_personel] UNIQUE NONCLUSTERED 
(
	[tckNo] ASC,
	[kullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = ON, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[personelSilinen]    Script Date: 19.12.2018 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[personelSilinen](
	[perNo] [int] NOT NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NULL,
	[tckNo] [char](11) NULL,
	[telefon] [char](17) NULL,
	[eposta] [varchar](50) NULL,
	[adres] [nvarchar](250) NULL,
	[kullaniciAdi] [varchar](50) NULL,
	[parola] [char](40) NULL,
 CONSTRAINT [PK_personelSilinen] PRIMARY KEY CLUSTERED 
(
	[perNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_personelSilinen] UNIQUE NONCLUSTERED 
(
	[tckNo] ASC,
	[kullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = ON, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[satis]    Script Date: 19.12.2018 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[satis](
	[satisNo] [int] IDENTITY(1,1) NOT NULL,
	[tarih] [datetime] NULL,
	[sasiNo] [varchar](50) NULL,
	[musNo] [int] NULL,
	[perNo] [int] NULL,
	[tutar] [money] NULL,
 CONSTRAINT [PK_satis] PRIMARY KEY CLUSTERED 
(
	[satisNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[servis]    Script Date: 19.12.2018 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[servis](
	[isEmriNo] [int] IDENTITY(1,1) NOT NULL,
	[girisTalimati] [nvarchar](250) NULL,
	[aracKm] [int] NULL,
	[girisTarihi] [datetime] NULL,
	[yapilanIslemler] [nvarchar](250) NULL,
	[cikisTarihi] [datetime] NULL,
	[faturaTutari] [money] NULL,
	[sasiNo] [varchar](50) NULL,
	[musNo] [int] NULL,
	[perNo] [int] NULL,
 CONSTRAINT [PK_servis] PRIMARY KEY CLUSTERED 
(
	[isEmriNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[yetki]    Script Date: 19.12.2018 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yetki](
	[yetkiNo] [int] IDENTITY(1,1) NOT NULL,
	[yetkiAdi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_yetki] PRIMARY KEY CLUSTERED 
(
	[yetkiNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[yetkiler]    Script Date: 19.12.2018 23:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yetkiler](
	[yetkilerNo] [int] IDENTITY(1,1) NOT NULL,
	[yetkiNo] [int] NOT NULL,
	[perNo] [int] NOT NULL,
 CONSTRAINT [PK_yetkiler] PRIMARY KEY CLUSTERED 
(
	[yetkilerNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[servis] ADD  CONSTRAINT [DF_servis_faturaTutari]  DEFAULT ((0)) FOR [faturaTutari]
GO
ALTER TABLE [dbo].[degisim]  WITH CHECK ADD  CONSTRAINT [FK_degisim_parca] FOREIGN KEY([parcaKodu])
REFERENCES [dbo].[parca] ([parcaKodu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[degisim] CHECK CONSTRAINT [FK_degisim_parca]
GO
ALTER TABLE [dbo].[degisim]  WITH CHECK ADD  CONSTRAINT [FK_degisim_servis] FOREIGN KEY([isEmriNo])
REFERENCES [dbo].[servis] ([isEmriNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[degisim] CHECK CONSTRAINT [FK_degisim_servis]
GO
ALTER TABLE [dbo].[satis]  WITH CHECK ADD  CONSTRAINT [FK_satis_araba1] FOREIGN KEY([sasiNo])
REFERENCES [dbo].[araba] ([sasiNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[satis] CHECK CONSTRAINT [FK_satis_araba1]
GO
ALTER TABLE [dbo].[satis]  WITH CHECK ADD  CONSTRAINT [FK_satis_musteri] FOREIGN KEY([musNo])
REFERENCES [dbo].[musteri] ([musNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[satis] CHECK CONSTRAINT [FK_satis_musteri]
GO
ALTER TABLE [dbo].[satis]  WITH CHECK ADD  CONSTRAINT [FK_satis_personel1] FOREIGN KEY([perNo])
REFERENCES [dbo].[personel] ([perNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[satis] CHECK CONSTRAINT [FK_satis_personel1]
GO
ALTER TABLE [dbo].[servis]  WITH CHECK ADD  CONSTRAINT [FK_servis_araba1] FOREIGN KEY([sasiNo])
REFERENCES [dbo].[araba] ([sasiNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[servis] CHECK CONSTRAINT [FK_servis_araba1]
GO
ALTER TABLE [dbo].[servis]  WITH CHECK ADD  CONSTRAINT [FK_servis_musteri] FOREIGN KEY([musNo])
REFERENCES [dbo].[musteri] ([musNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[servis] CHECK CONSTRAINT [FK_servis_musteri]
GO
ALTER TABLE [dbo].[servis]  WITH CHECK ADD  CONSTRAINT [FK_servis_personel] FOREIGN KEY([perNo])
REFERENCES [dbo].[personel] ([perNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[servis] CHECK CONSTRAINT [FK_servis_personel]
GO
ALTER TABLE [dbo].[yetkiler]  WITH CHECK ADD  CONSTRAINT [FK_yetkiler_personel1] FOREIGN KEY([perNo])
REFERENCES [dbo].[personel] ([perNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[yetkiler] CHECK CONSTRAINT [FK_yetkiler_personel1]
GO
ALTER TABLE [dbo].[yetkiler]  WITH CHECK ADD  CONSTRAINT [FK_yetkiler_yetki1] FOREIGN KEY([yetkiNo])
REFERENCES [dbo].[yetki] ([yetkiNo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[yetkiler] CHECK CONSTRAINT [FK_yetkiler_yetki1]
GO
ALTER TABLE [dbo].[araba]  WITH CHECK ADD  CONSTRAINT [ck_araba_plaka] CHECK  (([plaka] like '[0-8][0-9][A-Z][A-Z0-9][A-Z0-9][0-9][0-9][0-9 ]'))
GO
ALTER TABLE [dbo].[araba] CHECK CONSTRAINT [ck_araba_plaka]
GO
ALTER TABLE [dbo].[musteri]  WITH CHECK ADD  CONSTRAINT [ck_musteri_eposta] CHECK  (([eposta] like '%_@_%_.__%'))
GO
ALTER TABLE [dbo].[musteri] CHECK CONSTRAINT [ck_musteri_eposta]
GO
ALTER TABLE [dbo].[musteri]  WITH CHECK ADD  CONSTRAINT [ck_musteri_tckno] CHECK  (([tckNo] like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[musteri] CHECK CONSTRAINT [ck_musteri_tckno]
GO
ALTER TABLE [dbo].[musteri]  WITH CHECK ADD  CONSTRAINT [ck_musteri_telefon] CHECK  (([telefon] like '+90([2-5][0-9][0-9]) [0-9][0-9][0-9] [0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[musteri] CHECK CONSTRAINT [ck_musteri_telefon]
GO
ALTER TABLE [dbo].[personel]  WITH CHECK ADD  CONSTRAINT [ck_personel_eposta] CHECK  (([eposta] like '%_@_%_.__%'))
GO
ALTER TABLE [dbo].[personel] CHECK CONSTRAINT [ck_personel_eposta]
GO
ALTER TABLE [dbo].[personel]  WITH CHECK ADD  CONSTRAINT [ck_personel_tckNo] CHECK  (([tckNo] like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[personel] CHECK CONSTRAINT [ck_personel_tckNo]
GO
ALTER TABLE [dbo].[personel]  WITH CHECK ADD  CONSTRAINT [ck_personel_telefon] CHECK  (([telefon] like '+90([2-5][0-9][0-9]) [0-9][0-9][0-9] [0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[personel] CHECK CONSTRAINT [ck_personel_telefon]
GO
ALTER TABLE [dbo].[personelSilinen]  WITH CHECK ADD  CONSTRAINT [ck_personelSilinen_eposta] CHECK  (([eposta] like '%_@_%_.__%'))
GO
ALTER TABLE [dbo].[personelSilinen] CHECK CONSTRAINT [ck_personelSilinen_eposta]
GO
ALTER TABLE [dbo].[personelSilinen]  WITH CHECK ADD  CONSTRAINT [ck_personelSilinen_tckNo] CHECK  (([tckNo] like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[personelSilinen] CHECK CONSTRAINT [ck_personelSilinen_tckNo]
GO
ALTER TABLE [dbo].[personelSilinen]  WITH CHECK ADD  CONSTRAINT [ck_personelSilinen_telefon] CHECK  (([telefon] like '+90([2-5][0-9][0-9]) [0-9][0-9][0-9] [0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[personelSilinen] CHECK CONSTRAINT [ck_personelSilinen_telefon]
GO
/****** Ontanimli degerler                                                                *******/
INSERT INTO [dbo].[personel] ([ad], [kullaniciAdi], [parola]) VALUES ('admin', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997')
GO
INSERT INTO [dbo].[yetki] ([yetkiAdi]) VALUES ('Yönetim'), ('Satış'), ('Servis'), ('Parça')
GO
/****** Object:  Trigger [dbo].[trServisFaturaHesapla]    Script Date: 19.12.2018 23:26:16 ******/
CREATE TRIGGER [dbo].[trServisFaturaHesapla]
ON [dbo].[degisim]
FOR  INSERT, UPDATE, DELETE 
AS
BEGIN
	DECLARE @isemri int, @iscilik int = 100, @pIscilik float, @pTutar money, @parca nvarchar(20)
	DECLARE crsUpdated CURSOR FOR
		SELECT isEmriNo,  parcaKodu  FROM INSERTED

	OPEN crsUpdated
	FETCH NEXT FROM crsUpdated INTO @isemri, @parca
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SELECT @pIscilik = parcaIscilik, @pTutar = parcaTutari FROM parca WHERE parcaKodu = @parca
		UPDATE servis SET faturaTutari = faturaTutari + @pTutar + @iscilik * @pIscilik WHERE isEmriNo = @isemri
		FETCH NEXT FROM crsUpdated INTO @isemri, @parca
	END
	CLOSE crsUpdated

	DECLARE crsDeleted CURSOR FOR
		SELECT isEmriNo, parcaKodu  FROM DELETED

	OPEN crsDeleted
	FETCH NEXT FROM crsDeleted INTO @isemri, @parca
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SELECT @pIscilik = parcaIscilik, @pTutar = parcaTutari FROM parca WHERE parcaKodu = @parca
		UPDATE servis SET faturaTutari = faturaTutari - ( @pTutar + @iscilik * @pIscilik ) WHERE isEmriNo = @isemri
		FETCH NEXT FROM crsDeleted INTO @isemri, @parca
	END
	CLOSE crsDeleted
END
GO
/****** Object:  Trigger [dbo].[trParcaSil]    Script Date: 19.12.2018 23:26:16 ******/
CREATE TRIGGER [dbo].[trParcaSil]
ON [dbo].[parca]
FOR DELETE 
AS
BEGIN
	INSERT INTO parcaSilinen
	SELECT * FROM DELETED
END
GO
/****** Object:  Trigger [dbo].[trPersonelSil]    Script Date: 19.12.2018 23:26:16 ******/
CREATE TRIGGER [dbo].[trPersonelSil]
ON [dbo].[personel]
INSTEAD OF DELETE 
AS
BEGIN
	DECLARE @kullaniciAdi nvarchar(50) = ''
	SELECT @kullaniciAdi = kullaniciAdi FROM DELETED WHERE kullaniciAdi = 'admin'
	if @kullaniciAdi != 'admin'
	BEGIN
		INSERT INTO personelSilinen
		SELECT * FROM DELETED
		DELETE personel FROM personel JOIN DELETED on personel.perNo = DELETED.perNo
	END
END
GO
USE [master]
GO
ALTER DATABASE [araba] SET  READ_WRITE 
GO
