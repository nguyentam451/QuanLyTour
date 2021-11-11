USE master
DROP DATABASE QuanLyTour

-- =====================================================================================================================
-- =====================================================================================================================

CREATE DATABASE QuanLyTour
USE QuanLyTour

-- =====================================================================================================================
-- =====================================================================================================================

CREATE TABLE KHACH
(
	MaKhachHang		CHAR(10)	NOT NULL PRIMARY KEY,
	HoTen			NVARCHAR(20),
	SoCMND			CHAR(10),
	DiaChi			NVARCHAR(50),
	GioiTinh		NCHAR(3)	CHECK (GIOITINH IN (N'Nam',N'Nữ')),
	SDT				CHAR(10),
	QuocTich		NVARCHAR(20),

)

CREATE TABLE NHANVIEN
(
	MaNhanVien		CHAR(10)	NOT NULL PRIMARY KEY,
	TenNhanVien		NVARCHAR(20),
)

CREATE TABLE LOAIHINHDULICH
(
	MaLoaiHinh	CHAR(10) NOT NULL PRIMARY KEY,
	TenLoaiHinh	NVARCHAR(20),
)

CREATE TABLE TOURDULICH
(
	MaTour			CHAR(10) NOT NULL PRIMARY KEY,
	TenGoi			NVARCHAR(20),
	DacDiem			NVARCHAR(50),
	MaLoaiHinh		CHAR(10),

)

CREATE TABLE LOAICHIPHI
(
	MaLoaiChiPhi	CHAR(10) NOT NULL PRIMARY KEY,
	TenLoaiChiPhi	NVARCHAR(20),
)

CREATE TABLE CHIPHI
(
	MaChiPhi		CHAR(10) NOT NULL PRIMARY KEY,
	MaDoan			CHAR(10),
	SoTien			INT,
	MaLoaiChiPhi	CHAR(10),
)

CREATE TABLE DIADIEM
(
	MaDiaDiem	CHAR(10) NOT NULL PRIMARY KEY,
	TenDiaDiem	NVARCHAR(20),
)

CREATE TABLE THAMQUAN
(
	MaTour		CHAR(10), 
	MaDiaDiem	CHAR(10),
	ThuTu		INT,
	CONSTRAINT PK_THAMQUAN
	PRIMARY KEY (MaTour,MaDiaDiem,ThuTu),
)

CREATE TABLE GIATOUR
(
	MaGia			CHAR(10) NOT NULL PRIMARY KEY,
	MaTour			CHAR(10),
	ThanhTien		INT,
	ThoiGianBatDau	DATETIME,
	ThoiGianKetThuc DATETIME,
)

CREATE TABLE DOANDULICH
(
	MaDoan			CHAR(10) NOT NULL PRIMARY KEY,
	MaTour			CHAR(10),
	NgayKhoiHanh	DATETIME,
	NgayKetThuc		DATETIME,

)

CREATE TABLE NOIDUNGTOUR
(
	MaDoan				CHAR(10) NOT NULL PRIMARY KEY,
	HanhTrinh			NVARCHAR(20),
	KhachSan			NVARCHAR(20),
	DiaDiemThamQuan		NVARCHAR(50),
)

CREATE TABLE CHITIETDOAN
(
	MaDoan		CHAR(10),
	MaKhachHang	CHAR(10),

	CONSTRAINT PK_CHITIETDOAN
	PRIMARY KEY (MaDoan,MaKhachHang),
)

CREATE TABLE PHANBONHANVIEN_DOAN
(
	MaNhanVien	CHAR(10),
	MaDoan		CHAR(10),
	NhiemVu		NVARCHAR(50),

	CONSTRAINT PK_PHANBONHANVIEN_DOAN
	PRIMARY KEY (MaNhanVien,MaDoan),
)

-- =====================================================================================================================
-- =====================================================================================================================

ALTER TABLE TOURDULICH
ADD CONSTRAINT FK_TOURDULICH_LOAIHINHDULICH
FOREIGN KEY (MaLoaiHinh)
REFERENCES	LoaiHinhDuLich(MaLoaiHinh)

ALTER TABLE THAMQUAN
ADD CONSTRAINT FK_THAMQUAN_TOURDULICH
FOREIGN KEY (MaTour)
REFERENCES	TOURDULICH(MaTour)

ALTER TABLE THAMQUAN
ADD CONSTRAINT FK_THAMQUAN_DIADIEM
FOREIGN KEY (MaDiaDiem)
REFERENCES	DIADIEM(MaDiaDiem)

