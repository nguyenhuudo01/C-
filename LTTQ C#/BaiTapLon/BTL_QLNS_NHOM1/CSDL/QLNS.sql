USE [QLNS]
GO
/****** Object:  Table [dbo].[TblBangCongThuViec]    Script Date: 6/13/2022 6:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblBangCongThuViec](
	[TenBoPhan] [nvarchar](10) NULL,
	[TenPhong] [nvarchar](50) NULL,
	[MaNVTV] [char](10) NOT NULL,
	[LuongTViec] [int] NULL,
	[Thang] [char](10) NULL,
	[Nam] [char](10) NULL,
	[SoNgayCong] [int] NULL,
	[SoNgayNghi] [int] NULL,
	[SoGioLamThem] [int] NULL,
	[Luong] [float] NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblBangLuongCTy]    Script Date: 6/13/2022 6:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblBangLuongCTy](
	[MaLuong] [char](10) NOT NULL,
	[LCB] [int] NULL,
	[PCChucVu] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[LCBMoi] [int] NULL,
	[NgaySua] [datetime] NULL,
	[LyDo] [nvarchar](50) NULL,
	[PCCVuMoi] [int] NULL,
	[NgaySuaPC] [datetime] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_TblBangLuongCTy] PRIMARY KEY CLUSTERED 
(
	[MaLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblBoPhan]    Script Date: 6/13/2022 6:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblBoPhan](
	[MaBoPhan] [char](10) NOT NULL,
	[TenBoPhan] [nchar](10) NULL,
	[NgayThanhLap] [datetime] NULL,
	[GhiChu] [nchar](10) NULL,
 CONSTRAINT [PK_TblBoPhan] PRIMARY KEY CLUSTERED 
(
	[MaBoPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblCongKhoiDieuHanh]    Script Date: 6/13/2022 6:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCongKhoiDieuHanh](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[HoTen] [nvarchar](50) NULL,
	[MaLuong] [char](10) NULL,
	[LCB] [int] NULL,
	[PCChucVu] [int] NULL,
	[PCapKhac] [int] NULL,
	[Thuong] [nvarchar](50) NULL,
	[KyLuat] [nvarchar](50) NULL,
	[Thang] [char](10) NULL,
	[Nam] [char](19) NULL,
	[SoNgayCongThang] [int] NULL,
	[SoNgayNghi] [int] NULL,
	[SoGioLamThem] [int] NULL,
	[Luong] [int] NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblHoSoThuViec]    Script Date: 6/13/2022 6:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblHoSoThuViec](
	[MaPhong] [char](10) NOT NULL,
	[MaNVTV] [char](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[TDHocVan] [nvarchar](50) NULL,
	[HocHam] [nvarchar](50) NULL,
	[ViTriThuViec] [nvarchar](50) NULL,
	[NgayTV] [datetime] NULL,
	[ThangTV] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblNVThoiViec]    Script Date: 6/13/2022 6:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblNVThoiViec](
	[HoTen] [nvarchar](50) NULL,
	[CMTND] [nvarchar](50) NOT NULL,
	[NgayThoiViec] [datetime] NULL,
	[LyDo] [nvarchar](50) NULL,
 CONSTRAINT [PK_TblNVThoiViec] PRIMARY KEY CLUSTERED 
(
	[CMTND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblPhongBan]    Script Date: 6/13/2022 6:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPhongBan](
	[MaBoPhan] [char](10) NOT NULL,
	[MaPhong] [char](10) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[NgayThanhLap] [datetime] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_TblPhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSoBH]    Script Date: 6/13/2022 6:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSoBH](
	[MaNV] [nvarchar](50) NOT NULL,
	[MaLuong] [char](10) NOT NULL,
	[MaSoBH] [char](10) NOT NULL,
	[NgayCapSo] [datetime] NULL,
	[NoiCapSo] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblTangLuong]    Script Date: 6/13/2022 6:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTangLuong](
	[MaNV] [nvarchar](50) NULL,
	[HoTen] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[MaLuongCu] [char](10) NULL,
	[MaLuongMoi] [char](10) NULL,
	[NgayTang] [datetime] NULL,
	[LyDo] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblThaiSan]    Script Date: 6/13/2022 6:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblThaiSan](
	[MaBoPhan] [char](10) NOT NULL,
	[MaPhong] [char](10) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[NgayVeSom] [datetime] NULL,
	[NgayNghiSinh] [datetime] NULL,
	[NgayLamTroLai] [datetime] NULL,
	[TroCapCTY] [int] NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblTTCaNhan]    Script Date: 6/13/2022 6:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTTCaNhan](
	[MaNV] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NoiSinh] [nvarchar](50) NULL,
	[NguyenQuan] [nvarchar](50) NULL,
	[DCThuongChu] [nvarchar](100) NULL,
	[DCTamChu] [nvarchar](100) NULL,
	[SDT] [char](12) NULL,
	[DanToc] [nvarchar](30) NULL,
	[TonGiao] [nvarchar](20) NULL,
	[QuocTich] [nvarchar](20) NULL,
	[HocVan] [nvarchar](30) NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblTTNVCoBan]    Script Date: 6/13/2022 6:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTTNVCoBan](
	[MaBoPhan] [char](10) NOT NULL,
	[MaPhong] [char](10) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[MaLuong] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[TTHonNhan] [nvarchar](50) NULL,
	[CMTND] [nvarchar](50) NULL,
	[NoiCap] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[LoaiHD] [nvarchar](50) NULL,
	[ThoiGian] [nvarchar](10) NULL,
	[NgayKy] [date] NULL,
	[NgayHetHan] [date] NULL,
	[GhiChu] [nvarchar](100) NULL,
 CONSTRAINT [PK_TblTTNVCoBan] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbuser]    Script Date: 6/13/2022 6:05:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbuser](
	[Username] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NULL,
	[Quyen] [nchar](10) NULL,
	[Ten] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[TblBangCongThuViec] ([TenBoPhan], [TenPhong], [MaNVTV], [LuongTViec], [Thang], [Nam], [SoNgayCong], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'Kế hoạch  ', N'cntt', N'001       ', 1200000, N'2         ', N'2022      ', 31, 0, 30, 2630743, N'')
INSERT [dbo].[TblBangCongThuViec] ([TenBoPhan], [TenPhong], [MaNVTV], [LuongTViec], [Thang], [Nam], [SoNgayCong], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'Kế hoạch  ', N'Maketing', N'008       ', 1200000, N'2         ', N'2022      ', 31, 0, 30, 2630743, N'')
INSERT [dbo].[TblBangCongThuViec] ([TenBoPhan], [TenPhong], [MaNVTV], [LuongTViec], [Thang], [Nam], [SoNgayCong], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'Kế toán   ', N'Maketing', N'0011      ', 1500000, N'2         ', N'2020      ', 30, 1, 10, 2130760, N'   ')
GO
INSERT [dbo].[TblBangLuongCTy] ([MaLuong], [LCB], [PCChucVu], [NgayNhap], [LCBMoi], [NgaySua], [LyDo], [PCCVuMoi], [NgaySuaPC], [GhiChu]) VALUES (N'001       ', 3000, 100, CAST(N'2022-05-06T00:00:00.000' AS DateTime), 30000, CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'', 20000, CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'')
INSERT [dbo].[TblBangLuongCTy] ([MaLuong], [LCB], [PCChucVu], [NgayNhap], [LCBMoi], [NgaySua], [LyDo], [PCCVuMoi], [NgaySuaPC], [GhiChu]) VALUES (N'ml1       ', 3000000, 300000, CAST(N'2022-05-04T00:00:00.000' AS DateTime), 3000000, CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'ht', 5000000, CAST(N'2019-05-13T00:00:00.000' AS DateTime), N'ht')
INSERT [dbo].[TblBangLuongCTy] ([MaLuong], [LCB], [PCChucVu], [NgayNhap], [LCBMoi], [NgaySua], [LyDo], [PCCVuMoi], [NgaySuaPC], [GhiChu]) VALUES (N'ml2       ', 3000000, 1000000, CAST(N'2022-05-05T00:00:00.000' AS DateTime), 3000000, CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'ht', 5000000, CAST(N'2019-05-13T00:00:00.000' AS DateTime), N'ht')
INSERT [dbo].[TblBangLuongCTy] ([MaLuong], [LCB], [PCChucVu], [NgayNhap], [LCBMoi], [NgaySua], [LyDo], [PCCVuMoi], [NgaySuaPC], [GhiChu]) VALUES (N'ml3       ', 3000000, 500000, CAST(N'2022-05-05T00:00:00.000' AS DateTime), 4000000, CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'ht', 60000000, CAST(N'2019-05-13T00:00:00.000' AS DateTime), N'ht')
GO
INSERT [dbo].[TblBoPhan] ([MaBoPhan], [TenBoPhan], [NgayThanhLap], [GhiChu]) VALUES (N'mb01      ', N'Kế toán   ', CAST(N'2020-12-21T00:00:00.000' AS DateTime), N'OK        ')
INSERT [dbo].[TblBoPhan] ([MaBoPhan], [TenBoPhan], [NgayThanhLap], [GhiChu]) VALUES (N'mb02      ', N'Kỹ thuật  ', CAST(N'2020-11-20T00:00:00.000' AS DateTime), N'OK        ')
INSERT [dbo].[TblBoPhan] ([MaBoPhan], [TenBoPhan], [NgayThanhLap], [GhiChu]) VALUES (N'mb03      ', N'Kế hoạch  ', CAST(N'2022-01-25T00:00:00.000' AS DateTime), N'          ')
GO
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'001', N'cntt', N'Nguyễn Hữu Đô', N'ml1       ', 3000000, 300000, 2000000, N'1000', N'0', N'9         ', N'2020               ', 26, 0, 12, 5780984, N'')
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'002', N'kinh tế', N'Thịnh Văn Bảo', N'ml2       ', 3000000, 1000000, 500000, N'200000', N'0', N'12        ', N'2022               ', 32, 1, 15, 5992288, N'')
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'003', N'Maketing', N'Vũ Trung Kiêmm', N'001       ', 30000, 100, 3243, N'43433', N'222', N'2         ', N'2022               ', 21, 1, 111, 4510767, N'')
INSERT [dbo].[TblCongKhoiDieuHanh] ([MaNV], [TenPhong], [HoTen], [MaLuong], [LCB], [PCChucVu], [PCapKhac], [Thuong], [KyLuat], [Thang], [Nam], [SoNgayCongThang], [SoNgayNghi], [SoGioLamThem], [Luong], [GhiChu]) VALUES (N'005', N'Maketing', N'Mai Sỹ Đạt', N'ml3       ', 4000000, 100, 3243, N'43433', N'222', N'2         ', N'2022               ', 21, 1, 111, 4510767, N'')
GO
INSERT [dbo].[TblHoSoThuViec] ([MaPhong], [MaNVTV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [TDHocVan], [HocHam], [ViTriThuViec], [NgayTV], [ThangTV], [GhiChu]) VALUES (N'kt02      ', N'001       ', N'Nguyễn Hữu Đô', CAST(N'2002-12-12T00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', N'Đại học', N'Đại học', N'Nhân Viên', CAST(N'2022-02-10T00:00:00.000' AS DateTime), N'4', N'Thử việc')
INSERT [dbo].[TblHoSoThuViec] ([MaPhong], [MaNVTV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [TDHocVan], [HocHam], [ViTriThuViec], [NgayTV], [ThangTV], [GhiChu]) VALUES (N'kt01      ', N'0011      ', N'Thịnh Văn Bảo', CAST(N'2002-05-06T00:00:00.000' AS DateTime), N'Nam', N'Thanh Hóa', N'Đại Học', N'Đại học', N'Nhân Viên', CAST(N'2022-03-21T00:00:00.000' AS DateTime), N'6', N'Thử việc')
INSERT [dbo].[TblHoSoThuViec] ([MaPhong], [MaNVTV], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [TDHocVan], [HocHam], [ViTriThuViec], [NgayTV], [ThangTV], [GhiChu]) VALUES (N'kt02      ', N'008       ', N'Nguyễn Thị Thơm', CAST(N'2002-07-02T00:00:00.000' AS DateTime), N'Nữ', N'Hà Nội', N'Cao Đẳng', N'Cao Đẳng', N'Nhân Viên', CAST(N'2019-05-01T00:00:00.000' AS DateTime), N'5/2019', N'gsfbfd')
GO
INSERT [dbo].[TblNVThoiViec] ([HoTen], [CMTND], [NgayThoiViec], [LyDo]) VALUES (N'Lê Văn Đại', N'134892053', NULL, N'Cán bộ')
INSERT [dbo].[TblNVThoiViec] ([HoTen], [CMTND], [NgayThoiViec], [LyDo]) VALUES (N'Nguyễn Văn Dũng', N'14355678', NULL, N'nv')
INSERT [dbo].[TblNVThoiViec] ([HoTen], [CMTND], [NgayThoiViec], [LyDo]) VALUES (N'd', N'34246321', NULL, N'')
GO
INSERT [dbo].[TblPhongBan] ([MaBoPhan], [MaPhong], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'mb02      ', N'ht01      ', N'htt', CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'ab')
INSERT [dbo].[TblPhongBan] ([MaBoPhan], [MaPhong], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'mb03      ', N'kt02      ', N'kinh tế', CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'abc')
INSERT [dbo].[TblPhongBan] ([MaBoPhan], [MaPhong], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'mb03      ', N'kt03      ', N'kinh tế', CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'abc')
INSERT [dbo].[TblPhongBan] ([MaBoPhan], [MaPhong], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'mb03      ', N'mk01      ', N'Maketing', CAST(N'2022-06-10T00:00:00.000' AS DateTime), N'')
INSERT [dbo].[TblPhongBan] ([MaBoPhan], [MaPhong], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'mb02      ', N'qt01      ', N'Quản trị', CAST(N'2022-06-13T00:00:00.000' AS DateTime), N'không')
INSERT [dbo].[TblPhongBan] ([MaBoPhan], [MaPhong], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'mb02      ', N'tt01      ', N'cntt', CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'ab')
INSERT [dbo].[TblPhongBan] ([MaBoPhan], [MaPhong], [TenPhong], [NgayThanhLap], [GhiChu]) VALUES (N'mb02      ', N'tt02      ', N'cntt', CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'ab')
GO
INSERT [dbo].[TblSoBH] ([MaNV], [MaLuong], [MaSoBH], [NgayCapSo], [NoiCapSo], [GhiChu]) VALUES (N'001', N'ml1       ', N'123       ', CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'Hà Nội', N'YT')
INSERT [dbo].[TblSoBH] ([MaNV], [MaLuong], [MaSoBH], [NgayCapSo], [NoiCapSo], [GhiChu]) VALUES (N'001', N'ml2       ', N'123       ', CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'Hà Nội', N'YT')
INSERT [dbo].[TblSoBH] ([MaNV], [MaLuong], [MaSoBH], [NgayCapSo], [NoiCapSo], [GhiChu]) VALUES (N'005', N'ml1       ', N'b124632   ', CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'Bắcqd Giang', N'YT')
INSERT [dbo].[TblSoBH] ([MaNV], [MaLuong], [MaSoBH], [NgayCapSo], [NoiCapSo], [GhiChu]) VALUES (N'003', N'ml2       ', N'123       ', CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'Hà Nội', N'YT')
GO
INSERT [dbo].[TblTangLuong] ([MaNV], [HoTen], [GioiTinh], [ChucVu], [MaLuongCu], [MaLuongMoi], [NgayTang], [LyDo]) VALUES (N'001', N'Nguyễn Hữu Đô', N'Nam', N'GĐ', N'ml1       ', N'ml2       ', CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'')
INSERT [dbo].[TblTangLuong] ([MaNV], [HoTen], [GioiTinh], [ChucVu], [MaLuongCu], [MaLuongMoi], [NgayTang], [LyDo]) VALUES (N'002', N'Thịnh Văn Bảo', N'Nam', N'PGĐ', N'ml1       ', N'ml2       ', CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'')
INSERT [dbo].[TblTangLuong] ([MaNV], [HoTen], [GioiTinh], [ChucVu], [MaLuongCu], [MaLuongMoi], [NgayTang], [LyDo]) VALUES (N'003', N'Vũ Trung Kiên', N'Nam', N'PGĐ', N'ml3       ', N'ml2       ', CAST(N'2022-05-06T00:00:00.000' AS DateTime), N'')
GO
INSERT [dbo].[TblThaiSan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [NgaySinh], [NgayVeSom], [NgayNghiSinh], [NgayLamTroLai], [TroCapCTY], [GhiChu]) VALUES (N'mb02      ', N'002       ', N'002', N'Nguyễn Thị Thơm', CAST(N'2022-05-06T00:00:00.000' AS DateTime), CAST(N'2022-05-06T00:00:00.000' AS DateTime), CAST(N'2022-05-06T00:00:00.000' AS DateTime), CAST(N'2022-05-06T00:00:00.000' AS DateTime), 123456, N'')
GO
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'001', N'Nguyễn Hữu Đô', N'Nghệ An', N'Hà Nội', N'Hà Nội', N'Hà Nội', N'1234567     ', N'Kinh', N'Không', N'Việt Nam', N'Đại Học', N'ac')
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'002', N'Thịnh Văn Bảo', N'Thanh Hóa', N'Thanh Hóa', N'Hà Nội', N'Hà Nội ', N'1111111     ', N'Kinh', N'Không', N'Việt Nam', N'Đại Học', N'a')
INSERT [dbo].[TblTTCaNhan] ([MaNV], [HoTen], [NoiSinh], [NguyenQuan], [DCThuongChu], [DCTamChu], [SDT], [DanToc], [TonGiao], [QuocTich], [HocVan], [GhiChu]) VALUES (N'003', N'Vũ Trung Kiên', N'Nam Định', N'Nam ĐỊnh', N'Hà Nội', N'Hà Nội', N'2222222     ', N'Kinh', N'Không', N'Việt Nam', N'Đại Học', N's')
GO
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb01      ', N'tt02      ', N'001', N'Nguyễn Hữu Đô', N'ml2', CAST(N'2022-05-06' AS Date), N'Nam', N'Không', N'12345678', N'Hà Nội', N'GĐ', N'1', N'12 tháng', CAST(N'2022-05-06' AS Date), CAST(N'2023-05-06' AS Date), N'')
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb02      ', N'ht01      ', N'002', N'Thịnh Văn Bảo', N'ml2', CAST(N'2022-05-06' AS Date), N'Nam', N'Không', N'1111111111', N'Thanh Hóa', N'PGĐ', N'1', N'12 tháng', CAST(N'2022-05-06' AS Date), CAST(N'2023-05-06' AS Date), N'')
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb03      ', N'kt02      ', N'003', N'Vũ Trung Kiêmm', N'ml2', CAST(N'2022-05-06' AS Date), N'Nam', N'Không', N'1111111111', N'Thanh Hóa', N'PGĐ', N'1', N'12 tháng', CAST(N'2022-05-06' AS Date), CAST(N'2023-05-06' AS Date), N'')
INSERT [dbo].[TblTTNVCoBan] ([MaBoPhan], [MaPhong], [MaNV], [HoTen], [MaLuong], [NgaySinh], [GioiTinh], [TTHonNhan], [CMTND], [NoiCap], [ChucVu], [LoaiHD], [ThoiGian], [NgayKy], [NgayHetHan], [GhiChu]) VALUES (N'mb01      ', N'tt02      ', N'005', N'Mai Sỹ Đạt', N'ml3', CAST(N'2022-05-06' AS Date), N'Nam', N'Không', N'04243243432', N'Thanh Hóa', N'PGD', N'1', N'12 tháng', CAST(N'2022-05-06' AS Date), CAST(N'2023-05-06' AS Date), NULL)
GO
INSERT [dbo].[tbuser] ([Username], [Pass], [Quyen], [Ten], [Ngaysinh]) VALUES (N'admin', N'admin', N'Admin     ', N'Nguyễn Hữu Đô', CAST(N'2002-12-12' AS Date))
GO
ALTER TABLE [dbo].[TblCongKhoiDieuHanh]  WITH CHECK ADD  CONSTRAINT [FK_TblCongKhoiDieuHanh_TblBangLuongCTy] FOREIGN KEY([MaLuong])
REFERENCES [dbo].[TblBangLuongCTy] ([MaLuong])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblCongKhoiDieuHanh] CHECK CONSTRAINT [FK_TblCongKhoiDieuHanh_TblBangLuongCTy]
GO
ALTER TABLE [dbo].[TblCongKhoiDieuHanh]  WITH CHECK ADD  CONSTRAINT [FK_TblCongKhoiDieuHanh_TblTTNVCoBan] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TblTTNVCoBan] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblCongKhoiDieuHanh] CHECK CONSTRAINT [FK_TblCongKhoiDieuHanh_TblTTNVCoBan]
GO
ALTER TABLE [dbo].[TblPhongBan]  WITH CHECK ADD  CONSTRAINT [FK_TblPhongBan_TblBoPhan] FOREIGN KEY([MaBoPhan])
REFERENCES [dbo].[TblBoPhan] ([MaBoPhan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblPhongBan] CHECK CONSTRAINT [FK_TblPhongBan_TblBoPhan]
GO
ALTER TABLE [dbo].[TblSoBH]  WITH CHECK ADD  CONSTRAINT [FK_TblSoBH_TblBangLuongCTy] FOREIGN KEY([MaLuong])
REFERENCES [dbo].[TblBangLuongCTy] ([MaLuong])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblSoBH] CHECK CONSTRAINT [FK_TblSoBH_TblBangLuongCTy]
GO
ALTER TABLE [dbo].[TblTangLuong]  WITH NOCHECK ADD  CONSTRAINT [FK_TblTangLuong_TblTTNVCoBan] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TblTTNVCoBan] ([MaNV])
GO
ALTER TABLE [dbo].[TblTangLuong] CHECK CONSTRAINT [FK_TblTangLuong_TblTTNVCoBan]
GO
ALTER TABLE [dbo].[TblTangLuong]  WITH CHECK ADD  CONSTRAINT [tk_tl] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TblTTNVCoBan] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblTangLuong] CHECK CONSTRAINT [tk_tl]
GO
ALTER TABLE [dbo].[TblThaiSan]  WITH NOCHECK ADD  CONSTRAINT [FK_TblThaiSan_TblTTNVCoBan] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TblTTNVCoBan] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblThaiSan] CHECK CONSTRAINT [FK_TblThaiSan_TblTTNVCoBan]
GO
ALTER TABLE [dbo].[TblTTCaNhan]  WITH CHECK ADD  CONSTRAINT [tk_cn] FOREIGN KEY([MaNV])
REFERENCES [dbo].[TblTTNVCoBan] ([MaNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblTTCaNhan] CHECK CONSTRAINT [tk_cn]
GO
ALTER TABLE [dbo].[TblTTNVCoBan]  WITH CHECK ADD  CONSTRAINT [FK_TblTTNVCoBan_TblPhongBan] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[TblPhongBan] ([MaPhong])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblTTNVCoBan] CHECK CONSTRAINT [FK_TblTTNVCoBan_TblPhongBan]
GO
