USE [master]
GO
/****** Object:  Database [dbvacunate]    Script Date: 8/13/2021 12:27:25 PM ******/
CREATE DATABASE [dbvacunate]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbvacunate', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbvacunate.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbvacunate_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbvacunate_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbvacunate] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbvacunate].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbvacunate] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbvacunate] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbvacunate] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbvacunate] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbvacunate] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbvacunate] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbvacunate] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbvacunate] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbvacunate] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbvacunate] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbvacunate] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbvacunate] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbvacunate] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbvacunate] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbvacunate] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbvacunate] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbvacunate] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbvacunate] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbvacunate] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbvacunate] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbvacunate] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [dbvacunate] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbvacunate] SET RECOVERY FULL 
GO
ALTER DATABASE [dbvacunate] SET  MULTI_USER 
GO
ALTER DATABASE [dbvacunate] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbvacunate] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbvacunate] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbvacunate] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbvacunate] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbvacunate] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbvacunate', N'ON'
GO
ALTER DATABASE [dbvacunate] SET QUERY_STORE = OFF
GO
USE [dbvacunate]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/13/2021 12:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 8/13/2021 12:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [nvarchar](13) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](10) NOT NULL,
	[Correo] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [datetime2](7) NOT NULL,
	[IdSangre] [int] NOT NULL,
	[IdProvincia] [int] NOT NULL,
	[Direccion] [nvarchar](100) NOT NULL,
	[Latitud] [decimal](18, 2) NOT NULL,
	[Longitud] [decimal](18, 2) NOT NULL,
	[HistorialCovid] [bit] NOT NULL,
	[Justificacion] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 8/13/2021 12:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sangres]    Script Date: 8/13/2021 12:27:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sangres](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Sangres] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210809165623_Initial Migration', N'5.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210809173707_Adding foreign keys to models', N'5.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210809174501_Adding property name to provincia', N'5.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210809225805_Cambiando valor a propiedad tipo en tabla Sangres', N'5.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210810203604_SP_SolicitudVacuna', N'5.0.8')
GO
SET IDENTITY_INSERT [dbo].[Personas] ON 

INSERT [dbo].[Personas] ([Id], [Cedula], [Nombre], [Apellido], [Telefono], [Correo], [FechaNacimiento], [IdSangre], [IdProvincia], [Direccion], [Latitud], [Longitud], [HistorialCovid], [Justificacion]) VALUES (27, N'402558848866', N'Estrella', N'Aquino', N'8784544784', N'eaanny2611@gmail.com', CAST(N'2021-08-13T00:00:00.0000000' AS DateTime2), 16, 8, N'Por ahi', CAST(2.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), 1, N'No quiero ir')
SET IDENTITY_INSERT [dbo].[Personas] OFF
GO
SET IDENTITY_INSERT [dbo].[Provincias] ON 

INSERT [dbo].[Provincias] ([Id], [Nombre]) VALUES (7, N'SANTO DOMINGO')
INSERT [dbo].[Provincias] ([Id], [Nombre]) VALUES (8, N'DISTRITO NACIONAL')
INSERT [dbo].[Provincias] ([Id], [Nombre]) VALUES (9, N'SANTIAGO')
SET IDENTITY_INSERT [dbo].[Provincias] OFF
GO
SET IDENTITY_INSERT [dbo].[Sangres] ON 

INSERT [dbo].[Sangres] ([Id], [Tipo]) VALUES (14, N'O +')
INSERT [dbo].[Sangres] ([Id], [Tipo]) VALUES (15, N'A +')
INSERT [dbo].[Sangres] ([Id], [Tipo]) VALUES (16, N'B -')
INSERT [dbo].[Sangres] ([Id], [Tipo]) VALUES (17, N'O -')
INSERT [dbo].[Sangres] ([Id], [Tipo]) VALUES (18, N'B +')
INSERT [dbo].[Sangres] ([Id], [Tipo]) VALUES (19, N'AB +')
SET IDENTITY_INSERT [dbo].[Sangres] OFF
GO
/****** Object:  Index [IX_Personas_IdProvincia]    Script Date: 8/13/2021 12:27:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_Personas_IdProvincia] ON [dbo].[Personas]
(
	[IdProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Personas_IdSangre]    Script Date: 8/13/2021 12:27:27 PM ******/
CREATE NONCLUSTERED INDEX [IX_Personas_IdSangre] ON [dbo].[Personas]
(
	[IdSangre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Provincias] ADD  DEFAULT (N'') FOR [Nombre]
GO
ALTER TABLE [dbo].[Personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Provincias_IdProvincia] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [FK_Personas_Provincias_IdProvincia]
GO
ALTER TABLE [dbo].[Personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Sangres_IdSangre] FOREIGN KEY([IdSangre])
REFERENCES [dbo].[Sangres] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [FK_Personas_Sangres_IdSangre]
GO
USE [master]
GO
ALTER DATABASE [dbvacunate] SET  READ_WRITE 
GO
