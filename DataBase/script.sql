USE [master]
GO
/****** Object:  Database [SuperMarket]    Script Date: 5/15/2017 6:48:19 PM ******/
CREATE DATABASE [SuperMarket]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SuperMarket', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SuperMarket.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SuperMarket_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SuperMarket_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SuperMarket] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SuperMarket].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SuperMarket] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SuperMarket] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SuperMarket] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SuperMarket] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SuperMarket] SET ARITHABORT OFF 
GO
ALTER DATABASE [SuperMarket] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SuperMarket] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SuperMarket] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SuperMarket] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SuperMarket] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SuperMarket] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SuperMarket] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SuperMarket] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SuperMarket] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SuperMarket] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SuperMarket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SuperMarket] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SuperMarket] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SuperMarket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SuperMarket] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SuperMarket] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SuperMarket] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SuperMarket] SET RECOVERY FULL 
GO
ALTER DATABASE [SuperMarket] SET  MULTI_USER 
GO
ALTER DATABASE [SuperMarket] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SuperMarket] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SuperMarket] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SuperMarket] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SuperMarket] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SuperMarket', N'ON'
GO
USE [SuperMarket]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 5/15/2017 6:48:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[GrandTotal] [money] NOT NULL,
	[IdStaff] [int] NOT NULL,
	[IdCustomer] [int] NOT NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BillDetail]    Script Date: 5/15/2017 6:48:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetail](
	[IdProduct] [int] NOT NULL,
	[IdBill] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[PriceExport] [money] NOT NULL,
 CONSTRAINT [PK_BillDetail] PRIMARY KEY CLUSTERED 
(
	[IdProduct] ASC,
	[IdBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 5/15/2017 6:48:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[PhoneNumber] [varchar](13) NOT NULL,
	[Date] [date] NULL,
	[Gender] [nvarchar](10) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Import]    Script Date: 5/15/2017 6:48:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Import](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[GrandTotal] [money] NOT NULL,
	[IdStaff] [int] NOT NULL,
 CONSTRAINT [PK_Export] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ImportDetail]    Script Date: 5/15/2017 6:48:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportDetail](
	[IdProduct] [int] NOT NULL,
	[IdImport] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[PriceImport] [money] NOT NULL,
 CONSTRAINT [PK_ExportDetail] PRIMARY KEY CLUSTERED 
(
	[IdProduct] ASC,
	[IdImport] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 5/15/2017 6:48:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Manufacturer] [nvarchar](50) NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
	[PriceImport] [money] NOT NULL,
	[PriceExport] [money] NOT NULL,
	[IdStall] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reponsitory]    Script Date: 5/15/2017 6:48:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reponsitory](
	[IdProduct] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Reponsitory] PRIMARY KEY CLUSTERED 
(
	[IdProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staff]    Script Date: 5/15/2017 6:48:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Staff](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Phone] [varchar](13) NOT NULL,
	[Position] [nvarchar](50) NULL,
	[Date] [date] NOT NULL,
	[Salary] [money] NOT NULL,
	[IdStall] [int] NOT NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stall]    Script Date: 5/15/2017 6:48:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stall](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Stall] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([Id], [Date], [GrandTotal], [IdStaff], [IdCustomer]) VALUES (1, CAST(N'2017-05-05' AS Date), 20000000.0000, 1, 1)
