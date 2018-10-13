---new database Thinh
create  database QuanLyVeSo
use QuanLyVeSo
create table DaiLy
(
	MaDaiLy varchar(15),
	TenDaiLy nvarchar(100) not null,
	DiaChi nvarchar(100) not null,
	SoDienThoai varchar(15) not null,
	Email varchar(50) not null,
	TrangThai int not null,
	primary key(MaDaiLy)
)
create table LoaiVeSo
(
	MaLoaiVeSo varchar(15),
	TenTinhThanh nvarchar(50) not null,
	primary key(MaLoaiVeSo)
)
create  table PhieuPhatHanh
(
	MaPhieuPhatHanh int primary key identity(1,1) ,
	MaDaiLy varchar(15),
	MaLoaiVeSo varchar(15),
	NgayPhatHanh date not null,
	SoLuongPhatHanh int not null,
	SoLuongBanDuoc int
)
create table PhieuDangKy
(
	MaPhieuDangKy int primary key identity(1,1) ,
	MaDaiLy varchar(15),
	NgayDangKy date,
	SoLuongDangKy int
)
create table PhieuThu
(
	MaPhieuThu int primary key identity(1,1) ,
	MaDaiLy varchar(15),
	NgayThu date,
	TienThu int
)
create table GiaiThuong
(
	MaGiaiThuong varchar(15),
	TenGiai nvarchar(50),
	TienThuong int,
	primary key(MaGiaiThuong)
)
create table KetQuaXoSo
(
	MaKetQuaXoSo int primary key identity(1,1),
	MaLoaiVeSo varchar(15),
	MaGiaiThuong varchar(15),
	NgayXo date,
	SoTrung varchar(7)
)
create table CongNo
(
	MaCongNo int primary key identity(1,1),
	MaDaiLy varchar(15),
	SoTienBan int,
	HoaHong float default 0.1,
	NgayNo date,
	SoTienNo int
)
create table GiaVeSo
(
	MaGia int primary key identity(1,1),
	Gia int,
	NgayBatDau date,/*ngay bat dau ap dung*/
	NgayKetThuc date,/*ngay ket thuc ap dung*/
	TrangThai int /*1 dang ap dung, 0 het ap dung*/
)

alter table PhieuPhatHanh add constraint pph_dl_fk foreign key (MaDaiLy) references DaiLy(MaDaiLy)
--alter table PhieuPhatHanh drop constraint lvs_dl_fk
alter table PhieuPhatHanh add constraint pph_lvs_fk foreign key (MaLoaiVeSO) references LoaiVeSo(MaLoaiVeSO)
----
alter table PhieuDangKy add constraint pdk_dl_fk foreign key (MaDaiLy) references DaiLy(MaDaiLy)
----
alter table PhieuThu add constraint pt_dl_fk foreign key (MaDaiLy) references DaiLy(MaDaiLy)
----
alter table CongNo add constraint cn_dl_fk foreign key (MaDaiLy) references DaiLy(MaDaiLy)
----
alter table KetQuaXoSo add constraint kqxs_lvs_fk foreign key (MaLoaiVeSo) references LoaiVeSo(MaLoaiVeSo)
----
alter table KetQuaXoSo add constraint kqxs_g_fk foreign key (MaGiaiThuong) references GiaiThuong(MaGiaiThuong)
