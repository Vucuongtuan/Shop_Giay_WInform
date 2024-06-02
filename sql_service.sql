create database Winform_service

create table SanPham
(
	MaSP int not null primary key identity(1000,1),
	TenSP nvarchar(50) not null,
	 MoTa nvarchar(max),
	 HinhAnh nvarchar(500) not null,
	 Gia varchar(20) not null,
	LoaiSP varchar(10),
	foreign key (LoaiSP) references LoaiSP(MaLoaiSP)
)

create table LoaiSP
(	
	MaLoaiSP varchar(10) not null primary key,
	TenLoaiSP nvarchar(50) not null
)
create table KhachHang
(
	MaKH nchar(10) not null primary key,
	TenKH nvarchar(50) not null,
	SoDienThoai varchar(20) not null,
	DiaChi nvarchar(250),
	Email nvarchar(50),
	GioiTinh nvarchar(10)
)

create table NhanVien
(
	MaNV int not null primary key identity(100,1),
	TenNV nvarchar(50) not null,
	SoDienThoai int not null, 
	Email nvarchar(100),
	Hinhanh nvarchar(500),
	NgaySinh datetime,
	GioiTinh nvarchar(10),
)



create table AccountKH
(	
	MaKH nchar(10) not null ,
	Pass char(10) ,
	foreign key (MaKH) references KhachHang(MaKH)
)

create table AccountAdmin
(
	MaNV int,
	Ten_TK nvarchar(50) ,
	Pass char(10),
	foreign key (MaNV) references NhanVien(MaNV)
)

create table DanhGia
(
	MaSP int not null,
	TenNguoiDG nvarchar(50) not null,
	DanhGiaSP ntext,
	foreign key (MaSP) references SanPham(MaSP),
)
create table HoaDon
(
    MaHD int not null primary key identity(10000, 1),
    NgayDat datetime not null,
	Soluong int not null,
    TongTien varchar(20) not null,
    MaKH nchar(10) not null,
	MaSP int not null,
    foreign key (MaKH) references KhachHang(MaKH),
	foreign key (MaSP) references SanPham(MaSP)
)

create table QuangCao 
(
id_QC int not null primary key identity(1,1),
nameQC nvarchar(50),
imgQC nvarchar(255)
)
alter table NhanVien
add constraint Uni_sdtnv unique (SoDienThoai)
alter table AccountAdmin
add constraint Uni_tknv unique (Ten_TK)

insert into KhachHang Values('10000',N'Nguyễn Phamh Thanh Vũ ','1231',N'TP.HCM','vu@gmail.com','Nam');
insert into KhachHang Values('10001',N'Chang Bá Vũ','123',N'Đài Loan','BaVu@gmail.com','Nam');
insert into KhachHang Values('10002',N'Vũ Tuấn Cường','123123',N'Nam Định','vucuongtuan00@gmail.com','Nam');
select * from KhachHang
select * from NhanVien
select * from AccountAdmin
select * from SanPham
select * from AccountKH
insert into AccountKH Values('10000',1231)
insert into AccountKH Values('10001',123)
insert into AccountKH Values('10002',123123)


insert into NhanVien Values('admin','111','admin@gmail.com','~/image/img1.png','03/23/2004','nam');
insert into AccountAdmin Values('107','admin','111')


select * , AccountAdmin.Ten_TK,AccountAdmin.Pass from NhanVien Inner Join AccountAdmin On NhanVien.MaNV = AccountAdmin.MaNV Where TenNV Like '%' + 'admin' +'%';
insert into LoaiSP values('SP1',N'Giầy Nike')
insert into LoaiSP values('SP2',N'Giầy Converse')

insert into DanhGia Values('1002',N'Cuong01','Good')

insert into SanPham Values('Nike Pegasus 40',
N'Một chuyến đi nhẹ nhàng cho bất kỳ cuộc chạy nào, cảm giác quen thuộc, chỉ dành cho bạn của Peg sẽ quay trở lại để giúp bạn hoàn thành mục tiêu của mình. Phiên bản này có cùng độ nhạy và hỗ trợ trung tính mà bạn yêu thích nhưng với sự thoải mái được cải thiện ở những vùng nhạy cảm của bàn chân, như vòm bàn chân và ngón chân. Cho dù bạn đang chạy cự ly marathon dài hàng dặm, chạy đua tốc độ trước khi mặt trời lặn hay nhảy vào một cuộc vui theo nhóm tự phát, đó vẫn là vận động viên chạy đường trường lâu đời mà bạn có thể đặt niềm tin, ngày này qua ngày khác, hết lần này đến lần khác.',
'Nike Pegasus 40.png','3,829,000','SP1')

Insert into SanPham (TenSP,MoTa,HinhAnh,Gia,LoaiSP) Values('Air Jordan 1 Low',
N'Luôn trong, luôn tươi. Air Jordan 1 Low mang đến cho bạn một phần lịch sử và di sản của Jordan thoải mái cả ngày. Chọn màu sắc của bạn, sau đó bước ra ngoài trong cấu hình mang tính biểu tượng được chế tạo bằng sự kết hợp các vật liệu cao cấp và lớp khí nén ở gót chân.',
'Air Jordan 1 Low.png','3,239,000','SP1')

Insert into SanPham (TenSP,MoTa,HinhAnh,Gia,LoaiSP) Values('Chuck 70 Canvas',
N'Năm 1970, Chuck Taylor All Star đã là một trong những đôi giày thể thao bóng rổ tốt nhất từ trước đến nay. Chuck 70 tôn vinh truyền thống này bằng cách kết hợp các chi tiết lấy cảm hứng từ truyền thống với công nghệ hiện đại để tạo sự thoải mái. Đệm OrthoLite ở đế trong và đường khâu trên lưỡi vạt giúp tăng cường sự thoải mái, trong khi đế giữa cò bóng thêm nét phong cách thập niên 70.',
'Chuck 70 C107X1.jpeg','4,239,000','SP2')

Select * From SanPham Join LoaiSP On SanPham.LoaiSP = LoaiSP.MaLoaiSP 
Select SanPham.LoaiSP,LoaiSP.MaLoaiSP,LoaiSP.TenLoaiSP From SanPham Join LoaiSP On SanPham.LoaiSP = LoaiSP.MaLoaiSP 
delete NhanVien Where MaNV='110'
Select * From HoaDon
Select * From KhachHang,AccountKH