INSERT [dbo].[Bill] ([Id], [Date], [GrandTotal], [IdStaff], [IdCustomer]) VALUES (2, CAST(N'2017-05-15' AS Date), 120000.0000, 1, 2)
SET IDENTITY_INSERT [dbo].[Bill] OFF
INSERT [dbo].[BillDetail] ([IdProduct], [IdBill], [Quantity], [PriceExport]) VALUES (1, 1, 1, 20000000.0000)
INSERT [dbo].[BillDetail] ([IdProduct], [IdBill], [Quantity], [PriceExport]) VALUES (2, 1, 1, 30000000.0000)
INSERT [dbo].[BillDetail] ([IdProduct], [IdBill], [Quantity], [PriceExport]) VALUES (5, 2, 2, 10000.0000)
INSERT [dbo].[BillDetail] ([IdProduct], [IdBill], [Quantity], [PriceExport]) VALUES (6, 2, 1, 100000.0000)
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Date], [Gender]) VALUES (1, N'Hung Đẹp trai', N'Hà Nội', N'01234678', CAST(N'1996-05-05' AS Date), N'Nam')
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Date], [Gender]) VALUES (2, N'Khánh Lê', N'Hà Nam', N'1289506', CAST(N'2017-05-14' AS Date), N'Nam')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Import] ON 

INSERT [dbo].[Import] ([Id], [Date], [GrandTotal], [IdStaff]) VALUES (1, CAST(N'2017-05-05' AS Date), 249000000.0000, 1)
INSERT [dbo].[Import] ([Id], [Date], [GrandTotal], [IdStaff]) VALUES (5, CAST(N'2017-05-15' AS Date), 8500000.0000, 3)
SET IDENTITY_INSERT [dbo].[Import] OFF
INSERT [dbo].[ImportDetail] ([IdProduct], [IdImport], [Quantity], [PriceImport]) VALUES (1, 1, 1, 15000000.0000)
INSERT [dbo].[ImportDetail] ([IdProduct], [IdImport], [Quantity], [PriceImport]) VALUES (2, 1, 10, 20000000.0000)
INSERT [dbo].[ImportDetail] ([IdProduct], [IdImport], [Quantity], [PriceImport]) VALUES (3, 1, 2, 17000000.0000)
INSERT [dbo].[ImportDetail] ([IdProduct], [IdImport], [Quantity], [PriceImport]) VALUES (5, 5, 100, 5000.0000)
INSERT [dbo].[ImportDetail] ([IdProduct], [IdImport], [Quantity], [PriceImport]) VALUES (6, 5, 100, 80000.0000)
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Manufacturer], [Unit], [PriceImport], [PriceExport], [IdStall]) VALUES (1, N'Iphone', N'Apple', N'Chiếc', 15000000.0000, 20000000.0000, 1)
INSERT [dbo].[Product] ([Id], [Name], [Manufacturer], [Unit], [PriceImport], [PriceExport], [IdStall]) VALUES (2, N'SamSung s8', N'SamSung', N'Chiếc', 20000000.0000, 30000000.0000, 1)
INSERT [dbo].[Product] ([Id], [Name], [Manufacturer], [Unit], [PriceImport], [PriceExport], [IdStall]) VALUES (3, N'Dell 1487', N'Dell', N'Chiếc', 17000000.0000, 20000000.0000, 2)
INSERT [dbo].[Product] ([Id], [Name], [Manufacturer], [Unit], [PriceImport], [PriceExport], [IdStall]) VALUES (4, N'Lenovo G57', N'Lenovo', N'Chiếc', 10000000.0000, 15000000.0000, 2)
INSERT [dbo].[Product] ([Id], [Name], [Manufacturer], [Unit], [PriceImport], [PriceExport], [IdStall]) VALUES (5, N'Rau Muống', N'Sạch', N'Mớ', 5000.0000, 10000.0000, 3)
INSERT [dbo].[Product] ([Id], [Name], [Manufacturer], [Unit], [PriceImport], [PriceExport], [IdStall]) VALUES (6, N'Thị Lợn', N'Sạch', N'Cân', 80000.0000, 100000.0000, 4)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Reponsitory] ON 

