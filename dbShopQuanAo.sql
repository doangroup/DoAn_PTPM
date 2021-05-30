create database QLSHOPQUANAO
go
use QLSHOPQUANAO
go
------------------Bang-----------------------------------------

create table KhachHang
(
	MaKH int identity(1,1) primary key,
	TenKH nvarchar(100) not null,
	DiaChi nvarchar(100),
	SDT nvarchar(20),
	MatKhau nvarchar(50) default null
)
go
create table KhuyenMai
(
	MaKM int primary key,
	TenKM nvarchar(50),
	LinkKM nvarchar(max)
)
go

create table NhanVien
(
	MaNV int identity(1,1) primary key,
	TenNV nvarchar(100) not null,
	GioiTinh nvarchar(20) not null,
	DiaChi nvarchar(100) not null,
	SDT nvarchar(100) not null,
	NgaySinh datetime not null,
	TenDN nvarchar(50),
	MatKhau nvarchar(50) not null,
	LoaiTK int not null -- 1 = Quản lý & 0 = Nhân viên
)
go

create table DanhMuc
(
	MaDM int primary key,
	TenDM nvarchar(50)
)
go
create table SanPham
(
	MaSP int primary key,
	MaDM int,
	TenSP nvarchar(100) not null,
	SoLuong int not null,
	DonGia money not null,
	HinhAnh nvarchar(50),
	GhiChu nvarchar(200),
	constraint fk_SP_DM foreign key(MaDM) references DanhMuc(MaDM)
)
go

create table HoaDon
(
	MaHD int primary key,
	MaKH int,
	MaNV int,
	Tinhtrang int default 0, -- 0 = chưa thanh toán | 1 = đã thanh toán
	NgayBan datetime not null,
	NgayGiao datetime null,
	TongTien float,
	constraint fk_HD_NV foreign key(MaNV) references NhanVien(MaNV),
	
	constraint fk_HD_KH foreign key(MaKH) references KhachHang(MaKH)
)
go

create table ChiTietHD
(
	MaCTHD int identity(1,1)primary key,
	MaHD int null,
	MaSP int null,
	SoLuong int null,
	ThanhTien float null,
	
	constraint fk_CTHD_HD foreign key(MaHD) references HoaDon(MaHD),
	constraint fk_HD_H foreign key(MaSP) references SanPham(MaSP)
)

go
-----------------------------------------------------------------

--------------------------------Thêm Dữ Liệu Vào Bảng--------------------

set dateformat dmy
go

insert into NhanVien
values (N'Trung',N'Nam',N'Tân Phú','045648932',1999/01/23,'admin','c4ca4238a0b923820dcc509a6f75849b',1),
		(N'Nhân Viên 2',N'Nữ',N'Thủ Đức','045648932',2000/07/20,'admin2','c4ca4238a0b923820dcc509a6f75849b',0)
go

insert into DanhMuc
values (1,N'Áo Sơ Mi'),
		(2,N'Áo Thun'),
		(3,N'Quần Jean'),
		(4,N'Quần Tây'),
		(5,N'Áo Khoác Nam'),
		(6,N'Quần Jogger'),
		(7,N'Áo Cặp')
go

