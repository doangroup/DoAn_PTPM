create database QLSHOPQUANAO
go
use QLSHOPQUANAO
go


drop database QLSHOPQUANAO
go



create table TaiKhoan
(
	TenDN nvarchar(50) primary key,
	MatKhau nvarchar(50) not null,
	LoaiTK int not null -- 1 = Quản lý & 0 = Nhân viên
)
go

select * from TaiKhoan
go

create table KhachHang
(
	MaKH int primary key,
	TenKH nvarchar(100) not null,
	DiaChi nvarchar(100),
	SDT nvarchar(20),
)
go

insert into TaiKhoan
values ('admin','1',1),
		('admin2','1',0)
go

select * from TaiKhoan
go

create table NhanVien
(
	MaNV int primary key,
	TenNV nvarchar(100) not null,
	GioiTinh nvarchar(20) not null,
	DiaChi nvarchar(100) not null,
	SDT nvarchar(100) not null,
	NgaySinh datetime not null,
)
go
select * from NhanVien
set dateformat dmy
insert into NhanVien
values (0,N'Trung',N'Nam',N'Tân Phú','045648932',1999/01/23),
		(1,N'Nhân Viên 2',N'Nữ',N'Thủ Đức','045648932',2000/07/20)
go

insert into NhanVien values (N'trung',N'Nam',N'thone','65465',3/2/2010)

select * from NhanVien
go

create table Hang
(
	MaHang int primary key,
	TenHang nvarchar(100) not null,
	SoLuong int not null,
	DonGia int not null,
	GhiChu nvarchar(200),
)
go

insert into Hang
values (0,N'Áo phao mỏng',20,200000,N'Giặt ra màu'),
		(1,N'Áo phao',20,200000,N'Giặt ra màu'),
		(2,N'Áo dù',10,100000,null),
		(3,N'Quần đùi',50,20000,null),
		(4,N'Áo khoác kiểu Hàn',10,50000,N'Giặt ra màu'),
		(5,N'Áo phông kiểu Nhật',40,100000,null),
		(6,N'Quần jean',15,200000,N'Giặt không ra màu'),
		(7,N'Áo khoác jean',20,250000,N'Vải dày'),
		(8,N'Áo thun 3 lỗ',50,20000,null),
		(9,N'Áo thun in hình gấu',20,100000,N'Giặt ra màu')
go

select * from Hang
go

insert into KhachHang
values (0,N'Tạ Quang Trung', N'Thôn 5', N'0123456'),
		(1,N'Nguyễn Văn Tèo', N'Thôn 2', N'0123456'),
		(2,N'Nguyễn Thị Bưởi', N'Thôn 8', N'0123456'),
		(3,N'Nguyễn Thị Đào', N'Thôn 1', N'0123456')
go

select TenHang as [Tên Sản Phẩm], SoLuong as [Số Lượng], DonGiaNhap as [Đơn Giá Nhập], DonGiaBan as [Đơn Giá Bán], GhiChu as [Ghi Chú] from Hang
create table HoaDon
(
	MaHD int primary key,
	MaKH int,
	MaNV int,
	MaHang int,
	NgayBan datetime not null,
	constraint fk_HD_NV foreign key(MaNV) references NhanVien(MaNV),
	constraint fk_HD_H foreign key(MaHang) references Hang(MaHang),
	constraint fk_HD_KH foreign key(MaKH) references KhachHang(MaKH)
)
go

select * from KhachHang

insert into HoaDon
values (0,1,0,3,2020/05/01),
		(1,2,1,2,2020/07/01)
go

select Hang.TenHang, KhachHang.TenKH, HoaDon.SoLuong, DonGia, NgayBan, TenNV, ThanhTien from HoaDon, KhachHang,Hang,NhanVien where HoaDon.MaKH = KhachHang.MaKH and HoaDon.MaHang = Hang.MaHang and HoaDon.MaNV = NhanVien.MaNV
select * from HoaDon
go

select sum(ThanhTien) as [Tổng] from HoaDon
go



drop table ChiTietHD
select * from KhachHang
go

create table ChiTietHD
(
	MaHD int,
	SoLuong int,
	ThanhTien int,
	constraint fk_CTHD_HD foreign key(MaHD) references HoaDon(MaHD)
)
go

select NgayBan, TenKH, TenHang, ChiTietHD.SoLuong, DonGia, ThanhTien 
from HoaDon, Hang,KhachHang, ChiTietHD 
where Hang.MaHang = HoaDon.MaHang and KhachHang.MaKH = HoaDon.MaKH and ChiTietHD.MaHD = HoaDon.MaHD
go

select sum(ThanhTien) from ChiTietHD
go

create trigger TGThanhTien
on ChiTietHD
for insert, update
as
	update ChiTietHD
	set ThanhTien = inserted.SoLuong * Hang.DonGia
	from inserted, Hang, HoaDon
	where inserted.MaHD= ChiTietHD.MaHD and HoaDon.MaHang = Hang.MaHang
go

drop trigger TGThanhTien
create proc LayHDTheoNgay 
@ngayban datetime
as
begin
	select TenHang, ChiTietHD.SoLuong, Hang.DonGia, NgayBan, TenKH, ThanhTien = ChiTietHD.SoLuong * DonGia from KhachHang, HoaDon,Hang, ChiTietHD where NgayBan = @ngayban and Hang.MaHang = HoaDon.MaHang and KhachHang.MaKH = HoaDon.MaKH
end
go
exec LayHDTheoNgay '1900-01-01 00:00:00.000'

insert into ChiTietHD
values (0,1,0),
		(1,2,0)
go

update ChiTietHD
set ThanhTien = SoLuong * Hang.DonGia
where HoaDon.MaHang = Hang.MaHang and 
select * from ChiTietHD


select DonGia from Hang, HoaDon, ChiTietHD where ChiTietHD.MaHD = HoaDon.MaHD and Hang.MaHang = HoaDon.MaHang and HoaDon.MaHD = 1
update Hang set TenHang = N'', SoLuong = 5, DonGiaNhap = 4, DonGiaBan = 4, GhiChu = N'' where MaHang = 1

select * from Hang where MaHang = '2'

select * from Hang where TenHang = N'Áo dù'
select * from KhachHang where TenNV = N'trung123'









