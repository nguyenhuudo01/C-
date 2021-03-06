USE [master]
GO
/****** Object:  Database [BaoCaoNhom2]    Script Date: 14/04/2022 11:37:31 am ******/
CREATE DATABASE [BaoCaoNhom2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BaoCaoNhom2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BaoCaoNhom2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BaoCaoNhom2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BaoCaoNhom2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BaoCaoNhom2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BaoCaoNhom2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BaoCaoNhom2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET ARITHABORT OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BaoCaoNhom2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BaoCaoNhom2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BaoCaoNhom2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BaoCaoNhom2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET RECOVERY FULL 
GO
ALTER DATABASE [BaoCaoNhom2] SET  MULTI_USER 
GO
ALTER DATABASE [BaoCaoNhom2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BaoCaoNhom2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BaoCaoNhom2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BaoCaoNhom2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BaoCaoNhom2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BaoCaoNhom2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BaoCaoNhom2', N'ON'
GO
ALTER DATABASE [BaoCaoNhom2] SET QUERY_STORE = OFF
GO
USE [BaoCaoNhom2]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 14/04/2022 11:37:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[Taikhoan] [nvarchar](50) NOT NULL,
	[Matkhau] [nvarchar](50) NULL,
	[FullName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[phanquyen] [int] NULL,
	[trangthai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 14/04/2022 11:37:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[maDV] [nvarchar](15) NOT NULL,
	[tenDV] [nvarchar](15) NULL,
	[moTa] [nvarchar](1000) NULL,
	[phiDV] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[maDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoadon]    Script Date: 14/04/2022 11:37:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadon](
	[id_hoadon] [nvarchar](15) NOT NULL,
	[MaPhong] [nvarchar](15) NULL,
	[Manv] [nvarchar](15) NULL,
	[TenNV] [nvarchar](255) NULL,
	[Makh] [nvarchar](15) NULL,
	[TenKH] [nvarchar](255) NULL,
	[Ngaysinh] [date] NULL,
	[Ngaydatphong] [date] NULL,
	[Datcoc] [float] NULL,
	[Ngaynhanphong] [date] NULL,
	[Ngaytraphong] [date] NULL,
	[soluongnguoi] [int] NULL,
	[phiphong] [real] NULL,
	[phiphuthu] [real] NULL,
	[thanhtien] [real] NULL,
	[trangthai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonDV]    Script Date: 14/04/2022 11:37:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonDV](
	[maHDDV] [nvarchar](15) NOT NULL,
	[maDV] [nvarchar](15) NULL,
	[maKH] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[maHDDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khachhang]    Script Date: 14/04/2022 11:37:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khachhang](
	[MaKh] [nvarchar](15) NOT NULL,
	[Tenkh] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[gioitinh] [nvarchar](10) NULL,
	[sdt] [nvarchar](15) NULL,
	[Cmnd] [nvarchar](30) NULL,
	[Email] [nvarchar](500) NULL,
	[Diachi] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khohang]    Script Date: 14/04/2022 11:37:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khohang](
	[Maitem] [nvarchar](15) NOT NULL,
	[TenItem] [nvarchar](500) NULL,
	[gianhap] [real] NULL,
	[soluong] [int] NULL,
	[giaban] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[Maitem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LPhong]    Script Date: 14/04/2022 11:37:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LPhong](
	[loaiphong] [nvarchar](50) NOT NULL,
	[mota] [nvarchar](500) NULL,
	[giaphong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[loaiphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mahoa]    Script Date: 14/04/2022 11:37:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mahoa](
	[Taikhoan] [nvarchar](50) NOT NULL,
	[Matkhau] [nvarchar](50) NULL,
	[Mahoa] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 14/04/2022 11:37:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[Manv] [nvarchar](15) NOT NULL,
	[Tennv] [nvarchar](255) NULL,
	[Ngaysinh] [date] NULL,
	[gioitinh] [nvarchar](10) NULL,
	[sdt] [nvarchar](15) NULL,
	[Cmnd] [nvarchar](30) NULL,
	[Email] [nvarchar](500) NULL,
	[Diachi] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhapKho]    Script Date: 14/04/2022 11:37:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapKho](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tenSPNhap] [nvarchar](50) NULL,
	[soLuongNhap] [int] NULL,
	[ngayNhap] [date] NULL,
	[thanhTienNhap] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 14/04/2022 11:37:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [nvarchar](15) NOT NULL,
	[TenPhong] [nvarchar](255) NULL,
	[loaiphong] [nvarchar](50) NULL,
	[Mota] [nvarchar](1000) NULL,
	[songtoida] [int] NULL,
	[trangthai] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phuthu]    Script Date: 14/04/2022 11:37:31 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phuthu](
	[MaPhu] [nvarchar](15) NOT NULL,
	[MaKh] [nvarchar](15) NULL,
	[Maitem] [nvarchar](15) NULL,
	[tensp] [nvarchar](500) NULL,
	[soLuongPhuThu] [int] NULL,
	[gia] [real] NULL,
	[trangthai] [int] NULL,
	[thanhtien] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'admin', N'123456', N'Hà Huy Quang', N'quang@gmail.com', 1, 1)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'nguoidung', N'123456', N'Ngô Khai Anh', N'anhkh@gmail.com', 3, 1)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'nguoidung2', N'123456', N'Nguyễn Thị Nga', N'ngakh@gmail.com', 3, 0)