insert into SanPham
values (1,7,N'Áo thun đính đá hình báo',20,200000,'cap3.jpg',N'Giặt ra màu'),
		(2,7,N'Áo thun đính đá',10,100000,'cap6.jpg',null),
		(3,7,N'Áo thun đính đá đầu hổ',50,20000,'cap10.jpg',null),
		(4,7,N'Áo thun burlong thêu',10,50000,'cap5.jpg',N'Giặt ra màu'),
		(5,7,N'Áo thun cánh chim',40,100000,'cap13.jpg',null),
		(6,7,N'Áo thun cánh chim ngũ sắc',15,200000,'cap13.jpg',N'Giặt không ra màu'),
		(7,7,N'Áo sơ mi nam họa tiết sọc in',20,250000,'cap17.jpg',N'Vải dày'),
		(8,7,N'Áo thun cánh chim thiên thần có cổ đính ',50,20000,'cap14.jpg',null),
		(9,7,N'Áo thun nam đính đá versace ',20,100000,'cap2.jpg',N'Giặt ra màu'),
		(10,7,N'Áo thun cánh chim thiên thần',20,100000,'cap1.jpg',N'Giặt ra màu'),
		(11,7,N'Áo sơ mi nam họa tiết jean sọc ',20,100000,'cap16.jpg',null),
		(12,7,N'Áo thun tay dài thêu versace',20,100000,'cap4.jpg',null),
		(13,7,N'Áo thun dài tay đính đá',20,100000,'cap7.jpg',null),
		(14,7,N'Áo thun dài tay đính cườm versace',20,100000,'cap12.jpg',null),
		(15,7,N'áo thun đầu hổ 8997 Nam-Nữ',20,100000,'cap9.jpg',null),
		(16,7,N'áo sơ mi sọc 1890',20,100000,'cap18.jpg',null),
		(17,7,N'áo sơ mi mặt trời 290 (Nam -nữ)',20,100000,'cap15.jpg',null),
		(18,1,N'Áo sơ mi họa tiết versace',20,100000,'somi14.jpg',null),
		(19,1,N'Áo sơ mi họa tiết versace',20,100000,'somi15.jpg',null),
		(20,1,N'Áo sơ mi nam họa tiết D&G',20,100000,'somi16.jpg',null),
		(21,1,N'Áo sơ mi nam trắng NYC',20,100000,'somi11.jpg',null),
		(22,1,N'Áo sơ mi nam trắng trơn',20,100000,'somi20.jpg',null),
		(23,1,N'Áo sơ mi nam họa tiết versace',20,100000,'somi13.jpg',null),
		(24,1,N'Áo sơ mi nam họa tiết versace',20,100000,'somi25.jpg',null),
		(25,1,N'Áo sơ mi nam burberry ',20,100000,'somi10.jpg',null),
		(26,1,N'Áo sơ mi nam họa tiết hoa văn',20,100000,'somi12.jpg',null),
		(27,1,N'Áo sơ mi NYC',20,100000,'somi9.jpg',null),
		(28,1,N'Áo sơ mi nam sọc caro',20,100000,'somi23.jpg',null),
		(29,1,N'áo sơ mi nam trắng trơn',20,100000,'somi24.jpg',null),
		(30,1,N'Áo sơ mi nam họa tiết',20,100000,'somi3.jpg',null),
		(31,1,N'Áo sơ mi nam sọc họa',20,100000,'somi2.jpg',null),
		(32,2,N'Áo thun nam hoạ tiết burberi',20,100000,'thun1.jpg',null),
		(33,2,N'Áo thun nam hoạ tiết hình sư tử',20,100000,'thun2.jpg',null),
		(34,2,N'Áo thun nam hoạ tiết đặc biệt',20,100000,'thun3.jpg',null),
		(35,2,N'Áo thun nam hoạ tiết chuột Mickey đính',20,100000,'thun4.jpg',null),
		(36,2,N'Áo thun nam hoạ tiết đặc biệt ',20,100000,'thun5.jpg',null),
		(37,2,N'Áo thun nam đính cườm',20,100000,'thun6.jpg',null),
		(38,2,N'Áo thun nam hoạ tiết in nhũ vàng',20,100000,'thun7.jpg',null),
		(39,2,N'Áo thun đính cườm',20,100000,'thun8.jpg',null),
		(40,2,N'áo thun nam họa tiết thêu 3D đính cườm',20,100000,'thun9.jpg',null),
		(41,2,N'Áo thun có cổ LOGO',20,100000,'thun10.jpg',null),
		(42,2,N'Áo thun nam có cổ',20,100000,'thun11.jpg',null),
		(43,3,N'Quần jean đen nam rách gối',20,100000,'jean1.jpg',null),
		(44,3,N'quần jean rách nam',20,100000,'jean2',null),
		(45,3,N'quần jean rách',20,100000,'jean3',null),
		(46,3,N'quần jean rách',20,100000,'jean4',null),
		(47,3,N'Quần jean rách',20,100000,'jean5',null),
		(48,3,N'quần jean',20,100000,'jean6',null),
		(49,3,N'quần jean rách',20,100000,'jean7',null),
		(50,3,N'quần jean rách gối',20,100000,'jean8',null),
		(51,3,N'quần jean rách',20,100000,'jean9',null),
		(52,3,N'quần jean rách',20,100000,'jean10.jpg',null),
		(53,3,N'quần jean rách',20,100000,'jean11.jpg',null),
		(54,4,N'quần tây âu (big size)',20,100000,'tay1.jpg',null),
		(55,4,N'quần tây Nam size lớn ống côn',20,100000,'tay2.jpg',null),
		(56,4,N'quần tây size lớn xám chì ống ôm',20,100000,'tay3.jpg',null),
		(57,4,N'Quần Tây nam ống côn',20,100000,'tay4.jpg',null),
		(58,4,N'quần tây nam ống côn',20,100000,'tay5.jpg',null),
		(59,4,N'quần tây âu 3',20,100000,'tay6.jpg',null),
		(60,4,N'quần tây âu 5',20,100000,'tay7.jpg',null),
		(61,4,N'quần tây âu 1',20,100000,'tay8.jpg',null),
		(62,4,N'Tây slim hàn quốc',20,100000,'tay9.jpg',null),
		(63,5,N'áo khoác số c7',20,100000,'khoac1.jpg',null),
		(64,5,N'áo khoác bombor',20,100000,'khoac2.jpg',null),
		(65,6,N'quần jogger thun',20,100000,'jogger2.jpg',null),
		(66,6,N'quần jogger thun 2007',20,100000,'jogger3.jpg',null),
		(67,6,N'quần jogger thun 2009',20,100000,'jogger4.jpg',null),
		(68,6,N'quần jogger thun 2019',20,100000,'jogger5.jpg',null),
		(69,6,N'quần jogger thun 2020',20,100000,'jogger6.jpg',null),
		(70,6,N'quần jogger',20,100000,'jogger7.jpg',null),
		(71,6,N'quần jogger 1815',20,100000,'jogger8.jpg',null),
		(72,6,N'quần jogger 925',20,100000,'jogger9.jpg',null)
