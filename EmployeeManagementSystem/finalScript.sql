USE [master]
GO
/****** Object:  Database [Employee]    Script Date: 12/07/2014 20:33:00 ******/
CREATE DATABASE [Employee] ON  PRIMARY 
( NAME = N'Employee', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLSERVER\MSSQL\DATA\Employee.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Employee_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLSERVER\MSSQL\DATA\Employee_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Employee] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Employee].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Employee] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Employee] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Employee] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Employee] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Employee] SET ARITHABORT OFF
GO
ALTER DATABASE [Employee] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Employee] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Employee] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Employee] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Employee] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Employee] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Employee] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Employee] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Employee] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Employee] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Employee] SET  DISABLE_BROKER
GO
ALTER DATABASE [Employee] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Employee] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Employee] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Employee] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Employee] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Employee] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Employee] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Employee] SET  READ_WRITE
GO
ALTER DATABASE [Employee] SET RECOVERY FULL
GO
ALTER DATABASE [Employee] SET  MULTI_USER
GO
ALTER DATABASE [Employee] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Employee] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Employee', N'ON'
GO
USE [Employee]
GO
/****** Object:  Table [dbo].[EmpLeave]    Script Date: 12/07/2014 20:33:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmpLeave](
	[EmpId] [int] NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[Reason] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[EmpLeave] ([EmpId], [FromDate], [ToDate], [Reason]) VALUES (3, CAST(0x0000A3E000000000 AS DateTime), CAST(0x0000A3E100000000 AS DateTime), N'sick')
INSERT [dbo].[EmpLeave] ([EmpId], [FromDate], [ToDate], [Reason]) VALUES (3, CAST(0x0000A40400000000 AS DateTime), CAST(0x0000A40600000000 AS DateTime), N'sick again')
INSERT [dbo].[EmpLeave] ([EmpId], [FromDate], [ToDate], [Reason]) VALUES (3, CAST(0x0000A3F700000000 AS DateTime), CAST(0x0000A3FD00000000 AS DateTime), N'I am sick of ')
INSERT [dbo].[EmpLeave] ([EmpId], [FromDate], [ToDate], [Reason]) VALUES (3, CAST(0x0000A3F700000000 AS DateTime), CAST(0x0000A3F800000000 AS DateTime), N's')
INSERT [dbo].[EmpLeave] ([EmpId], [FromDate], [ToDate], [Reason]) VALUES (3, CAST(0x0000A3FE00000000 AS DateTime), CAST(0x0000A3FE00000000 AS DateTime), N'sa')
INSERT [dbo].[EmpLeave] ([EmpId], [FromDate], [ToDate], [Reason]) VALUES (3, CAST(0x0000A40500000000 AS DateTime), CAST(0x0000A40500000000 AS DateTime), N'a')
INSERT [dbo].[EmpLeave] ([EmpId], [FromDate], [ToDate], [Reason]) VALUES (3, CAST(0x0000A3FB00000000 AS DateTime), CAST(0x0000A3FC00000000 AS DateTime), N'as')
INSERT [dbo].[EmpLeave] ([EmpId], [FromDate], [ToDate], [Reason]) VALUES (100000000, CAST(0x0000A3FE00000000 AS DateTime), CAST(0x0000A3FE00000000 AS DateTime), N'ew')
INSERT [dbo].[EmpLeave] ([EmpId], [FromDate], [ToDate], [Reason]) VALUES (100000000, CAST(0x0000A3F700000000 AS DateTime), CAST(0x0000A3F800000000 AS DateTime), N'a')
INSERT [dbo].[EmpLeave] ([EmpId], [FromDate], [ToDate], [Reason]) VALUES (100000000, CAST(0x0000A40300000000 AS DateTime), CAST(0x0000A40400000000 AS DateTime), N'asd')
INSERT [dbo].[EmpLeave] ([EmpId], [FromDate], [ToDate], [Reason]) VALUES (100000000, CAST(0x0000A40600000000 AS DateTime), CAST(0x0000A40D00000000 AS DateTime), N'as')
INSERT [dbo].[EmpLeave] ([EmpId], [FromDate], [ToDate], [Reason]) VALUES (100000000, CAST(0x0000A40200000000 AS DateTime), CAST(0x0000A40300000000 AS DateTime), N'w')
/****** Object:  Table [dbo].[EmpDetails]    Script Date: 12/07/2014 20:33:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmpDetails](
	[FirstName] [varchar](50) NULL,
	[MiddleName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[ZipCode] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[EmailId] [varchar](50) NULL,
	[EmpId] [int] IDENTITY(100000000,1) NOT NULL,
	[Department] [varchar](50) NULL,
	[Picture] [varchar](50) NULL,
	[Salary] [decimal](18, 2) NULL,
	[Leaves] [int] NULL,
	[Position] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[EmpDetails] ON
INSERT [dbo].[EmpDetails] ([FirstName], [MiddleName], [LastName], [Address], [City], [ZipCode], [State], [PhoneNumber], [EmailId], [EmpId], [Department], [Picture], [Salary], [Leaves], [Position]) VALUES (N'polly', N'', N'', N'', N'', N'-', N'', N'1234567890', N'qw@fe.co', 100000000, N'Transport', NULL, CAST(12.00 AS Decimal(18, 2)), 22, N'')
INSERT [dbo].[EmpDetails] ([FirstName], [MiddleName], [LastName], [Address], [City], [ZipCode], [State], [PhoneNumber], [EmailId], [EmpId], [Department], [Picture], [Salary], [Leaves], [Position]) VALUES (N'pol', N'm', N'm', N'', N'', N'-', N'', N'1234', N'sa@we.co', 100000001, N'Sales', NULL, CAST(22.00 AS Decimal(18, 2)), 1, N'')
SET IDENTITY_INSERT [dbo].[EmpDetails] OFF
/****** Object:  Table [dbo].[EmpAttendance]    Script Date: 12/07/2014 20:33:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpAttendance](
	[Month] [int] NULL,
	[Empld] [int] NULL,
	[DaysPresent] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpAtt]    Script Date: 12/07/2014 20:33:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpAtt](
	[EmpId] [int] NULL,
	[DateCurrent] [datetime] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[EmpAtt] ([EmpId], [DateCurrent]) VALUES (100000000, CAST(0x0000A3FA009EA27C AS DateTime))
INSERT [dbo].[EmpAtt] ([EmpId], [DateCurrent]) VALUES (100000000, CAST(0x0000A3F9009EA27C AS DateTime))
INSERT [dbo].[EmpAtt] ([EmpId], [DateCurrent]) VALUES (100000000, CAST(0x0000A3F8009EA27C AS DateTime))
INSERT [dbo].[EmpAtt] ([EmpId], [DateCurrent]) VALUES (100000000, CAST(0x0000A3DA009EA27C AS DateTime))
INSERT [dbo].[EmpAtt] ([EmpId], [DateCurrent]) VALUES (100000000, CAST(0x0000A3F7009EA27C AS DateTime))
/****** Object:  Table [dbo].[EmailLog]    Script Date: 12/07/2014 20:33:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmailLog](
	[mailMsg] [varchar](1500) NULL,
	[DateofLog] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[EmailLog] ([mailMsg], [DateofLog]) VALUES (N' Emp Id with100000000has applied leave from 12/15/2014 12:00:00 AM to 12/16/2014 12:00:00 AM for the particular reason w Failure sending mail.', CAST(0x0000A3F900B9ED84 AS DateTime))
/****** Object:  Table [dbo].[Dept]    Script Date: 12/07/2014 20:33:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dept](
	[deptName] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Dept] ([deptName]) VALUES (N'Sales')
INSERT [dbo].[Dept] ([deptName]) VALUES (N'Marketing')
INSERT [dbo].[Dept] ([deptName]) VALUES (N'Transport')
/****** Object:  Table [dbo].[users]    Script Date: 12/07/2014 20:33:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[IsAdmin] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[users] ([username], [password], [IsAdmin]) VALUES (N'user', N'user', 1)
INSERT [dbo].[users] ([username], [password], [IsAdmin]) VALUES (N'1', N'welcome', 0)
INSERT [dbo].[users] ([username], [password], [IsAdmin]) VALUES (N'2', N'welcome', 0)
INSERT [dbo].[users] ([username], [password], [IsAdmin]) VALUES (N'3', N'welcome', 0)
INSERT [dbo].[users] ([username], [password], [IsAdmin]) VALUES (N'4', N'welcome', 0)
INSERT [dbo].[users] ([username], [password], [IsAdmin]) VALUES (N'5', N'ruin', 0)
INSERT [dbo].[users] ([username], [password], [IsAdmin]) VALUES (N'6', N'welcome', 0)
INSERT [dbo].[users] ([username], [password], [IsAdmin]) VALUES (N'7', N'welcome', 0)
INSERT [dbo].[users] ([username], [password], [IsAdmin]) VALUES (N'100000000', N'welcome', 0)
INSERT [dbo].[users] ([username], [password], [IsAdmin]) VALUES (N'100000001', N'welcome', 0)
/****** Object:  StoredProcedure [dbo].[UpdateEmp]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[UpdateEmp]
@inEmpId int,
@inEmpFname varchar(50),
@inEmpMname varchar(50),
@inEmpLname varchar(50),
@inEmpAdd varchar(50),
@inEmpCity varchar(50),
@inZipCode varchar(50),
@inEmpState varchar(50),
@inEmpPhNo varchar(50),
@inEmpEmail varchar(50),
@inEmpDepart varchar(50),
@inEmpPic varchar(50),
@inEmpSal decimal(18,2),
@inEmpLeaves int,
@inEmpPosition varchar(50)
as begin 
update EmpDetails SET FirstName=@inEmpFname,
MiddleName=@inEmpMname,
LastName=@inEmpLname,
[Address]=@inEmpAdd,
City=@inEmpCity,
ZipCode=@inZipCode,
[State]=@inEmpState,
PhoneNumber=@inEmpPhNo,
EmailId=@inEmpEmail,
Department=@inEmpDepart,
Picture=@inEmpPic,
Salary=@inEmpSal,
Leaves=@inEmpLeaves,
Position=@inEmpPosition
where EmpId=@inEmpId
END
GO
/****** Object:  StoredProcedure [dbo].[InsertLeave]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertLeave]
@in_EmpId int,
@in_Todate datetime,
@in_FromDate datetime,
@in_descr varchar(50)
as
begin
insert into EmpLeave VALUES(@in_EmpId,
@in_Todate,
@in_FromDate,
@in_descr

)
end
GO
/****** Object:  StoredProcedure [dbo].[insertEmployee]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertEmployee]  
--@inEmpId int,  
@inEmpFname varchar(50),  
@inEmpMname varchar(50),  
@inEmpLname varchar(50),  
@inEmpAdd varchar(50),  
@inEmpCity varchar(50),  
@inZipCode varchar(50),  
@inEmpState varchar(50),  
@inEmpPhNo varchar(50),  
@inEmpEmail varchar(50),  
@inEmpDepart varchar(50),  
@inEmpPic varchar(50),  
@inEmpSal decimal(18,2),  
@inEmpLeaves int,  
@inEmpPosition varchar(50)  
  
as begin   
DECLARE @empId  Int  
  
  
insert into EmpDetails VALUES(  
@inEmpFname,  
@inEmpMname,   
@inEmpLname,  
@inEmpAdd,  
@inEmpCity,  
@inZipCode,  
@inEmpState,  
@inEmpPhNo,  
@inEmpEmail,  
@inEmpDepart,  
@inEmpPic,  
@inEmpSal,  
@inEmpLeaves,  
@inEmpPosition)  
  
SELECT @empId =  SCOPE_IDENTITY();  
insert into users VALUES (@empId,'welcome',0)  
  
end
GO
/****** Object:  StoredProcedure [dbo].[InsertEmailLog]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[InsertEmailLog]
@in_emsg varchar(1000)

as
begin
insert into EmailLog VALUES(@in_emsg,GETUTCDATE())
end
GO
/****** Object:  StoredProcedure [dbo].[GetSalaryonAttend]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetSalaryonAttend]
@in_EmpId int,
@in_month int
as
begin

SELECT * from EmpAtt where DATEPART(mm,DateCurrent)=@in_month and DateName(dw,DateCurrent) Not in ('Saturday','Sunday') and EmpId=@in_empid
end
GO
/****** Object:  StoredProcedure [dbo].[GetSalary]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetSalary]  
@in_empId int  
AS  
begin  
select Salary from EmpDetails where EmpId=@in_empId  
END
GO
/****** Object:  StoredProcedure [dbo].[GetLeavesApplied]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetLeavesApplied]
@in_empId int,
@in_month int

AS
BEGIN
select FromDate,ToDate from EmpLeave where EmpId=@in_empId and DATEPART(MONTH,ToDate)=@in_month
end
GO
/****** Object:  StoredProcedure [dbo].[getLeaves]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[getLeaves]
@in_EmpId int
AS
BEGIN
SELECT EmpId,FromDate,ToDate,Reason from EmpLeave where EmpId=@in_EmpId
END
GO
/****** Object:  StoredProcedure [dbo].[getIsPresent]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getIsPresent]
@in_EmpId int,
@in_dau datetime
as
begin
if exists (select DateCurrent from EmpAtt where EmpId=@in_EmpId )
BEGIN
RETURN 2;
END
ELSE
BEGIN
insert into EmpAtt VALUES (@in_EmpId,@in_dau)
return 4;
end
end
GO
/****** Object:  StoredProcedure [dbo].[GetIsAdmin]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetIsAdmin]
@inU varchar(50),
@inP varchar(50)
AS
BEGIN
SELECT IsAdmin from users where username=@inU and password=@inP
END
GO
/****** Object:  StoredProcedure [dbo].[getEmpOnName]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[getEmpOnName]  
@empName varchar(50) 
AS  
BEGIN  
select FirstName,MiddleName,LastName,[Address],City,  
ZipCode,[State],PhoneNumber,EmailId,EmpId,Department,Picture,Salary,Leaves,Position from EmpDetails where EmpId =@empName  
END
GO
/****** Object:  StoredProcedure [dbo].[getEmpOnId]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[getEmpOnId]
@empId int
AS
BEGIN
select FirstName,MiddleName,LastName,[Address],City,
ZipCode,[State],PhoneNumber,EmailId,EmpId,Department,Picture,Salary,Leaves,Position from EmpDetails where EmpId =@empId
END
GO
/****** Object:  StoredProcedure [dbo].[getEmp]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getEmp]    
@in_FirstName varchar(50)    
AS    
BEGIN    
select FirstName,MiddleName,LastName,[Address],City,    
ZipCode,[State],PhoneNumber,EmailId,EmpId,Department,Picture,Salary,Leaves,Position from EmpDetails where FirstName like '%'+@in_FirstName+'%'   
END
GO
/****** Object:  StoredProcedure [dbo].[GetAuthorization]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[GetAuthorization]
@inUser varchar(20),
@inPass varchar(20)
as BEGIN
SELECT username from users where username=@inUser and password=@inPass
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmployee]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DeleteEmployee]
@inEmpId int
as
begin
delete from EmpDetails where EmpId=@inEmpId

end
GO
/****** Object:  StoredProcedure [dbo].[changePassword]    Script Date: 12/07/2014 20:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[changePassword]
@in_uname varchar(50),
@in_oldPass varchar(50),
@in_newPass varchar(50)
as
begin
if exists(SELECT * from users where username=@in_uname and password=@in_oldPass)
BEGIN
update users SET password=@in_newPass where username=@in_uname
RETURN 2
END
ELSE
RETURN 4
end
GO