INSERT [dbo].[DangNhap] ([Taikhoan], [Matkhau], [FullName], [Email], [phanquyen], [trangthai]) VALUES (N'quanly', N'123456', N'Nguyễn Mạnh Hùng', N'hung@gmail.com', 2, 1)
GO
INSERT [dbo].[DichVu] ([maDV], [tenDV], [moTa], [phiDV]) VALUES (N'dv01', N'Nhà hàng', N'Bạn có thể ăn uống thỏa thích với gói buffet sáng hoặc tối với những món ăn đặc sản ở địa phương hay không gian ấm cúng, sang trọng đậm chất Châu Âu', 1500000)
INSERT [dbo].[DichVu] ([maDV], [tenDV], [moTa], [phiDV]) VALUES (N'dv02', N'Quầy bar', N'Khách sạn phục vụ đồ ăn thì quầy bar chịu trách nhiệm cung cấp đồ uống, từ rượu vang, cocktail, rượu mạnh cho đến smoothies, nước ngọt lon hay bất kỳ thứ gì có cung cấp khác.', 500000)
INSERT [dbo].[DichVu] ([maDV], [tenDV], [moTa], [phiDV]) VALUES (N'dv03', N'Xe dạo', N'Đó có thể là xe đạp, xe máy, thậm chí xe du lịch tự lái để đi dạo...', 0)
INSERT [dbo].[DichVu] ([maDV], [tenDV], [moTa], [phiDV]) VALUES (N'dv04', N'Sân goft', N'Nơi thỏa mãn đam mê đánh goft của các khách thuê có điều kiện tài chính và nhu cầu giải trí cao', 4500000)
INSERT [dbo].[DichVu] ([maDV], [tenDV], [moTa], [phiDV]) VALUES (N'dv05', N'Bể bơi', N'Bể được thiết kế riêng đầy sang trọng, quý phái', 100000)
GO
INSERT [dbo].[HoaDonDV] ([maHDDV], [maDV], [maKH]) VALUES (N'hd01', N'dv01', N'kh01')
INSERT [dbo].[HoaDonDV] ([maHDDV], [maDV], [maKH]) VALUES (N'hd02', N'dv02', N'kh02')
INSERT [dbo].[HoaDonDV] ([maHDDV], [maDV], [maKH]) VALUES (N'hd03', N'dv05', N'kh01')
INSERT [dbo].[HoaDonDV] ([maHDDV], [maDV], [maKH]) VALUES (N'hd04', N'dv04', N'kh04')
INSERT [dbo].[HoaDonDV] ([maHDDV], [maDV], [maKH]) VALUES (N'hd05', N'dv03', N'kh03')
INSERT [dbo].[HoaDonDV] ([maHDDV], [maDV], [maKH]) VALUES (N'hd07', N'dv02', N'kh03')
INSERT [dbo].[HoaDonDV] ([maHDDV], [maDV], [maKH]) VALUES (N'hd08', N'dv04', N'kh03')
GO
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email], [Diachi]) VALUES (N'kh01', N'Đoàn Duy Khanh', CAST(N'1993-02-03' AS Date), N'Nam', N'386123242', N'146582362', N'khach@gmail.com', N'Nam T? Liêm-Hà N?i')
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email], [Diachi]) VALUES (N'kh02', N'Trần Doãn Mạnh', CAST(N'1992-12-05' AS Date), N'Nam', N'386427880', N'146582895', N'manh@gmail.com', N'Thanh Xuân- Hà N?i')
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email], [Diachi]) VALUES (N'kh03', N'Trần Văn Minh', CAST(N'1996-09-11' AS Date), N'Nam', N'366421315', N'146582662', N'Minh@gmail.com', N'Qu?n 1 - HCM')
INSERT [dbo].[Khachhang] ([MaKh], [Tenkh], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email], [Diachi]) VALUES (N'kh04', N'Trần Hoài Nam', CAST(N'1999-01-14' AS Date), N'Nam', N'976445444', N'146582321', N'Namhh@gmail.com', N'Qu?n 9 - HCM')
GO
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it01', N'Cocacola', 6000, 2155, 10000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it02', N'Khăn giương', 10000, 201, 20000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it03', N'Nước cam', 7000, 3000, 11000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it04', N'xe đạp', 50000, 50, 100000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it05', N'Khăn mặt', 10000, 200, 20000)
INSERT [dbo].[Khohang] ([Maitem], [TenItem], [gianhap], [soluong], [giaban]) VALUES (N'it06', N'BimBims', 8000, 510, 10000)
GO
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'Deluxe', N'Phòng trung cấp', 500000)
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'Standard', N'Phòng bình dân', 300000)
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'Superior', N'Phòng thường', 400000)
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'VIP', N'Phòng cao cấp', 600000)
INSERT [dbo].[LPhong] ([loaiphong], [mota], [giaphong]) VALUES (N'VIP2', N'Phòng cao cấp', 600000)
GO
INSERT [dbo].[Mahoa] ([Taikhoan], [Matkhau], [Mahoa]) VALUES (N'admin', N'admin123456', N'a66abb5684c45962d887564f08346e8d')
INSERT [dbo].[Mahoa] ([Taikhoan], [Matkhau], [Mahoa]) VALUES (N'quanly', N'123456', N'e10adc3949ba59abbe56e057f20f883e')
GO
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email], [Diachi]) VALUES (N'nv01', N'Nguyễn Hồng Hạnh ', CAST(N'1996-08-25' AS Date), N'Nam', N'0386143805', N'145715186', N'hanhth.hh@gmail.com', N'Liên Minh-V? B?n-Nam Đ?nh-Vi?t Nam')
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email], [Diachi]) VALUES (N'nv02', N'Trương Quang Linh', CAST(N'1998-12-15' AS Date), N'Nam', N'0366524687', N'145715189', N'linhtr.hh@gmail.com', N'Thanh Oai- Hà N?i')
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email], [Diachi]) VALUES (N'nv03', N'Hoang Van Nam', CAST(N'1999-03-02' AS Date), N'Nam', N'0385145235', N'145715125', N'namhv.hh@gmail.com', N'x? Phú Ngh?a -Chương M?- Hà N?i')
INSERT [dbo].[Nhanvien] ([Manv], [Tennv], [Ngaysinh], [gioitinh], [sdt], [Cmnd], [Email], [Diachi]) VALUES (N'nv04', N'Nguyễn Trọng Phú', CAST(N'2000-06-07' AS Date), N'Nữ', N'0366888521', N'154862123', N'phulemlinh.hh@gmail.com', N'Qu?c Oai - Hà N?i')
GO
SET IDENTITY_INSERT [dbo].[NhapKho] ON 

