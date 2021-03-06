USE [master]
GO
/****** Object:  Database [QLNS]    Script Date: 4/22/2022 9:22:58 PM ******/
CREATE DATABASE [QLNS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNS', FILENAME = N'D:\SQL\QLNS.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLNS_log', FILENAME = N'D:\SQL\QLNS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLNS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLNS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLNS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLNS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLNS] SET  MULTI_USER 
GO
ALTER DATABASE [QLNS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLNS]
GO
/****** Object:  Table [dbo].[BANGCONGNVCB]    Script Date: 4/22/2022 9:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGCONGNVCB](
	[MaNV] [nchar](10) NOT NULL,
	[MaPhong] [nchar](10) NOT NULL,
	[MaLuong] [nchar](10) NOT NULL,
	[LCB] [int] NULL,
	[PCChucVu] [int] NULL,
	[PCapKhac] [int] NULL,
	[Thuong] [int] NULL,
	[KyLuat] [int] NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL,
	[SoNgayCong] [int] NULL,
	[SoNgayNghi] [int] NULL,
	[SoGioLamThem] [int] NULL,
	[Luong] [float] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_BANGCONGNVCB] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[MaPhong] ASC,
	[MaLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BANGCONGTHUVIEC]    Script Date: 4/22/2022 9:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BANGCONGTHUVIEC](
	[MaNVTV] [char](10) NOT NULL,
	[MaPhong] [char](10) NOT NULL,
	[LuongTViec] [int] NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL,
	[SoNgayCong] [int] NULL,
	[SoNgayNghi] [int] NULL,
	[SoGioLamThem] [int] NULL,
	[Luong] [float] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_BANGCONGTHUVIEC] PRIMARY KEY CLUSTERED 
(
	[MaNVTV] ASC,
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BANGLUONGCTY]    Script Date: 4/22/2022 9:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGLUONGCTY](
	[MaLuong] [nchar](10) NOT NULL,
	[LCB] [float] NULL,
	[PCChucVu] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[LCBMoi] [int] NULL,
	[NgaySua] [datetime] NULL,
	[LyDo] [nvarchar](50) NULL,
	[PCChucVuMoi] [int] NULL,
	[NgaySuaPC] [date] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_BANGLUONGCTY] PRIMARY KEY CLUSTERED 
(
	[MaLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BOPHAN]    Script Date: 4/22/2022 9:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOPHAN](
	[MaBoPhan] [nchar](10) NOT NULL,
	[TenBoPhan] [nvarchar](20) NULL,
	[NgayThanhLap] [date] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_BOPHAN] PRIMARY KEY CLUSTERED 
(
	[MaBoPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOSOTHUVIEC]    Script Date: 4/22/2022 9:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOSOTHUVIEC](
	[MaNVTV] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[MaPhong] [char](10) NOT NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[TDHocVan] [nvarchar](20) NULL,
	[ViTriThuViec] [nvarchar](50) NULL,
	[NgayTV] [date] NULL,
	[ThangTV] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_HOSOTHUVIEC] PRIMARY KEY CLUSTERED 
(
	[MaNVTV] ASC,
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NVTHOIVIEC]    Script Date: 4/22/2022 9:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NVTHOIVIEC](
	[HoTen] [nchar](10) NULL,
	[CCCD] [nchar](10) NOT NULL,
	[NgayThoiViec] [nchar](10) NULL,
	[LyDo] [nchar](10) NULL,
 CONSTRAINT [PK_NVTHOIVIEC] PRIMARY KEY CLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 4/22/2022 9:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHONGBAN](
	[MaBoPhan] [char](10) NOT NULL,
	[MaPhongBan] [char](10) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[NgayThanhLap] [date] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHONGBAN] PRIMARY KEY CLUSTERED 
(
	[MaBoPhan] ASC,
	[MaPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SOBAOHIEM]    Script Date: 4/22/2022 9:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SOBAOHIEM](
	[MaNV] [char](10) NOT NULL,
	[MaLuong] [char](10) NULL,
	[MaSoBH] [char](10) NOT NULL,
	[NgayCap] [datetime] NULL,
	[NoiCap] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_SOBAOHIEM] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[MaSoBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THAISAN]    Script Date: 4/22/2022 9:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THAISAN](
	[MaPhong] [char](10) NOT NULL,
	[MaNV] [char](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[NgayVeSom] [datetime] NULL,
	[NgayNghiSinh] [datetime] NULL,
	[NgayTroLaiLam] [datetime] NULL,
	[TroCapCTY] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_THAISAN] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC,
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TTCANHAN]    Script Date: 4/22/2022 9:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTCANHAN](
	[MaNV] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NoiSinh] [nvarchar](50) NULL,
	[NguyenQuan] [nvarchar](50) NULL,
	[DCThuongChu] [nvarchar](50) NULL,
	[DCTamChu] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[DanToc] [nvarchar](20) NULL,
	[TonGiao] [nvarchar](20) NULL,
 CONSTRAINT [PK_TTCANHAN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TTNHANVIENCOBAN]    Script Date: 4/22/2022 9:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TTNHANVIENCOBAN](
	[MaNV] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[MaBoPhan] [char](10) NOT NULL,
	[MaPhong] [char](10) NOT NULL,
	[MaLuong] [char](10) NOT NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](20) NULL,
	[TTHonNhan] [nvarchar](50) NULL,
	[CCCD] [nvarchar](50) NULL,
	[NoiCap] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](255) NULL,
	[LoaiHD] [nvarchar](50) NULL,
	[Thoigian] [int] NULL,
	[NgayKy] [datetime] NULL,
	[NgayHetHan] [datetime] NULL,
 CONSTRAINT [PK_TTNHANVIENCOBAN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[MaBoPhan] ASC,
	[MaPhong] ASC,
	[MaLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[USER]    Script Date: 4/22/2022 9:22:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER](
	[Username] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](20) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Quyen] [nchar](10) NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[Username] ASC,
	[Pass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[BANGLUONGCTY] ([MaLuong], [LCB], [PCChucVu], [NgayNhap], [LCBMoi], [NgaySua], [LyDo], [PCChucVuMoi], [NgaySuaPC], [GhiChu]) VALUES (N'M123      ', 460000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [NgayThanhLap], [GhiChu]) VALUES (N'HT21      ', N'Quản Lý Kinh Doanh', CAST(N'2017-06-02' AS Date), N'')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [NgayThanhLap], [GhiChu]) VALUES (N'HT22      ', N'Tiếp Nhận Hồ Sơ', CAST(N'2017-04-02' AS Date), N'')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [NgayThanhLap], [GhiChu]) VALUES (N'HT23      ', N'Sale Bán Hàng', CAST(N'2017-05-02' AS Date), N'')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [NgayThanhLap], [GhiChu]) VALUES (N'HT24      ', N'Quảng Cáo Sản Phẩm', CAST(N'2017-04-02' AS Date), N'')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [NgayThanhLap], [GhiChu]) VALUES (N'HT25      ', N'Thu Ngân ', CAST(N'2017-04-02' AS Date), N'')
INSERT [dbo].[BOPHAN] ([MaBoPhan], [TenBoPhan], [NgayThanhLap], [GhiChu]) VALUES (N'HT26      ', N'Thiết Kế Sản Phẩm', CAST(N'2017-04-02' AS Date), N'')
INSERT [dbo].[HOSOTHUVIEC] ([MaNVTV], [HoTen], [MaPhong], [NgaySinh], [GioiTinh], [DiaChi], [TDHocVan], [ViTriThuViec], [NgayTV], [ThangTV], [GhiChu]) VALUES (N'K01       ', N'Nguyễn Thị Thùy Linh', N'H21       ', CAST(N'2002-01-10' AS Date), N'Nữ    ', N'Hà Nội', N'Đại Học', N'Kinh Doanh', CAST(N'2022-01-05' AS Date), 3, NULL)
INSERT [dbo].[HOSOTHUVIEC] ([MaNVTV], [HoTen], [MaPhong], [NgaySinh], [GioiTinh], [DiaChi], [TDHocVan], [ViTriThuViec], [NgayTV], [ThangTV], [GhiChu]) VALUES (N'K02       ', N'Vũ Thu Hòa', N'H23       ', CAST(N'2000-12-20' AS Date), N'Nữ', N'Nam Định', N'Đại Học', N'Sale', CAST(N'2022-03-01' AS Date), 3, NULL)
INSERT [dbo].[HOSOTHUVIEC] ([MaNVTV], [HoTen], [MaPhong], [NgaySinh], [GioiTinh], [DiaChi], [TDHocVan], [ViTriThuViec], [NgayTV], [ThangTV], [GhiChu]) VALUES (N'K03       ', N'Nguyễn Văn Hải', N'H22       ', CAST(N'2002-12-05' AS Date), N'Nam', N'Hà Nội', N'Đại Học', N'Nhân Sự', CAST(N'2022-05-01' AS Date), 3, NULL)
INSERT [dbo].[PHONGBAN] ([MaBoPhan], [MaPhongBan], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'HT21      ', N'H21       ', N'Kinh Doanh', CAST(N'2017-06-02' AS Date), NULL)
INSERT [dbo].[PHONGBAN] ([MaBoPhan], [MaPhongBan], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'HT22      ', N'H22       ', N'Nhân Sự', CAST(N'2017-04-02' AS Date), NULL)
INSERT [dbo].[PHONGBAN] ([MaBoPhan], [MaPhongBan], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'HT23      ', N'H23       ', N'Sale', CAST(N'2017-05-02' AS Date), NULL)
INSERT [dbo].[PHONGBAN] ([MaBoPhan], [MaPhongBan], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'HT24      ', N'H24       ', N'Maketing', CAST(N'2017-04-02' AS Date), NULL)
INSERT [dbo].[PHONGBAN] ([MaBoPhan], [MaPhongBan], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'HT25      ', N'H25       ', N'Kế Toán', CAST(N'2017-04-02' AS Date), NULL)
INSERT [dbo].[PHONGBAN] ([MaBoPhan], [MaPhongBan], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'HT26      ', N'H26       ', N'Desgin', CAST(N'2017-04-02' AS Date), NULL)
INSERT [dbo].[SOBAOHIEM] ([MaNV], [MaLuong], [MaSoBH], [NgayCap], [NoiCap], [GhiChu]) VALUES (N'M01       ', N'L100      ', N'SV1226532 ', CAST(N'2019-12-02 00:00:00.000' AS DateTime), N'Hà Nội', NULL)
INSERT [dbo].[SOBAOHIEM] ([MaNV], [MaLuong], [MaSoBH], [NgayCap], [NoiCap], [GhiChu]) VALUES (N'M02       ', N'L101      ', N'MV5844123 ', CAST(N'2020-02-20 00:00:00.000' AS DateTime), N'Hà Nội', NULL)
INSERT [dbo].[SOBAOHIEM] ([MaNV], [MaLuong], [MaSoBH], [NgayCap], [NoiCap], [GhiChu]) VALUES (N'M03       ', N'L102      ', N'HV5548411 ', CAST(N'2019-12-03 00:00:00.000' AS DateTime), N'Hà Nội', NULL)
INSERT [dbo].[SOBAOHIEM] ([MaNV], [MaLuong], [MaSoBH], [NgayCap], [NoiCap], [GhiChu]) VALUES (N'M04       ', N'L103      ', N'KV1162998 ', CAST(N'2020-05-02 00:00:00.000' AS DateTime), N'Hà Nội', NULL)
INSERT [dbo].[SOBAOHIEM] ([MaNV], [MaLuong], [MaSoBH], [NgayCap], [NoiCap], [GhiChu]) VALUES (N'M05       ', N'L104      ', N'HT6959196 ', CAST(N'2020-06-02 00:00:00.000' AS DateTime), N'Hà Nội', NULL)
INSERT [dbo].[SOBAOHIEM] ([MaNV], [MaLuong], [MaSoBH], [NgayCap], [NoiCap], [GhiChu]) VALUES (N'M06       ', N'L105      ', N'HY8983415 ', CAST(N'2018-08-04 00:00:00.000' AS DateTime), N'Hà Nội', NULL)
INSERT [dbo].[TTCANHAN] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao]) VALUES (N'M01       ', N'Nguyễn Hữu Đô', N'Nghệ An', N'Nghệ An', N'Hà Nội', N'Nghệ An', N'0366666666', N'Kinh', N'Không')
INSERT [dbo].[TTCANHAN] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao]) VALUES (N'M02       ', N'Vũ Trung Kiên', N'Nam Định', N'Nam Định', N'Hà Nội', N'Nam Định', N'0368686868', N'Kinh ', N'Không')
INSERT [dbo].[TTCANHAN] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao]) VALUES (N'M03       ', N'Thịnh Văn Bảo', N'Thanh Hóa', N'Thanh Hóa', N'Hà Nội', N'Hà Nội', N'0355555555', N'Kinh', N'Không')
INSERT [dbo].[TTCANHAN] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao]) VALUES (N'M04       ', N'Đặng Thế Dương', N'Ninh Bình', N'Ninh Bình', N'Hà Nội', N'Ninh Bình', N'0688888888', N'Kinh', N'Không')
INSERT [dbo].[TTCANHAN] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao]) VALUES (N'M05       ', N'Nguyễn Thị Thơm', N'Hà Nội', N'Hà Nội', N'Hà Nội', N'Hà Nội', N'0399999999', N'Kinh', N'Không')
INSERT [dbo].[TTCANHAN] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao]) VALUES (N'M06       ', N'Phạm Thị Hoa', N'Hòa Bình', N'Hòa Bình', N'Hà Nội', N'Hà Nội', N'0326556547', N'Tày', N'Không')
INSERT [dbo].[TTNHANVIENCOBAN] ([MaNV], [HoTen], [MaBoPhan], [MaPhong], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CCCD], [NoiCap], [ChucVu], [LoaiHD], [Thoigian], [NgayKy], [NgayHetHan]) VALUES (N'M01       ', N'Nguyễn Hữu Đô', N'HT21      ', N'H21       ', N'M123      ', CAST(N'2002-12-24' AS Date), N'Nam       ', N'Kết Hôn', N'036581254321', N'Hà Nội', N'Trường Phòng', N'Chính Thức', 10, CAST(N'2022-01-01 00:00:00.000' AS DateTime), CAST(N'2032-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[TTNHANVIENCOBAN] ([MaNV], [HoTen], [MaBoPhan], [MaPhong], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CCCD], [NoiCap], [ChucVu], [LoaiHD], [Thoigian], [NgayKy], [NgayHetHan]) VALUES (N'M02       ', N'Vũ Trung Kiên', N'HT22      ', N'H22       ', N'M234      ', CAST(N'2002-02-10' AS Date), N'Nam       ', N'Độc Thân', N'036200224848', N'Nam Định', N'Nhân Viên', N'Chính Thức', 8, CAST(N'2021-01-01 00:00:00.000' AS DateTime), CAST(N'2029-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[TTNHANVIENCOBAN] ([MaNV], [HoTen], [MaBoPhan], [MaPhong], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CCCD], [NoiCap], [ChucVu], [LoaiHD], [Thoigian], [NgayKy], [NgayHetHan]) VALUES (N'M03       ', N'Thịnh Văn Bảo', N'HT23      ', N'H23       ', N'M345      ', CAST(N'2002-11-02' AS Date), N'Nam       ', N'Độc Thân', N'032551154854', N'Thanh Hóa', N'Nhân Viên', N'Chính Thức', 6, CAST(N'2021-02-01 00:00:00.000' AS DateTime), CAST(N'2027-02-01 00:00:00.000' AS DateTime))
INSERT [dbo].[TTNHANVIENCOBAN] ([MaNV], [HoTen], [MaBoPhan], [MaPhong], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CCCD], [NoiCap], [ChucVu], [LoaiHD], [Thoigian], [NgayKy], [NgayHetHan]) VALUES (N'M04       ', N'Đặng Thế Dương', N'HT24      ', N'H24       ', N'M456      ', CAST(N'2002-12-02' AS Date), N'Nam       ', N'Độc Thân', N'032546526254', N'Ninh Bình', N'Nhân Viên', N'Chính Thức', 5, CAST(N'2022-03-01 00:00:00.000' AS DateTime), CAST(N'2027-03-01 00:00:00.000' AS DateTime))
INSERT [dbo].[TTNHANVIENCOBAN] ([MaNV], [HoTen], [MaBoPhan], [MaPhong], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CCCD], [NoiCap], [ChucVu], [LoaiHD], [Thoigian], [NgayKy], [NgayHetHan]) VALUES (N'M05       ', N'Nguyễn Thị Thơm', N'HT25      ', N'H25       ', N'M567      ', CAST(N'2002-03-02' AS Date), N'Nữ    ', N'Độc Thân', N'032265262554', N'Hà Nội', N'Nhân Viên', N'Chính Thức', 8, CAST(N'2021-01-01 00:00:00.000' AS DateTime), CAST(N'2029-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[TTNHANVIENCOBAN] ([MaNV], [HoTen], [MaBoPhan], [MaPhong], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CCCD], [NoiCap], [ChucVu], [LoaiHD], [Thoigian], [NgayKy], [NgayHetHan]) VALUES (N'M06       ', N'Phạm Thị Hoa', N'HT26      ', N'H26       ', N'M678      ', CAST(N'2000-12-20' AS Date), N'Nữ', N'Kết Hôn', N'032655432654', N'Hà Nội', N'Phó Phòng', N'Chính Thức', 10, CAST(N'2018-01-01 00:00:00.000' AS DateTime), CAST(N'2028-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[USER] ([Username], [Pass], [Ten], [Quyen]) VALUES (N'admin', N'12345', N'Nguyễn Hữu Đô', N'admin     ')
INSERT [dbo].[USER] ([Username], [Pass], [Ten], [Quyen]) VALUES (N'name', N'12345', N'Thịnh Văn Bảo', N'admin     ')
INSERT [dbo].[USER] ([Username], [Pass], [Ten], [Quyen]) VALUES (N'user', N'12345', N'Vũ Trung Kiên', N'admin     ')
USE [master]
GO
ALTER DATABASE [QLNS] SET  READ_WRITE 
GO
