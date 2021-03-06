USE [master]
GO
/****** Object:  Database [BookCar]    Script Date: 2/17/2020 11:08:29 PM ******/
CREATE DATABASE [BookCar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookCar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BookCar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BookCar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BookCar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BookCar] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookCar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookCar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookCar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookCar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookCar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookCar] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookCar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BookCar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookCar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookCar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookCar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookCar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookCar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookCar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookCar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookCar] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BookCar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookCar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookCar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookCar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookCar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookCar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookCar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookCar] SET RECOVERY FULL 
GO
ALTER DATABASE [BookCar] SET  MULTI_USER 
GO
ALTER DATABASE [BookCar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookCar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookCar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookCar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BookCar] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BookCar', N'ON'
GO
ALTER DATABASE [BookCar] SET QUERY_STORE = OFF
GO
USE [BookCar]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 2/17/2020 11:08:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[CarID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NULL,
	[Color] [nvarchar](32) NULL,
	[Description] [nvarchar](512) NULL,
	[PlateNumber] [nvarchar](8) NULL,
	[Price] [decimal](18, 0) NULL,
	[Deleted] [int] NULL,
	[Version] [int] NULL,
	[CreatedBy] [nvarchar](32) NULL,
	[CreatedDTG] [datetime] NULL,
	[UpdatedBy] [nvarchar](32) NULL,
	[UpdatedDTG] [datetime] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarCategory]    Script Date: 2/17/2020 11:08:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarCategory](
	[CarCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[Description] [nvarchar](512) NULL,
	[Deleted] [int] NULL,
	[Version] [int] NULL,
	[CreatedBy] [nvarchar](32) NULL,
	[CreatedDTG] [datetime] NULL,
	[UpdatedBy] [nvarchar](32) NULL,
	[UpdatedDTG] [datetime] NULL,
 CONSTRAINT [PK_CarCategory] PRIMARY KEY CLUSTERED 
(
	[CarCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceOrder]    Script Date: 2/17/2020 11:08:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceOrder](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NULL,
	[TimeCategory] [int] NULL,
	[OrderDuration] [int] NULL,
	[PlanStartDTG] [datetime] NULL,
	[PlanEndDTG] [datetime] NULL,
	[ActualStartDTG] [datetime] NULL,
	[ActualEndDTG] [datetime] NULL,
	[CustomerName] [nvarchar](512) NULL,
	[Description] [nvarchar](512) NULL,
	[Status] [int] NULL,
	[Deleted] [int] NULL,
	[Version] [int] NULL,
	[CreatedBy] [nvarchar](32) NULL,
	[CreatedDTG] [datetime] NULL,
	[UpdatedBy] [nvarchar](32) NULL,
	[UpdatedDTG] [datetime] NULL,
 CONSTRAINT [PK_ServiceOrder] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeCategory]    Script Date: 2/17/2020 11:08:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeCategory](
	[TimeCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](32) NULL,
	[Description] [nvarchar](512) NULL,
	[Deleted] [int] NULL,
	[Version] [int] NULL,
	[CreatedBy] [nvarchar](32) NULL,
	[CreatedDTG] [datetime] NULL,
	[UpdatedBy] [nvarchar](32) NULL,
	[UpdatedDTG] [datetime] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Car] ON 

INSERT [dbo].[Car] ([CarID], [CategoryID], [Color], [Description], [PlateNumber], [Price], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (7, 3, N'Yellow', N'Xe 4 chỗ - Tốt', N'18K-2468', CAST(2500000 AS Decimal(18, 0)), 0, 1, N'Thanh', CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'Thanh', CAST(N'2020-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Car] ([CarID], [CategoryID], [Color], [Description], [PlateNumber], [Price], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (8, 1, N'White', N'Xe 7 chỗ - Tốt', N'26k-1357', CAST(4500000 AS Decimal(18, 0)), 0, 1, N'Thanh', CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'Thanh', CAST(N'2020-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Car] ([CarID], [CategoryID], [Color], [Description], [PlateNumber], [Price], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (10, 3, N'White', N'4 Chỗ - Good', N'36B4567', CAST(200000 AS Decimal(18, 0)), 0, 1, N'Thanh', CAST(N'2020-02-07T15:57:27.733' AS DateTime), N'Thanh', CAST(N'2020-02-14T11:51:50.610' AS DateTime))
INSERT [dbo].[Car] ([CarID], [CategoryID], [Color], [Description], [PlateNumber], [Price], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (11, 3, N'Blue', N'hyper', N'23k1245', CAST(200000 AS Decimal(18, 0)), 0, 1, N'Thanh', CAST(N'2020-02-07T16:01:06.130' AS DateTime), N'Thanh', CAST(N'2020-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Car] ([CarID], [CategoryID], [Color], [Description], [PlateNumber], [Price], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (12, 3, N'Blue', N'Yupp', N'99H13576', CAST(350000 AS Decimal(18, 0)), 0, 1, N'Thanh', CAST(N'2020-02-07T16:10:25.093' AS DateTime), N'Thanh', CAST(N'2020-02-14T11:52:14.127' AS DateTime))
INSERT [dbo].[Car] ([CarID], [CategoryID], [Color], [Description], [PlateNumber], [Price], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (15, 1, N'Red', N'', N'2645', CAST(200000 AS Decimal(18, 0)), 0, 0, N'Thanh', CAST(N'2020-02-12T16:30:12.650' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CategoryID], [Color], [Description], [PlateNumber], [Price], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (16, 3, N'Red', N'None', N'30L0987', CAST(4500000 AS Decimal(18, 0)), 0, 1, N'Thanh', CAST(N'2020-02-12T16:30:32.003' AS DateTime), N'Thanh', CAST(N'2020-02-17T15:39:49.920' AS DateTime))
INSERT [dbo].[Car] ([CarID], [CategoryID], [Color], [Description], [PlateNumber], [Price], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (17, 13, N'Red', N'Tốt', N'20k1357', CAST(200000 AS Decimal(18, 0)), 0, NULL, N'Thanh', CAST(N'2020-02-13T09:44:15.850' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CategoryID], [Color], [Description], [PlateNumber], [Price], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (18, 12, N'Blue', N'None', N'75H2589', CAST(350000 AS Decimal(18, 0)), 0, 0, N'Thanh', CAST(N'2020-02-14T10:40:24.750' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CategoryID], [Color], [Description], [PlateNumber], [Price], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (19, 3, N'Blue', N'Good Car', N'16k3576', CAST(200000 AS Decimal(18, 0)), 0, 0, N'Thanh', CAST(N'2020-02-14T10:53:15.750' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CategoryID], [Color], [Description], [PlateNumber], [Price], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (20, 12, N'Orange', N'Nope', N'18B1357', CAST(175000 AS Decimal(18, 0)), 0, 0, N'Thanh', CAST(N'2020-02-15T10:30:32.810' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Car] OFF
SET IDENTITY_INSERT [dbo].[CarCategory] ON 

INSERT [dbo].[CarCategory] ([CarCategoryID], [Name], [Description], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (3, N'Benz', N'Good', 0, 2, N'Thanh', CAST(N'2020-02-06T10:03:55.327' AS DateTime), N'Thanh', CAST(N'2020-02-06T15:02:58.540' AS DateTime))
INSERT [dbo].[CarCategory] ([CarCategoryID], [Name], [Description], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (11, N'BMW', N'Rich', 0, 1, N'Thanh', CAST(N'2020-02-13T09:40:45.517' AS DateTime), N'Thanh', NULL)
INSERT [dbo].[CarCategory] ([CarCategoryID], [Name], [Description], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (12, N'HUYNDAI', N'GOODDDD', 0, 4, N'Thanh', CAST(N'2020-02-13T09:41:37.840' AS DateTime), N'Thanh', CAST(N'2020-02-17T16:42:46.670' AS DateTime))
INSERT [dbo].[CarCategory] ([CarCategoryID], [Name], [Description], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (13, N'Ford', N'Ex', 0, 1, N'Thanh', CAST(N'2020-02-13T09:42:02.297' AS DateTime), N'Thanh', NULL)
INSERT [dbo].[CarCategory] ([CarCategoryID], [Name], [Description], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (14, N'Toyota', N'Ex', 0, 1, N'Thanh', CAST(N'2020-02-13T09:42:55.213' AS DateTime), N'Thanh', NULL)
INSERT [dbo].[CarCategory] ([CarCategoryID], [Name], [Description], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (15, N'Yamaha', N'Japan', 0, 1, N'Thanh', CAST(N'2020-02-14T14:59:25.727' AS DateTime), NULL, NULL)
INSERT [dbo].[CarCategory] ([CarCategoryID], [Name], [Description], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (16, N'Lexus', N'None', 0, NULL, N'Thanh', CAST(N'2020-02-14T15:11:32.547' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[CarCategory] OFF
SET IDENTITY_INSERT [dbo].[ServiceOrder] ON 

INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (1, 1, 2, 5, CAST(N'2020-02-05T14:46:13.397' AS DateTime), CAST(N'2020-02-05T14:46:13.643' AS DateTime), CAST(N'2020-02-11T09:58:29.000' AS DateTime), CAST(N'2020-02-13T09:58:32.000' AS DateTime), N'Thanh', N'Nope', 2, 0, 0, N'Thanh', CAST(N'2020-02-05T14:46:15.430' AS DateTime), N'Thanh', CAST(N'2020-02-05T14:46:15.937' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (2, 8, 2, 5, CAST(N'2020-02-05T14:46:21.227' AS DateTime), CAST(N'2020-02-05T14:46:21.227' AS DateTime), CAST(N'2020-02-05T14:46:21.227' AS DateTime), CAST(N'2020-02-05T14:46:21.227' AS DateTime), N'Thanh', N'&nbsp;', 1, 0, 1, N'Thanh', CAST(N'2020-02-05T14:46:21.227' AS DateTime), N'Thanh', CAST(N'2020-02-17T15:08:26.743' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (3, 1, 2, 5, CAST(N'2020-02-05T14:54:36.157' AS DateTime), CAST(N'2020-02-05T14:54:36.157' AS DateTime), CAST(N'2020-02-05T14:54:36.157' AS DateTime), CAST(N'2020-02-05T14:54:36.157' AS DateTime), N'Thanh', N'&nbsp;', 1, 0, 6, N'Thanh', CAST(N'2020-02-05T14:54:36.157' AS DateTime), N'Thanh', CAST(N'2020-02-17T14:46:23.417' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (4, 10, 2, 5, CAST(N'2020-02-07T16:18:00.593' AS DateTime), CAST(N'2020-02-07T16:18:00.593' AS DateTime), CAST(N'2020-02-07T16:18:00.597' AS DateTime), CAST(N'2020-02-07T16:18:00.597' AS DateTime), N'Thanh', N'&nbsp;', 1, 0, 4, N'Thanh', CAST(N'2020-02-07T16:18:00.597' AS DateTime), N'Thanh', CAST(N'2020-02-15T14:40:53.060' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (5, 11, 2, 5, CAST(N'2020-02-07T16:18:00.667' AS DateTime), CAST(N'2020-02-07T16:18:00.667' AS DateTime), CAST(N'2020-02-07T16:18:00.000' AS DateTime), CAST(N'2020-02-07T16:18:00.000' AS DateTime), N'Thanh', N'', 2, 0, 7, N'Thanh', CAST(N'2020-02-07T16:18:00.667' AS DateTime), N'Thanh', CAST(N'2020-02-12T18:17:54.857' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (6, 10, 2, 5, CAST(N'2020-02-07T02:06:00.000' AS DateTime), CAST(N'2020-02-07T00:03:00.000' AS DateTime), CAST(N'2020-02-07T14:57:48.000' AS DateTime), CAST(N'2020-02-14T15:02:46.000' AS DateTime), N'Thanh', N'', 2, 0, 5, N'Thanh', CAST(N'2020-02-07T17:16:19.423' AS DateTime), N'Thanh', CAST(N'2020-02-13T09:25:39.520' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (7, 8, 1, 24, CAST(N'2020-02-12T12:43:48.000' AS DateTime), CAST(N'2020-02-13T12:43:48.000' AS DateTime), CAST(N'2020-02-12T18:00:00.000' AS DateTime), CAST(N'2020-02-13T00:00:00.000' AS DateTime), N'Vũ Thanh', N'None', 2, 0, 3, N'Vũ Thanh', CAST(N'2020-02-12T12:44:25.007' AS DateTime), N'Thanh', CAST(N'2020-02-15T17:17:43.970' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (8, 8, 1, 24, CAST(N'2020-02-12T17:44:22.000' AS DateTime), CAST(N'2020-02-13T17:44:22.000' AS DateTime), NULL, NULL, N'Thanh', N'', 2, 0, 5, N'Thanh', CAST(N'2020-02-12T17:44:38.847' AS DateTime), N'Thanh', CAST(N'2020-02-12T18:18:10.563' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (9, 15, 1, 24, CAST(N'2020-02-12T17:44:22.000' AS DateTime), CAST(N'2020-02-13T17:44:22.000' AS DateTime), NULL, NULL, N'Thanh', N'', 1, 0, 2, N'Thanh', CAST(N'2020-02-12T17:44:38.920' AS DateTime), N'Thanh', CAST(N'2020-02-12T17:52:55.413' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (10, 8, 2, 1, CAST(N'2020-02-12T17:56:30.000' AS DateTime), CAST(N'2020-02-13T17:56:30.000' AS DateTime), NULL, NULL, N'Mike', N'', 0, 0, 3, N'Mike', CAST(N'2020-02-12T17:57:05.580' AS DateTime), N'Thanh', CAST(N'2020-02-17T15:16:58.673' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (11, 10, 2, 1, CAST(N'2020-02-15T00:00:00.000' AS DateTime), CAST(N'2020-02-16T00:00:00.000' AS DateTime), NULL, NULL, N'Đen Vâu', N'&nbsp;', 0, 0, 2, N'Đen Vâu', CAST(N'2020-02-15T10:04:56.563' AS DateTime), N'Thanh', CAST(N'2020-02-17T15:43:07.670' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (12, 10, 1, 24, CAST(N'2020-02-15T00:00:00.000' AS DateTime), CAST(N'2020-02-16T00:00:00.000' AS DateTime), NULL, NULL, N'', N'&nbsp;', 0, 0, 2, N'', CAST(N'2020-02-15T10:19:15.770' AS DateTime), N'Thanh', CAST(N'2020-02-17T15:43:15.500' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (13, 10, 1, 24, CAST(N'2020-02-15T00:00:00.000' AS DateTime), CAST(N'2020-02-16T00:00:00.000' AS DateTime), NULL, NULL, N'Thanh Vũ', N'&nbsp;', 0, 0, 0, N'Thanh Vũ', CAST(N'2020-02-15T10:38:25.350' AS DateTime), N'Thanh', CAST(N'2020-02-15T10:38:25.350' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (14, 8, 2, 1, CAST(N'2020-02-15T00:00:00.000' AS DateTime), CAST(N'2020-02-16T00:00:00.000' AS DateTime), NULL, NULL, N'Công Phượng', N'&nbsp;', 1, 0, 1, N'Công Phượng', CAST(N'2020-02-15T14:45:29.583' AS DateTime), N'Thanh', CAST(N'2020-02-17T15:43:23.397' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (15, 11, 1, 24, CAST(N'2020-02-15T00:00:00.000' AS DateTime), CAST(N'2020-02-16T00:00:00.000' AS DateTime), NULL, NULL, N'Công Vinh', N'&nbsp;', 1, 0, 1, N'Công Vinh', CAST(N'2020-02-15T14:45:40.397' AS DateTime), N'Thanh', CAST(N'2020-02-17T15:43:24.373' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (16, 10, 2, 1, CAST(N'2020-02-15T00:00:00.000' AS DateTime), CAST(N'2020-02-16T00:00:00.000' AS DateTime), NULL, NULL, N'Minz', N'&nbsp;', 0, 0, 2, N'Minz', CAST(N'2020-02-15T14:59:15.557' AS DateTime), N'Thanh', CAST(N'2020-02-17T15:43:18.090' AS DateTime))
INSERT [dbo].[ServiceOrder] ([OrderID], [CarID], [TimeCategory], [OrderDuration], [PlanStartDTG], [PlanEndDTG], [ActualStartDTG], [ActualEndDTG], [CustomerName], [Description], [Status], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (17, 10, 1, 149, CAST(N'2020-02-15T00:00:00.000' AS DateTime), CAST(N'2020-02-21T05:00:00.000' AS DateTime), NULL, NULL, N'Quang Lê', N'&nbsp;', 1, 0, 1, N'Quang Lê', CAST(N'2020-02-15T15:00:12.350' AS DateTime), N'Thanh', CAST(N'2020-02-15T15:01:36.390' AS DateTime))
SET IDENTITY_INSERT [dbo].[ServiceOrder] OFF
SET IDENTITY_INSERT [dbo].[TimeCategory] ON 

INSERT [dbo].[TimeCategory] ([TimeCategoryID], [Name], [Description], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (1, N'Giờ', N'Tính thời gian thuê theo giờ', 0, 0, N'Thanh', CAST(N'2020-02-12T00:00:00.000' AS DateTime), N'Thanh', CAST(N'2020-02-12T00:00:00.000' AS DateTime))
INSERT [dbo].[TimeCategory] ([TimeCategoryID], [Name], [Description], [Deleted], [Version], [CreatedBy], [CreatedDTG], [UpdatedBy], [UpdatedDTG]) VALUES (2, N'Ngày', N'Theo ngày', 0, 0, N'Thanh', CAST(N'2020-02-12T00:00:00.000' AS DateTime), N'Thanh', CAST(N'2020-02-12T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[TimeCategory] OFF
USE [master]
GO
ALTER DATABASE [BookCar] SET  READ_WRITE 
GO