ALTER TABLE GIATOUR
ADD CONSTRAINT FK_GIATOUR_TOURDULICH
FOREIGN KEY (MaTour)
REFERENCES	TourDuLich(MaTour)

ALTER TABLE CHIPHI
ADD CONSTRAINT FK_CHIPHI_DOANDULICH
FOREIGN KEY (MaDoan)
REFERENCES	DOANDULICH(MaDoan)

ALTER TABLE CHIPHI
ADD CONSTRAINT FK_CHIPHI_LOAICHIPHI
FOREIGN KEY (MaLoaiChiPhi)
REFERENCES	LOAICHIPHI(MaLoaiChiPhi)

ALTER TABLE DOANDULICH
ADD CONSTRAINT FK_DOANDULICH_TUORDULICH
FOREIGN KEY (MaTour)
REFERENCES	TourDuLich(MaTour)

ALTER TABLE NOIDUNGTOUR
ADD CONSTRAINT FK_NOIDUNGTOUR_DOANDULICH
FOREIGN KEY (MaDoan)
REFERENCES	DoanDuLich(MaDoan)

ALTER TABLE CHITIETDOAN
ADD CONSTRAINT FK_CHITIETDOAN_DOANDULICH
FOREIGN KEY (MaDoan)
REFERENCES	DOANDULICH(MaDoan)

ALTER TABLE CHITIETDOAN
ADD CONSTRAINT FK_CHITIETDOAN_KHACH
FOREIGN KEY (MaKhachHang)
REFERENCES	KHACH(MaKhachHang)

ALTER TABLE PHANBONHANVIEN_DOAN
ADD CONSTRAINT FK_PHANBONHANVIEN_DOAN_NHANVIEN
FOREIGN KEY (MaNhanVien)
REFERENCES	NHANVIEN(MaNhanVien)

ALTER TABLE PHANBONHANVIEN_DOAN
ADD CONSTRAINT FK_PHANBONHANVIEN_DOAN_DOANDULICH
FOREIGN KEY (MaDoan)
REFERENCES	DOANDULICH(MaDoan)

-- =====================================================================================================================
-- =====================================================================================================================

INSERT [dbo].[KHACH] ([MaKhachHang], [HoTen], [SoCMND], [DiaChi], [GioiTinh], [SDT], [QuocTich]) VALUES (N'MKH1', N'Pham Trang Ngoc', N'23417984', N'TP HCM', N'Nữ', N'0973657377', N'Viet Nam')
INSERT [dbo].[KHACH] ([MaKhachHang], [HoTen], [SoCMND], [DiaChi], [GioiTinh], [SDT], [QuocTich]) VALUES (N'MKH2', N'Nguyen Thi An', N'239584938', N'Ha Noi', N'Nữ', N'0902477321', N'Viet Nam ')
INSERT [dbo].[KHACH] ([MaKhachHang], [HoTen], [SoCMND], [DiaChi], [GioiTinh], [SDT], [QuocTich]) VALUES (N'MKH3', N'Tran Van B', N'285740199', N'Ha Noi', N'Nam', N'0934758294', N'Viet Nam')
INSERT [dbo].[KHACH] ([MaKhachHang], [HoTen], [SoCMND], [DiaChi], [GioiTinh], [SDT], [QuocTich]) VALUES (N'MKH4', N'Pham Thi C', N'285739135', N'TP HCM', N'Nữ', N'0738227184', N'Viet Nam')
INSERT [dbo].[KHACH] ([MaKhachHang], [HoTen], [SoCMND], [DiaChi], [GioiTinh], [SDT], [QuocTich]) VALUES (N'MKH5', N'Hoang Van D', N'234145665', N'TP HCM ', N'Nam', N'0472845738', NULL)

INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien]) VALUES (N'MNV1', N'Nguyen Van A')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien]) VALUES (N'MNV2', N'Nguyen Van B')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien]) VALUES (N'MNV3', N'Tran Thi B')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien]) VALUES (N'MNV4', N'Pham Van C')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien]) VALUES (N'MNV5', NULL)

INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem]) VALUES (N'MDD1', N'Phu Quoc')
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem]) VALUES (N'MDD2', N'Vung Tau')
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem]) VALUES (N'MDD3', N'Da Lat')
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem]) VALUES (N'MDD4', N'Ben Tre')
INSERT [dbo].[DIADIEM] ([MaDiaDiem], [TenDiaDiem]) VALUES (N'MADD5', NULL)

