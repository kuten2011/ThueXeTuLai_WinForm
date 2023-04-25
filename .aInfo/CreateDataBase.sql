create database ThueXe
Go
use ThueXe
Go

create table Taikhoan(
	mataikhoan char(8) primary key,
	matkhau varchar(50),
	ten nvarchar(50),
	sodienthoai varchar(20),
	gioitinh char(10),
	email varchar(50),
	diachi nvarchar(200),
	chucvu char(20)
);

INSERT INTO Taikhoan VALUES ('AD0001', '123', 'KHANH', '0944799819', 'NAM', 'KHOAVO006@GMAIL.COM', 'LONG AN', 'Admin')
INSERT INTO Taikhoan VALUES ('MN0001', '123', 'KHANH', '0944799819', 'NAM', 'KHOAVO006@GMAIL.COM', 'LONG AN', 'Manager')
INSERT INTO Taikhoan VALUES ('ST0001', '123', 'KHOA', '0944799819', 'NAM', 'KHOAVO006@GMAIL.COM', 'LONG AN', 'Staff')
INSERT INTO Taikhoan VALUES ('ST0002', '123', 'DUONG', '0944799819', 'NAM', 'KHOAVO006@GMAIL.COM', 'LONG AN', 'Staff')
INSERT INTO Taikhoan VALUES ('ST0003', '123', 'DUY', '0944799819', 'NAM', 'KHOAVO006@GMAIL.COM', 'LONG AN', 'Staff')
INSERT INTO Taikhoan VALUES ('ST0004', '123', 'THUC', '0944799819', 'NAM', 'KHOAVO006@GMAIL.COM', 'LONG AN', 'Staff')
INSERT INTO Taikhoan VALUES ('ST0005', '123', 'KHANH', '0944799819', 'NAM', 'KHOAVO006@GMAIL.COM', 'LONG AN', 'Staff')


create table khachhang(
	makhachhang VARCHAR(20) PRIMARY KEY,
	tenkhachhang NVARCHAR(50),
	sodienthoai varchar(20),
	gioitinh nvarchar(10),
	email varchar(50),
	cccd varchar(20),
	diachi nvarchar(200),
);

INSERT INTO khachhang VALUES ('KH0001', N'VÕ NGUYỄN ANH KHOA', '0944799819', N'NAM', 'KHOAVO006@GMAIL.COM', '079203034133', N'ĐỨC HÒA - LONG AN')
INSERT INTO khachhang VALUES ('KH0002', N'LÊ HOÀNG THỨC', '0944799819', N'NAM', 'KHOAVO006@GMAIL.COM', '079203034133', N'QUẬN GÒ VẮP')
INSERT INTO khachhang VALUES ('KH0003', N'NGUYỄN NGỌC ANH DUY', '0944799819', N'NAM', 'KHOAVO006@GMAIL.COM', '079203034133', N'QUẬN 4')
INSERT INTO khachhang VALUES ('KH0004', N'NGUYỄN QUỐC KHÁNH', '0944799819', N'NAM', 'KHOAVO006@GMAIL.COM', '079203034133', N'QUẬN THỦ ĐỨC')
INSERT INTO khachhang VALUES ('KH0005', N'HÀ THỊ THÙY DƯƠNG', '0944799819', N'NỮU', 'KHOAVO006@GMAIL.COM', '079203034133', N'QUẬN 7')

CREATE TABLE chuxe (
	machuxe VARCHAR(20) PRIMARY KEY,
	tenchuxe NVARCHAR(50),
	sodienthoai varchar(20),
	gioitinh nvarchar(10),
	email varchar(50),
	cccd varchar(20),
	diachi nvarchar(200),
)

INSERT INTO chuxe VALUES ('CX0001', N'VÕ NGUYỄN ANH KHOA', '0944799819', N'NAM', 'KHOAVO006@GMAIL.COM', '079203034133', N'ĐỨC HÒA - LONG AN')
INSERT INTO chuxe VALUES ('CX0002', N'LÊ HOÀNG THỨC', '0944799819', N'NAM', 'KHOAVO006@GMAIL.COM', '079203034133', N'QUẬN GÒ VẮP')
INSERT INTO chuxe VALUES ('CX0003', N'HÀ THỊ THÙY DƯƠNG', '0944799819', N'NỮ', 'KHOAVO006@GMAIL.COM', '079203034133', N'QUẬN 7')
INSERT INTO chuxe VALUES ('CX0004', N'NGUYỄN NGỌC ANH DUY', '0944799819', N'NAM', 'KHOAVO006@GMAIL.COM', '079203034133', N'QUẬN 4')
INSERT INTO chuxe VALUES ('CX0005', N'NGUYỄN QUỐC KHÁNH', '0944799819', N'NAM', 'KHOAVO006@GMAIL.COM', '079203034133', N'QUẬN THỦ ĐỨC')

CREATE TABLE car (
	maxe VARCHAR(20) PRIMARY KEY,
	hangxe VARCHAR(50),
	tenxe VARCHAR(50),
	machuxe varchar(20),
	giathue int,
	biensoxe varchar(50),
	nhienlieu varchar(50), -- petrol, diesel, hybrid, electric
	hopso varchar(50), -- automatic, mannual, CVT, electric
	ngoaihinh varchar(10), -- good, very good, brandnew, fair, bad, verybad, damaged
	tinhtrang VARCHAR(50), -- available hay in-possession

	foreign key (machuxe) references chuxe(machuxe),
);

INSERT INto car VALUES ('X0001', 'HONDA','R15','CX0001',12000,'','','','','STILL')
INSERT INto car VALUES ('X0002', 'HONDA','R15','CX0002',129923,'','','','','STILL')
INSERT INto car VALUES ('X0003', 'HONDA','R15','CX0003',435235,'','','','','STILL')

Create table hoadon (
	mahoadon VarChar(20) PRIMARY KEY,
	manhanvien char(8),

	makhachhang varchar(20),
	nhanxe varchar(20),
	ngaythue Date,
	ngaytra Date,
	hinhthucthanhtoan varchar(20),
	tongtien int,

	foreign key (manhanvien) references Taikhoan(mataikhoan),
	foreign key (makhachhang) references khachhang(makhachhang),
);
INSERT INTO hoadon VALUES ('HD000132', 'ST0001', 'KH0001', '', '24/04/2023 12:00:00', '24/04/2023', '', 0)


CREATE TABLE CTHD (
	mahoadon varchar(20),
	maxe varchar(20),
	machuxe varchar(20),
	tenxe varchar(20),

	dongia int,

	FOREIGN KEY (mahoadon) REFERENCES hoadon(mahoadon),
	FOREIGN KEY (maxe) REFERENCES car(maxe),
);