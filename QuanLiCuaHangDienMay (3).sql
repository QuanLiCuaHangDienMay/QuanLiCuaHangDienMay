CREATE DATABASE QB_QL_CUA_HANG_DIEN_MAY
ON PRIMARY
(
	NAME = QLDDH_PRIMARY,
	FILENAME = 'E:\Win nag cao\QuanLiCuaHangDienMayWin\CSDL\QB_QL_CUA_HANG_DIEN_MAY_PRIMARY.mdf',
	SIZE = 5MB,
	MAXSIZE = 10MB,
	FILEGROWTH = 10%
)

LOG ON
(
	NAME = QLDDH_LOG,
	FILENAME = 'E:\Win nag cao\QuanLiCuaHangDienMayWin\CSDL\QB_QL_CUA_HANG_DIEN_MAY_LOG.LDF',
	SIZE = 1MB,
	MAXSIZE = 5MB,
	FILEGROWTH = 10%
)

go
use QB_QL_CUA_HANG_DIEN_MAY ---------------------------------------------------------------------------
go

create table LoaiMatHang
(
	MaLoaiMatHang varchar(11) not null,
	TenLoaiMatHang nvarchar(100),
	CONSTRAINT PK_LoaiMatHang PRIMARY KEY(MaLoaiMatHang)
)
go

create table NhaCungCap
(
	MaNhaCC varchar(11) not null,
	TenNhaCC nvarchar(200),
	DiaChiNCC nvarchar(200),
	DienThoaiNCC varchar(16),
	EmailNCC nvarchar(50),
	websiteNCC nvarchar(100),
	CONSTRAINT PK_NhaCungCap PRIMARY KEY(MaNhaCC)
)
go

create table MatHang
(
	MaHang varchar(11) not null,
	TenMatHang nvarchar(100),
	MaLoaiMatHang varchar(11),
	DVT nvarchar(11),
	GiaBan money,
	GiaNhap money,
	MaNhaCC varchar(11),
	BaoHanh tinyint,
	TinhTrangHang nvarchar(50),
	CONSTRAINT PK_MatHang PRIMARY KEY(MaHang)
)
ALTER TABLE MatHang
ADD Constraint fk_MatHang_LoaiMatHang Foreign Key(MaLoaiMatHang)
References LoaiMatHang(MaLoaiMatHang),
Constraint fk_MatHang_nhaCungCap Foreign Key(MaNhaCC)
References NhaCungCap(MaNhaCC)
go

create table LichSuGiaBan
(
	MaHang varchar(11) not null,
	NgayCapNhat datetime not null,
	GiaCapNhat float,
	NgayKetThuc datetime,
	CONSTRAINT PK_LichSuGiaBan PRIMARY KEY(MaHang,NgayCapNhat)
)
ALTER TABLE LichSuGiaBan
ADD Constraint fk_LichGiaBan_MatHang Foreign Key(MaHang)
References MatHang(MaHang)
go

create table TinhThanhPho
(
	MaTinhThanh varchar(11) not null,
	TenTinhThanh nvarchar(100),
	CONSTRAINT PK_tinhThanh PRIMARY KEY(MaTinhThanh)
)
go

create table ChucVu
(
	MaCV varchar(11) not null,
	TenChucVu nvarchar(70),
	LuongTheoThang money,
	CONSTRAINT PK_chucVu PRIMARY KEY(MaCV)
)
go

create table NhanVien
(
	MaNV varchar(11) not null,
	TenNV nvarchar(100),
	MaCV varchar(11),
	DiaChiNV nvarchar(200),
	DienThoaiNV varchar(10),
	GioiTinhNV nvarchar(5),
	NgayVaoLam datetime,
	CONSTRAINT PK_NhanVien PRIMARY KEY(MaNV)
)
ALTER TABLE NhanVien
ADD Constraint fk_NhanVien_ChucVu Foreign Key(MaCV)
References ChucVu(MaCV)
go

create table NhomKH
(
	MaNhomKH varchar(11) not null,
	TenNhomKH nvarchar(50),
	TiLeGiamGia float,
	CONSTRAINT PK_NhomKH PRIMARY KEY(MaNhomKH)
)
go

