CREATE DATABASE [bcs_development] ON  PRIMARY 
( NAME = N'bcs_development', FILENAME = N'E:\MSSQL2008\DATA\omron\bcs\development\bcs_development.mdf' , SIZE = 4096KB , FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'bcs_development_log', FILENAME = N'E:\MSSQL2008\DATA\omron\bcs\development\bcs_development_log.ldf' , SIZE = 17408KB , FILEGROWTH = 10%)
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'bcs_development', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bcs_development].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [bcs_development] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bcs_development] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bcs_development] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bcs_development] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bcs_development] SET ARITHABORT OFF 
GO
ALTER DATABASE [bcs_development] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bcs_development] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [bcs_development] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bcs_development] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bcs_development] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bcs_development] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bcs_development] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bcs_development] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bcs_development] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bcs_development] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bcs_development] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bcs_development] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bcs_development] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bcs_development] SET  READ_WRITE 
GO
ALTER DATABASE [bcs_development] SET RECOVERY FULL 
GO
ALTER DATABASE [bcs_development] SET  MULTI_USER 
GO
ALTER DATABASE [bcs_development] SET PAGE_VERIFY CHECKSUM  
GO
USE [bcs_development]
GO
IF NOT EXISTS (SELECT name FROM sys.filegroups WHERE is_default=1 AND name = N'PRIMARY') ALTER DATABASE [bcs_development] MODIFY FILEGROUP [PRIMARY] DEFAULT
GO