INSERT [dbo].[LOAICHIPHI] ([MaLoaiChiPhi], [TenLoaiChiPhi]) VALUES (N'MCP1', N'An uong')
INSERT [dbo].[LOAICHIPHI] ([MaLoaiChiPhi], [TenLoaiChiPhi]) VALUES (N'MCP2', N'An uong')
INSERT [dbo].[LOAICHIPHI] ([MaLoaiChiPhi], [TenLoaiChiPhi]) VALUES (N'MCP3', N'Ve Sinh')
INSERT [dbo].[LOAICHIPHI] ([MaLoaiChiPhi], [TenLoaiChiPhi]) VALUES (N'MCP4', N'An uong')
INSERT [dbo].[LOAICHIPHI] ([MaLoaiChiPhi], [TenLoaiChiPhi]) VALUES (N'MCP5', NULL)

INSERT [dbo].[LOAIHINHDULICH] ([MaLoaiHinh], [TenLoaiHinh]) VALUES (N'MLH1', N'Du lich van hoa')
INSERT [dbo].[LOAIHINHDULICH] ([MaLoaiHinh], [TenLoaiHinh]) VALUES (N'MLH2', N'Du lich giai tri')
INSERT [dbo].[LOAIHINHDULICH] ([MaLoaiHinh], [TenLoaiHinh]) VALUES (N'MLH3', N'Du lich the thao')
INSERT [dbo].[LOAIHINHDULICH] ([MaLoaiHinh], [TenLoaiHinh]) VALUES (N'MLH4', N'Du lich giai tri')
INSERT [dbo].[LOAIHINHDULICH] ([MaLoaiHinh], [TenLoaiHinh]) VALUES (N'MLH5', NULL)

INSERT [dbo].[TOURDULICH] ([MaTour], [TenGoi], [DacDiem], [MaLoaiHinh]) VALUES (N'MT1', N'TG1', N'DD1', N'MLH1')
INSERT [dbo].[TOURDULICH] ([MaTour], [TenGoi], [DacDiem], [MaLoaiHinh]) VALUES (N'MT2', N'TG2', N'DD2', N'MLH2')
INSERT [dbo].[TOURDULICH] ([MaTour], [TenGoi], [DacDiem], [MaLoaiHinh]) VALUES (N'MT3', N'TG3', N'DD3', N'MLH2')
INSERT [dbo].[TOURDULICH] ([MaTour], [TenGoi], [DacDiem], [MaLoaiHinh]) VALUES (N'MT4', N'TG4', N'DD4', N'MLH3')
INSERT [dbo].[TOURDULICH] ([MaTour], [TenGoi], [DacDiem], [MaLoaiHinh]) VALUES (N'MT5', N'TG5', N'DD5', NULL)

INSERT [dbo].[THAMQUAN] ([MaTour], [MaDiaDiem], [ThuTu]) VALUES (N'MT1', N'MDD1', N'1')
INSERT [dbo].[THAMQUAN] ([MaTour], [MaDiaDiem], [ThuTu]) VALUES (N'MT2', N'MDD1', N'2')
INSERT [dbo].[THAMQUAN] ([MaTour], [MaDiaDiem], [ThuTu]) VALUES (N'MT3', N'MDD2', N'3')
INSERT [dbo].[THAMQUAN] ([MaTour], [MaDiaDiem], [ThuTu]) VALUES (N'MT4', N'MDD3', N'4')
INSERT [dbo].[THAMQUAN] ([MaTour], [MaDiaDiem], [ThuTu]) VALUES (N'MT5', N'MDD4', N'5')

INSERT [dbo].[DOANDULICH] ([MaDoan], [MaTour], [NgayKhoiHanh], [NgayKetThuc]) VALUES (N'MD1', N'MT1', N'12/22/2020', N'12/25/2020')
INSERT [dbo].[DOANDULICH] ([MaDoan], [MaTour], [NgayKhoiHanh], [NgayKetThuc]) VALUES (N'MD2', N'MT4', N'4/11/2020', N'7/11/2020')
-- Resmater
INSERT [dbo].[DOANDULICH] ([MaDoan], [MaTour], [NgayKhoiHanh], [NgayKetThuc]) VALUES (N'MD3', N'MT5', N'3/16/2021', N'3/21/2021')
INSERT [dbo].[DOANDULICH] ([MaDoan], [MaTour], [NgayKhoiHanh], [NgayKetThuc]) VALUES (N'MD4', N'MT3', N'3/9/2021', N'3/16/2021')
INSERT [dbo].[DOANDULICH] ([MaDoan], [MaTour], [NgayKhoiHanh], [NgayKetThuc]) VALUES (N'MD5', N'MT3', N'7/10/2021', N'7/15/2021')

