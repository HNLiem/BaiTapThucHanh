
USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='LTDG')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'LTDG') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [LTDG]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [LTDG]
GO
USE [LTDG]
GO

/****** Object:  Table [dbo].[tblDocGia]    Script Date: 5/4/2018 9:54:20 SA ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblDocGia](
	[mathe] [nchar](10) NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[loaithe] [nchar](10) NOT NULL,
	[ngaysinh] [datetime2](7) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[ngaylapthe] [datetime2](7) NOT NULL,
	[nguoilapthe] [nvarchar](50) NOT NULL,
	[hansudung] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[mathe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [LTDG]
GO

INSERT INTO [dbo].[tblDocGia]
           ([mathe]
           ,[hoten]
           ,[loaithe]
           ,[ngaysinh]
           ,[diachi]
           ,[email]
           ,[ngaylapthe]
           ,[nguoilapthe]
           ,[hansudung])
     VALUES
           (1800000001
           ,N'Number 01'
           ,'X'
		   ,convert(datetime,'03/22/2000 00:00:00')
           ,N'17 Nguyễn Văn Chuối'
           ,N'number01@gmail.com'
           ,convert(datetime,'06/22/2017 00:00:00')
           ,N'Nguyễn Phi Phú'
           ,convert(datetime,'12/22/2017 00:00:00')
		   )
GO
INSERT INTO [dbo].[tblDocGia]
           ([mathe]
           ,[hoten]
           ,[loaithe]
           ,[ngaysinh]
           ,[diachi]
           ,[email]
           ,[ngaylapthe]
           ,[nguoilapthe]
           ,[hansudung])
     VALUES
           (1800000002
           ,N'Number 02'
           ,'X'
		   ,convert(datetime,'03/13/1998 00:00:00')
           ,N'18 Lê Văn Ổi'
           ,N'number02@gmail.com'
           ,convert(datetime,'05/22/2017 00:00:00')
           ,N'Nguyễn Phi Phú'
           ,convert(datetime,'11/22/2017 00:00:00')
		   )
GO
INSERT INTO [dbo].[tblDocGia]
           ([mathe]
           ,[hoten]
           ,[loaithe]
           ,[ngaysinh]
           ,[diachi]
           ,[email]
           ,[ngaylapthe]
           ,[nguoilapthe]
           ,[hansudung])
     VALUES
           (1800000003
           ,N'Number 03'
           ,'Y'
		   ,convert(datetime,'01/01/1999 00:00:00')
           ,N'19 Trần Văn Lê'
           ,N'number03@gmail.com'
           ,convert(datetime,'04/25/2017 00:00:00')
           ,N'Nguyễn Phi Phú'
           ,convert(datetime,'10/25/2017 00:00:00')
		   )
GO



