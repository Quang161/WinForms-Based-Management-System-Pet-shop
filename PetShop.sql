USE [master]
GO
/****** Object:  Database [Petshop]    Script Date: 23/02/2025 18:52:14 ******/
CREATE DATABASE [Petshop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Petshop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Petshop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Petshop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Petshop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Petshop] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Petshop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Petshop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Petshop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Petshop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Petshop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Petshop] SET ARITHABORT OFF 
GO
ALTER DATABASE [Petshop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Petshop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Petshop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Petshop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Petshop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Petshop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Petshop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Petshop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Petshop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Petshop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Petshop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Petshop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Petshop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Petshop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Petshop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Petshop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Petshop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Petshop] SET RECOVERY FULL 
GO
ALTER DATABASE [Petshop] SET  MULTI_USER 
GO
ALTER DATABASE [Petshop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Petshop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Petshop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Petshop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Petshop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Petshop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Petshop', N'ON'
GO
ALTER DATABASE [Petshop] SET QUERY_STORE = ON
GO
ALTER DATABASE [Petshop] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Petshop]
GO
/****** Object:  Table [dbo].[BillingDetail]    Script Date: 23/02/2025 18:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillingDetail](
	[IDBill] [int] NULL,
	[IDProduct] [int] NULL,
	[Quantity] [int] NULL,
	[UnitPrice] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
	[IDDetail] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDDetail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillingTbl]    Script Date: 23/02/2025 18:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillingTbl](
	[Total] [decimal](18, 3) NOT NULL,
	[IDCustomer] [int] NOT NULL,
	[IDEmp] [int] NULL,
	[CDate] [date] NULL,
	[IDBill] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerTbl]    Script Date: 23/02/2025 18:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTbl](
	[IDCustomer] [int] IDENTITY(1,1) NOT NULL,
	[NameCustomer] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[Nickname] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[IDCustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeTbl]    Script Date: 23/02/2025 18:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeTbl](
	[IDEmp] [int] IDENTITY(1,1) NOT NULL,
	[NameEmp] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[DOB] [date] NULL,
	[Role] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Phone] [varchar](20) NULL,
	[Password] [nvarchar](50) NULL,
	[Permission] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDEmp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermissionTbl]    Script Date: 23/02/2025 18:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissionTbl](
	[PerId] [int] IDENTITY(1,1) NOT NULL,
	[PerType] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[PerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PetTbl]    Script Date: 23/02/2025 18:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PetTbl](
	[IDpet] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Age] [nvarchar](50) NOT NULL,
	[ColorAndPattern] [nvarchar](50) NOT NULL,
	[HealthStatus] [nvarchar](50) NOT NULL,
	[Species] [nvarchar](50) NULL,
	[IDCustomer] [int] NULL,
 CONSTRAINT [PK_Pet] PRIMARY KEY CLUSTERED 
(
	[IDpet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTbl]    Script Date: 23/02/2025 18:52:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTbl](
	[IDProduct] [int] IDENTITY(1,1) NOT NULL,
	[NameProduct] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 3) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[IDProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BillingDetail] ON 

INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (79, 8, 2, CAST(10.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), 36)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (80, 8, 2, CAST(10.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), 37)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (81, 8, 2, CAST(10.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), 38)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (82, 10, 2, CAST(20.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), 39)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (83, 16, 1, CAST(50.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), 40)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (84, 16, 2, CAST(50.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 41)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (85, 19, 2, CAST(65.00 AS Decimal(18, 2)), CAST(130.00 AS Decimal(18, 2)), 42)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (86, 15, 2, CAST(45.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), 43)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (87, 13, 2, CAST(35.00 AS Decimal(18, 2)), CAST(70.00 AS Decimal(18, 2)), 44)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (88, 10, 2, CAST(20.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), 45)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (89, 13, 3, CAST(35.00 AS Decimal(18, 2)), CAST(105.00 AS Decimal(18, 2)), 46)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (90, 12, 2, CAST(30.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), 47)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (91, 15, 3, CAST(45.00 AS Decimal(18, 2)), CAST(135.00 AS Decimal(18, 2)), 48)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (92, 14, 1, CAST(40.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), 49)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (92, 17, 1, CAST(55.00 AS Decimal(18, 2)), CAST(55.00 AS Decimal(18, 2)), 50)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (93, 18, 1, CAST(60.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), 51)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (93, 19, 2, CAST(65.00 AS Decimal(18, 2)), CAST(130.00 AS Decimal(18, 2)), 52)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (94, 16, 2, CAST(50.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 53)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (94, 19, 1, CAST(65.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), 54)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (95, 18, 2, CAST(60.00 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), 55)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (95, 16, 1, CAST(50.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), 56)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (96, 18, 2, CAST(60.00 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), 57)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (96, 15, 1, CAST(45.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), 58)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (97, 20, 2, CAST(70.00 AS Decimal(18, 2)), CAST(140.00 AS Decimal(18, 2)), 59)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (97, 18, 1, CAST(60.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), 60)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (98, 19, 1, CAST(65.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), 61)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (98, 18, 1, CAST(60.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), 62)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (99, 19, 1, CAST(65.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), 63)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (99, 18, 1, CAST(60.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), 64)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (99, 15, 1, CAST(45.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), 65)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (100, 19, 1, CAST(65.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), 66)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (100, 18, 1, CAST(60.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), 67)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (100, 15, 1, CAST(45.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), 68)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (101, 19, 1, CAST(65.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), 69)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (101, 18, 1, CAST(60.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), 70)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (101, 16, 1, CAST(50.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), 71)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (102, 10, 1, CAST(20.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), 72)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (102, 13, 1, CAST(35.00 AS Decimal(18, 2)), CAST(35.00 AS Decimal(18, 2)), 73)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (102, 9, 1, CAST(15.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), 74)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (103, 16, 1, CAST(50.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), 75)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (103, 15, 1, CAST(45.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), 76)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (103, 17, 1, CAST(55.00 AS Decimal(18, 2)), CAST(55.00 AS Decimal(18, 2)), 77)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (104, 10, 2, CAST(20.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), 78)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (104, 9, 1, CAST(15.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), 79)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (105, 9, 3, CAST(15.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), 80)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (105, 12, 4, CAST(30.00 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), 81)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (106, 15, 2, CAST(45.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), 82)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (106, 16, 1, CAST(50.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), 83)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (107, 15, 2, CAST(45.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), 84)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (107, 16, 1, CAST(50.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), 85)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (107, 18, 1, CAST(60.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), 86)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (108, 16, 1, CAST(50.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), 87)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (108, 15, 1, CAST(45.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), 88)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (108, 12, 1, CAST(30.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), 89)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (109, 13, 1, CAST(35.00 AS Decimal(18, 2)), CAST(35.00 AS Decimal(18, 2)), 90)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (109, 12, 1, CAST(30.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), 91)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (109, 16, 1, CAST(50.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), 92)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (110, 12, 2, CAST(30.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), 93)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (110, 13, 3, CAST(35.00 AS Decimal(18, 2)), CAST(105.00 AS Decimal(18, 2)), 94)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (110, 18, 1, CAST(60.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), 95)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (111, 19, 3, CAST(65.00 AS Decimal(18, 2)), CAST(195.00 AS Decimal(18, 2)), 96)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (111, 16, 1, CAST(50.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), 97)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (112, 14, 2, CAST(40.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), 98)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (112, 15, 2, CAST(45.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), 99)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (113, 14, 2, CAST(40.00 AS Decimal(18, 2)), CAST(80.00 AS Decimal(18, 2)), 100)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (113, 15, 2, CAST(45.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), 101)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (114, 10, 1, CAST(20.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), 102)
INSERT [dbo].[BillingDetail] ([IDBill], [IDProduct], [Quantity], [UnitPrice], [Total], [IDDetail]) VALUES (114, 12, 1, CAST(30.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), 103)
SET IDENTITY_INSERT [dbo].[BillingDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[BillingTbl] ON 

INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(20.000 AS Decimal(18, 3)), 23, 19, CAST(N'2024-09-10' AS Date), 79)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(20.000 AS Decimal(18, 3)), 23, 19, CAST(N'2024-09-10' AS Date), 80)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(20.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 81)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(40.000 AS Decimal(18, 3)), 24, 18, CAST(N'2024-09-10' AS Date), 82)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(50.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 83)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(100.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 84)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(130.000 AS Decimal(18, 3)), 25, 18, CAST(N'2024-09-10' AS Date), 85)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(90.000 AS Decimal(18, 3)), 27, 18, CAST(N'2024-09-10' AS Date), 86)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(70.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 87)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(40.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 88)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(105.000 AS Decimal(18, 3)), 24, 18, CAST(N'2024-09-10' AS Date), 89)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(60.000 AS Decimal(18, 3)), 28, 18, CAST(N'2024-09-10' AS Date), 90)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(135.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 91)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(95.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 92)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(190.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 93)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(165.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 94)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(170.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 95)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(165.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 96)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(200.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 97)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(125.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 98)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(170.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 99)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(170.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 100)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(175.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 101)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(70.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 102)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(150.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 103)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(55.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 104)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(165.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 105)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(140.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 106)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(200.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 107)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(125.000 AS Decimal(18, 3)), 24, 18, CAST(N'2024-09-10' AS Date), 108)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(115.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 109)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(225.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 110)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(245.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 111)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(170.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 112)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(170.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-10' AS Date), 113)
INSERT [dbo].[BillingTbl] ([Total], [IDCustomer], [IDEmp], [CDate], [IDBill]) VALUES (CAST(50.000 AS Decimal(18, 3)), 23, 18, CAST(N'2024-09-11' AS Date), 114)
SET IDENTITY_INSERT [dbo].[BillingTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[CustomerTbl] ON 

INSERT [dbo].[CustomerTbl] ([IDCustomer], [NameCustomer], [Gender], [Address], [Phone], [Nickname]) VALUES (23, N'Emily', N'Other', N'Q1', N'0987654321', N'Emily')
INSERT [dbo].[CustomerTbl] ([IDCustomer], [NameCustomer], [Gender], [Address], [Phone], [Nickname]) VALUES (24, N'Liam', N'Male', N'Q2', N'0987654321', N'Liam')
INSERT [dbo].[CustomerTbl] ([IDCustomer], [NameCustomer], [Gender], [Address], [Phone], [Nickname]) VALUES (25, N'Sophia', N'Female', N'Q3', N'0987654321', N'Sophia')
INSERT [dbo].[CustomerTbl] ([IDCustomer], [NameCustomer], [Gender], [Address], [Phone], [Nickname]) VALUES (26, N'Ethan', N'Male', N'Q4', N'0987654321', N'Ethan')
INSERT [dbo].[CustomerTbl] ([IDCustomer], [NameCustomer], [Gender], [Address], [Phone], [Nickname]) VALUES (27, N'Isabella', N'Female', N'Q5', N'0987654321', N'Isabella')
INSERT [dbo].[CustomerTbl] ([IDCustomer], [NameCustomer], [Gender], [Address], [Phone], [Nickname]) VALUES (28, N'Sans', N'Other', N'Q6', N'0987654321', N'Sans')
SET IDENTITY_INSERT [dbo].[CustomerTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[EmployeeTbl] ON 

INSERT [dbo].[EmployeeTbl] ([IDEmp], [NameEmp], [Gender], [DOB], [Role], [Address], [Phone], [Password], [Permission]) VALUES (18, N'TQuang', N'Male', CAST(N'2000-01-01' AS Date), N'Manager', N'Q1', N'0987654321', N'TQuang', 1)
INSERT [dbo].[EmployeeTbl] ([IDEmp], [NameEmp], [Gender], [DOB], [Role], [Address], [Phone], [Password], [Permission]) VALUES (19, N'HThang', N'Male', CAST(N'2000-02-02' AS Date), N'Clerk', N'Q2', N'0987654321', N'HThang', 2)
INSERT [dbo].[EmployeeTbl] ([IDEmp], [NameEmp], [Gender], [DOB], [Role], [Address], [Phone], [Password], [Permission]) VALUES (20, N'QPhu', N'Male', CAST(N'2000-03-03' AS Date), N'Accountant', N'Q3', N'0987654321', N'QPhu', 3)
SET IDENTITY_INSERT [dbo].[EmployeeTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[PermissionTbl] ON 

INSERT [dbo].[PermissionTbl] ([PerId], [PerType]) VALUES (1, N'Manager')
INSERT [dbo].[PermissionTbl] ([PerId], [PerType]) VALUES (2, N'Clerk')
INSERT [dbo].[PermissionTbl] ([PerId], [PerType]) VALUES (3, N'Accountant')
SET IDENTITY_INSERT [dbo].[PermissionTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[PetTbl] ON 

INSERT [dbo].[PetTbl] ([IDpet], [Name], [Gender], [Age], [ColorAndPattern], [HealthStatus], [Species], [IDCustomer]) VALUES (15, N'Bulldog', N'Male', N'7', N'White', N'Excellent', N'Dog', 23)
INSERT [dbo].[PetTbl] ([IDpet], [Name], [Gender], [Age], [ColorAndPattern], [HealthStatus], [Species], [IDCustomer]) VALUES (16, N'Beagle', N'Female', N'9', N'Yellow', N'Good', N'Dog', 24)
INSERT [dbo].[PetTbl] ([IDpet], [Name], [Gender], [Age], [ColorAndPattern], [HealthStatus], [Species], [IDCustomer]) VALUES (17, N'LaPerm ', N'Female', N'5', N'Blue', N'Fair', N'Cat', 25)
INSERT [dbo].[PetTbl] ([IDpet], [Name], [Gender], [Age], [ColorAndPattern], [HealthStatus], [Species], [IDCustomer]) VALUES (18, N'Pigeon', N'Other', N'4', N'Gray', N'Poor', N'Bird', 26)
INSERT [dbo].[PetTbl] ([IDpet], [Name], [Gender], [Age], [ColorAndPattern], [HealthStatus], [Species], [IDCustomer]) VALUES (20, N'Owl', N'Other', N'8', N'Brown', N'Critical', N'Bird', 27)
INSERT [dbo].[PetTbl] ([IDpet], [Name], [Gender], [Age], [ColorAndPattern], [HealthStatus], [Species], [IDCustomer]) VALUES (21, N'Nemo', N'Male', N'2', N'WRed', N'Excellent', N'Fish', 28)
SET IDENTITY_INSERT [dbo].[PetTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductTbl] ON 

INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (8, N'Food A', N'Food', 3, CAST(10.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (9, N'Food B', N'Food', 5, CAST(15.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (10, N'Food C', N'Food', 4, CAST(20.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (11, N'Toy A', N'Toy', 20, CAST(25.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (12, N'Toy B', N'Toy', 14, CAST(30.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (13, N'Toy C', N'Toy', 20, CAST(35.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (14, N'Extras A', N'Extras', 32, CAST(40.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (15, N'Extras B', N'Extras', 27, CAST(45.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (16, N'Extras C', N'Extras', 34, CAST(50.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (17, N'Furniture A', N'Furniture', 48, CAST(55.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (18, N'Furniture B', N'Furniture', 45, CAST(60.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (19, N'Furniture C', N'Furniture', 50, CAST(65.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (20, N'Random', N'', 67, CAST(70.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (21, N'Random', N'', 67, CAST(70.000 AS Decimal(18, 3)))
INSERT [dbo].[ProductTbl] ([IDProduct], [NameProduct], [Type], [Quantity], [Price]) VALUES (22, N'Random', N'', 67, CAST(70.000 AS Decimal(18, 3)))
SET IDENTITY_INSERT [dbo].[ProductTbl] OFF
GO
ALTER TABLE [dbo].[BillingDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillingDetail_BillingTbl] FOREIGN KEY([IDBill])
REFERENCES [dbo].[BillingTbl] ([IDBill])
GO
ALTER TABLE [dbo].[BillingDetail] CHECK CONSTRAINT [FK_BillingDetail_BillingTbl]
GO
ALTER TABLE [dbo].[BillingDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillingDetail_ProductTbl] FOREIGN KEY([IDProduct])
REFERENCES [dbo].[ProductTbl] ([IDProduct])
GO
ALTER TABLE [dbo].[BillingDetail] CHECK CONSTRAINT [FK_BillingDetail_ProductTbl]
GO
ALTER TABLE [dbo].[BillingTbl]  WITH CHECK ADD  CONSTRAINT [fk_customer_id] FOREIGN KEY([IDCustomer])
REFERENCES [dbo].[CustomerTbl] ([IDCustomer])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillingTbl] CHECK CONSTRAINT [fk_customer_id]
GO
ALTER TABLE [dbo].[BillingTbl]  WITH CHECK ADD  CONSTRAINT [fk_Emp_id] FOREIGN KEY([IDEmp])
REFERENCES [dbo].[EmployeeTbl] ([IDEmp])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillingTbl] CHECK CONSTRAINT [fk_Emp_id]
GO
ALTER TABLE [dbo].[EmployeeTbl]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeTbl_PermissionTbl] FOREIGN KEY([Permission])
REFERENCES [dbo].[PermissionTbl] ([PerId])
GO
ALTER TABLE [dbo].[EmployeeTbl] CHECK CONSTRAINT [FK_EmployeeTbl_PermissionTbl]
GO
ALTER TABLE [dbo].[PetTbl]  WITH CHECK ADD  CONSTRAINT [FK_Pet_Customer] FOREIGN KEY([IDCustomer])
REFERENCES [dbo].[CustomerTbl] ([IDCustomer])
GO
ALTER TABLE [dbo].[PetTbl] CHECK CONSTRAINT [FK_Pet_Customer]
GO
USE [master]
GO
ALTER DATABASE [Petshop] SET  READ_WRITE 
GO