INSERT [dbo].[NOIDUNGTOUR] ([MaDoan], [HanhTrinh], [KhachSan], [DiaDiemThamQuan]) VALUES (N'MD1', N'HT1', N'KS1', N'TP HCM')
INSERT [dbo].[NOIDUNGTOUR] ([MaDoan], [HanhTrinh], [KhachSan], [DiaDiemThamQuan]) VALUES (N'MD2', N'HT2', N'KS2', N'Vung Tau')
INSERT [dbo].[NOIDUNGTOUR] ([MaDoan], [HanhTrinh], [KhachSan], [DiaDiemThamQuan]) VALUES (N'MD3', N'HT3', N'KS3', N'Da Lat')
INSERT [dbo].[NOIDUNGTOUR] ([MaDoan], [HanhTrinh], [KhachSan], [DiaDiemThamQuan]) VALUES (N'MD4', N'HT4', N'KS4', N'Ben Tre')
INSERT [dbo].[NOIDUNGTOUR] ([MaDoan], [HanhTrinh], [KhachSan], [DiaDiemThamQuan]) VALUES (N'MD5', N'HT5', N'KS5', NULL)

INSERT [dbo].[GIATOUR] ([MaGia], [MaTour], [ThanhTien], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (N'MG1', N'MT4', 30000000, N'12/22/2020', N'12/26/2020')
INSERT [dbo].[GIATOUR] ([MaGia], [MaTour], [ThanhTien], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (N'MG2', N'MT1', 20000000, N'10/30/2020', N'11/4/2020')
INSERT [dbo].[GIATOUR] ([MaGia], [MaTour], [ThanhTien], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (N'MG3', N'MT4', 2000000, N'12/5/2020', N'1/3/2021')
-- Remaster
INSERT [dbo].[GIATOUR] ([MaGia], [MaTour], [ThanhTien], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (N'MG4', N'MT5', 3000000, N'7/13/2021', N'7/20/2021')
INSERT [dbo].[GIATOUR] ([MaGia], [MaTour], [ThanhTien], [ThoiGianBatDau], [ThoiGianKetThuc]) VALUES (N'MG5', N'MT2', 1500000, N'3/11/2021', N'3/16/2021')

INSERT [dbo].[CHITIETDOAN] ([MaDoan], [MaKhachHang]) VALUES (N'MD1', N'MKH1')
INSERT [dbo].[CHITIETDOAN] ([MaDoan], [MaKhachHang]) VALUES (N'MD2', N'MKH3')
INSERT [dbo].[CHITIETDOAN] ([MaDoan], [MaKhachHang]) VALUES (N'MD3', N'MKH5')
INSERT [dbo].[CHITIETDOAN] ([MaDoan], [MaKhachHang]) VALUES (N'MD4', N'MKH1')
INSERT [dbo].[CHITIETDOAN] ([MaDoan], [MaKhachHang]) VALUES (N'MD5', N'MKH2')

INSERT [dbo].[PHANBONHANVIEN_DOAN] ([MaNhanVien], [MaDoan], [NhiemVu]) VALUES (N'MNV1', N'MD1', N'Phien dich')
INSERT [dbo].[PHANBONHANVIEN_DOAN] ([MaNhanVien], [MaDoan], [NhiemVu]) VALUES (N'MNV2', N'MD1', N'Huong dan')
INSERT [dbo].[PHANBONHANVIEN_DOAN] ([MaNhanVien], [MaDoan], [NhiemVu]) VALUES (N'MNV3', N'MD2', N'Huong dan')
INSERT [dbo].[PHANBONHANVIEN_DOAN] ([MaNhanVien], [MaDoan], [NhiemVu]) VALUES (N'MNV4', N'MD3', N'Huong dan')
INSERT [dbo].[PHANBONHANVIEN_DOAN] ([MaNhanVien], [MaDoan], [NhiemVu]) VALUES (N'MNV5', N'MD4', NULL)

-- ???? 
INSERT [dbo].[CHIPHI] ([MaChiPhi], [MaDoan], [SoTien], [MaLoaiChiPhi]) VALUES (N'MLCP1', N'MD1', 2000000, N'MCP1')
INSERT [dbo].[CHIPHI] ([MaChiPhi], [MaDoan], [SoTien], [MaLoaiChiPhi]) VALUES (N'MLCP2', N'MD1', 3000000, N'MCP2')
INSERT [dbo].[CHIPHI] ([MaChiPhi], [MaDoan], [SoTien], [MaLoaiChiPhi]) VALUES (N'MLCP3', N'MD2', 2500000, N'MCP2')