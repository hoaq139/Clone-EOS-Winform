USE [master]
GO
/****** Object:  Database [EosDB]    Script Date: 7/19/2023 9:10:39 AM ******/
CREATE DATABASE [EosDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EosDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EosDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EosDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EosDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EosDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EosDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EosDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EosDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EosDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EosDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EosDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [EosDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EosDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EosDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EosDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EosDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EosDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EosDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EosDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EosDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EosDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EosDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EosDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EosDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EosDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EosDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EosDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EosDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EosDB] SET RECOVERY FULL 
GO
ALTER DATABASE [EosDB] SET  MULTI_USER 
GO
ALTER DATABASE [EosDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EosDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EosDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EosDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EosDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EosDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'EosDB', N'ON'
GO
ALTER DATABASE [EosDB] SET QUERY_STORE = OFF
GO
USE [EosDB]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 7/19/2023 9:10:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[userid] [varchar](150) NOT NULL,
	[password] [varchar](150) NOT NULL,
	[displayname] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 7/19/2023 9:10:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[cid] [int] IDENTITY(1,1) NOT NULL,
	[ctitle] [varchar](150) NOT NULL,
	[userid] [varchar](150) NOT NULL,
	[tid] [int] NOT NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[cid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionPRN211]    Script Date: 7/19/2023 9:10:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionPRN211](
	[SubjectID] [nvarchar](50) NULL,
	[QuestionID] [nvarchar](50) NULL,
	[Questions] [nvarchar](50) NULL,
	[AnswerA] [nvarchar](50) NULL,
	[AnswerB] [nvarchar](50) NULL,
	[AnswerC] [nvarchar](50) NULL,
	[AnswerD] [nvarchar](50) NULL,
	[AnswerRight] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 7/19/2023 9:10:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[sid] [int] NOT NULL,
	[name] [varchar](150) NOT NULL,
	[gender] [bit] NOT NULL,
	[dob] [date] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[sid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentChoice]    Script Date: 7/19/2023 9:10:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentChoice](
	[QuestionID] [nvarchar](50) NULL,
	[Choice] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subject]    Script Date: 7/19/2023 9:10:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subject](
	[SubjectID] [int] NOT NULL,
	[Subject] [nchar](10) NOT NULL,
 CONSTRAINT [PK_subject] PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thread]    Script Date: 7/19/2023 9:10:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thread](
	[tid] [int] NOT NULL,
	[tcontent] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Thread] PRIMARY KEY CLUSTERED 