go

insert into KhachHang
values (N'Tạ Quang Trung', N'Thôn 5', N'0123456','1'),
		(N'Nguyễn Văn Tèo', N'Thôn 2', N'0123456','1'),
		(N'Nguyễn Thị Bưởi', N'Thôn 8', N'0123456','1'),
		(N'Nguyễn Thị Đào', N'Thôn 1', N'0123456','1'),
		(N'Nguyễn Thanh Huy', N'Tp.HCM', N'0902669401','admin')
go


---------------------Tạo Trigger------------------------------------
create trigger TGThanhTien 
on ChiTIetHD
FOR INSERT, UPDATE
AS
	UPDATE HOADON
	SET TongTien = (SELECT SUM(ChiTietHD.THANHTIEN) FROM ChiTietHD WHERE ChiTietHD.MAHD = (SELECT MAHD FROM inserted))
	WHERE HOADON.MAHD = (SELECT MAHD FROM inserted)
GO

create trigger SoLuong
on ChiTietHD
for insert, update
as
	update SanPham
	set SoLuong = SanPham.SoLuong - (select SoLuong from inserted where MaSP =(select MaSP from inserted))
	where SanPham.MaSP = (select MaSP from inserted)
go

----------------------Tạo Procedduce APP Desktop---------------------------------------
----------------------------------------------
--drop database QLSHOPQUANAO
--create proc findKHByHD @tenKH nvarchar(50)
--as
--begin
--	select HoaDon.MaHD, HoaDon.MaKH,HoaDon.MaNV,HoaDon.MaSP,HoaDon.NgayBan 
--	from HoaDon, KhachHang 
--	where TenKH = @tenKH and HoaDon.MaKH = KhachHang.MaKH
--end
--go
--exec findKHByHD N'Tạ Quang Trung'