create table KhachHang
(
	MaKH varchar(11) not null,
	TenKH nvarchar(100),
	GioiTinhKH nvarchar(5),
	DiaChiKH nvarchar(200),
	DienThoaiKH varchar(10),
	EmailKH nvarchar(30),
	NgaySinhKH datetime,
	DiemTichLuyBanDau float,
	MaNV varchar(11),
	MaNhomKH varchar(11),
	MaTinhThanh varchar(11),
	GhiChu nvarchar(100),
	CONSTRAINT PK_khachHang PRIMARY KEY(MaKH)
)
ALTER TABLE KhachHang
ADD Constraint fk_KhachHang_NhomKH Foreign Key(MaNhomKH)
References NhomKH(MaNhomKH),
Constraint fk_KhachHang_NhanVien Foreign Key(MaNV)
References NhanVien(MaNV),
Constraint fk_KhachHang_TinhThanhPho Foreign Key(MaTinhThanh)
References TinhThanhPho(MaTinhThanh)
go

create table Kho
(
	MaKho varchar(11) not null,
	TenKho nvarchar(50),
	CONSTRAINT PK_kho PRIMARY KEY(MaKho)
)
go

create table ChiTietKho
(
	MaKho varchar(11) not null,
	MaHang varchar(11) not null,
	SoLuong int,
	CONSTRAINT PK_ChiTietKho PRIMARY KEY(MaKho,MaHang)
)
ALTER TABLE ChiTietKho
ADD Constraint fk_ChiTietKho_kho Foreign Key(MaKho)
References Kho(MaKho),
Constraint fk_ChiTietKho_matHang Foreign Key(MaHang)
References MatHang(MaHang)
go

create table PhieuNhap
(
	MaPN varchar(11) not null,
	MaNV varchar(11) not null,
	NgayLapPN datetime,
	TongTienNhap money,
	GhiChu nvarchar(200),
	CONSTRAINT PK_PhieuNhap PRIMARY KEY(MaPN)
)
ALTER TABLE PhieuNhap
ADD Constraint fk_PhieuNhap_nhanVien Foreign Key(MaNV)
References NhanVien(MaNV)
go

create table ChiTietPhieuNhap
(
	MaPN varchar(11) not null,
	MaKho varchar(11) not null,
	MaHang varchar(11) not null,
	GiaNhap money,
	SoLuongNhap int,
	ThanhTien money,
	CONSTRAINT PK_ChiTietPhieuNhap PRIMARY KEY(MaPN,MaKho,MaHang)
)
ALTER TABLE ChiTietPhieuNhap
ADD Constraint fk_ChiTietPhieuNhap_chiTietKho Foreign Key(MaKho,MaHang)
References ChiTietKho(MaKho,MaHang),
Constraint fk_ChiTietPhieuNhap_PhieuNhap Foreign Key(MaPN)
References PhieuNhap(MaPN)
go

/*create table PhieuXuat
(
	MaPX varchar(11) not null,
	MaNV varchar(11) not null,
	NgayLapPX datetime,
	GhiChu nvarchar(200),
	CONSTRAINT PK_PhieuXuat PRIMARY KEY(MaPX)
)
ALTER TABLE PhieuXuat
ADD Constraint fk_PhieuXuat_nhanVien Foreign Key(MaNV)
References NhanVien(MaNV)
go

create table ChiTietPhieuXuat
(
	MaPX varchar(11) not null,
	MaKho varchar(11) not null,
	MaHang varchar(11) not null,
	SoLuongNhap int,
	CONSTRAINT PK_ChiTietPhieuXuat PRIMARY KEY(MaPX,MaKho,MaHang)
)
ALTER TABLE ChiTietPhieuXuat
ADD Constraint fk_ChiTietPhieuXuat_chiTietKho Foreign Key(MaKho,MaHang)
References ChiTietKho(MaKho,MaHang),
Constraint fk_ChiTietPhieuXuat_PhieuXuat Foreign Key(MaPX)
References PhieuXuat(MaPX)*/
go

create table HoaDon
(
	MaHD varchar(11) not null,
	MaKH varchar(11) not null,
	MaNV varchar(11) not null,
	NgayLapHD datetime,
	GiamGiaTrucTiep money,
	TongTien money,
	CONSTRAINT PK_HoaDon PRIMARY KEY(MaHD)
)
ALTER TABLE HoaDon
ADD Constraint fk_HoaDon_KhachHang Foreign Key(MaKH)
References KhachHang(MaKH),
Constraint fk_HoaDon_NhanVien Foreign Key(MaNV)
References NhanVien(MaNV)
go