(
	[tid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/19/2023 9:10:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[account] [nchar](30) NOT NULL,
	[password] [nchar](30) NOT NULL,
	[name] [nchar](30) NOT NULL,
	[subject] [nchar](30) NOT NULL,
	[studentid] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[account] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([userid], [password], [displayname]) VALUES (N'mra', N'123', N'MR A')
INSERT [dbo].[Account] ([userid], [password], [displayname]) VALUES (N'mrb', N'123', N'MR B')
INSERT [dbo].[Account] ([userid], [password], [displayname]) VALUES (N'mrc', N'123', N'MR C')
GO
SET IDENTITY_INSERT [dbo].[Comment] ON 

INSERT [dbo].[Comment] ([cid], [ctitle], [userid], [tid]) VALUES (2, N'You can cheat', N'mra', 1)
INSERT [dbo].[Comment] ([cid], [ctitle], [userid], [tid]) VALUES (3, N':)) no way bro', N'mrb', 1)
INSERT [dbo].[Comment] ([cid], [ctitle], [userid], [tid]) VALUES (4, N'cheat does work, but don get catched', N'mrc', 1)
INSERT [dbo].[Comment] ([cid], [ctitle], [userid], [tid]) VALUES (5, N'because they are not hated by smarter people', N'mrc', 2)
INSERT [dbo].[Comment] ([cid], [ctitle], [userid], [tid]) VALUES (6, N'no idea', N'mra', 2)
SET IDENTITY_INSERT [dbo].[Comment] OFF
GO
INSERT [dbo].[QuestionPRN211] ([SubjectID], [QuestionID], [Questions], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [AnswerRight]) VALUES (N'PRN211', N'1', N'Mot nam co bao nhieu ngay', N'180', N'260', N'365', N'240', N'365')
INSERT [dbo].[QuestionPRN211] ([SubjectID], [QuestionID], [Questions], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [AnswerRight]) VALUES (N'PRN211', N'2', N'Thu do Viet Nam la gi?', N'HCM', N'Hanoi', N'Da Nang', N'Hue', N'Hanoi')
INSERT [dbo].[QuestionPRN211] ([SubjectID], [QuestionID], [Questions], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [AnswerRight]) VALUES (N'PRN211', N'3', N'100+20=', N'10', N'20', N'30', N'120', N'120')
INSERT [dbo].[QuestionPRN211] ([SubjectID], [QuestionID], [Questions], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [AnswerRight]) VALUES (N'PRN211', N'4', N'Tap doan FPT thanh lap nam nao?', N'1997', N'1998', N'1988', N'1987', N'1988')
INSERT [dbo].[QuestionPRN211] ([SubjectID], [QuestionID], [Questions], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [AnswerRight]) VALUES (N'PRN211', N'5', N'1+1=', N'2', N'3', N'4', N'5', N'2')
GO
INSERT [dbo].[Student] ([sid], [name], [gender], [dob]) VALUES (1, N'Violet Quinn', 0, CAST(N'1983-08-19' AS Date))
INSERT [dbo].[Student] ([sid], [name], [gender], [dob]) VALUES (2, N'Dax Benson', 1, CAST(N'1963-10-20' AS Date))
INSERT [dbo].[Student] ([sid], [name], [gender], [dob]) VALUES (3, N'Kristina Poole', 1, CAST(N'1975-09-29' AS Date))
INSERT [dbo].[Student] ([sid], [name], [gender], [dob]) VALUES (4, N'Sandra Lambert', 0, CAST(N'1965-10-11' AS Date))
INSERT [dbo].[Student] ([sid], [name], [gender], [dob]) VALUES (5, N'Ace Singh', 0, CAST(N'1988-11-13' AS Date))
INSERT [dbo].[Student] ([sid], [name], [gender], [dob]) VALUES (6, N'Dakota Mccullough
', 0, CAST(N'1987-11-24' AS Date))
INSERT [dbo].[Student] ([sid], [name], [gender], [dob]) VALUES (7, N'Jazlynn Sheppard
', 1, CAST(N'1976-07-23' AS Date))
GO
INSERT [dbo].[StudentChoice] ([QuestionID], [Choice]) VALUES (N'1', N'label5')
INSERT [dbo].[StudentChoice] ([QuestionID], [Choice]) VALUES (N'2', N'label5')
INSERT [dbo].[StudentChoice] ([QuestionID], [Choice]) VALUES (N'3', N'label5')
INSERT [dbo].[StudentChoice] ([QuestionID], [Choice]) VALUES (N'4', N'label5')
INSERT [dbo].[StudentChoice] ([QuestionID], [Choice]) VALUES (N'5', N'0')
INSERT [dbo].[StudentChoice] ([QuestionID], [Choice]) VALUES (N'0', N'0')
GO
INSERT [dbo].[Thread] ([tid], [tcontent]) VALUES (1, N'How to pass the subject without studying?')
INSERT [dbo].[Thread] ([tid], [tcontent]) VALUES (2, N'Why do stupid people live longer?')
INSERT [dbo].[Thread] ([tid], [tcontent]) VALUES (3, N'Am I the dumbest in class?')
GO
INSERT [dbo].[Users] ([account], [password], [name], [subject], [studentid]) VALUES (N'admin                         ', N'123                           ', N'Nguyen Van A                  ', N'PRN211                        ', N'HE123456                      ')
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Account] FOREIGN KEY([userid])
REFERENCES [dbo].[Account] ([userid])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Account]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Thread] FOREIGN KEY([tid])
REFERENCES [dbo].[Thread] ([tid])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Thread]
GO
USE [master]
GO
ALTER DATABASE [EosDB] SET  READ_WRITE 
GO