create proc ThanhToan @mahd int
as
	begin
		select HoaDon.NgayBan, HoaDon.MaHD, NhanVien.TenNV, SanPham.TenSP,ChiTietHD.SoLuong,SanPham.DonGia,ChiTietHD.ThanhTien,HoaDon.TongTien
		from HoaDon,ChiTietHD,SanPham,NhanVien,KhachHang
		where HoaDon.MaHD = ChiTietHD.MaHD and SanPham.MaSP = ChiTietHD.MaSP and NhanVien.MaNV = HoaDon.MaNV and HoaDon.MaKH = KhachHang.MaKH and HoaDon.MaHD = @mahd
		group by HoaDon.NgayBan,HoaDon.MaHD, NhanVien.TenNV, SanPham.TenSP,ChiTietHD.SoLuong,SanPham.DonGia,ChiTietHD.ThanhTien,HoaDon.TongTien
	end
go



--create proc LayHDTheoNgay 
--@ngayban datetime
--as
--begin
--	select TenSP, ChiTietHD.SoLuong, SanPham.DonGia, NgayBan, TenKH, ThanhTien = ChiTietHD.SoLuong * DonGia from KhachHang, HoaDon,SanPham, ChiTietHD where NgayBan = @ngayban and SanPham.MaSP = HoaDon.MaSP and KhachHang.MaKH = HoaDon.MaKH
--end
--go

--exec LayHDTheoNgay '1900-01-01 00:00:00.000'

create proc HoaDonKH @mahd int
as
	begin
		select KhachHang.TenKH, NhanVien.TenNV, SanPham.TenSP, HoaDon.NgayBan, ChiTietHD.SoLuong, SanPham.DonGia ,ChiTietHD.ThanhTien
		from KhachHang, NhanVien,SanPham, HoaDon, ChiTietHD
		where HoaDon.MaKH = KhachHang.MaKH and NhanVien.MaNV = HoaDon.MaNV and ChiTietHD.MaHD = HoaDon.MaHD and ChiTietHD.MaSP = SanPham.MaSP and HoaDon.MaHD = @mahd
	end
	go
--------------------------------------


----------Proceduce của App Android--------------------------------------
go
-----Dang Ky Thanh Vien--------
/****** Object:  StoredProcedure [dbo].[DangKyThanhVien]    Script Date: 5/30/2021 11:23:11 AM ******/

Create proc [dbo].[DangKyThanhVien](@makhach int,@tenKH nvarchar(50),@diachi nvarchar(100),@sdt nvarchar(20),@mk nvarchar(50))
as 
insert into KhachHang(MaKH,TenKH,DiaChi,SDT,MatKhau)
values (@makhach,@tenKH,@diachi,@sdt,@mk)
------------
Go
----------Lay Danh Myc San Pham

GO
/****** Object:  StoredProcedure [dbo].[lay_DanhMuc]    Script Date: 5/30/2021 11:23:52 AM ******/

GO
Create proc [dbo].[lay_DanhMuc]
as
(
select * from DanhMuc
)
------------------------
go
--------------Lay DS San Pham--

GO
/****** Object:  StoredProcedure [dbo].[lay_DS_SanPham_Theo_Danh_Muc]    Script Date: 5/30/2021 11:24:24 AM ******/

GO
Create proc [dbo].[lay_DS_SanPham_Theo_Danh_Muc](@ma int)
as
Select *
from SanPham as s
where  s.MaDM=@ma
--------------------
go
-----------------Lay Thong Tin Khach Hang
GO
/****** Object:  StoredProcedure [dbo].[lay_KhachHang]    Script Date: 5/30/2021 11:25:02 AM ******/
go
Create proc lay_KhachHang(@sdt nvarchar(50))
as
Select *
from KhachHang
where KhachHang.SDT=@sdt
-------------------------

-----------------Lay Thong Tin San Pham
GO
/****** Object:  StoredProcedure [dbo].[lay_SanPham]    Script Date: 5/30/2021 11:25:40 AM ******/

GO
Create proc [dbo].[lay_SanPham]
as
(
select * from SanPham
)

