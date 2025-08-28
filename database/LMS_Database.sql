USE [LMS]
GO
GO
/****** Object:  Table [dbo].[Notifications]    Script Date: 6/9/2025 8:15:05 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Notifications]') AND type in (N'U'))
DROP TABLE [dbo].[Notifications]
GO
/****** Object:  Table [dbo].[LibraryLogEntry]    Script Date: 6/9/2025 8:15:05 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LibraryLogEntry]') AND type in (N'U'))
DROP TABLE [dbo].[LibraryLogEntry]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 6/9/2025 8:15:05 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Admin]') AND type in (N'U'))
DROP TABLE [dbo].[Admin]
GO
/****** Object:  View [dbo].[vw_OPACBooks]    Script Date: 6/9/2025 8:15:06 AM ******/
DROP VIEW [dbo].[vw_OPACBooks]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 6/9/2025 8:15:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Transactions]') AND type in (N'U'))
DROP TABLE [dbo].[Transactions]
GO
/****** Object:  Table [dbo].[Accession]    Script Date: 6/9/2025 8:15:06 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Accession]') AND type in (N'U'))
DROP TABLE [dbo].[Accession]
GO
/****** Object:  User [lms_user]    Script Date: 6/9/2025 8:15:06 AM ******/
-- DROP USER removed for installer safety
GO
-- USE master removed
GO
/****** Object:  Database [LMS]    Script Date: 6/9/2025 8:15:06 AM ******/
-- DROP DATABASE removed for installer safety
GO
/****** Object:  Database [LMS]    Script Date: 6/9/2025 8:15:06 AM ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'LMS')
BEGIN
    CREATE DATABASE [LMS];
END
GO
ALTER DATABASE [LMS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [LMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LMS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LMS] SET RECOVERY FULL 
GO
ALTER DATABASE [LMS] SET  MULTI_USER 
GO
ALTER DATABASE [LMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LMS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LMS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LMS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LMS', N'ON'
GO
ALTER DATABASE [LMS] SET QUERY_STORE = ON
GO
ALTER DATABASE [LMS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LMS]
GO
GO
/****** Object:  User [lms_user]    Script Date: 6/9/2025 8:15:06 AM ******/
CREATE USER [lms_user] FOR LOGIN [lms_user] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [lms_user]
GO
/****** Object:  Table [dbo].[Accession]    Script Date: 6/9/2025 8:15:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accession](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[DateReceived] [date] NULL,
	[MaterialType] [varchar](100) NULL,
	[Author] [varchar](255) NULL,
	[BookTitle] [varchar](255) NULL,
	[Edition] [varchar](50) NULL,
	[Volume] [varchar](50) NULL,
	[Pages] [int] NULL,
	[CostPrice] [decimal](10, 2) NULL,
	[Publisher] [varchar](255) NULL,
	[Year] [int] NULL,
	[Remarks] [varchar](500) NULL,
	[PhotoPath] [varchar](500) NULL,
 CONSTRAINT [PK_Accession] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 6/9/2025 8:15:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [int] NULL,
	[BookTitle] [varchar](255) NULL,
	[BorrowerName] [varchar](255) NULL,
	[BorrowDate] [datetime] NULL,
	[DueDate] [datetime] NULL,
	[ReturnDate] [datetime] NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_OPACBooks]    Script Date: 6/9/2025 8:15:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   VIEW [dbo].[vw_OPACBooks] AS
SELECT 
    A.BookID,
    A.BookTitle,
    A.Author,
    A.MaterialType,
    A.Year,
    A.PhotoPath,
    A.Edition,
    A.Volume,
    A.Pages,
    A.Publisher,
    -- Determine Status based on latest transaction
    ISNULL((
        SELECT TOP 1 
            CASE 
                WHEN ReturnDate IS NULL THEN 'Borrowed'
                ELSE 'Available'
            END
        FROM Transactions T
        WHERE T.BookID = A.BookID
        ORDER BY BorrowDate DESC
    ), 'Available') AS Status
FROM Accession A
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 6/9/2025 8:15:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[AdminUsername] [nvarchar](50) NULL,
	[AdminFullname] [nvarchar](100) NULL,
	[ContactInfo] [nvarchar](100) NULL,
	[Role] [nvarchar](20) NULL,
	[Password] [nvarchar](255) NULL,
	[ProfilePicturePath] [nvarchar](255) NULL,
	[OTPSecret] [nvarchar](64) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_AdminUsername] UNIQUE NONCLUSTERED 
(
	[AdminUsername] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LibraryLogEntry]    Script Date: 6/9/2025 8:15:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibraryLogEntry](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](255) NULL,
	[Role] [varchar](100) NULL,
	[Purpose] [varchar](100) NULL,
	[DateLogged] [date] NULL,
	[TimeIn] [datetime] NULL,
	[BookID] [int] NULL,
 CONSTRAINT [PK_LibraryLogEntry] PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notifications]    Script Date: 6/9/2025 8:15:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notifications](
	[NotificationID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NULL,
	[Message] [nvarchar](max) NULL,
	[Sender] [nvarchar](100) NULL,
	[DateCreated] [datetime] NULL,
	[IsRead] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[RelatedID] [int] NULL,
 CONSTRAINT [PK__Notifica__20CF2E32C377ACB8] PRIMARY KEY CLUSTERED 
(
	[NotificationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
-- USE master removed
GO
ALTER DATABASE [LMS] SET  READ_WRITE 
GO
