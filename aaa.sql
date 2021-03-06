USE [master]
GO
/****** Object:  Database [QUANLYCUAHANGXEMAY]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 01/06/2017 12:16:21 ******/
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
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'M13', N'Nguyễn Minh Khuê', CAST(0x3E3C0B00 AS Date), N'Nam', N'Hà Nội', 1647145623, N'Trưởng Phòng', 3000000.0000, CAST(0x3E3C0B00 AS Date), 6000000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH03', N'Nguyễn Văn Hiếu', CAST(0x461E0B00 AS Date), N'Nam', N'Hà Nội', 981349571, N'Giám đốc', 6000000.0000, CAST(0x88360B00 AS Date), 3000000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH05', N'Trịnh Đức Dương', CAST(0x2C3C0B00 AS Date), N'Nữ', N'Quảng Ninh', 981349571, N'Giám đốc', 3000000.0000, CAST(0x2D3C0B00 AS Date), 6000000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH06', N'Phạm Xuân Duy', CAST(0x4E3C0B00 AS Date), N'Nam', N'Hà Nội', 1647145623, N'Giám đốc', 10000000.0000, CAST(0x3D3C0B00 AS Date), 4000000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH12', N'Kim Văn Sáng', CAST(0xB7150B00 AS Date), N'Nam', N'Nam Định', 981349571, N'Giám đốc', 5000000.0000, CAST(0x2D3C0B00 AS Date), 8000000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH13', N'Nguyễn Đức Quyết', CAST(0xB61F0B00 AS Date), N'Nữ', N'Hà Nội', 123456789, N'Nhân viên', 3000000.0000, CAST(0x4D3C0B00 AS Date), 4200000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH14', N'Phạm Minh Đức', CAST(0x423C0B00 AS Date), N'Nam', N'Hà Nội', 123456789, N'Nhân viên', 3000000.0000, CAST(0x4D3C0B00 AS Date), 4200000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH15', N'Nguyễn Thành Trung', CAST(0xA41F0B00 AS Date), N'Nam', N'Hà Nội', 123456789, N'Trưởng phòng', 4000000.0000, CAST(0x423C0B00 AS Date), 5800000.0000)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [Chucvu], [LuongCoBan], [Ngayvaolam], [Luong]) VALUES (N'MH16', N'Nguyễn Minh Khuê', CAST(0x571E0B00 AS Date), N'Nam', N'Hà Nôi', 1234567, N'Trưởng phòng', 4000000.0000, CAST(0x4E3C0B00 AS Date), 6100000.0000)
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 01/06/2017 12:16:21 ******/
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
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC01', N'HonDa', N'Nhật Bản', N'123456789', N'honda@gmail.com.vn')
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC02', N'Suzuki', N'Hà Nội', N'123456789', N'suzuki@gmail.com.vn')
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC03', N'Yamaha', N'Hà Nội', N'123456789', N'yamaha@gmail.com.vn')
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC05', N'Piaggio', N'Nhật Bản', N'0981349571', N'piaggio')
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC06', N'SYM', N'Nhật Bản', N'123456', N'sym@gmail.com.vn')
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC07', N'Ducati', N'Nhật Bản', N'123456789', N'ducati@gmail.com.vn')
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC08', N'KTM', N'Nhật Bản', N'123456', N'')
INSERT [dbo].[NhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC09', N'Benelli', N'Nhật bản', N'123456789', NULL)
/****** Object:  Table [dbo].[KhachHang]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [varchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh], [TinhTrang]) VALUES (N'KH02', N'Nguyễn Đức Giang', N'Thái Bình', N'01647145623', N'ducgiang@gmail.com', CAST(0xA31F0B00 AS Date), N'Đã thanh toán')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh], [TinhTrang]) VALUES (N'KH03', N'Nguyễn Thuỳ Dương', N'Nam Định', N'981349571', N'nguyenthuyduong@gmail.com.vn', CAST(0xA61F0B00 AS Date), N'Đã thanh toán')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh], [TinhTrang]) VALUES (N'KH04', N'Hà Văn Nước', N'Hà Nội', N'1647145623', N'havannuoc@gmail.com.vn', CAST(0xB51F0B00 AS Date), N'Đã thanh toán')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh], [TinhTrang]) VALUES (N'KH05', N'Phạm Xuân Duy', N'Hà Nội ', N'0981349571', N'phamxuanduy1996@gmail.com.vn', CAST(0xB91F0B00 AS Date), N'Đã thanh toán')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [DienThoai], [Email], [NgaySinh], [TinhTrang]) VALUES (N'KH1', N'Nguyễn Văn Dương ', N'Hà Nội', N'01647145623', N'nguyenvanduong96@gmail.com.vn', CAST(0xEA1F0B00 AS Date), N'Đã thanh toán')
/****** Object:  UserDefinedFunction [dbo].[fuChuyenCoDauThanhKhongDau]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fuChuyenCoDauThanhKhongDau]
(
      @strInput NVARCHAR(4000)
)
RETURNS NVARCHAR(4000)
AS
BEGIN    
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế
                 ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý
                 ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ
                 ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'
                  +NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee
                 iiiiiooooooooooooooouuuuuuuuuuyyyyy
                 AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII
                 OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER INT
    DECLARE @COUNTER1 INT
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN  
      SET @COUNTER1 = 1
      --Tìm trong chuỗi mẫu
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1))
            = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN          
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1)
              + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                  
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1)
              +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1)
              + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)
              BREAK
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tìm tiếp
       SET @COUNTER = @COUNTER +1
    END
    SET @strInput = REPLACE(@strInput,' ','-')
    RETURN @strInput
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuXuat_getByTop]    Script Date: 01/06/2017 12:16:21 ******/
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
	Select @SQL = 'SELECT top ' + @strTop + ' MaPhieuXuat,MaXe,SLXuat,CONVERT(DECIMAL(18,0),DonGiaXuat)AS DonGiaXuat ,Thue,CONVERT(decimal(18,0),ThanhTien)as ThanhTien  FROM [ChiTietPhieuXuat]'
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
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_getByTop]    Script Date: 01/06/2017 12:16:21 ******/
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
	Select @SQL = 'SELECT top ' + @strTop + ' MaKH,TenKH,DiaChi,DienThoai,Email,CONVERT(VARCHAR,NgaySinh,103) as NgaySinh,TinhTrang FROM [KhachHang]'
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
/****** Object:  StoredProcedure [dbo].[sp_MatHang_getByTop]    Script Date: 01/06/2017 12:16:21 ******/
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
	Select @SQL = 'SELECT top ' + @strTop + ' MaXe,TenHangXe,Convert(decimal(18,0),DonGia) AS DonGia,ThongTinBaoHanh,TenXe,NhaSX,SoLuong,TinhTrang FROM [Xe]'
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
/****** Object:  StoredProcedure [dbo].[sp_NhaCungCap_getByTop]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_getByTop]    Script Date: 01/06/2017 12:16:21 ******/
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
	Select @SQL = 'SELECT top ' + @strTop + ' MaNhanVien,TenNhanVien, CONVERT(VARCHAR,NgaySinh,103) as NgaySinh,GioiTinh,DiaChi,DienThoai,Chucvu,Convert(decimal(18,0),LuongCoBan)AS LuongCoBan ,CONVERT(VARCHAR,Ngayvaolam,103) as Ngayvaolam ,Convert(decimal(18,0),Luong)AS Luong  FROM [NhanVien]'
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
/****** Object:  StoredProcedure [dbo].[sp_PhieuNhap_getByTop]    Script Date: 01/06/2017 12:16:21 ******/
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
	Select @SQL = 'SELECT top ' + @strTop + ' MaPN,CONVERT(VARCHAR,NgayNhap,103) as NgayNhap,MaNhanVien,MaNhaCungCap FROM [PhieuNhap]'
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
/****** Object:  StoredProcedure [dbo].[sp_Users_getByTop]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  Table [dbo].[Xe]    Script Date: 01/06/2017 12:16:21 ******/
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
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Xe] ([MaXe], [TenHangXe], [SoLuong], [ThongTinBaoHanh], [TenXe], [NhaSX], [DonGia], [TinhTrang]) VALUES (N'XE10      ', N'Lexu', 2, N'1 năm', N'Lexu', N'Lexu', 20000000.0000, N'Còn')
INSERT [dbo].[Xe] ([MaXe], [TenHangXe], [SoLuong], [ThongTinBaoHanh], [TenXe], [NhaSX], [DonGia], [TinhTrang]) VALUES (N'XE11      ', N'SH', 102, N'', N'SH10', N'', 3000000.0000, N'Còn')
INSERT [dbo].[Xe] ([MaXe], [TenHangXe], [SoLuong], [ThongTinBaoHanh], [TenXe], [NhaSX], [DonGia], [TinhTrang]) VALUES (N'XE12      ', N'Dream30', 48, N'Dream30', N'Dream30', N'Dream30', 12000000.0000, N'Còn')
INSERT [dbo].[Xe] ([MaXe], [TenHangXe], [SoLuong], [ThongTinBaoHanh], [TenXe], [NhaSX], [DonGia], [TinhTrang]) VALUES (N'XE14      ', N'XE2', 1000, N'', N'SH', N'', 3000000.0000, N'Còn')
INSERT [dbo].[Xe] ([MaXe], [TenHangXe], [SoLuong], [ThongTinBaoHanh], [TenXe], [NhaSX], [DonGia], [TinhTrang]) VALUES (N'XE3       ', N'Superbike30', 298, N'Superbike30', N'Superbike30', N'Superbike30', 30000000.0000, N'Còn')
INSERT [dbo].[Xe] ([MaXe], [TenHangXe], [SoLuong], [ThongTinBaoHanh], [TenXe], [NhaSX], [DonGia], [TinhTrang]) VALUES (N'XE4       ', N'Duke      ', 271, N'2 năm', N'Duke', N'Duke', 1200000.0000, N'Còn')
INSERT [dbo].[Xe] ([MaXe], [TenHangXe], [SoLuong], [ThongTinBaoHanh], [TenXe], [NhaSX], [DonGia], [TinhTrang]) VALUES (N'XE6       ', N'Air blade', 0, N'1 năm', N'Air blade', N'Air blade', 100000.0000, N'Hết')
INSERT [dbo].[Xe] ([MaXe], [TenHangXe], [SoLuong], [ThongTinBaoHanh], [TenXe], [NhaSX], [DonGia], [TinhTrang]) VALUES (N'XE7       ', N'Wave10', 148, N'1 năm', N'Wave', N'Wave', 3000000.0000, N'Còn')
INSERT [dbo].[Xe] ([MaXe], [TenHangXe], [SoLuong], [ThongTinBaoHanh], [TenXe], [NhaSX], [DonGia], [TinhTrang]) VALUES (N'XE8       ', N' Lead     ', 130, N'2 năm', N'Lead', N'Lead', 20000000.0000, N'Còn')
/****** Object:  StoredProcedure [dbo].[sp_PhieuXuat_getByTop]    Script Date: 01/06/2017 12:16:21 ******/
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
	Select @SQL = 'SELECT top ' + @strTop + ' MaPhieuXuat,CONVERT(VARCHAR,NgayXuat,103) as NgayXuat,MaNhanVien,MaKhachHang FROM [PhieuXuat]'
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
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuNhap_getByTop]    Script Date: 01/06/2017 12:16:21 ******/
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
	Select @SQL = 'SELECT top ' + @strTop + ' MaPN,MaXe,SLNhap,CONVERT(DECIMAL(18,0),DonGiaNhap)as DonGiaNhap,Thue,CONVERT(DECIMAL(18,0),ThanhTien)as ThanhTien  FROM [ChiTietPhieuNhap]'
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
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_Update]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_Insert]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_TongSLXe]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TongSLXe]
AS
BEGIN
SELECT COUNT(*) FROM dbo.Xe
end
GO
/****** Object:  StoredProcedure [dbo].[sp_TongSLNhaCungCap]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TongSLNhaCungCap]
AS
BEGIN
SELECT COUNT(*) FROM dbo.NhaCungCap
end
GO
/****** Object:  StoredProcedure [dbo].[sp_TongSLKhachHang]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TongSLKhachHang]
AS
BEGIN
SELECT COUNT(*) FROM KhachHang
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Select_TenKH]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Search_TenXe]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Search_TenXe]
@TenXe nvarchar(50)
as
SELECT * FROM dbo.Xe where [dbo].[fuChuyenCoDauThanhKhongDau](TenXe) like N'%' +dbo.fuChuyenCoDauThanhKhongDau(@TenXe)+'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_Search_TenNV]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Search_TenNV]
@TenNV nvarchar(50)
as
SELECT * FROM dbo.NhanVien where [dbo].[fuChuyenCoDauThanhKhongDau](TenNhanVien) like N'%' +dbo.fuChuyenCoDauThanhKhongDau(@TenNV)+'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_Search_TenNhaCC]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Search_TenNhaCC]
@TenNhaCC nvarchar(50)
as
SELECT * FROM dbo.NhaCungCap where [dbo].[fuChuyenCoDauThanhKhongDau](TenNhaCC) like N'%' +dbo.fuChuyenCoDauThanhKhongDau(@TenNhaCC)+'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_Search_TenKH]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Search_TenKH]
@TenKH nvarchar(50)
as
SELECT * FROM dbo.KhachHang where [dbo].[fuChuyenCoDauThanhKhongDau](TenKH) like N'%' +dbo.fuChuyenCoDauThanhKhongDau(@TenKH)+'%'
GO
/****** Object:  Table [dbo].[Users]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[User] [varchar](50) NOT NULL,
	[MaNhanVien] [nvarchar](50) NULL,
	[MatKhauMoi] [varchar](50) NULL,
	[Quyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[User] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Users] ([User], [MaNhanVien], [MatKhauMoi], [Quyen]) VALUES (N'admin', N'MH12', N'123456', N'admin')
INSERT [dbo].[Users] ([User], [MaNhanVien], [MatKhauMoi], [Quyen]) VALUES (N'phamxuanduy', N'MH12', N'1234567', N'nhanvien')
INSERT [dbo].[Users] ([User], [MaNhanVien], [MatKhauMoi], [Quyen]) VALUES (N'test', N'MH12', N'test33', N'nhanvien')
INSERT [dbo].[Users] ([User], [MaNhanVien], [MatKhauMoi], [Quyen]) VALUES (N'test2', N'MH12', N'test21', N'nhanvien')
INSERT [dbo].[Users] ([User], [MaNhanVien], [MatKhauMoi], [Quyen]) VALUES (N'test3', N'MH06', N'test', N'admin')
INSERT [dbo].[Users] ([User], [MaNhanVien], [MatKhauMoi], [Quyen]) VALUES (N'trinhducduong', N'MH12', N'123456', N'nhanvien')
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_Delete]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_NhaCungCap_Update]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_NhaCungCap_Insert]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_NhaCungCap_Delete]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_MatHang_Update]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_MatHang_Insert]    Script Date: 01/06/2017 12:16:21 ******/
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
	insert into dbo.Xe(MaXe,TenHangXe,SoLuong,ThongTinBaoHanh,TenXe,NhaSX,DonGia) values(@MaXe,@TenHangXe,@SoLuong,@ThongTinBaoHanh,@TenXe,@NhaSX,@DonGia)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_MatHang_Delete]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Update]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KhachHang_Update]
	@MaKH nvarchar(50),
	@TenKH nvarchar(50),
	@DiaChi nvarchar(50),
	@DienThoai varchar(50),
	@Email nvarchar(50),
	@NgaySinh date