INSERT [dbo].[Reponsitory] ([IdProduct], [Quantity]) VALUES (1, 100)
SET IDENTITY_INSERT [dbo].[Reponsitory] OFF
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([Id], [Name], [Address], [Phone], [Position], [Date], [Salary], [IdStall]) VALUES (1, N'HungTran', N'VinhPhuc', N'0123456789', N'Giám Đốc', CAST(N'1996-05-05' AS Date), 200000.0000, 1)
INSERT [dbo].[Staff] ([Id], [Name], [Address], [Phone], [Position], [Date], [Salary], [IdStall]) VALUES (3, N'Nam Phong', N'VinhPhuc', N'0123456789', N'Nhân viên', CAST(N'1996-05-05' AS Date), 200000.0000, 1)
INSERT [dbo].[Staff] ([Id], [Name], [Address], [Phone], [Position], [Date], [Salary], [IdStall]) VALUES (4, N'Nguyễn Ánh', N'hà nội', N'012934845', N'nhân viên', CAST(N'2017-05-14' AS Date), 1200000.0000, 1)
INSERT [dbo].[Staff] ([Id], [Name], [Address], [Phone], [Position], [Date], [Salary], [IdStall]) VALUES (6, N'Lê Quốc Khánh', N'Thanh Xuân', N'01647689122', N'Bồi Bàn', CAST(N'1996-08-14' AS Date), 1200000.0000, 1)
SET IDENTITY_INSERT [dbo].[Staff] OFF
SET IDENTITY_INSERT [dbo].[Stall] ON 

INSERT [dbo].[Stall] ([Id], [Name]) VALUES (1, N'Điện thoại')
INSERT [dbo].[Stall] ([Id], [Name]) VALUES (2, N'Máy tính')
INSERT [dbo].[Stall] ([Id], [Name]) VALUES (3, N'Rau củ')
INSERT [dbo].[Stall] ([Id], [Name]) VALUES (4, N'Thị cá')
INSERT [dbo].[Stall] ([Id], [Name]) VALUES (5, N'Quần áo')
SET IDENTITY_INSERT [dbo].[Stall] OFF
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Customer] FOREIGN KEY([IdCustomer])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Customer]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Staff] FOREIGN KEY([IdStaff])
REFERENCES [dbo].[Staff] ([Id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Staff]
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillDetail_Bill] FOREIGN KEY([IdBill])
REFERENCES [dbo].[Bill] ([Id])
GO
ALTER TABLE [dbo].[BillDetail] CHECK CONSTRAINT [FK_BillDetail_Bill]
GO
ALTER TABLE [dbo].[BillDetail]  WITH CHECK ADD  CONSTRAINT [FK_BillDetail_Product] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[BillDetail] CHECK CONSTRAINT [FK_BillDetail_Product]
GO
ALTER TABLE [dbo].[Import]  WITH CHECK ADD  CONSTRAINT [FK_Export_Staff] FOREIGN KEY([IdStaff])
REFERENCES [dbo].[Staff] ([Id])
GO
ALTER TABLE [dbo].[Import] CHECK CONSTRAINT [FK_Export_Staff]
GO
ALTER TABLE [dbo].[ImportDetail]  WITH CHECK ADD  CONSTRAINT [FK_ImportDetail_Import] FOREIGN KEY([IdImport])
REFERENCES [dbo].[Import] ([Id])
GO
ALTER TABLE [dbo].[ImportDetail] CHECK CONSTRAINT [FK_ImportDetail_Import]
GO
ALTER TABLE [dbo].[ImportDetail]  WITH CHECK ADD  CONSTRAINT [FK_ImportDetail_Product] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[ImportDetail] CHECK CONSTRAINT [FK_ImportDetail_Product]
GO
ALTER TABLE [dbo].[Reponsitory]  WITH CHECK ADD  CONSTRAINT [FK_Reponsitory_Product] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[Reponsitory] CHECK CONSTRAINT [FK_Reponsitory_Product]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Stall] FOREIGN KEY([IdStall])
REFERENCES [dbo].[Stall] ([Id])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Stall]
GO
USE [master]
GO
ALTER DATABASE [SuperMarket] SET  READ_WRITE 
GO
