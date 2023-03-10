USE [master]
GO
/****** Object:  Database [HastaneProje]    Script Date: 12.01.2023 13:47:00 ******/
CREATE DATABASE [HastaneProje]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HastaneProje', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HastaneProje.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HastaneProje_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HastaneProje_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HastaneProje] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HastaneProje].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HastaneProje] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HastaneProje] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HastaneProje] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HastaneProje] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HastaneProje] SET ARITHABORT OFF 
GO
ALTER DATABASE [HastaneProje] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HastaneProje] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HastaneProje] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HastaneProje] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HastaneProje] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HastaneProje] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HastaneProje] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HastaneProje] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HastaneProje] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HastaneProje] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HastaneProje] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HastaneProje] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HastaneProje] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HastaneProje] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HastaneProje] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HastaneProje] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HastaneProje] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HastaneProje] SET RECOVERY FULL 
GO
ALTER DATABASE [HastaneProje] SET  MULTI_USER 
GO
ALTER DATABASE [HastaneProje] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HastaneProje] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HastaneProje] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HastaneProje] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HastaneProje] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HastaneProje] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HastaneProje', N'ON'
GO
ALTER DATABASE [HastaneProje] SET QUERY_STORE = OFF
GO
USE [HastaneProje]
GO
/****** Object:  Table [dbo].[Tbl_Branslar]    Script Date: 12.01.2023 13:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Branslar](
	[Bransid] [tinyint] IDENTITY(1,1) NOT NULL,
	[BransAd] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Doktorlar]    Script Date: 12.01.2023 13:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Doktorlar](
	[Doktorid] [tinyint] IDENTITY(1,1) NOT NULL,
	[DoktorAd] [varchar](10) NULL,
	[DoktorSoyad] [varchar](10) NULL,
	[DoktorBrans] [varchar](30) NULL,
	[DoktorTC] [char](11) NULL,
	[DoktorSifre] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Duyurular]    Script Date: 12.01.2023 13:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Duyurular](
	[Duyuruid] [smallint] IDENTITY(1,1) NOT NULL,
	[Duyuru] [varchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Hastalar]    Script Date: 12.01.2023 13:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Hastalar](
	[Hastaid] [smallint] IDENTITY(1,1) NOT NULL,
	[HastaAd] [varchar](10) NULL,
	[HastaSoyad] [varchar](10) NULL,
	[HastaTC] [char](111) NULL,
	[HastaTelefon] [varchar](15) NULL,
	[HastaSifre] [varchar](10) NULL,
	[HastaCinsiyet] [varchar](5) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Randevular]    Script Date: 12.01.2023 13:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Randevular](
	[Randevuid] [int] IDENTITY(1,1) NOT NULL,
	[RandevuTarih] [varchar](10) NULL,
	[RandevuSaat] [varchar](5) NULL,
	[RandevuBrans] [varchar](30) NULL,
	[RandevuDoktor] [varchar](20) NULL,
	[RandevuDurum] [bit] NULL,
	[HastaTc] [char](11) NULL,
	[HastaSikayet] [varchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Sekreter]    Script Date: 12.01.2023 13:47:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sekreter](
	[Sekreterid] [tinyint] IDENTITY(1,1) NOT NULL,
	[SekreterAdSoyad] [varchar](20) NULL,
	[SekreterTC] [char](11) NULL,
	[SekreterSifre] [varchar](10) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Branslar] ON 

INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (1, N'Dahiliye')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (2, N'Göz')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (3, N'KBB')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (4, N'Fizik Tedavi')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (6, N'Cilt Hastalıkları')
INSERT [dbo].[Tbl_Branslar] ([Bransid], [BransAd]) VALUES (7, N'Genel Cerrahi')
SET IDENTITY_INSERT [dbo].[Tbl_Branslar] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Doktorlar] ON 

INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorTC], [DoktorSifre]) VALUES (1, N'Ahmet', N'KARABAYIR', N'Dahiliye', N'33333333333', N'3333')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorTC], [DoktorSifre]) VALUES (2, N'Nilay', N'KURT', N'Dahiliye', N'44444444444', N'234')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorTC], [DoktorSifre]) VALUES (6, N'Mert', N'YILMAZ', N'Göz', N'99999999999', N'9999')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorTC], [DoktorSifre]) VALUES (4, N'Naciye', N'MELİKOĞLU', N'Göz', N'66666666666', N'55555')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorTC], [DoktorSifre]) VALUES (5, N'Levent', N'ALTIN', N'Fizik Tedavi', N'88888888888', N'8888')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorTC], [DoktorSifre]) VALUES (7, N'Derya', N'LULU', N'Fizik Tedavi', N'95959595951', N'9999')
INSERT [dbo].[Tbl_Doktorlar] ([Doktorid], [DoktorAd], [DoktorSoyad], [DoktorBrans], [DoktorTC], [DoktorSifre]) VALUES (8, N'Ahmet', N'KARADALLI', N'KBB', N'87452136987', N'1478')
SET IDENTITY_INSERT [dbo].[Tbl_Doktorlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Duyurular] ON 

INSERT [dbo].[Tbl_Duyurular] ([Duyuruid], [Duyuru]) VALUES (1, N'Saat 21:21 de acil odası karşısında toplantı olacaktır.')
INSERT [dbo].[Tbl_Duyurular] ([Duyuruid], [Duyuru]) VALUES (2, N'bla bla bla ')
SET IDENTITY_INSERT [dbo].[Tbl_Duyurular] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Hastalar] ON 

INSERT [dbo].[Tbl_Hastalar] ([Hastaid], [HastaAd], [HastaSoyad], [HastaTC], [HastaTelefon], [HastaSifre], [HastaCinsiyet]) VALUES (1, N'Mustafa', N'GÜR', N'11111111111                                                                                                    ', N'(530) 626-5252', N'1111', N'Erkek')
INSERT [dbo].[Tbl_Hastalar] ([Hastaid], [HastaAd], [HastaSoyad], [HastaTC], [HastaTelefon], [HastaSifre], [HastaCinsiyet]) VALUES (2, N'Merve', N'GÜR', N'22222222222                                                                                                    ', N'(538) 326-3347', N'2222', N'Kadın')
SET IDENTITY_INSERT [dbo].[Tbl_Hastalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Randevular] ON 

INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTc], [HastaSikayet]) VALUES (1, N'13.12.2022', N'14:00', N'Dahiliye', N'Ahmet KARABAYIR', 0, N'11111111111', NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTc], [HastaSikayet]) VALUES (2, N'14.12.2022', N'15:00', N'Göz', N'Naciye MELİKOĞLU', 1, N'11111111111', N'afasfasdf')
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTc], [HastaSikayet]) VALUES (3, N'15.12.2022', N'09:00', N'Göz', N'Naciye MELİKOĞLU', 0, N'11111111111', NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTc], [HastaSikayet]) VALUES (4, N'14.12.2022', N'15:30', N'Dahiliye', N'Nilay KURT', 1, N'11111111111', N'afasfasdfrfgqewrfq')
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTc], [HastaSikayet]) VALUES (5, N'18.12.2022', N'15:30', N'Dahiliye', N'Ahmet KARABAYIR', 0, N'22222222222', NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTc], [HastaSikayet]) VALUES (7, N'10.12.2022', N'20:00', N'Göz', N'Mert YILMAZ', 0, NULL, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTc], [HastaSikayet]) VALUES (8, N'21.12.2022', N'15:24', N'KBB', N'Ahmet KARADALLI', 1, N'22222222222', N'gsgegdfggf')
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTc], [HastaSikayet]) VALUES (10, N'01.12.2022', N'20:00', N'Dahiliye', N'Nilay KURT', 0, NULL, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTc], [HastaSikayet]) VALUES (6, N'10.12.2022', N'21:00', N'Göz', N'Mert YILMAZ', 0, NULL, NULL)
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTc], [HastaSikayet]) VALUES (9, N'01.12.2022', N'15:50', N'Dahiliye', N'Nilay KURT', 1, N'22222222222', N'tyewyb weyweby')
INSERT [dbo].[Tbl_Randevular] ([Randevuid], [RandevuTarih], [RandevuSaat], [RandevuBrans], [RandevuDoktor], [RandevuDurum], [HastaTc], [HastaSikayet]) VALUES (11, N'10.12.2022', N'20:00', N'Dahiliye', N'Nilay KURT', 0, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Tbl_Randevular] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Sekreter] ON 

INSERT [dbo].[Tbl_Sekreter] ([Sekreterid], [SekreterAdSoyad], [SekreterTC], [SekreterSifre]) VALUES (1, N'Nalan KARABACAK', N'77777777777', N'7777')
INSERT [dbo].[Tbl_Sekreter] ([Sekreterid], [SekreterAdSoyad], [SekreterTC], [SekreterSifre]) VALUES (2, N'Natali ABROWİC', N'88888888888', N'8888')
SET IDENTITY_INSERT [dbo].[Tbl_Sekreter] OFF
GO
ALTER TABLE [dbo].[Tbl_Randevular] ADD  CONSTRAINT [DF_Tbl_Randevular_RandevuDurum]  DEFAULT ((0)) FOR [RandevuDurum]
GO
USE [master]
GO
ALTER DATABASE [HastaneProje] SET  READ_WRITE 
GO