AS
BEGIN
	update dbo.KhachHang set   TenKH = @TenKH,DiaChi=@DiaChi,DienThoai=@DienThoai,Email=@Email,NgaySinh=@NgaySinh
	where MaKH = @MaKH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Insert]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_Delete]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPhieuXuat] [nvarchar](50) NOT NULL,
	[NgayXuat] [datetime] NULL,
	[MaNhanVien] [nvarchar](50) NULL,
	[MaKhachHang] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PhieuXuat] ([MaPhieuXuat], [NgayXuat], [MaNhanVien], [MaKhachHang]) VALUES (N'HD01', CAST(0x0000A6E300000000 AS DateTime), N'MH12', N'KH02')
INSERT [dbo].[PhieuXuat] ([MaPhieuXuat], [NgayXuat], [MaNhanVien], [MaKhachHang]) VALUES (N'HD02', CAST(0x0000A12E00000000 AS DateTime), N'MH14', N'KH02')
INSERT [dbo].[PhieuXuat] ([MaPhieuXuat], [NgayXuat], [MaNhanVien], [MaKhachHang]) VALUES (N'HD03', CAST(0x0000A12E00000000 AS DateTime), N'MH12', N'KH1')
INSERT [dbo].[PhieuXuat] ([MaPhieuXuat], [NgayXuat], [MaNhanVien], [MaKhachHang]) VALUES (N'HD04', CAST(0x0000A6E300000000 AS DateTime), N'MH12', N'KH03')
INSERT [dbo].[PhieuXuat] ([MaPhieuXuat], [NgayXuat], [MaNhanVien], [MaKhachHang]) VALUES (N'HD05', CAST(0x0000A6F200000000 AS DateTime), N'MH12', N'KH1')
INSERT [dbo].[PhieuXuat] ([MaPhieuXuat], [NgayXuat], [MaNhanVien], [MaKhachHang]) VALUES (N'HD06', CAST(0x0000A6F000000000 AS DateTime), N'MH12', N'KH03')
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [nvarchar](50) NOT NULL,
	[NgayNhap] [date] NULL,
	[MaNhanVien] [nvarchar](50) NULL,
	[MaNhaCungCap] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN01', CAST(0x2A3C0B00 AS Date), N'MH12', N'NCC01')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN02', CAST(0x3F3C0B00 AS Date), N'MH12', N'NCC01')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN03', CAST(0x403C0B00 AS Date), N'MH03', N'NCC01')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN04', CAST(0x3F3C0B00 AS Date), N'MH12', N'NCC07')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN05', CAST(0x2A3C0B00 AS Date), N'MH12', N'NCC01')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN06', CAST(0x3F3C0B00 AS Date), N'MH12', N'NCC01')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN07', CAST(0x413C0B00 AS Date), N'MH12', N'NCC09')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN08', CAST(0x413C0B00 AS Date), N'MH12', N'NCC02')