create table ChiTietHoaDon
(
	MaHD varchar(11) not null,
	MaHang varchar(11) not null,
	SoLuong int,
	DonGia money,
	ThanhTien money,
	CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY(MaHD,MaHang)
)
ALTER TABLE ChiTietHoaDon
ADD Constraint fk_ChiTietHoaDon_HoaDon Foreign Key(MaHD)
References HoaDon(MaHD),
Constraint fk_ChiTietHoaDon_MatHang Foreign Key(MaHang)
References MatHang(MaHang)
go

create table PhieuBaoHanh
(
	MaPBH varchar(11) not null,
	MaKH varchar(11) not null,
	MaNV varchar(11) not null,
	NgayLapPBH datetime,
	CONSTRAINT PK_PhieuBaoHanh PRIMARY KEY(MaPBH)
)
ALTER TABLE PhieuBaoHanh
ADD Constraint fk_PhieuBaoHanh_kh Foreign Key(MaKH)
References KhachHang(MaKH),
Constraint fk_PhieuBaoHanh_nhanVien Foreign Key(MaNV)
References NhanVien(MaNV)
go

create table ChiTietPhieuBaoHanh
(
	MaPBH varchar(11) not null,
	MaHang varchar(11) not null,
	ThoiGianHetBaoHanh datetime,
	SoLanBH int,
	CONSTRAINT PK_ChiTietPhieuBaoHanh PRIMARY KEY(MaPBH,MaHang)
)
ALTER TABLE ChiTietPhieuBaoHanh
ADD Constraint fk_ChiTietPhieuBaoHanh_PhieuBaoHanh Foreign Key(MaPBH)
References PhieuBaoHanh(MaPBH),
Constraint fk_ChiTietPhieuBaoHanh_MatHang Foreign Key(MaHang)
References MatHang(MaHang)
go

create table TaiKhoan
(
	TenTaiKhoan varchar(20) not null,
	MatKhau varchar(25) not null,
	TinhTrangTK nvarchar(30),
	MaNV varchar(11),
	NgayCap datetime,
	CONSTRAINT PK_TaiKhoan PRIMARY KEY(TenTaiKhoan)
)
ALTER TABLE TaiKhoan
ADD Constraint fk_TaiKhoan_NhanVien Foreign Key(MaNV)
References NhanVien(MaNV)
go

create table QuanLiNhomTaiKhoan
(
	MaNhomTK varchar(11) not null,
	TenNhomTK nvarchar(50),
	GhiChu nvarchar(100),
	CONSTRAINT PK_QuanLiNhomTaiKhoan PRIMARY KEY(MaNhomTK)
)
go

create table QuanLiTaiKhoan_NhomTaiKhoan
(
	TenTaiKhoan varchar(20) not null,
	MaNhomTK varchar(11) not null,
	GhiChu nvarchar(100),
	CONSTRAINT PK_QuanLiTaiKhoan_NhomTaiKhoan PRIMARY KEY(TenTaiKhoan,MaNhomTK)
)
ALTER TABLE QuanLiTaiKhoan_NhomTaiKhoan
ADD Constraint fk_QuanLiTaiKhoan_NhomTaiKhoan_TaiKhoan Foreign Key(TenTaiKhoan)
References TaiKhoan(TenTaiKhoan),
Constraint fk_QuanLiTaiKhoan_NhomTaiKhoan_QuanLiNhomTaiKhoan Foreign Key(MaNhomTK)
References QuanLiNhomTaiKhoan(MaNhomTK)
go

create table QuanLiManHinh
(
	MaMH varchar(11) not null,
	TenMaMH nvarchar(50),
	CONSTRAINT PK_QuanLiManHinh PRIMARY KEY(MaMH)
)
go

create table QuanLiPhanQuyen
(
	MaNhomTK varchar(11) not null,
	MaMH varchar(11) not null,
	TenQuyen nvarchar(50),
	TinhTrang bit,
	CONSTRAINT PK_QuanLiPhanQuyen PRIMARY KEY(MaNhomTK,MaMH)
)
ALTER TABLE QuanLiPhanQuyen
ADD Constraint fk_QuanLiPhanQuyen_QuanLiNhomTaiKhoan Foreign Key(MaNhomTK)
References QuanLiNhomTaiKhoan(MaNhomTK),
Constraint fk_QuanLiPhanQuyen_QuanLiManHinh Foreign Key(MaMH)
References QuanLiManHinh(MaMH)
go
--------------------------------------------------------------------------------
ALTER TABLE MatHang
ADD Constraint uni_TenMH Unique(TenMatHang)
go
ALTER TABLE TinhThanhPho
ADD Constraint uni_TenTinhThanh Unique(TenTinhThanh)
go
ALTER TABLE ChucVu
ADD Constraint uni_TenChucVu Unique(TenChucVu)
go
alter table LichSuGiaBan
add constraint df_NgayKetThuc default null for NgayKetThuc
go
ALTER TABLE KhachHang
ADD CONSTRAINT CHK_GioiTinhKH CHECK (GioiTinhKH='NAM'OR GioiTinhKH=N'NỮ')
go


