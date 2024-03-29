USE [master]
GO
/****** Object:  Database [ChickStore]    Script Date: 09/12/2016 10:46:21 CH ******/
CREATE DATABASE [ChickStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ChickStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ChickStore.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ChickStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ChickStore_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ChickStore] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ChickStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ChickStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ChickStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ChickStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ChickStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ChickStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [ChickStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ChickStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ChickStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ChickStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ChickStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ChickStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ChickStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ChickStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ChickStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ChickStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ChickStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ChickStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ChickStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ChickStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ChickStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ChickStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ChickStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ChickStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ChickStore] SET  MULTI_USER 
GO
ALTER DATABASE [ChickStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ChickStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ChickStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ChickStore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ChickStore] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ChickStore]
GO
/****** Object:  Table [dbo].[BangLuong]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BangLuong](
	[MSNV] [varchar](8) NOT NULL,
	[ThangNamTinhLuong] [date] NOT NULL,
	[TongGioCongNgayThuong] [float] NOT NULL,
	[TongGioCongNgayLe] [float] NOT NULL,
	[Luong] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MSNV] ASC,
	[ThangNamTinhLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BoPhan]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BoPhan](
	[MaBoPhan] [varchar](8) NOT NULL,
	[TenBoPhan] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BoPhan] PRIMARY KEY CLUSTERED 
(
	[MaBoPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChamCong](
	[MSNV] [varchar](8) NOT NULL,
	[NgayThangLamViec] [date] NOT NULL,
	[LaNgayLe] [int] NOT NULL,
	[DiLam] [bit] NULL,
 CONSTRAINT [PK__ChamCong__5E17FF5675FCA20B] PRIMARY KEY CLUSTERED 
(
	[MSNV] ASC,
	[NgayThangLamViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietDoanhThuNgay]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietDoanhThuNgay](
	[MSBaoCao] [varchar](8) NOT NULL,
	[CaPos] [int] NOT NULL,
	[MSNV] [varchar](8) NOT NULL,
	[TienVay] [float] NOT NULL,
	[DoanhThu] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MSBaoCao] ASC,
	[CaPos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietDoanhThuThang]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietDoanhThuThang](
	[MSBaoCaoThang] [varchar](8) NOT NULL,
	[MSBaoCaoNgay] [varchar](8) NULL,
 CONSTRAINT [PK_ChiTietDoanhThuThang] PRIMARY KEY CLUSTERED 
(
	[MSBaoCaoThang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MSHoaDon] [varchar](8) NOT NULL,
	[PhanAn] [nvarchar](50) NOT NULL,
	[SL] [int] NOT NULL,
	[ThanhTien] [float] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MSHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DoanhThuNgay]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DoanhThuNgay](
	[MSBaoCao] [varchar](8) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[TongDoanhThu] [float] NOT NULL,
 CONSTRAINT [PK_DoanhThuNgay] PRIMARY KEY CLUSTERED 
(
	[MSBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DoanhThuThang]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DoanhThuThang](
	[MSBaoCaoThang] [varchar](8) NOT NULL,
	[Nam] [int] NOT NULL,
	[Thang] [int] NOT NULL,
	[TongDoanhThuThang] [float] NOT NULL,
 CONSTRAINT [PK_DoanhThuThang] PRIMARY KEY CLUSTERED 
(
	[MSBaoCaoThang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MSHoaDon] [varchar](8) NOT NULL,
	[MSNV] [varchar](8) NOT NULL,
	[Pos] [int] NOT NULL,
	[LoaiPhucVu] [nvarchar](50) NOT NULL,
	[ThoiGianXuatHD] [date] NOT NULL,
	[TienGiamGia] [float] NOT NULL,
	[TongThanhToan] [float] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MSHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MatHangWetGoods]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MatHangWetGoods](
	[MaHang] [varchar](15) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[DonViTinh] [nchar](20) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_MatHangWetGoods] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MSNV] [varchar](8) NOT NULL,
	[HoTenNV] [nvarchar](50) NOT NULL,
	[NgSinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[QueQuan] [nvarchar](50) NOT NULL,
	[MaBoPhan] [varchar](8) NULL,
	[NgayTiepNhan] [date] NOT NULL,
	[Password] [varchar](30) NULL,
	[LaQL] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MSNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhapWetGoods]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhapWetGoods](
	[MaNhap] [varchar](8) NOT NULL,
	[MaHang] [varchar](15) NOT NULL,
	[NgayNhap] [date] NOT NULL,
	[SL] [int] NOT NULL,
	[ThucNhan] [int] NOT NULL,
	[NgayHetHan] [date] NOT NULL,
 CONSTRAINT [PK_NhapWetGoods] PRIMARY KEY CLUSTERED 
(
	[MaNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhomSanPham]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhomSanPham](
	[IDNhomSP] [varchar](7) NOT NULL,
	[TenNhomSP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhomSanPham] PRIMARY KEY CLUSTERED 
(
	[IDNhomSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QuanLySanPham]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QuanLySanPham](
	[IDSP] [varchar](8) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[GiaSP] [nvarchar](8) NOT NULL,
	[IDNhomSP] [varchar](7) NOT NULL,
 CONSTRAINT [PK_QLSP] PRIMARY KEY CLUSTERED 
(
	[IDSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QuyDinh]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinh](
	[TuoiToiThieu] [int] NOT NULL,
	[TuoiToiDa] [int] NOT NULL,
	[GioCongToiThieu] [float] NOT NULL,
	[GioCongToiDa] [float] NOT NULL,
	[MucLuongNgayThuong] [float] NOT NULL,
	[MucLuongNgayLe] [float] NOT NULL,
	[ThoiGianXuatHD] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[XuatWetGoods]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XuatWetGoods](
	[MaXuat] [varchar](8) NOT NULL,
	[MaHang] [varchar](15) NOT NULL,
	[NgayXuat] [date] NOT NULL,
	[SLXuat] [int] NOT NULL,
 CONSTRAINT [PK_XuatWetGoods] PRIMARY KEY CLUSTERED 
(
	[MaXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[funcDoanhThuTheoNgay]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[funcDoanhThuTheoNgay]
(	
	@NgayTinh date
)
RETURNS TABLE 
AS
RETURN 
(
	select CaPos,NhanVien.MSNV,NhanVien.HoTenNV,TienVay,DoanhThu 
from DoanhThuNgay,ChiTietDoanhThuNgay,NhanVien
where DoanhThuNgay.MSBaoCao=ChiTietDoanhThuNgay.MSBaoCao 
and ChiTietDoanhThuNgay.MSNV=NhanVien.MSNV and NgayLap=@NgayTinh
)

GO
/****** Object:  UserDefinedFunction [dbo].[funcDoanhThuTrongThang]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[funcDoanhThuTrongThang]
(	
	@CuoiThang varchar(30),
	@DauThang varchar(30)
)
RETURNS TABLE 
AS
RETURN 
(
	select NgayLap,TongDoanhThu from DoanhThuNgay where NgayLap<@CuoiThang and NgayLap > @DauThang
)

GO
/****** Object:  UserDefinedFunction [dbo].[funcTongDoanhThuTrongThang]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[funcTongDoanhThuTrongThang]
(	
		@CuoiThang varchar(30),
	@DauThang varchar(30)
)
RETURNS TABLE 
AS
RETURN 
(
		select SUM(TongDoanhThu) as TongDT from DoanhThuNgay 
	where NgayLap<@CuoiThang and NgayLap > @DauThang
)

GO
INSERT [dbo].[BangLuong] ([MSNV], [ThangNamTinhLuong], [TongGioCongNgayThuong], [TongGioCongNgayLe], [Luong]) VALUES (N'1', CAST(N'2016-11-08' AS Date), 4, 5, 200000)
INSERT [dbo].[BangLuong] ([MSNV], [ThangNamTinhLuong], [TongGioCongNgayThuong], [TongGioCongNgayLe], [Luong]) VALUES (N'1', CAST(N'2016-11-09' AS Date), 6.1833333969116211, 7.3333334922790527, 455966.6875)
INSERT [dbo].[BangLuong] ([MSNV], [ThangNamTinhLuong], [TongGioCongNgayThuong], [TongGioCongNgayLe], [Luong]) VALUES (N'1', CAST(N'2016-12-08' AS Date), 6, 3, 200000)
INSERT [dbo].[BangLuong] ([MSNV], [ThangNamTinhLuong], [TongGioCongNgayThuong], [TongGioCongNgayLe], [Luong]) VALUES (N'2', CAST(N'2016-11-09' AS Date), 17, 12.333333015441895, 885666.625)
INSERT [dbo].[BoPhan] ([MaBoPhan], [TenBoPhan]) VALUES (N'COK', N'Cook')
INSERT [dbo].[BoPhan] ([MaBoPhan], [TenBoPhan]) VALUES (N'CSH', N'Cashier')
INSERT [dbo].[BoPhan] ([MaBoPhan], [TenBoPhan]) VALUES (N'RIR', N'Rider')
INSERT [dbo].[BoPhan] ([MaBoPhan], [TenBoPhan]) VALUES (N'SUP', N'Supply')
INSERT [dbo].[ChamCong] ([MSNV], [NgayThangLamViec], [LaNgayLe], [DiLam]) VALUES (N'1', CAST(N'2016-11-07' AS Date), 1, 1)
INSERT [dbo].[ChamCong] ([MSNV], [NgayThangLamViec], [LaNgayLe], [DiLam]) VALUES (N'1', CAST(N'2016-11-08' AS Date), 0, 1)
INSERT [dbo].[ChamCong] ([MSNV], [NgayThangLamViec], [LaNgayLe], [DiLam]) VALUES (N'2', CAST(N'2015-10-11' AS Date), 1, 1)
INSERT [dbo].[ChamCong] ([MSNV], [NgayThangLamViec], [LaNgayLe], [DiLam]) VALUES (N'2', CAST(N'2016-11-09' AS Date), 0, 1)
INSERT [dbo].[ChamCong] ([MSNV], [NgayThangLamViec], [LaNgayLe], [DiLam]) VALUES (N'2', CAST(N'2016-12-10' AS Date), 0, 1)
INSERT [dbo].[ChiTietDoanhThuNgay] ([MSBaoCao], [CaPos], [MSNV], [TienVay], [DoanhThu]) VALUES (N'1', 1, N'1', 20000, 400000)
INSERT [dbo].[ChiTietDoanhThuNgay] ([MSBaoCao], [CaPos], [MSNV], [TienVay], [DoanhThu]) VALUES (N'2', 1, N'1', 2000, 50000)
INSERT [dbo].[ChiTietDoanhThuThang] ([MSBaoCaoThang], [MSBaoCaoNgay]) VALUES (N'1', N'1')
INSERT [dbo].[ChiTietDoanhThuThang] ([MSBaoCaoThang], [MSBaoCaoNgay]) VALUES (N'2', N'2')
INSERT [dbo].[ChiTietDoanhThuThang] ([MSBaoCaoThang], [MSBaoCaoNgay]) VALUES (N'3', N'3')
INSERT [dbo].[ChiTietHoaDon] ([MSHoaDon], [PhanAn], [SL], [ThanhTien]) VALUES (N'1', N'bntSP11', 1, 79000)
INSERT [dbo].[ChiTietHoaDon] ([MSHoaDon], [PhanAn], [SL], [ThanhTien]) VALUES (N'2', N'bntSP11', 1, 79000)
INSERT [dbo].[ChiTietHoaDon] ([MSHoaDon], [PhanAn], [SL], [ThanhTien]) VALUES (N'3', N'bntSP11', 1, 79000)
INSERT [dbo].[ChiTietHoaDon] ([MSHoaDon], [PhanAn], [SL], [ThanhTien]) VALUES (N'4', N'bntSP11', 1, 79000)
INSERT [dbo].[ChiTietHoaDon] ([MSHoaDon], [PhanAn], [SL], [ThanhTien]) VALUES (N'5', N'bntSP11', 1, 79000)
INSERT [dbo].[ChiTietHoaDon] ([MSHoaDon], [PhanAn], [SL], [ThanhTien]) VALUES (N'6', N'bntSP18', 1, 345000)
INSERT [dbo].[DoanhThuNgay] ([MSBaoCao], [NgayLap], [TongDoanhThu]) VALUES (N'1', CAST(N'2016-11-12' AS Date), 40000)
INSERT [dbo].[DoanhThuNgay] ([MSBaoCao], [NgayLap], [TongDoanhThu]) VALUES (N'2', CAST(N'2016-11-13' AS Date), 200000)
INSERT [dbo].[DoanhThuNgay] ([MSBaoCao], [NgayLap], [TongDoanhThu]) VALUES (N'3', CAST(N'2016-11-14' AS Date), 300000)
INSERT [dbo].[DoanhThuNgay] ([MSBaoCao], [NgayLap], [TongDoanhThu]) VALUES (N'4', CAST(N'2016-10-11' AS Date), 300)
INSERT [dbo].[DoanhThuNgay] ([MSBaoCao], [NgayLap], [TongDoanhThu]) VALUES (N'5', CAST(N'2015-10-01' AS Date), 99999999)
INSERT [dbo].[DoanhThuThang] ([MSBaoCaoThang], [Nam], [Thang], [TongDoanhThuThang]) VALUES (N'DTT01', 2016, 11, 0)
INSERT [dbo].[HoaDon] ([MSHoaDon], [MSNV], [Pos], [LoaiPhucVu], [ThoiGianXuatHD], [TienGiamGia], [TongThanhToan]) VALUES (N'1', N'1', 0, N'1', CAST(N'2016-01-01' AS Date), 0, 100000)
INSERT [dbo].[HoaDon] ([MSHoaDon], [MSNV], [Pos], [LoaiPhucVu], [ThoiGianXuatHD], [TienGiamGia], [TongThanhToan]) VALUES (N'2', N'1', 0, N'1', CAST(N'2015-01-01' AS Date), 0, 200000)
INSERT [dbo].[HoaDon] ([MSHoaDon], [MSNV], [Pos], [LoaiPhucVu], [ThoiGianXuatHD], [TienGiamGia], [TongThanhToan]) VALUES (N'3', N'1', 0, N'1', CAST(N'2016-01-01' AS Date), 0, 100000)
INSERT [dbo].[HoaDon] ([MSHoaDon], [MSNV], [Pos], [LoaiPhucVu], [ThoiGianXuatHD], [TienGiamGia], [TongThanhToan]) VALUES (N'4', N'1', 0, N'1', CAST(N'2015-01-01' AS Date), 0, 200000)
INSERT [dbo].[HoaDon] ([MSHoaDon], [MSNV], [Pos], [LoaiPhucVu], [ThoiGianXuatHD], [TienGiamGia], [TongThanhToan]) VALUES (N'5', N'3', 0, N'0', CAST(N'2016-12-09' AS Date), 0, 79000)
INSERT [dbo].[HoaDon] ([MSHoaDon], [MSNV], [Pos], [LoaiPhucVu], [ThoiGianXuatHD], [TienGiamGia], [TongThanhToan]) VALUES (N'6', N'3', 0, N'0', CAST(N'2016-12-09' AS Date), 0, 345000)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'01. CO_CANHGA', N'01. Cánh gà đông lạnh', N'Cái                 ', 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'02. CO_DUIGO4', N'02. Đùi gà góc tư', N'Cái                 ', 9)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'03. CO_9MIENG', N'03. Gà 9 miếng', N'Cái                 ', 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'04. CO_PHILE0', N'04. Gà phi-lê không da', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'05. CO_PHILE1', N'05. Gà phi-lê có da', NULL, 4)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'06. CO_GAVIEN', N'06. Gà viên', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'07. CO_GXUONG', N'07. Xương gà', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'08. SU_KHOAIT', N'08. Khoai tây chiên', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'09. SU_BANHTA', N'09. Bánh pie táo', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'10. SU_BANHMO', N'10. Bánh pie môn', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'11. SU_BUGTOM', N'11. Miếng Burger tôm', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'12. SU_BUGOCN', N'12. Miếng Burger hải sản', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'13. SU_CATHAN', N'13. Cá thanh', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'14. SU_BANHTR', N'14. Vỏ bánh trứng', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'15. SU_KEMSUA', N'15. Kem sữa', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'16. SU_PHOMAI', N'16. Phô mai lát', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'17. SU_LOLOXA', N'17. Lolo xanh', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'18. SU_CACHUA', N'18. Cà chua', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'19. SU_DUALEO', N'19. Dưa leo', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'20. SU_CARROT', N'20. Cà rốt', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'21. SU_KHOAIC', N'21. Khoai tây củ', NULL, 9)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'22. SU_BCAITR', N'22. Bắp cải trộn', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'23. SU_HANHLA', N'23. Hành lá', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'24. SU_SALADM', N'24. Salad Mỹ', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'25. SU_CAITHI', N'25. Cải thìa', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'26. SU_GUNGNO', N'26. Gừng non', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'27. SU_TDAUCO', N'27. Dầu cọ', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'28. CS_PEPSIT', N'28. Pepsi tươi', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'29. CS_PEPSIL', N'29. Pepsi lon', NULL, 0)
INSERT [dbo].[MatHangWetGoods] ([MaHang], [TenHang], [DonViTinh], [SoLuong]) VALUES (N'30. CS_BANHKE', N'30. Ống bánh kem', NULL, 0)
INSERT [dbo].[NhanVien] ([MSNV], [HoTenNV], [NgSinh], [GioiTinh], [QueQuan], [MaBoPhan], [NgayTiepNhan], [Password], [LaQL]) VALUES (N'1', N'Khán', CAST(N'2016-11-07' AS Date), N'Nam', N'TB', N'CSH', CAST(N'2016-11-07' AS Date), N'1', 1)
INSERT [dbo].[NhanVien] ([MSNV], [HoTenNV], [NgSinh], [GioiTinh], [QueQuan], [MaBoPhan], [NgayTiepNhan], [Password], [LaQL]) VALUES (N'2', N'Duyên', CAST(N'1996-11-11' AS Date), N'Nữ', N'Không', N'RIR', CAST(N'2015-11-11' AS Date), NULL, 1)
INSERT [dbo].[NhanVien] ([MSNV], [HoTenNV], [NgSinh], [GioiTinh], [QueQuan], [MaBoPhan], [NgayTiepNhan], [Password], [LaQL]) VALUES (N'3', N'3333', CAST(N'1990-01-01' AS Date), N'Nam', N'TB', N'CSH', CAST(N'2016-01-01' AS Date), N'3', 0)
INSERT [dbo].[NhanVien] ([MSNV], [HoTenNV], [NgSinh], [GioiTinh], [QueQuan], [MaBoPhan], [NgayTiepNhan], [Password], [LaQL]) VALUES (N'NV003', N'Thaoi', CAST(N'2016-12-08' AS Date), N'Nam', N'TB', N'SUP', CAST(N'2016-12-08' AS Date), NULL, 0)
INSERT [dbo].[NhanVien] ([MSNV], [HoTenNV], [NgSinh], [GioiTinh], [QueQuan], [MaBoPhan], [NgayTiepNhan], [Password], [LaQL]) VALUES (N'NV004', N'4', CAST(N'2016-12-09' AS Date), N'Nữ', N'4', N'SUP', CAST(N'2016-12-09' AS Date), NULL, NULL)
INSERT [dbo].[NhapWetGoods] ([MaNhap], [MaHang], [NgayNhap], [SL], [ThucNhan], [NgayHetHan]) VALUES (N'NW001', N'02. CO_DUIGO4', CAST(N'2016-12-09' AS Date), 5, 5, CAST(N'2016-12-28' AS Date))
INSERT [dbo].[NhapWetGoods] ([MaNhap], [MaHang], [NgayNhap], [SL], [ThucNhan], [NgayHetHan]) VALUES (N'NW002', N'05. CO_PHILE1', CAST(N'2016-12-09' AS Date), 4, 4, CAST(N'2016-12-30' AS Date))
INSERT [dbo].[NhapWetGoods] ([MaNhap], [MaHang], [NgayNhap], [SL], [ThucNhan], [NgayHetHan]) VALUES (N'NW003', N'02. CO_DUIGO4', CAST(N'2016-12-09' AS Date), 3, 3, CAST(N'2016-12-21' AS Date))
INSERT [dbo].[NhapWetGoods] ([MaNhap], [MaHang], [NgayNhap], [SL], [ThucNhan], [NgayHetHan]) VALUES (N'NW004', N'21. SU_KHOAIC', CAST(N'2016-12-09' AS Date), 10, 9, CAST(N'2016-12-31' AS Date))
INSERT [dbo].[NhomSanPham] ([IDNhomSP], [TenNhomSP]) VALUES (N'subtab1', N'Phần ăn Combo')
INSERT [dbo].[NhomSanPham] ([IDNhomSP], [TenNhomSP]) VALUES (N'subtab2', N'Gà chiên / Gà nướng')
INSERT [dbo].[NhomSanPham] ([IDNhomSP], [TenNhomSP]) VALUES (N'subtab3', N'Burger / Cơm')
INSERT [dbo].[NhomSanPham] ([IDNhomSP], [TenNhomSP]) VALUES (N'subtab4', N'Thức ăn nhẹ')
INSERT [dbo].[NhomSanPham] ([IDNhomSP], [TenNhomSP]) VALUES (N'subtab5', N'Tráng miệng / Nước uống')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP11', N'Gà giòn cay ‖ 079', N'79000', N'subtab1')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP110', N'Phần ăn TEEN ‖ 063', N'63000', N'subtab1')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP111', N'Phần ăn DOUBLE ‖ 175', N'175000', N'subtab1')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP112', N'COMBO 99k ‖ 099', N'99000', N'subtab1')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP12', N'Gà truyền thống ‖ 079', N'79000', N'subtab1')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP13', N'Phần ăn trẻ em ‖ 056', N'56000', N'subtab1')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP14', N'Phần ăn XL ‖ 099', N'99000', N'subtab1')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP15', N'Phần ăn gia đình 1 ‖ 242', N'242000', N'subtab1')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP16', N'Phần ăn gia đình 2 ‖ 258', N'258000', N'subtab1')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP17', N'Phần ăn gia đình 3 ‖ 245', N'245000', N'subtab1')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP18', N'Phần ăn gia đình 4 ‖ 345', N'345000', N'subtab1')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP19', N'Đùi gà quay ‖ 079', N'79000', N'subtab1')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP21', N'1 miếng Gà giòn cay ‖ 034', N'34000', N'subtab2')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP210', N'Gà quay giấy bạc ‖ 064', N'64000', N'subtab2')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP211', N'', N'0', N'subtab2')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP212', N'', N'0', N'subtab2')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP22', N'3 miếng Gà giòn cay ‖ 094', N'94000', N'subtab2')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP23', N'5 miếng Gà giòn cay ‖ 149', N'149000', N'subtab2')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP24', N'1 miếng Gà truyền thống ‖ 034', N'34000', N'subtab2')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP25', N'3 miếng Gà truyền thống ‖ 094', N'94000', N'subtab2')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP26', N'5 miếng Gà truyền thống ‖ 149', N'149000', N'subtab2')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP27', N'3 miếng cánh gà giòn ‖ 047', N'47000', N'subtab2')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP28', N'5 miếng cánh gà giòn ‖ 069', N'69000', N'subtab2')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP29', N'', N'0', N'subtab2')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP31', N'Burger Hải sản ‖ 022', N'22000', N'subtab3')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP310', N'Cơm gà xiên que ‖ 039', N'39000', N'subtab3')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP311', N'', N'0', N'subtab3')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP312', N'Cơm thêm ‖ 010', N'10000', N'subtab3')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP32', N'Burger Tôm ‖ 039', N'39000', N'subtab3')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP33', N'Burger Gà quay ‖ 045', N'45000', N'subtab3')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP34', N'Burger Zinger ‖ 049', N'49000', N'subtab3')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP35', N'', N'0', N'subtab3')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP36', N'Kẹp phô mai ‖ 004', N'4000', N'subtab3')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP37', N'Cơm gà truyền thống ‖ 039', N'39000', N'subtab3')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP38', N'Cơm gà giòn cay ‖ 039', N'39000', N'subtab3')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP39', N'Cơm gà quay ‖ 039', N'39000', N'subtab3')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP41', N'Súp rau củ ‖ 012', N'12000', N'subtab4')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP410', N'Salad ‖ 015', N'15000', N'subtab4')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP411', N'Salad gà ‖ 019', N'19000', N'subtab4')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP412', N'', N'0', N'subtab4')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP42', N'Canh cải thìa ‖ 009', N'9000', N'subtab4')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP43', N'', N'0', N'subtab4')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP44', N'Gà viên vừa ‖ 040', N'40000', N'subtab4')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP45', N'Gà viên lớn ‖ 061', N'61000', N'subtab4')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP46', N'', N'0', N'subtab4')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP47', N'Khoai chiên ‖ 012', N'12000', N'subtab4')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP48', N'Khoai nghiền ‖ 010', N'10000', N'subtab4')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP49', N'Bắp cải trộn ‖ 012', N'12000', N'subtab4')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP51', N'Pepsi vừa ‖ 010', N'10000', N'subtab5')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP510', N'Kem Vani ‖ 003', N'3000', N'subtab5')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP511', N'Kem Socola ‖ 005', N'5000', N'subtab5')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP512', N'Kem ly ‖ 012', N'12000', N'subtab5')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP52', N'Pepsi lớn ‖ 017', N'17000', N'subtab5')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP53', N'Milo ‖ 020', N'20000', N'subtab5')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP54', N'1 cái Bánh trứng ‖ 015', N'15000', N'subtab5')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP55', N'4 cái Bánh trứng ‖ 045', N'45000', N'subtab5')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP56', N'HOTPIE ‖ 012', N'12000', N'subtab5')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP57', N'Pepsi lon ‖ 017', N'17000', N'subtab5')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP58', N'Pepsi Diet ‖ 017', N'17000', N'subtab5')
INSERT [dbo].[QuanLySanPham] ([IDSP], [TenSP], [GiaSP], [IDNhomSP]) VALUES (N'bntSP59', N'', N'0', N'subtab5')
SET ANSI_PADDING ON

GO
/****** Object:  Index [demoindex]    Script Date: 09/12/2016 10:46:21 CH ******/
CREATE NONCLUSTERED INDEX [demoindex] ON [dbo].[BangLuong]
(
	[MSNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BangLuong]  WITH CHECK ADD  CONSTRAINT [FK__BangLuong__MSNV__4D94879B] FOREIGN KEY([MSNV])
REFERENCES [dbo].[NhanVien] ([MSNV])
GO
ALTER TABLE [dbo].[BangLuong] CHECK CONSTRAINT [FK__BangLuong__MSNV__4D94879B]
GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD  CONSTRAINT [FK__ChamCong__MSNV__398D8EEE] FOREIGN KEY([MSNV])
REFERENCES [dbo].[NhanVien] ([MSNV])
GO
ALTER TABLE [dbo].[ChamCong] CHECK CONSTRAINT [FK__ChamCong__MSNV__398D8EEE]
GO
ALTER TABLE [dbo].[ChiTietDoanhThuNgay]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietDoa__MSNV__45F365D3] FOREIGN KEY([MSNV])
REFERENCES [dbo].[NhanVien] ([MSNV])
GO
ALTER TABLE [dbo].[ChiTietDoanhThuNgay] CHECK CONSTRAINT [FK__ChiTietDoa__MSNV__45F365D3]
GO
ALTER TABLE [dbo].[ChiTietDoanhThuNgay]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDoanhThuNgay_DoanhThuNgay] FOREIGN KEY([MSBaoCao])
REFERENCES [dbo].[DoanhThuNgay] ([MSBaoCao])
GO
ALTER TABLE [dbo].[ChiTietDoanhThuNgay] CHECK CONSTRAINT [FK_ChiTietDoanhThuNgay_DoanhThuNgay]
GO
ALTER TABLE [dbo].[ChiTietDoanhThuThang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDoanhThuThang_DoanhThuNgay] FOREIGN KEY([MSBaoCaoThang])
REFERENCES [dbo].[DoanhThuNgay] ([MSBaoCao])
GO
ALTER TABLE [dbo].[ChiTietDoanhThuThang] CHECK CONSTRAINT [FK_ChiTietDoanhThuThang_DoanhThuNgay]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MSHoaDon])
REFERENCES [dbo].[HoaDon] ([MSHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK__HoaDon__MSNV__6477ECF3] FOREIGN KEY([MSNV])
REFERENCES [dbo].[NhanVien] ([MSNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK__HoaDon__MSNV__6477ECF3]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK__NhanVien__MaBoPh__4BAC3F29] FOREIGN KEY([MaBoPhan])
REFERENCES [dbo].[BoPhan] ([MaBoPhan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK__NhanVien__MaBoPh__4BAC3F29]
GO
ALTER TABLE [dbo].[NhapWetGoods]  WITH CHECK ADD  CONSTRAINT [FK_NhapWetGoods_MatHangWetGoods] FOREIGN KEY([MaHang])
REFERENCES [dbo].[MatHangWetGoods] ([MaHang])
GO
ALTER TABLE [dbo].[NhapWetGoods] CHECK CONSTRAINT [FK_NhapWetGoods_MatHangWetGoods]
GO
ALTER TABLE [dbo].[QuanLySanPham]  WITH CHECK ADD  CONSTRAINT [FK_QuanLySanPham_NhomSanPham1] FOREIGN KEY([IDNhomSP])
REFERENCES [dbo].[NhomSanPham] ([IDNhomSP])
GO
ALTER TABLE [dbo].[QuanLySanPham] CHECK CONSTRAINT [FK_QuanLySanPham_NhomSanPham1]
GO
ALTER TABLE [dbo].[XuatWetGoods]  WITH CHECK ADD  CONSTRAINT [FK_XuatWetGoods_MatHangWetGoods] FOREIGN KEY([MaHang])
REFERENCES [dbo].[MatHangWetGoods] ([MaHang])
GO
ALTER TABLE [dbo].[XuatWetGoods] CHECK CONSTRAINT [FK_XuatWetGoods_MatHangWetGoods]
GO
/****** Object:  StoredProcedure [dbo].[sp_insertBangLuong]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_insertBangLuong]
@MSNV varchar(8),
@ThangNamTinhLuong date,
@TongGioCongNgayThuong float ,
@TongGioCongNgayLe float,
@Luong float
AS
BEGIN
	update BangLuong set TongGioCongNgayThuong=@TongGioCongNgayThuong,@TongGioCongNgayLe=@TongGioCongNgayLe,Luong=@Luong
	where MSNV=@MSNV and ThangNamTinhLuong=@ThangNamTinhLuong
END

GO
/****** Object:  StoredProcedure [dbo].[sp_insertGioCongtoChamCong]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_insertGioCongtoChamCong]
@MSNV varchar(8),
@NgayThangLamViec date,
@GioCong float
AS
BEGIN
update ChamCong set GioCong=@GioCong where MSNV=@MSNV and NgayThangLamViec=@NgayThangLamViec
END

GO
/****** Object:  StoredProcedure [dbo].[sp_insertNhapWetGoods]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Autho(r:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_insertNhapWetGoods]
@MaNhap varchar(8),
@MaHang varchar(15),
@NgayNhap date,
@SL int,
@ThucNhan int,
@NgayHetHan date
AS
BEGIN
	insert into NhapWetGoods(MaNhap,MaHang,NgayNhap,SL,ThucNhan,NgayHetHan) values (@MaNhap,@MaHang,@NgayNhap,@SL,@ThucNhan,@NgayHetHan);
	update MatHangWetGoods set SoLuong=SoLuong+@ThucNhan where MaHang=@MaHang
END

GO
/****** Object:  StoredProcedure [dbo].[spIncreaseNhapWetGoods]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spIncreaseNhapWetGoods]
@MaHang varchar(15),
@SL int ,
@ThucNhan int,
@NgayNhap date,
@NgayHetHan date
AS
BEGIN
	update NhapWetGoods  set SL=SL+@SL,ThucNhan=ThucNhan+@ThucNhan,NgayNhap=@NgayNhap,NgayHetHan=@NgayHetHan where MaHang=@MaHang
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertDoanhThuThang]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertDoanhThuThang]
@MSBaoCaoThang varchar(8),
@Thang int,
@Nam int,
@TongDoanhThu float
AS
BEGIN
	insert into DoanhThuThang(MSBaoCaoThang,Nam,Thang,TongDoanhThuThang) values (@MSBaoCaoThang,@Nam,@Thang,@TongDoanhThu)
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertNhanVien]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertNhanVien]
@MSNV varchar(8),
@HoTenNV nvarchar(50),
@NgSinh date,
@GioiTinh nvarchar(10),
@QueQuan nvarchar(50),
@MaBoPhan varchar(8),
@NgayTiepNhan date
AS
BEGIN
	insert into NhanVien(MSNV,HoTenNV,NgSinh,GioiTinh,QueQuan,MaBoPhan,NgayTiepNhan) values (@MSNV,@HoTenNV,@NgSinh,@GioiTinh,@QueQuan,@MaBoPhan,@NgayTiepNhan)
END

GO
/****** Object:  StoredProcedure [dbo].[spUpdateNhap_XuatWetGoods]    Script Date: 09/12/2016 10:46:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUpdateNhap_XuatWetGoods]

@MaHang varchar(15),

@MaXuat varchar(8),
@NgayXuat date,
@SLXuat int
AS
BEGIN
	
	insert into XuatWetGoods (MaXuat,MaHang,NgayXuat,SLXuat) values (@MaXuat,@MaHang,@NgayXuat,@SLXuat);
	update MatHangWetGoods set SoLuong=SoLuong-@SLXuat Where MaHang=@MaHang
END

GO
USE [master]
GO
ALTER DATABASE [ChickStore] SET  READ_WRITE 
GO