INSERT [dbo].[PhieuNhap] ([MaPN], [NgayNhap], [MaNhanVien], [MaNhaCungCap]) VALUES (N'PN09', CAST(0x463C0B00 AS Date), N'MH12', N'NCC07')
/****** Object:  StoredProcedure [dbo].[sp_Get_SoLuongHang]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Get_SoLuongHang]
	@MaXe nvarchar(50)
AS
BEGIN

	SELECT SoLuong from dbo.Xe where MaXe=@MaXe

END
GO
/****** Object:  Table [dbo].[ChiTietPhieuXuat]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuXuat](
	[MaPhieuXuat] [nvarchar](50) NOT NULL,
	[MaXe] [nchar](10) NOT NULL,
	[SLXuat] [int] NULL,
	[DonGiaXuat] [money] NULL,
	[Thue] [int] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_ChiTietPhieuXuat] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC,
	[MaXe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietPhieuXuat] ([MaPhieuXuat], [MaXe], [SLXuat], [DonGiaXuat], [Thue], [ThanhTien]) VALUES (N'HD01', N'XE11      ', 2, 3000000.0000, 10, 6600000.0000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaPhieuXuat], [MaXe], [SLXuat], [DonGiaXuat], [Thue], [ThanhTien]) VALUES (N'HD01', N'XE12      ', 4, 12000000.0000, 0, 48000000.0000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaPhieuXuat], [MaXe], [SLXuat], [DonGiaXuat], [Thue], [ThanhTien]) VALUES (N'HD01', N'XE3       ', 1, 30000000.0000, 1, 30300000.0000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaPhieuXuat], [MaXe], [SLXuat], [DonGiaXuat], [Thue], [ThanhTien]) VALUES (N'HD02', N'XE7       ', 2, 10000000.0000, 5, 21000000.0000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaPhieuXuat], [MaXe], [SLXuat], [DonGiaXuat], [Thue], [ThanhTien]) VALUES (N'HD03', N'XE3       ', 1, 30000000.0000, 0, 30000000.0000)
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPN] [nvarchar](50) NOT NULL,
	[MaXe] [nchar](10) NOT NULL,
	[SLNhap] [int] NULL,
	[DonGiaNhap] [money] NULL,
	[Thue] [int] NULL,
	[ThanhTien] [money] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaXe] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaXe], [SLNhap], [DonGiaNhap], [Thue], [ThanhTien]) VALUES (N'PN01', N'XE11      ', 3, 300.0000, 2, 918.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaXe], [SLNhap], [DonGiaNhap], [Thue], [ThanhTien]) VALUES (N'PN01', N'XE12      ', 1, 12000000.0000, 1, 12120000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaXe], [SLNhap], [DonGiaNhap], [Thue], [ThanhTien]) VALUES (N'PN02', N'XE12      ', 1, 12000000.0000, 0, 12000000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaXe], [SLNhap], [DonGiaNhap], [Thue], [ThanhTien]) VALUES (N'PN02', N'XE4       ', 1, 1200000.0000, 0, 1200000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaXe], [SLNhap], [DonGiaNhap], [Thue], [ThanhTien]) VALUES (N'PN03', N'XE12      ', 1, 12000000.0000, 1, 12120000.0000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPN], [MaXe], [SLNhap], [DonGiaNhap], [Thue], [ThanhTien]) VALUES (N'PN03', N'XE7       ', 30, 3000000.0000, 2, 91800000.0000)
/****** Object:  StoredProcedure [dbo].[sp_Get_Quyen]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Get_Quyen]
	@User nvarchar(50)
AS
BEGIN

	SELECT Quyen from dbo.Users where [User]=@User

END
GO
/****** Object:  StoredProcedure [dbo].[sp_Get_MaNV]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Get_MaNV]
	@User nvarchar(50)
AS
BEGIN

	SELECT MaNhanVien from dbo.Users where [User]=@User

END
GO
/****** Object:  StoredProcedure [dbo].[sp_Users_Delete]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_PhieuNhap_Delete]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Users_Update]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Users_Update]
	@User varchar(50),
	 @MatKhauCu varchar(50),
	@MatKhauMoi	varchar(50)
AS
BEGIN
	update dbo.Users set  MatKhauCu = @MatKhauCu,MatKhauMoi=@MatKhauMoi
	where [User] = @User 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Users_Insert]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_Search_MaPhieuXuat]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Search_MaPhieuXuat]
@MaPhieuXuat nvarchar(50)
as
SELECT * FROM dbo.PhieuXuat where [dbo].[fuChuyenCoDauThanhKhongDau](MaPhieuXuat) like N'%' +dbo.fuChuyenCoDauThanhKhongDau(@MaPhieuXuat)+'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuXuat_Update]    Script Date: 01/06/2017 12:16:21 ******/
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
	where MaPhieuXuat = @MaPX
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuXuat_Insert]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuXuat_Insert]
	@MaPhieuXuat varchar(50),
	@NgayXuat datetime,
	@MaNhanVien nvarchar(50),
	@MaKhachHang nvarchar(50)