-------------------------------


---------------------------------------------------------------------------------
insert into LoaiMatHang(MaLoaiMatHang,TenLoaiMatHang)
values	('TV',N'Tivi'),
		('DTDD',N'Điện Thoại Di Động'),
		('TL',N'Tủ Lạnh'),
		('LVS',N'Lò Vi Sóng'),
		('MDH',N'Máy Điều Hòa')
go

insert into NhaCungCap(MaNhaCC,TenNhaCC,DiaChiNCC,DienThoaiNCC,EmailNCC,websiteNCC)
values	('LG','Lifes Good',N'Lô CN2, KCN Tràng Duệ, xã Lê Lợi, huyện An Dương, thành phố Hải Phòng, Việt Nam',
		'84-24.9345151','lgorder.online@lgepartner.com','http://www.lg.com/vn'),
		('CTYVINPRO',N'Chi nhánh SONY ELECTRONICS VIỆT NAM',N'16/2, LÊ VĂN KHƯƠNG, P.THỚI AN, Q.12 TP.HỒ CHÍ MINH',
		'08418006988','noInfo','https://www.sony.com.vn/')

go
insert into MatHang(MaHang,TenMatHang,MaLoaiMatHang,DVT,GiaBan,GiaNhap,MaNhaCC,BaoHanh,TinhTrangHang)
values	('MH001','Sony Bravia Oleb MASTER Series A9G','TV',N'Cái',69900000,67000000,'CTYVINPRO',24,N'Còn hàng'),
		('MH002',N'Điện thoại Sony Xperia 1','DTDD',N'Chiếc',22990000,21000000,'CTYVINPRO',12,N'Còn hàng'),
		('MH003',N'DUALCOOL Inverter 1 chiều Thanh lọc không khí','MDH',N'Chiếc',14790000,14000000,'LG',12,N'Hết hàng')

go
set dateformat DMY
insert into LichSuGiaBan(MaHang,NgayCapNhat,GiaCapNhat,NgayKetThuc)
values	('MH001','11/09/2019',69900000,null)

go
insert into TinhThanhPho(MaTinhThanh,TenTinhThanh)
values	('HCM',N'Hồ Chí Minh'),
		('HN',N'Hà Nội'),
		('CT',N'Cần Thơ'),
		('DN',N'Đà Nẵng'),
		('HP',N'Hải Phòng')

go
insert into ChucVu(MaCV,TenChucVu,LuongTheoThang)
values	('CV001',N'Nhân viên bán hàng',50000000),
		('CV002',N'Thu ngân',5500000),
		('CV003',N'Bảo vệ',4800000),
		('CV004',N'Quản lí kho',5000000),
		('CV005',N'Hỗ trợ khách hàng',5000000),
		('CV006',N'Quản lí cửa hàng',7000000)

go
set dateformat DMY
insert into NhanVien(MaNV,TenNV,MaCV,DiaChiNV,DienThoaiNV,GioiTinhNV,NgayVaoLam)
values	('NV001',N'Nguyễn Phương Thảo','CV002',N'123,Tân Kì Tân Quý, Quận Tân Phú,tp Hồ Chí Minh','0923456765',N'Nữ','11/08/2019'),
		('NV002',N'Huỳnh Minh Anh','CV001',N'88, Lê Trọng Tấn, Quận Tân Phú, tp Hồ Chí Minh','098354555',N'Nữ','08/06/2019'),
		('NV003',N'Trần Hữu Minh','CV003',N'100,Tỉnh lộ 10, Quận Bình Tân,tp Hồ Chí Minh','0983322344',N'Nam','07/01/2019'),
		('NV004',N'Nguyễn Minh Nhật','CV004',N'100,Tên lửa, Quận Bình Tân,tp Hồ Chí Minh','0983433434',N'Nam','20/03/2019'),
		('NV005',N'Đào Ánh Mai','CV005',N'14,Đường số 7, Quận Bình Tân,tp Hồ Chí Minh','0983343434',N'Nữ','20/12/2018'),
		('NV006',N'Nguyễn Ánh Nguyệt','CV005',N'14,Đường ab, Quận Long Biên,Hà Nội','0983343434',N'Nữ','15/10/2018'),
		('NV007',N'Hoàng Mai Linh','CV006',N'14,Đường ab, Quận Long Biên,Hà Nội','0983343434',N'Nữ','15/10/2018')
