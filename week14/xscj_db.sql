USE [master]
GO
/****** Object:  Database [xscj_db]    Script Date: 2019-06-05 13:12:27 ******/
CREATE DATABASE [xscj_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'xscj_db', FILENAME = N'D:\Githome\csharp_homework\week14\xscj_db.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'xscj_db_log', FILENAME = N'D:\Githome\csharp_homework\week14\xscj_db_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [xscj_db] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [xscj_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [xscj_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [xscj_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [xscj_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [xscj_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [xscj_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [xscj_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [xscj_db] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [xscj_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [xscj_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [xscj_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [xscj_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [xscj_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [xscj_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [xscj_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [xscj_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [xscj_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [xscj_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [xscj_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [xscj_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [xscj_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [xscj_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [xscj_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [xscj_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [xscj_db] SET RECOVERY FULL 
GO
ALTER DATABASE [xscj_db] SET  MULTI_USER 
GO
ALTER DATABASE [xscj_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [xscj_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [xscj_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [xscj_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'xscj_db', N'ON'
GO
USE [xscj_db]
GO
/****** Object:  User [xscjgl_sa]    Script Date: 2019-06-05 13:12:27 ******/
CREATE USER [xscjgl_sa] FOR LOGIN [xscjgl_sa] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [xscjgl_sa]
GO
/****** Object:  Table [dbo].[Table_Czy]    Script Date: 2019-06-05 13:12:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_Czy](
	[UserId] [varchar](10) NOT NULL,
	[UserName] [varchar](10) NOT NULL,
	[UserLevel] [int] NOT NULL,
	[UserPwd] [varchar](15) NOT NULL,
	[UserIsStoped] [bit] NOT NULL,
	[UserRegDate] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Table_Czy] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Table_Kcxx]    Script Date: 2019-06-05 13:12:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_Kcxx](
	[课程号] [varchar](5) NOT NULL,
	[课程名] [varchar](20) NULL,
	[课程类别] [varchar](10) NULL,
	[学分] [smallint] NULL,
	[开课学期] [varchar](10) NULL,
 CONSTRAINT [PK_Table_Kcxx] PRIMARY KEY CLUSTERED 
(
	[课程号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Table_Xscj]    Script Date: 2019-06-05 13:12:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_Xscj](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[学号] [varchar](8) NOT NULL,
	[课程号] [varchar](5) NOT NULL,
	[成绩] [decimal](6, 1) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Table_Xsxx]    Script Date: 2019-06-05 13:12:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_Xsxx](
	[学号] [varchar](8) NOT NULL,
	[姓名] [varchar](10) NOT NULL,
	[性别] [varchar](2) NOT NULL,
	[年级] [smallint] NOT NULL,
	[学院] [varchar](10) NOT NULL,
	[专业] [varchar](10) NOT NULL,
	[班级] [varchar](20) NOT NULL,
	[电话] [varchar](10) NULL,
 CONSTRAINT [PK_Table_Xsxx] PRIMARY KEY CLUSTERED 
(
	[学号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Table_Czy] ([UserId], [UserName], [UserLevel], [UserPwd], [UserIsStoped], [UserRegDate]) VALUES (N'admin', N'系统管理员', -1, N'admin123', 0, CAST(0xAA5903DC AS SmallDateTime))
GO
INSERT [dbo].[Table_Czy] ([UserId], [UserName], [UserLevel], [UserPwd], [UserIsStoped], [UserRegDate]) VALUES (N'xieyunc', N'小宇飞刀', 0, N'12345678', 0, CAST(0xAA5903E0 AS SmallDateTime))
GO
INSERT [dbo].[Table_Czy] ([UserId], [UserName], [UserLevel], [UserPwd], [UserIsStoped], [UserRegDate]) VALUES (N'zhangs', N'张三', 1, N'123456', 0, CAST(0xAA5903E0 AS SmallDateTime))
GO
ALTER TABLE [dbo].[Table_Czy] ADD  CONSTRAINT [DF_Table_1_IsStoped]  DEFAULT ((0)) FOR [UserIsStoped]
GO
ALTER TABLE [dbo].[Table_Czy] ADD  CONSTRAINT [DF_Table_Czy_UserRegDate]  DEFAULT (getdate()) FOR [UserRegDate]
GO
USE [master]
GO
ALTER DATABASE [xscj_db] SET  READ_WRITE 
GO