AS
BEGIN
	insert into dbo.PhieuXuat values(@MaPhieuXuat,@NgayXuat,@MaNhanVien,@MaKhachHang)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuXuat_Delete]    Script Date: 01/06/2017 12:16:21 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_PhieuNhap_Update]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuNhap_Update]
	@MaPN nvarchar(50),
	@NgayNhap date,
	@MaNhanVien nvarchar(50),
	@MaNhaCungCap nvarchar(50)
AS
BEGIN
	update dbo.PhieuNhap set  NgayNhap = @NgayNhap, MaNhanVien = @MaNhanVien,MaNhaCungCap=@MaNhaCungCap
	where MaPN = @MaPN
END
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuNhap_Insert]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_PhieuNhap_Insert]
	@MaPN nvarchar(50),
	@NgayNhap date,
	@MaNhanVien nvarchar(50),
	@MaNhaCungCap nvarchar(50)
AS
BEGIN
	insert into dbo.PhieuNhap values(@MaPN,@NgayNhap,@MaNhanVien,@MaNhaCungCap)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuNhap_Delete]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuNhap_Delete]
	@MaPN nvarchar(50),
	@MaXe nvarchar(50)
AS
BEGIN
	delete from dbo.ChiTietPhieuNhap where MaPN=@MaPN and MaXe=@MaXe
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HoaDonThanhToanKH]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_HoaDonThanhToanKH]
AS
BEGIN
SELECT * from dbo.ChiTietPhieuXuat,dbo.Xe,dbo.PhieuXuat,dbo.KhachHang
	where KhachHang.MaKH=PhieuXuat.MaKhachHang and PhieuXuat.MaPhieuXuat=ChiTietPhieuXuat.MaPhieuXuat
	and dbo.ChiTietPhieuXuat.MaXe=Xe.MaXe
