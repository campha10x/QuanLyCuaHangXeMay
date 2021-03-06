USE [master]
GO
/****** Object:  Database [QUANLYCUAHANGXEMAY]    Script Date: 12/11/2016 21:22:02 ******/
CREATE DATABASE [QUANLYCUAHANGXEMAY] ON  PRIMARY 
( NAME = N'QUANLYCUAHANGXEMAY', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQL2008\MSSQL\DATA\QUANLYCUAHANGXEMAY.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QUANLYCUAHANGXEMAY_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQL2008\MSSQL\DATA\QUANLYCUAHANGXEMAY_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYCUAHANGXEMAY].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET ARITHABORT OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET  DISABLE_BROKER
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET  READ_WRITE
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET  MULTI_USER
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QUANLYCUAHANGXEMAY] SET DB_CHAINING OFF
GO
USE [QUANLYCUAHANGXEMAY]
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuNhap_getByTop]    Script Date: 12/11/2016 21:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuNhap_getByTop]
@Top	nvarchar(10),
@Where	nvarchar(MAX),
@Order	nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop = '(' + @Top + ')'
	if len(@Top) = 0 
		BEGIN
			Select @strTop = '100 percent'
		END
	Select @SQL = 'SELECT top ' + @strTop + ' * FROM [PhieuNhap]'
	if len(@Where) >0 
		BEGIN
			Select @SQL = @SQL + ' Where ' + @Where
		END
	if len(@Order) >0
		BEGIN
			Select @SQL = @SQL + ' Order by ' + @Order
		END
	EXEC (@SQL)
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](50) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [ntext] NULL,
	[DienThoai] [int] NULL,
	[Chucvu] [nvarchar](50) NULL,
	[LuongCoBan] [money] NULL,
	[Ngayvaolam] [date] NULL,
	[Luong] [money] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'', N'', CAST(0x343C0B00 AS Date), N'Nam', N'', 0, N'Giám đốc', 5000000.0000, CAST(0x343C0B00 AS Date), 8000000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'aaaaa', N'aaaaa', CAST(0x343C0B00 AS Date), N'Nam', N'', 0, N'Giám đốc', 0.0000, CAST(0x343C0B00 AS Date), 0.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'aaaaaa', N'ccccccccccccc', CAST(0x343C0B00 AS Date), N'Nam', N'', 0, N'Giám đốc', 0.0000, CAST(0x343C0B00 AS Date), 0.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'aaaaaaaa', N'aaaaaaaa', CAST(0x343C0B00 AS Date), N'Nam', N'aaaaaaaa', 0, N'Giám đốc', 0.0000, CAST(0x343C0B00 AS Date), 0.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'aaaaaaaaaa', N'aaaaaaaaaa', NULL, N'Nam', N'', 0, N'Giám đốc', 0.0000, NULL, 0.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'aaaaaaaaaaaaaaaaaaaaaa', N'', CAST(0x343C0B00 AS Date), N'Nam', N'', 0, N'Giám đốc', 0.0000, CAST(0x343C0B00 AS Date), 0.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'bbbb', N'bbbbbbb', CAST(0x343C0B00 AS Date), N'Nam', N'', 0, N'Giám đốc', 0.0000, CAST(0x343C0B00 AS Date), 0.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'bbbbb', N'', CAST(0x343C0B00 AS Date), N'Nam', N'', 0, N'Giám đốc', 0.0000, CAST(0x343C0B00 AS Date), 0.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'cccc', N'', CAST(0x343C0B00 AS Date), N'Nam', N'', 0, N'Giám đốc', 0.0000, CAST(0x343C0B00 AS Date), 0.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'cccccb', N'bbbbbbb', CAST(0x343C0B00 AS Date), N'Nam', N'', 0, N'Giám đốc', 0.0000, CAST(0x343C0B00 AS Date), 0.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'ccccccccc', N'', CAST(0x343C0B00 AS Date), N'Nam', N'', 0, N'Giám đốc', 5000000.0000, CAST(0x343C0B00 AS Date), 8000000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'ddddd', N'', CAST(0x343C0B00 AS Date), N'Nam', N'', 0, N'Giám đốc', 0.0000, CAST(0x343C0B00 AS Date), 0.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH03', N'Nguyễn Văn Hiếu', CAST(0x2F3C0B00 AS Date), N'Nam', N'Hà Nội', 981349571, N'Trưởng Phòng', 6000000.0000, CAST(0x2F3C0B00 AS Date), 3000000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH05', N'Trịnh Đức Dương', CAST(0x2C3C0B00 AS Date), N'Nữ', N'Quảng Ninh', 981349571, N'Giám đốc', 3000000.0000, CAST(0x2D3C0B00 AS Date), 6000000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH06', N'', CAST(0x2E3C0B00 AS Date), N'Nữ', N'', 0, N'Trưởng Phòng', 3000000.0000, CAST(0x2E3C0B00 AS Date), 6000000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH07', N'', CAST(0x343C0B00 AS Date), N'Nam', N'', 0, N'Giám đốc', 0.0000, CAST(0x343C0B00 AS Date), 0.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH33', N'Nguyễn Thị Tuyết', CAST(0x2F3C0B00 AS Date), N'Nữ', N'Quảng Ninh', 1647145623, N'Giám đốc', 4000000.0000, CAST(0x2F3C0B00 AS Date), 10000000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH34', N'', CAST(0x343C0B00 AS Date), N'Nam', N'', 0, N'Giám đốc', 0.0000, NULL, 0.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH35', N'', CAST(0x343C0B00 AS Date), N'Nam', N'', 0, N'Giám đốc', 0.0000, CAST(0x343C0B00 AS Date), 0.0000)
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCC] [nvarchar](50) NOT NULL,
	[TenNhaCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC01', N'', N'', N'123456', N'')
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH03', N'TEST', N'12/5/2016 8:08:08 PM', 0, N'', CAST(0x5B950A00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH04', N'', N'12/5/2016 8:10:02 PM', 0, N'Hà Nội', CAST(0x5B950A00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH06', N'', N'12/5/2016 8:21:06 PM', 0, N'', CAST(0x5B950A00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH07', N'Phạm Mạnh Hoàng', N'12/5/2016 8:21:15 PM', 0, N'', CAST(0x5B950A00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH08', N'', N'12/05/2016', 0, N'', CAST(0x5B950A00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH10', N'', N'12/05/2016', 0, N'', CAST(0x5B950A00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH11', N'', N'12/05/2016', 0, N'', CAST(0x5B950A00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH12', N'', N'', 0, N'', CAST(0x2E3C0B00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH13', N'TEST', N'TEST', 123456, N'TEST', CAST(0xA51F0B00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH16', N'', N'', 0, N'', CAST(0x2E3C0B00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH17', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH18', N'', N'', 0, N'', CAST(0x5B950A00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH20', N'', N'', 0, N'', CAST(0x5B950A00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH22', N'', N'', 0, N'', CAST(0x2F3C0B00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH23', N'test 23', N'dia chi', 435345, N'', CAST(0x3E3C0B00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH40', N'', N'', 0, N'', CAST(0x2F3C0B00 AS Date))
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh]) VALUES (N'MH41', N'test 41', N'', 0, N'', CAST(0x393C0B00 AS Date))
/****** Object:  Table [dbo].[HangXe]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangXe](
	[MaHangXe] [nchar](10) NOT NULL,
	[TenHangXe] [nvarchar](50) NULL,
	[DiaChi] [ntext] NULL,
	[sđt] [int] NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_HangXe] PRIMARY KEY CLUSTERED 
(
	[MaHangXe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuXuat_getByTop]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuXuat_getByTop]
@Top	nvarchar(10),
@Where	nvarchar(MAX),
@Order	nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop = '(' + @Top + ')'
	if len(@Top) = 0 
		BEGIN
			Select @strTop = '100 percent'
		END
	Select @SQL = 'SELECT top ' + @strTop + ' * FROM [ChiTietPhieuXuat]'
	if len(@Where) >0 
		BEGIN
			Select @SQL = @SQL + ' Where ' + @Where
		END
	if len(@Order) >0
		BEGIN
			Select @SQL = @SQL + ' Order by ' + @Order
		END
	EXEC (@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_getByTop]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KhachHang_getByTop]
@Top	nvarchar(10),
@Where	nvarchar(MAX),
@Order	nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop = '(' + @Top + ')'
	if len(@Top) = 0 
		BEGIN
			Select @strTop = '100 percent'
		END
	Select @SQL = 'SELECT top ' + @strTop + ' MaKH,TenKH,DiaChi,DienThoai,Email,CONVERT(VARCHAR,NgaySinh,103) as NgaySinh FROM [KhachHang]'
	if len(@Where) >0 
		BEGIN
			Select @SQL = @SQL + ' Where ' + @Where
		END
	if len(@Order) >0
		BEGIN
			Select @SQL = @SQL + ' Order by ' + @Order
		END
	EXEC (@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuXuat_getByTop]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuXuat_getByTop]
@Top	nvarchar(10),
@Where	nvarchar(MAX),
@Order	nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop = '(' + @Top + ')'
	if len(@Top) = 0 
		BEGIN
			Select @strTop = '100 percent'
		END
	Select @SQL = 'SELECT top ' + @strTop + ' * FROM [PhieuXuat]'
	if len(@Where) >0 
		BEGIN
			Select @SQL = @SQL + ' Where ' + @Where
		END
	if len(@Order) >0
		BEGIN
			Select @SQL = @SQL + ' Order by ' + @Order
		END
	EXEC (@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_Users_getByTop]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Users_getByTop]
@Top	nvarchar(10),
@Where	nvarchar(MAX),
@Order	nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop = '(' + @Top + ')'
	if len(@Top) = 0 
		BEGIN
			Select @strTop = '100 percent'
		END
	Select @SQL = 'SELECT top ' + @strTop + ' * FROM [Users]'
	if len(@Where) >0 
		BEGIN
			Select @SQL = @SQL + ' Where ' + @Where
		END
	if len(@Order) >0
		BEGIN
			Select @SQL = @SQL + ' Order by ' + @Order
		END
	EXEC (@SQL)
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[MaXe] [nchar](10) NOT NULL,
	[TenHangXe] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[ThongTinBaoHanh] [ntext] NULL,
	[TenXe] [nvarchar](50) NULL,
	[NhaSX] [nvarchar](50) NULL,
	[DonGia] [money] NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Xe] ([MaXe], [TenHangXe], [SoLuong], [ThongTinBaoHanh], [TenXe], [NhaSX], [DonGia]) VALUES (N'XE3       ', N'          ', 0, N'', N'', N'', 0.0000)
/****** Object:  Table [dbo].[Users]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[User] [varchar](50) NOT NULL,
	[MatKhauCu] [varchar](50) NULL,
	[MaNhanVien] [nvarchar](50) NULL,
	[MatKhauMoi] [varchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[User] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Users] ([User], [MatKhauCu], [MaNhanVien], [MatKhauMoi]) VALUES (N'admin', N'', N'001', N'admin')
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuNhap_getByTop]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuNhap_getByTop]
@Top	nvarchar(10),
@Where	nvarchar(MAX),
@Order	nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop = '(' + @Top + ')'
	if len(@Top) = 0 
		BEGIN
			Select @strTop = '100 percent'
		END
	Select @SQL = 'SELECT top ' + @strTop + ' * FROM [ChiTietPhieuNhap]'
	if len(@Where) >0 
		BEGIN
			Select @SQL = @SQL + ' Where ' + @Where
		END
	if len(@Order) >0
		BEGIN
			Select @SQL = @SQL + ' Order by ' + @Order
		END
	EXEC (@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_getByTop]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_NhanVien_getByTop]
@Top	nvarchar(10),
@Where	nvarchar(MAX),
@Order	nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop = '(' + @Top + ')'
	if len(@Top) = 0 
		BEGIN
			Select @strTop = '100 percent'
		END
	Select @SQL = 'SELECT top ' + @strTop + ' MaNhanVien,TenNhanVien, CONVERT(VARCHAR,NgaySinh,103) as NgaySinh,GioiTinh,DiaChi,DienThoai,Chucvu,LuongCoBan,CONVERT(VARCHAR,Ngayvaolam,103) as Ngayvaolam ,Luong FROM [NhanVien]'
	if len(@Where) >0 
		BEGIN
			Select @SQL = @SQL + ' Where ' + @Where
		END
	if len(@Order) >0
		BEGIN
			Select @SQL = @SQL + ' Order by ' + @Order
		END
	EXEC (@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_MatHang_getByTop]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MatHang_getByTop]
@Top	nvarchar(10),
@Where	nvarchar(MAX),
@Order	nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop = '(' + @Top + ')'
	if len(@Top) = 0 
		BEGIN
			Select @strTop = '100 percent'
		END
	Select @SQL = 'SELECT top ' + @strTop + ' * FROM [Xe]'
	if len(@Where) >0 
		BEGIN
			Select @SQL = @SQL + ' Where ' + @Where
		END
	if len(@Order) >0
		BEGIN
			Select @SQL = @SQL + ' Order by ' + @Order
		END
	EXEC (@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_NhaCungCap_getByTop]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_NhaCungCap_getByTop]
@Top	nvarchar(10),
@Where	nvarchar(MAX),
@Order	nvarchar(200)
AS
	Declare @SQL as nvarchar(500)
	Declare @strTop as nvarchar(100)
	Select @strTop = '(' + @Top + ')'
	if len(@Top) = 0 
		BEGIN
			Select @strTop = '100 percent'
		END
	Select @SQL = 'SELECT top ' + @strTop + ' * FROM [NhaCungCap]'
	if len(@Where) >0 
		BEGIN
			Select @SQL = @SQL + ' Where ' + @Where
		END
	if len(@Order) >0
		BEGIN
			Select @SQL = @SQL + ' Order by ' + @Order
		END
	EXEC (@SQL)
GO
/****** Object:  StoredProcedure [dbo].[sp_NhaCungCap_Delete]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_NhaCungCap_Delete]
	@MaNhaCC nvarchar(50)
AS
BEGIN
	delete from dbo.NhaCungCap where MaNhaCC=@MaNhaCC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MatHang_Update]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MatHang_Update]
	@MaXe nchar(10),
	@TenHangXe nchar(10),
	@NhaSX nvarchar(50),
	@SoLuong int,
	@ThongTinBaoHanh ntext,
	@DonGia money,
	@TenXe nvarchar(50)
AS
BEGIN
	update dbo.Xe set  TenXe = @TenXe, NhaSX = @NhaSX,SoLuong=@SoLuong,ThongTinBaoHanh=@ThongTinBaoHanh,TenHangXe=@TenHangXe,DonGia=@DonGia
	where MaXe = @MaXe
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MatHang_Insert]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MatHang_Insert]
	@MaXe nchar(10),
	@TenHangXe nchar(10),
	@NhaSX nvarchar(50),
	@SoLuong int,
	@ThongTinBaoHanh ntext,
	@DonGia money,
	@TenXe nvarchar(50)
AS
BEGIN
	insert into dbo.Xe values(@MaXe,@TenHangXe,@SoLuong,@ThongTinBaoHanh,@TenXe,@NhaSX,@DonGia)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MatHang_Delete]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_MatHang_Delete]
	@MaXe nchar(10)
AS
BEGIN
	delete from dbo.Xe where MaXe = @MaXe
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Update]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KhachHang_Update]
	@MaKH nvarchar(50),
	@TenKH nvarchar(50),
	@DiaChi nvarchar(50),
	@DienThoai int,
	@Email nvarchar(50),
	@NgaySinh date
AS
BEGIN
	update dbo.KhachHang set   TenKH = @TenKH,DiaChi=@DiaChi,DienThoai=@DienThoai,Email=@Email,NgaySinh=@NgaySinh
	where MaKH = @MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Insert]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KhachHang_Insert]
	@MaKH nvarchar(50),
	@TenKH nvarchar(50),
	@DiaChi nvarchar(50),
	@DienThoai int,
	@Email nvarchar(50),
	@NgaySinh date
AS
BEGIN
	insert into dbo.KhachHang(MaKH,TenKH,DiaChi,DienThoai,Email,NgaySinh) values(@MaKH,@TenKH,@DiaChi,@DienThoai,@Email,@NgaySinh)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_Delete]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_NhanVien_Delete]
	@MaNhanVien nvarchar(50)
AS
BEGIN
	delete from dbo.NhanVien where MaNhanVien=@MaNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[sp_NhaCungCap_Update]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_NhaCungCap_Update]
	@MaNhaCC nvarchar(50),
	@TenNhaCC nvarchar(50),
	@DiaChi nvarchar(50),
	@DienThoai nvarchar(50),
	@Email nvarchar(50)
AS
BEGIN
	update dbo.NhaCungCap set  TenNhaCC = @TenNhaCC, DiaChi = @DiaChi,DienThoai=@DienThoai,Email=@Email
	where MaNhaCC = @MaNhaCC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_NhaCungCap_Insert]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_NhaCungCap_Insert]
	@MaNhaCC nvarchar(50),
	@TenNhaCC nvarchar(50),
	@DiaChi nvarchar(50),
	@DienThoai nvarchar(50),
	@Email nvarchar(50)
AS
BEGIN
	insert into dbo.NhaCungCap values(@MaNhaCC,@TenNhaCC,@DiaChi,@DienThoai,@Email)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_Update]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_NhanVien_Update]
	@MaNhanVien nvarchar(50),
	@TenNhanVien nvarchar(50),
	@NgaySinh date,
	@GioiTinh nvarchar(50),
	@DiaChi nvarchar(50),
	@DienThoai nvarchar(50),
	@ChucVu nvarchar(50),
	@LuongCoBan money,
	@Ngayvaolam date,
	@Luong money
AS
BEGIN
	update dbo.NhanVien set  TenNhanVien = @TenNhanVien, NgaySinh = @NgaySinh,GioiTinh=@GioiTinh,DiaChi=@DiaChi,DienThoai=@DienThoai,ChucVu=@ChucVu,LuongCoBan=@LuongCoBan,Ngayvaolam=@Ngayvaolam,Luong=@Luong
	where MaNhanVien = @MaNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_Insert]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_NhanVien_Insert]
	@MaNhanVien nvarchar(50),
	@TenNhanVien nvarchar(50),
	@NgaySinh date,
	@GioiTinh nvarchar(50),
	@DiaChi nvarchar(50),
	@DienThoai nvarchar(50),
	@ChucVu nvarchar(50),
	@LuongCoBan money,
	@Ngayvaolam date,
	@Luong money
AS
BEGIN
	insert into dbo.NhanVien values(@MaNhanVien,@TenNhanVien,@NgaySinh,@GioiTinh,@DiaChi,@DienThoai,@ChucVu,@LuongCoBan,@Ngayvaolam,@Luong)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Users_Update]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Users_Update]
	@User varchar(50),
	 @MatKhauCu varchar(50),
	@MaNhanVien nvarchar(50),
	@MatKhauMoi	varchar(50)
AS
BEGIN
	update dbo.Users set  MatKhauCu = @MatKhauCu,MatKhauMoi=@MatKhauMoi
	where [User] = @User and MaNhanVien = @MaNhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Users_Insert]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Users_Insert]
	@User varchar(50),
	 @MatKhauCu varchar(50),
	@MaNhanVien nvarchar(50),
	@MatKhauMoi	varchar(50)
AS
BEGIN
	insert into dbo.Users values(@User,@MatKhauCu,@MaNhanVien,@MatKhauMoi)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Users_Delete]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Users_Delete]
	@User varchar(50)
AS
BEGIN
	delete from dbo.Users where [User]=@User
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Select_TenKH]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_Select_TenKH]
AS
BEGIN
	SELECT TenKH FROM dbo.KhachHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Search_TenNV]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Search_TenNV]
AS
BEGIN
	SELECT TenNhanVien from dbo.NhanVien
END
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPhieuDatHang] [nvarchar](50) NOT NULL,
	[NgayDatHang] [datetime] NULL,
	[MaNhanVien] [nvarchar](50) NULL,
	[MaKhachHang] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDatHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [nvarchar](50) NOT NULL,
	[NgayNhap] [datetime] NULL,
	[MaNhanVien] [nvarchar](50) NULL,
	[MaNhaCungCap] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Delete]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KhachHang_Delete]
	@MaKH nvarchar(50)
AS
BEGIN
	delete from dbo.KhachHang where MaKH=@MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuNhap_Delete]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuNhap_Delete]
	@MaPN nvarchar(50)
AS
BEGIN
	delete from dbo.PhieuNhap where MaPN=@MaPN
END
GO
/****** Object:  Table [dbo].[ChiTietPhieuXuat]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuXuat](
	[MaPhieuDatHang] [nvarchar](50) NOT NULL,
	[MaXe] [nchar](10) NOT NULL,
	[SLDatHang] [int] NULL,
	[DonGiaDatHang] [money] NULL,
	[Thue] [money] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_ChiTietPhieuXuat] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDatHang] ASC,
	[MaXe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPN] [nvarchar](50) NOT NULL,
	[MaXe] [nchar](10) NOT NULL,
	[SLNhap] [int] NULL,
	[DonGiaNhap] [money] NULL,
	[Thue] [money] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaXe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuXuat_Update]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuXuat_Update]
	@MaPX varchar(50),
	@NgayXuat datetime,
	@MaNhanVien nvarchar(50),
	@MaKhachHang nvarchar(50)
AS
BEGIN
	update dbo.PhieuXuat set  NgayXuat = @NgayXuat, MaNhanVien = @MaNhanVien,MaKhachHang=@MaKhachHang
	where MaPX = @MaPX
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuXuat_Insert]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuXuat_Insert]
	@MaPX varchar(50),
	@NgayXuat datetime,
	@MaNhanVien nvarchar(50),
	@MaKhachHang nvarchar(50)
AS
BEGIN
	insert into dbo.PhieuXuat values(@MaPX,@NgayXuat,@MaNhanVien,@MaKhachHang)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuXuat_Delete]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuXuat_Delete]
	@MaPX nvarchar
AS
BEGIN
	delete from dbo.PhieuXuat where MaPX=@MaPX
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuNhap_Update]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuNhap_Update]
	@MaPN nvarchar(50),
	@NgayNhap datetime,
	@MaNhanVien nvarchar(50),
	@MaNhaCungCap nvarchar(50)
AS
BEGIN
	update dbo.PhieuNhap set  NgayNhap = @NgayNhap, MaNhanVien = @MaNhanVien,MaNhaCungCap=@MaNhaCungCap
	where MaPN = @MaPN
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuNhap_Insert]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuNhap_Insert]
	@MaPN nvarchar(50),
	@NgayNhap datetime,
	@MaNhanVien nvarchar(50),
	@MaNhaCungCap nvarchar(50)
AS
BEGIN
	insert into dbo.PhieuNhap values(@MaPN,@NgayNhap,@MaNhanVien,@MaNhaCungCap)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuNhap_Delete]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuNhap_Delete]
	@MaPN nvarchar(50),
	@MaHang nvarchar(50)
AS
BEGIN
	delete from dbo.ChiTietPhieuNhap where MaPN=@MaPN and MaHang=@MaHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuXuat_Update]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuXuat_Update]
	@MaPX nvarchar(50),
	@MaHang nvarchar(50),
	@SLXuat int,
	@DonGiaXuat money,
	@Thue money
AS
BEGIN
	update dbo.ChiTietPhieuXuat set   SLXuat = @SLXuat,DonGiaXuat=@DonGiaXuat,Thue=@Thue
	where MaPX = @MaPX and MaHang=@MaHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuXuat_Insert]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuXuat_Insert]
	@MaPX nvarchar(50),
	@MaHang nvarchar(50),
	@SLXuat int,
	@DonGiaXuat money,
	@Thue money
AS
BEGIN
	insert into dbo.ChiTietPhieuXuat values(@MaPX,@MaHang,@SLXuat,@DonGiaXuat,@Thue)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuXuat_Delete]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuXuat_Delete]
	@MaPX nvarchar(50),
	@MaHang nvarchar(50)
AS
BEGIN
	delete from dbo.ChiTietPhieuXuat where MaPX=@MaPX and MaHang=@MaHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuNhap_Update]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuNhap_Update]
	@MaPN nvarchar(50),
	@MaHang nvarchar(50),
	@SLNhap int,
	@DonGiaNhap money,
	@Thue money
AS
BEGIN
	update dbo.ChiTietPhieuNhap set   SLNhap = @SLNhap,DonGiaNhap=@DonGiaNhap,Thue=@Thue
	where MaPN = @MaPN and MaHang=@MaHang
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuNhap_Insert]    Script Date: 12/11/2016 21:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuNhap_Insert]
	@MaPN nvarchar(50),
	@MaHang nvarchar(50),
	@SLNhap int,
	@DonGiaNhap money,
	@Thue money
AS
BEGIN
	insert into dbo.ChiTietPhieuNhap values(@MaPN,@MaHang,@SLNhap,@DonGiaNhap,@Thue)
END
GO
/****** Object:  ForeignKey [FK_PhieuXuat_KhachHang]    Script Date: 12/11/2016 21:22:07 ******/
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_KhachHang]
GO
/****** Object:  ForeignKey [FK_PhieuXuat_NhanVien]    Script Date: 12/11/2016 21:22:07 ******/
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuNhap_NhaCungCap]    Script Date: 12/11/2016 21:22:07 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_PhieuNhap_NhanVien]    Script Date: 12/11/2016 21:22:07 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuXuat_PhieuXuat]    Script Date: 12/11/2016 21:22:07 ******/
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat] FOREIGN KEY([MaPhieuDatHang])
REFERENCES [dbo].[PhieuXuat] ([MaPhieuDatHang])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuXuat_Xe]    Script Date: 12/11/2016 21:22:07 ******/
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_Xe]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhap_PhieuNhap]    Script Date: 12/11/2016 21:22:07 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhap_Xe]    Script Date: 12/11/2016 21:22:07 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_Xe]
GO