INSERT [dbo].[NhapKho] ([id], [tenSPNhap], [soLuongNhap], [ngayNhap], [thanhTienNhap]) VALUES (2, N'xe đạp', 9, CAST(N'2021-07-10' AS Date), 427500)
INSERT [dbo].[NhapKho] ([id], [tenSPNhap], [soLuongNhap], [ngayNhap], [thanhTienNhap]) VALUES (3, N'BimBims', 10, CAST(N'2021-07-10' AS Date), 427500)
INSERT [dbo].[NhapKho] ([id], [tenSPNhap], [soLuongNhap], [ngayNhap], [thanhTienNhap]) VALUES (4, N'Cocacola', 156, CAST(N'2021-07-10' AS Date), 879840)
SET IDENTITY_INSERT [dbo].[NhapKho] OFF
GO
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph01', N'6001', N'VIP', N'Phòng đẹp, rộng 5*15m, có cửa sổ, view đẹp nhìn ra biển', 4, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph02', N'4001', N'Standard', N'Phòng đẹp, rộng 4*6m, có cửa sổ, view hồ ', 2, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph03', N'4002', N'Superior ', N'Phòng đẹp, rộng 10*4m, có cửa sổ, view đẹp nhìn ra biển', 4, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph04', N'4003', N'Deluxe', N'Phòng đẹp, rộng 3*8m, có cửa sổ, view đẹp nhìn ra biển', 4, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph05', N'4004', N'Standard', N'Phòng đẹp, rộng 4*6m, có cửa sổ, view đẹp nhìn ra biển', 2, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph06', N'4005', N'VIP2', N'Phòng đẹp, rộng 4*6m, có cửa sổ, view đẹp nhìn ra biển', 2, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph07', N'4006', N'Deluxe', N'Phòng đẹp, rộng 11*4m, có cửa sổ, view đẹp nhìn ra biển', 4, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph08', N'4009', N'Superior', N'Phòng đẹp, rộng 10*4m, có cửa sổ, view đẹp nhìn ra biển', 4, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph09', N'4055', N'VIP2', N'Phòng đẹp, rộng 15*5m, có cửa sổ, view đẹp nhìn ra biển,rộng thoáng mát', 4, N'Trống')
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [loaiphong], [Mota], [songtoida], [trangthai]) VALUES (N'ph10', N'5005', N'Superior', N'Phòng đẹp, rộng 12*4m, có cửa sổ, view đẹp ', 4, N'Trống')
GO
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [soLuongPhuThu], [gia], [trangthai], [thanhtien]) VALUES (N'ph01', N'kh01', N'it01', N'BimBims', 10, 10000, 0, 100000)
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [soLuongPhuThu], [gia], [trangthai], [thanhtien]) VALUES (N'ph02', N'kh01', N'it02', N'Khăn giương', 1, 10000, 0, 100000)
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [soLuongPhuThu], [gia], [trangthai], [thanhtien]) VALUES (N'ph04', N'kh01', N'it05', N'Khăn mặt', 10, 10000, 0, 100000)
INSERT [dbo].[Phuthu] ([MaPhu], [MaKh], [Maitem], [tensp], [soLuongPhuThu], [gia], [trangthai], [thanhtien]) VALUES (N'ph05', N'kh02', N'it04', N'xe đạp', 2, 100000, 0, 200000)
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([Makh])
REFERENCES [dbo].[Khachhang] ([MaKh])
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([Manv])
REFERENCES [dbo].[Nhanvien] ([Manv])
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[HoaDonDV]  WITH CHECK ADD FOREIGN KEY([maDV])
REFERENCES [dbo].[DichVu] ([maDV])
GO
ALTER TABLE [dbo].[HoaDonDV]  WITH CHECK ADD FOREIGN KEY([maKH])
REFERENCES [dbo].[Khachhang] ([MaKh])
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD FOREIGN KEY([loaiphong])
REFERENCES [dbo].[LPhong] ([loaiphong])
GO
ALTER TABLE [dbo].[Phuthu]  WITH CHECK ADD FOREIGN KEY([Maitem])
REFERENCES [dbo].[Khohang] ([Maitem])
GO
ALTER TABLE [dbo].[Phuthu]  WITH CHECK ADD FOREIGN KEY([MaKh])
REFERENCES [dbo].[Khachhang] ([MaKh])
GO
USE [master]
GO
ALTER DATABASE [BaoCaoNhom2] SET  READ_WRITE 
GO