go
insert into NhomKH(MaNhomKH,TenNhomKH,TiLeGiamGia)
values	('NKH001',N'Khách vảng lai',0),
		('NKH002',N'Khách Thành Viên Bạc',0.05),
		('NKH003',N'Khách Thành Viên Vàng',0.07),
		('NKH004',N'Khách Thành Viên Bạch Kim',0.1),
		('NKH005',N'Khách Thành Viên Kim Cương',0.15)

go
set dateformat DMY
insert into KhachHang(MaKH,TenKH,GioiTinhKH,DiaChiKH,DienThoaiKH,EmailKH,NgaySinhKH,DiemTichLuyBanDau,MaNV,MaNhomKH,MaTinhThanh,GhiChu)
values	('KH001',N'Nguyễn Kim Chi',N'Nữ',N'123,Tân Kì Tân Quý, Quận Tân Phú,Hồ Chí Minh','0923456765','abc@gmail.com',
		'20/10/1980',100,'NV005','NKH001','HCM',null),
		('KH002',N'Nguyễn Hoài Phương',N'Nữ',N'123,Bình Long, Quận Tân Phú,Hồ Chí Minh','0923434365','def@gmail.com',
		'22/11/1985',100,'NV005','NKH002','HCM',null),
		('KH003',N'Nguyễn Minh Phát',N'Nam',N'123,abc, Quận Đống Đa,Hà Nội','092312365','mgh@gmail.com',
		'22/08/1984',100,'NV006','NKH002','HN',null)

go
insert into Kho(MaKho,TenKho)
values	('KHO001','Kho hàng A')

go
insert into ChiTietKho(MaKho,MaHang,SoLuong)
values	('KHO001','MH001',10),
		('KHO001','MH002',11),
		('KHO001','MH003',0)

go
set dateformat DMY
insert into PhieuNhap(MaPN,MaNV,NgayLapPN,TongTienNhap,GhiChu)
values	('PN001','NV004','01/09/2019',0,null),
		('PN002','NV004','12/09/2019',0,null)
		
go
insert into ChiTietPhieuNhap(MaPN,MaKho,MaHang,GiaNhap,SoLuongNhap)
values	('PN001','KHO001','MH001',67000000,5),
		('PN002','KHO001','MH002',21000000,5),
		('PN002','KHO001','MH001',67000000,1)

go
set dateformat DMY
insert into HoaDon(MaHD,MaKH,MaNV,NgayLapHD,GiamGiaTrucTiep,TongTien)
values	('HD001','KH001','NV002','10/09/2019',0,69900000),
		('HD002','KH002','NV002','12/09/2019',200000,92690000)

go
insert into ChiTietHoaDon(MaHD,MaHang,SoLuong,DonGia,ThanhTien)
values	('HD001','MH001',1,69900000,69900000),
		('HD002','MH001',1,69900000,69900000),
		('HD002','MH002',1,22990000,22990000)

go
set dateformat DMY
insert into PhieuBaoHanh(MaPBH,MaKH,MaNV,NgayLapPBH)
values	('PBH001','KH001','NV006','10/09/2019'),
		('PBH002','KH002','NV006','12/09/2019')

go
set dateformat DMY
insert into ChiTietPhieuBaoHanh(MaPBH,MaHang,ThoiGianHetBaoHanh,SoLanBH)
values	('PBH001','MH001','10/09/2021',0),
		('PBH002','MH001','12/09/2021',0),
		('PBH002','MH002','10/09/2020',1)

go
set dateformat DMY
insert into TaiKhoan(TenTaiKhoan,MatKhau,TinhTrangTK,MaNV,NgayCap)
values	('admin','admin','Hoạt động','NV007','01/01/2019')
go