END
GO
/****** Object:  StoredProcedure [dbo].[sp_HoaDonKH]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_HoaDonKH]
AS
BEGIN
SELECT * FROM KhachHang,ChiTietPhieuXuat,Xe,PhieuXuat Where KhachHang.MaKH=PhieuXuat.MaKhachHang
and ChiTietPhieuXuat.MaXe=Xe.MaXe 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuXuat_Update]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuXuat_Update]
	@MaPhieuXuat nvarchar(50),
	@MaXe nchar(50),
	@SLXuat int,
	@DonGiaXuat money,
	@Thue money
AS
BEGIN
	update dbo.ChiTietPhieuXuat set   SLXuat = @SLXuat,DonGiaXuat=@DonGiaXuat,Thue=@Thue
	where MaXe = @MaXe and MaPhieuXuat=@MaPhieuXuat
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuXuat_Insert]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuXuat_Insert]
	@MaPhieuXuat nvarchar(50),
	@MaXe nchar(10),
	@SLXuat int,
	@DonGiaXuat money,
	@Thue int
AS
BEGIN
	insert into dbo.ChiTietPhieuXuat(MaPhieuXuat,MaXe,SLXuat,DonGiaXuat,Thue) values(@MaPhieuXuat,@MaXe,@SLXuat,@DonGiaXuat,@Thue)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuXuat_Delete]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuXuat_Delete]
	@MaPhieuXuat nvarchar(50),
	@MaXe nchar(10)
AS
BEGIN
	delete from dbo.ChiTietPhieuXuat where MaPhieuXuat=@MaPhieuXuat and MaXe=@MaXe
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuNhap_Update]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuNhap_Update]
	@MaPN nvarchar(50),
	@MaXe nvarchar(50),
	@SLNhap int,
	@DonGiaNhap money,
	@Thue money
AS
BEGIN
	update dbo.ChiTietPhieuNhap set   SLNhap = @SLNhap,DonGiaNhap=@DonGiaNhap,Thue=@Thue
	where MaPN = @MaPN and MaXe=@MaXe
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ChiTietPhieuNhap_Insert]    Script Date: 01/06/2017 12:16:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ChiTietPhieuNhap_Insert]
	@MaPN nvarchar(50),
	@MaXe nvarchar(50),
	@SLNhap int,
	@DonGiaNhap money,
	@Thue money
AS
BEGIN
	insert into dbo.ChiTietPhieuNhap(MaPN,MaXe,SLNhap,DonGiaNhap,Thue) values(@MaPN,@MaXe,@SLNhap,@DonGiaNhap,@Thue)
END
GO
/****** Object:  ForeignKey [FK_Users_NhanVien]    Script Date: 01/06/2017 12:16:21 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuXuat_KhachHang]    Script Date: 01/06/2017 12:16:21 ******/
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_KhachHang]
GO
/****** Object:  ForeignKey [FK_PhieuXuat_NhanVien]    Script Date: 01/06/2017 12:16:21 ******/
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_NhanVien]
GO
/****** Object:  ForeignKey [FK_PhieuNhap_NhaCungCap]    Script Date: 01/06/2017 12:16:21 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_PhieuNhap_NhanVien]    Script Date: 01/06/2017 12:16:21 ******/
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuXuat_PhieuXuat]    Script Date: 01/06/2017 12:16:21 ******/
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PhieuXuat] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuXuat_Xe]    Script Date: 01/06/2017 12:16:21 ******/
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_Xe]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhap_PhieuNhap]    Script Date: 01/06/2017 12:16:21 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhap_Xe]    Script Date: 01/06/2017 12:16:21 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_Xe]
GO
