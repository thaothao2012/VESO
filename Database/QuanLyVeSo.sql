drop database QuanLyVeSo
create database QuanLyVeSo
use QuanLyVeSo
create table DaiLy
(
	id int primary key identity(1,1),
	maDL varchar(15) not null unique,
	tenDL nvarchar(100) not null,
	diaChi nvarchar(100) not null,
	soDT varchar(15) not null,
	email varchar(50) not null,
	trangThai int not null
)
create table LoaiVeSo
(
	id int primary key identity(1,1),
	maLoaiVS varchar(15) not null unique,
	tenTinhThanh nvarchar(50) not null
)
create table PhieuPhatHanh
(
	id int primary key identity(1,1),
	maPhieuPhatHanh varchar(15) not null unique,
	daiLyId int,
	loaiVSId int,
	ngayPhatHanh date not null,
	soLuongPhatHanh int not null,
	soLuongBanDuoc int
)
create table PhieuDangKy
(
	id int primary key identity(1,1),
	maPhieuDK varchar(15) not null unique,
	daiLyId int,
	ngayDK date,
	soLuongDK int
)
create table PhieuThu
(
	id int primary key identity(1,1),
	maPhieuThu varchar(15) not null unique,
	daiLyId int,
	ngayThu date,
	tienThu int
)
create table GiaiThuong
(
	id int primary key identity(1,1),
	tenGiai nvarchar(50),
	tienThuong int
)
create table KetQuaXoSo
(
	id int primary key identity(1,1),
	loaiVSId int,
	ngayXo date,
	giaiId int,
	soTrung varchar(7)
)
create table CongNo
(
	id int primary key identity(1,1),
	daiLyId int,
	soTienBan int,
	hoaHong float default 0.1,
	ngayNo date,
	soTienNo int
)
create table GiaVeSo
(
	id int primary key identity(1,1),
	gia int,
	ngayBatDau date,/*ngay bat dau ap dung*/
	ngayKetThuc date,/*ngay ket thuc ap dung*/
	trangThai int /*1 dang ap dung, 0 het ap dung*/
)

alter table PhieuPhatHanh add constraint pph_dl_fk foreign key (daiLyId) references DaiLy(id)
--alter table PhieuPhatHanh drop constraint lvs_dl_fk
alter table PhieuPhatHanh add constraint pph_lvs_fk foreign key (loaiVSId) references LoaiVeSo(id)
----
alter table PhieuDangKy add constraint pdk_dl_fk foreign key (daiLyId) references DaiLy(id)
----
alter table PhieuThu add constraint pt_dl_fk foreign key (daiLyId) references DaiLy(id)
----
alter table CongNo add constraint cn_dl_fk foreign key (daiLyId) references DaiLy(id)
----
alter table KetQuaXoSo add constraint kqxs_lvs_fk foreign key (loaiVSId) references LoaiVeSo(id)
----
alter table KetQuaXoSo add constraint kqxs_g_fk foreign key (giaiId) references GiaiThuong(id)
