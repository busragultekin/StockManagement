USE [master]
GO
/****** Object:  Database [StockManagement]    Script Date: 9.4.2019 10:44:02 ******/
CREATE DATABASE [StockManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StockManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StockManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StockManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [StockManagement] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StockManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StockManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StockManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StockManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StockManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StockManagement] SET  MULTI_USER 
GO
ALTER DATABASE [StockManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StockManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StockManagement] SET QUERY_STORE = OFF
GO
USE [StockManagement]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [StockManagement]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 9.4.2019 10:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhoneCase]    Script Date: 9.4.2019 10:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhoneCase](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[Price] [decimal](18, 0) NULL,
	[CaseColor] [int] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_PhoneCase] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phones]    Script Date: 9.4.2019 10:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](150) NULL,
	[Price] [decimal](18, 0) NULL,
	[IMEI1] [nvarchar](50) NULL,
	[IMEI2] [nvarchar](50) NULL,
	[BrandID] [int] NULL,
	[ModelCode] [nvarchar](50) NULL,
 CONSTRAINT [PK_Phones] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [Quantity]    Script Date: 9.4.2019 10:44:03 ******/
CREATE NONCLUSTERED INDEX [Quantity] ON [dbo].[PhoneCase]
(
	[Quantity] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Phones]  WITH CHECK ADD  CONSTRAINT [FK_Phones_Brands] FOREIGN KEY([BrandID])
REFERENCES [dbo].[Brands] ([ID])
GO
ALTER TABLE [dbo].[Phones] CHECK CONSTRAINT [FK_Phones_Brands]
GO
/****** Object:  StoredProcedure [dbo].[AddStock]    Script Date: 9.4.2019 10:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[AddStock]
@id int,
@qty int
As
Begin
Update PhoneCase set
Quantity=Quantity+@qty where ID=@id
End
GO
/****** Object:  StoredProcedure [dbo].[DeleteBrand]    Script Date: 9.4.2019 10:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteBrand]
@ID int
AS 
BEGIN
DELETE FROM Brands WHERE ID=@ID
END


GO
/****** Object:  StoredProcedure [dbo].[DeletePhone]    Script Date: 9.4.2019 10:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[DeletePhone]
@ID int
AS
BEGIN
	DELETE FROM Phones WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[DeletePhoneCase]    Script Date: 9.4.2019 10:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[DeletePhoneCase]
@ID int
As
Begin
	Delete From PhoneCase where ID=@ID
End
GO
/****** Object:  StoredProcedure [dbo].[GetAvailableProducts]    Script Date: 9.4.2019 10:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAvailableProducts]
@q as nvarchar(50) = NULL
AS
BEGIN
	Declare @sql AS nvarchar(MAX)
	SET @sql ='SELECT ID, ProductName, Price, IMEI1, IMEI2 From Phones'
IF(@q IS NOT NULL)
BEGIN
    SET @sql+='WHERE  ProductName LIKE ''%'+ @q+'%'''
	SET @sql+='OR IMEI1 LIKE ''%'+ @q+'%'''
	SET @sql+='OR IMEI2 LIKE ''%'+ @q+'%'''
	SET @sql+='OR ModelCode LIKE ''%'+ @q+'%'''
END
SET @sql +=' UNION ALL '
SET @sql += 'SELECT ID, ProductName, Price, '''', '''' From PhoneCase '

IF(@q IS NOT NULL)
	SET @sql += ' Where ProductName LIKE ''%'+ @q +'%'''

	--SELECT @sql
	exec @sql
END
GO
/****** Object:  StoredProcedure [dbo].[GetPhones]    Script Date: 9.4.2019 10:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetPhones]
AS
BEGIN
	SELECT p.*,b.ID AS BID, b.BrandName FROM Phones p inner join Brands b 
	ON p.BrandID=b.ID  ORDER BY BrandID,ProductName
END
GO
/****** Object:  StoredProcedure [dbo].[InsertPhone]    Script Date: 9.4.2019 10:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertPhone] 
@ProductName nvarchar(150),
@Price decimal,
@IMEI1 nvarchar(50),
@IMEI2 nvarchar(50),
@BrandID int,
@ModelCode nvarchar(50)
AS
BEGIN
	INSERT INTO Phones (ProductName,Price,IMEI1,IMEI2,BrandID,ModelCode)
	VALUES(@ProductName,@Price,@IMEI1,@IMEI2,@BrandID,@ModelCode)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertPhoneCases]    Script Date: 9.4.2019 10:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[InsertPhoneCases]
@ProductName nvarchar(50),
@Price decimal,
@CaseColor int,
@Quantity int
AS
BEGIN
	Insert Into PhoneCase (ProductName,Price,CaseColor,Quantity) 
	Values (@ProductName,@Price,@CaseColor,@Quantity)
END
GO
/****** Object:  StoredProcedure [dbo].[SearchPhone]    Script Date: 9.4.2019 10:44:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SearchPhone]
@BrandID int,
@ModelCode nvarchar(50)
AS
BEGIN

select * from Phones p inner join Brands b
on p.BrandID=b.ID 
where (p.BrandID=@BrandID or @BrandID=0) and 
(ModelCode like '%'+ @ModelCode + '%'or @ModelCode='')
END
GO
USE [master]
GO
ALTER DATABASE [StockManagement] SET  READ_WRITE 
GO