---------------------------------------------------------------------------------
--Cap nhat tong tien nhap
CREATE TRIGGER CNTT_CTPN_PN
ON ChiTietPhieuNhap
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE ChiTietPhieuNhap
		SET ThanhTien=(SELECT SoLuongNhap*GiaNhap FROM inserted )
		where ChiTietPhieuNhap.MaPN=(SELECT MaPN FROM inserted) and ChiTietPhieuNhap.MaHang=(SELECT MaHang FROM inserted)
		UPDATE PhieuNhap
		SET TongTienNhap=(SELECT SUM(ThanhTien) FROM ChiTietPhieuNhap WHERE ChiTietPhieuNhap.MaPN=PhieuNhap.MaPN)
END

go
--cap nhat tong tien hoa don
CREATE TRIGGER CNTT_CTHD_HD
ON ChiTietHoaDon
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE ChiTietHoaDon
		SET ThanhTien=(SELECT SoLuong*DonGia FROM inserted )
		where ChiTietHoaDon.MaHD=(SELECT MaHD FROM inserted) and ChiTietHoaDon.MaHang=(SELECT MaHang FROM inserted)
		UPDATE HoaDon
		SET TongTien=(SELECT SUM(ThanhTien) FROM ChiTietHoaDon WHERE ChiTietHoaDon.MaHD=HoaDon.MaHD)
END

go
/*drop TRIGGER CNTT_CTPN_PN*/
set dateformat DMY
insert into PhieuNhap(MaPN,MaNV,NgayLapPN,TongTienNhap,GhiChu)
values	('PN003','NV004','15/09/2019',0,null)
insert into ChiTietPhieuNhap(MaPN,MaKho,MaHang,GiaNhap,SoLuongNhap)
values	('PN003','KHO001','MH001',67000000,5)

go
--Kiem tra tinh trang hang
CREATE TRIGGER CNTT_CTHD_Kho
ON ChiTietHoaDon
FOR INSERT
AS
	BEGIN
		IF(SELECT ChiTietKho.SoLuong FROM ChiTietKho, inserted WHERE inserted.MaHang=ChiTietKho.MaHang)=0
		BEGIN
			UPDATE MatHang
			SET TinhTrangHang=(N'Hết hàng')
			WHERE MatHang.MaHang=(SELECT MaHang FROM inserted)
		END
		ELSE
		BEGIN
			IF(SELECT SoLuong FROM inserted)<=(SELECT ChiTietKho.SoLuong FROM ChiTietKho, inserted WHERE inserted.MaHang=ChiTietKho.MaHang)
			BEGIN
				UPDATE MatHang
				SET TinhTrangHang=('Đã bán')
				WHERE MatHang.MaHang=(SELECT MaHang FROM inserted)

				UPDATE ChiTietKho
				SET SoLuong=SoLuong-(SELECT SoLuong FROM inserted)
				WHERE ChiTietKho.MaHang=(SELECT MaHang FROM inserted)
			END
			ELSE
				PRINT (N'Không đủ hàng')
		END
END

/*drop TRIGGER CNTT_CTHD_Kho*/

go
--tang so luong hang nhap vao kho
CREATE TRIGGER TANGSLHANG_CTPN
ON ChiTietPhieuNhap
FOR INSERT
AS
	BEGIN
		UPDATE ChiTietKho
		SET SoLuong=SoLuong+(SELECT SoLuong FROM inserted)
		WHERE ChiTietKho.MaHang=(SELECT MaHang FROM inserted) and ChiTietKho.MaKho=(SELECT MaKho FROM inserted)
END

/*drop TRIGGER TANGSLHANG_CTPN*/

go
--
CREATE TRIGGER GIAMSLHANG_CTHD
ON ChiTietHoaDon
FOR INSERT
AS
	BEGIN
		UPDATE ChiTietKho
		SET SoLuong=SoLuong-(SELECT SoLuong FROM inserted)
		WHERE ChiTietKho.MaHang=(SELECT MaHang FROM inserted)
END

go
CREATE TRIGGER ngayMacDinhPN
ON PhieuNhap
FOR INSERT
AS
	BEGIN
		UPDATE PhieuNhap
		SET NgayLapPN=GETDATE()
		WHERE PhieuNhap.MaPN=(SELECT MaPN FROM inserted)
END

go
CREATE TRIGGER NgayLapHD
ON HoaDon
FOR INSERT
AS
	BEGIN
		UPDATE HoaDon
		SET NgayLapHD=GETDATE()
		WHERE HoaDon.MaHD=(SELECT MaHD FROM inserted)
END