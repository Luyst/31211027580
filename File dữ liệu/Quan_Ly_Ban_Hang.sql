﻿

CREATE DATABASE Quan_Ly_Ban_Hang
Go

-----------------------------------------
Use Quan_Ly_Ban_Hang
GO

-----------------------------------------
CREATE TABLE ACCOUNT
(
id char(4) PRIMARY KEY,
DisplayName NVARCHAR(100) NOT NULL,
UserName VARCHAR(100) NOT NULL,
UserPass VARCHAR(100) NOT NULL,
TypeAcc int NOT NULL,
)
GO
--Tạo bảng loại hàng hóa----------------------------------------------
CREATE TABLE GoodsCategory
(
id char(2) primary key,
name Nvarchar(100) NOT NULL
)
GO
--Tạo bảng hàng hóa--------------------------------------------------------
CREATE TABLE GOODS
(
id char(4) PRIMARY KEY,
gName NVARCHAR(100) NOT NULL,
gType char(2) FOREIGN KEY REFERENCES GoodsCategory(id),
DVT NVARCHAR(6) ,
gPrice FLOAT NOT NULL,
)
GO

--Tạo bảng khách hảng------------------------------------------------------
CREATE TABLE CUSTOMER
(
id CHAR(6) PRIMARY KEY,
cName NVARCHAR(100) ,
cNumber VARCHAR(10) UNIQUE,
cPoint FLOAT DEFAULT 0,
)
GO

--Tạo bảng hóa đơn----------------------------------------------------------
CREATE TABLE BILL
(
id int identity PRIMARY KEY,
DateCheck DATE NOT NULL DEFAULT GETDATE(),
aID CHAR(4) FOREIGN KEY REFERENCES ACCOUNT(id),
CustomerID CHAR(6) FOREIGN KEY REFERENCES CUSTOMER(id) default '000000',
)
GO
--Tạo bảng thông tin hóa đơn------------------------------------------------
CREATE TABLE BILL_INFOR
(
id int identity ,
bID int FOREIGN KEY REFERENCES BILL(id),
gID CHAR(4) FOREIGN KEY REFERENCES GOODS(id),
quanlity INT NOT NULL DEFAULT 0,
CONSTRAINT PK_Bill_Infor PRIMARY KEY (gID,bID)
)
GO
-- INSERT dữ liệu tài khoản-------------------------------------
INSERT INTO ACCOUNT VALUES ('NV01',N'Đức Huy',N'NV01',N'1',0)
INSERT INTO ACCOUNT VALUES ('NV02',N'Thầy Tùng',N'NV02',N'2',0)
INSERT INTO ACCOUNT VALUES ('AD01',N'Admin 1',N'AD01',N'1',1)
INSERT INTO ACCOUNT VALUES ('AD02',N'Admin 2',N'AD02',N'2',1)

GO
-- INSERT dữ liệu loại sản phẩm---------------------------------
INSERT INTO GoodsCategory VALUES ('HM',N'HÀNG MÁT')
INSERT INTO GoodsCategory VALUES ('TM',N'TRÁNG MIỆNG')
INSERT INTO GoodsCategory VALUES ('NE',N'NEM, GIÒ, CHẢ')
INSERT INTO GoodsCategory VALUES ('DL',N'ĐÔNG LẠNH')
INSERT INTO GoodsCategory VALUES ('PH',N'THỨC PHẨM ĂN LIỀN')
INSERT INTO GoodsCategory VALUES ('RU',N'RƯỢU')
INSERT INTO GoodsCategory VALUES ('KE',N'KEM')
INSERT INTO GoodsCategory VALUES ('MY',N'MỲ ĂN LIỀN')
GO

-- INSERT dữ liệu hàng hóa------------------------------------------------------------------------------------------------------------------------------
INSERT INTO GOODS VALUES('HM01',N'Sữa chua uống men sống Việt Quất Tự nhiên TH True Yogurt  100ml T12',N'HM',N'Lốc',27600)
INSERT INTO GOODS VALUES('HM02',N'Sữa Chua Uống Tiệt Trùng Hương Cam Tự nhiên TH True Yogurt 180mlx48T T12 Thùng ',N'HM',N'Thùng',340000)
INSERT INTO GOODS VALUES('HM03',N'Sữa Chua Uống Tiệt Trùng Hương Dâu Tự nhiên TH True Yogurt 180ml T12 Thùng',N'HM',N'Thùng',340000)
INSERT INTO GOODS VALUES('HM04',N'Sữa Chua Uống Tiệt Trùng tiệt trùng Hương Việt Quất Tự nhiên TH True Yogurt 180ml T12 Thùng',N'HM',N'Thùng',340000)
INSERT INTO GOODS VALUES('HM05',N'Sữa chua uống Đà lạt chanh dây 200ml',N'HM',N'Chai',14300)
INSERT INTO GOODS VALUES('HM06',N'Bơ nhạt hộp President 250g',N'HM',N'Miếng',107000)
INSERT INTO GOODS VALUES('HM07',N'Bơ mặn President 200g',N'HM',N'Miếng',65500)
INSERT INTO GOODS VALUES('HM08',N'Bơ nhạt President 125g',N'HM',N'Miếng',43000)
INSERT INTO GOODS VALUES('HM09',N'Bơ mặn President 125g',N'HM',N'Miếng',43000)
INSERT INTO GOODS VALUES('HM10',N'Phô mai tươi HӦff - Hương Vị hạnh nhân 45gr L4 T8',N'HM',N'Lốc',26000)
INSERT INTO GOODS VALUES('HM11',N' Phomai CBC 8M vị cua biển nướng 120g T36',N'HM',N'Hộp',28200)
INSERT INTO GOODS VALUES('HM12',N' Phomai CBC 8M vị gà quay kiểu pháp 120g T36',N'HM',N'Hộp',28200)
INSERT INTO GOODS VALUES('HM13',N' Phomai bò cười 8M light VN 120g T36',N'HM',N'Hộp',37500)
INSERT INTO GOODS VALUES('TM01',N'Bánh bao An Phú chay 260g',N'TM',N'Túi',14200)
INSERT INTO GOODS VALUES('TM02',N'Bánh bao nhân thập cẩm 270g',N'TM',N'Túi',24000)
INSERT INTO GOODS VALUES('TM03',N'Bánh bao nhân xá xíu 270g',N'TM',N'Túi',24000)
INSERT INTO GOODS VALUES('TM04',N'Sữa chua nếp cẩm',N'TM',N'Hộp',7900)
INSERT INTO GOODS VALUES('NE01',N'Hoành thánh tôm thịt vissan 200g*40',N'NE',N'Gói',25000)
INSERT INTO GOODS VALUES('NE02',N'Chả nướng vissan 400g/gói*24',N'NE',N'Gói',63000)
INSERT INTO GOODS VALUES('NE03',N'Nem nướng vissan Nam Bộ 400g*22',N'NE',N'Gói',64500)
INSERT INTO GOODS VALUES('NE04',N'Giò bò 1kg Vissan ',N'NE',N'cây',193500)
INSERT INTO GOODS VALUES('NE05',N'Giò lụa 1kg Vissan ',N'NE',N'cây',167500)
INSERT INTO GOODS VALUES('NE06',N'Giò lụa đặc biệt 1kg Vissan ',N'NE',N'cây',169500)
INSERT INTO GOODS VALUES('NE07',N'Nem chua rán 400g',N'NE',N'Hộp',46700)
INSERT INTO GOODS VALUES('KE01',N'Kem Ốc Quế Socola Extra  78g *10',N'KE',N'Cây',18400)
INSERT INTO GOODS VALUES('KE02',N'Kem Ốc Quế Dâu Extra  78g*10',N'KE',N'Cây',18400)
INSERT INTO GOODS VALUES('KE03',N'Kem Ốc Quề Matcha Extra  78g*10',N'KE',N'Cây',18400)
INSERT INTO GOODS VALUES('KE04',N'Kem que khoai lang gạo lứt Merino X T40',N'KE',N'Que',9400)
INSERT INTO GOODS VALUES('KE05',N'Kem que yeah vani socola gạo lứt Merino T40',N'KE',N'Que',10500)
INSERT INTO GOODS VALUES('KE06',N'Kem que Yeah cacao lõi caramel Merino T40',N'KE',N'Que',10500)
INSERT INTO GOODS VALUES('KE07',N'Kem ốc quế Celano classic Khoai Môn-Dừa T16',N'KE',N'Que',15500)
INSERT INTO GOODS VALUES('DL01',N'Trứng cút bách hoa 360g',N'DL',N'Gói',63000)
INSERT INTO GOODS VALUES('DL02',N'Cá Hồng tẩm gia vị Thabifood 500g',N'DL',N'Túi',36500)
INSERT INTO GOODS VALUES('DL03',N'Bò viên Thabifood 200g',N'DL',N'Túi',32500)
INSERT INTO GOODS VALUES('DL04',N'Tôm viên Thabifood 200g',N'DL',N'Túi',28300)
INSERT INTO GOODS VALUES('DL05',N'Bò viên Thabifood 500g',N'DL',N'Túi',73700)
INSERT INTO GOODS VALUES('DL06',N'Tôm viên Thabifood 500g',N'DL',N'Túi',63500)
INSERT INTO GOODS VALUES('DL07',N'Hồ lô cá Thabifood 200g',N'DL',N'Túi',29500)
INSERT INTO GOODS VALUES('DL08',N'Cá Basa kho tộ Thabifood 300g',N'DL',N'Tộ',36500)
INSERT INTO GOODS VALUES('DL09',N'Cá Bống  kho tộ Thabifood 300g',N'DL',N'Tộ',43500)
INSERT INTO GOODS VALUES('DL10',N'Cá Cơm kho tiêu Thabifood 300g',N'DL',N'Tộ',39300)
INSERT INTO GOODS VALUES('DL11',N'Chạo cá  Minh Tiến 300g',N'DL',N'túi',33500)
INSERT INTO GOODS VALUES('DL12',N'Chả mực giã tay Quảng Ninh cc Minh Tiến 500g',N'DL',N'khay',159500)
INSERT INTO GOODS VALUES('DL13',N'Chả cá Thu cao cấp Minh Tiến 250g',N'DL',N'khay',48700)
INSERT INTO GOODS VALUES('DL14',N'Mực viên  Minh Tiến 200g',N'DL',N'khay',37500)
INSERT INTO GOODS VALUES('DL15',N'Chả hải sản Minh Tiến 200g',N'DL',N'túi',24000)
INSERT INTO GOODS VALUES('DL16',N'Chả cá ba sa viên Minh Tiến 200g',N'DL',N'túi',19700)
INSERT INTO GOODS VALUES('MY01',N'Mỳ Omachi sốt Spaghetti Bò 89g  T30 Thùng',N'MY',N'Thùng',185000)
INSERT INTO GOODS VALUES('MY02',N'Mì omachi tôm chua cay 5 sao có thịt 112g T24',N'MY',N'Hộp',15000)
INSERT INTO GOODS VALUES('MY03',N'Mì omachi sườn hầm ngũ quả có thịt 113g T24',N'MY',N'Hộp',15000)
INSERT INTO GOODS VALUES('MY04',N'Mì omachi xốt bò hầm có thịt 113g T24',N'MY',N'Hộp',15000)
INSERT INTO GOODS VALUES('MY05',N' Mì hảo hảo tôm xào chua ngọt 75g T30 Thùng',N'MY',N'Thùng',102000)
INSERT INTO GOODS VALUES('MY06',N'Mì cung đình cua bể rau răm (bát) 80g T12',N'MY',N'Bát',7500)
INSERT INTO GOODS VALUES('MY07',N'Mì cung đình sườn heo ( bát) 80g T12',N'MY',N'Bát',7500)
INSERT INTO GOODS VALUES('MY08',N'Mì cung đình lẩu tôm chua cay (bát) 80g T12',N'MY',N'Bát',7500)
INSERT INTO GOODS VALUES('MY09',N'Mì cung đình thịt hầm nấm (bát) 80g T12',N'MY',N'Bát',7500)
INSERT INTO GOODS VALUES('MY10',N'Mì cung đình bò hầm (bát) 80g T12',N'MY',N'Bát',7500)
INSERT INTO GOODS VALUES('MY11',N'Mì cung đình sườn hầm ngũ quả (bát) 80g T12',N'MY',N'Bát',7500)
INSERT INTO GOODS VALUES('MY12',N'Mì cung đình cua bể rau răm (ly) 80g T24',N'MY',N'Ly',5900)
INSERT INTO GOODS VALUES('MY13',N'Mì mum mum lẩu tôm chua cay 70g T30',N'MY',N'Gói',3000)
INSERT INTO GOODS VALUES('MY14',N'Mì gà nấm micoem 70g T30',N'MY',N'Gói',3200)
INSERT INTO GOODS VALUES('MY15',N'Mì cung đình cua bể rau răm 80g T30 Thùng',N'MY',N'Thùng',152000)
INSERT INTO GOODS VALUES('MY16',N'Mì cung đình sườn heo 80g T30 Thùng',N'MY',N'Thùng',152000)
INSERT INTO GOODS VALUES('MY17',N'Mì cung đình gà nấm 80g T30 Thùng',N'MY',N'Thùng',152000)
INSERT INTO GOODS VALUES('MY18',N'Mì cung đình lẩu tôm chua cay 80g T30 Thùng',N'MY',N'Thùng',152000)
INSERT INTO GOODS VALUES('MY19',N'Mì cung đình thịt hầm nấm 80g T30 Thùng',N'MY',N'Thùng',152000)
INSERT INTO GOODS VALUES('MY20',N'Mì cung đình bò hầm 80g T30 Thùng',N'MY',N'Thùng',152000)
INSERT INTO GOODS VALUES('MY21',N'Mì cung đình sườn hầm ngũ quả 80g T30 Thùng',N'MY',N'Thùng',152000)
INSERT INTO GOODS VALUES('MY22',N'Mì cung đình cua bể rau răm (bát) 80g T12 Thùng',N'MY',N'Thùng',88000)
INSERT INTO GOODS VALUES('MY23',N'Mì cung đình sườn heo ( bát) 80g T12 Thùng',N'MY',N'Thùng',88000)
INSERT INTO GOODS VALUES('MY24',N'Mì cung đình gà nấm (bát) 80g T12 Thùng',N'MY',N'Thùng',88000)
INSERT INTO GOODS VALUES('MY25',N'Mì cung đình lẩu tôm chua cay (bát) 80g T12 Thùng',N'MY',N'Thùng',88000)
INSERT INTO GOODS VALUES('MY26',N'Mì cung đình thịt hầm nấm (bát) 80g T12 Thùng',N'MY',N'Thùng',88000)
INSERT INTO GOODS VALUES('MY27',N'Mì cung đình bò hầm (bát) 80g T12 Thùng',N'MY',N'Thùng',88000)
INSERT INTO GOODS VALUES('MY28',N'Mì cung đình sườn hầm ngũ quả (bát) 80g T12 Thùng',N'MY',N'Thùng',88000)
INSERT INTO GOODS VALUES('MY29',N'Mì cung đình cua bể rau răm (ly) 80g T24 Thùng',N'MY',N'Thùng',139000)
INSERT INTO GOODS VALUES('MY30',N'Mì cung đình sườn heo ( ly) 80g T24 Thùng',N'MY',N'Thùng',139000)
INSERT INTO GOODS VALUES('MY31',N'Mì cung đình gà nấm (ly) 80g T24 Thùng',N'MY',N'Thùng',139000)
INSERT INTO GOODS VALUES('MY32',N'Mì cung đình lẩu tôm chua cay (ly) 80g T24 Thùng',N'MY',N'Thùng',139000)
INSERT INTO GOODS VALUES('MY33',N'Mì cung đình thịt hầm nấm (ly) 80g T24 Thùng',N'MY',N'Thùng',139000)
INSERT INTO GOODS VALUES('MY34',N'Mì cung đình bò hầm (ly) 80g T24 Thùng',N'MY',N'Thùng',139000)
INSERT INTO GOODS VALUES('MY35',N'Mì cung đình sườn hầm ngũ quả (ly) 80g T24 Thùng',N'MY',N'Thùng',139000)
INSERT INTO GOODS VALUES('MY36',N'Mì mum mum lẩu tôm chua cay 70g T30 Thùng',N'MY',N'Thùng',88000)
INSERT INTO GOODS VALUES('MY37',N'Mì gà nấm micoem 70g T30 Thùng',N'MY',N'Thùng',94000)
INSERT INTO GOODS VALUES('MY38',N'Mì cân micoem (kg) 15bánh/kg*10 Thùng',N'MY',N'Thùng',355000)
INSERT INTO GOODS VALUES('PH01',N'Phở bò phố cổ hà việt 76gr T12',N'PH',N'Bát',9600)
INSERT INTO GOODS VALUES('PH02',N'Cá ngừ sốt cà hộp HL 175g*48',N'PH',N'Hộp',18700)
INSERT INTO GOODS VALUES('PH03',N'Cá chiên sốt ớt HL 175g*48',N'PH',N'Hộp',18000)
INSERT INTO GOODS VALUES('PH04',N'Bò xay vissan 170g*72',N'PH',N'Hộp',24500)
INSERT INTO GOODS VALUES('RU01',N'Rượu Chivas regal 12yo 12*75cl 40% (restage) 750ml',N'RU',N'Chai',720000)
INSERT INTO GOODS VALUES('RU02',N'Rượu Chivas regal 18yo 6*75cl  750ml',N'RU',N'Chai',1550000)
INSERT INTO GOODS VALUES('RU03',N'Rượu Chivas regal 18yo Bluesignature 6*75cl 750ml',N'RU',N'Chai',1900000)
INSERT INTO GOODS VALUES('RU04',N'Rượu Salute 21yo 6*70CL 40% 700ml',N'RU',N'Chai',3500000)
INSERT INTO GOODS VALUES('RU05',N'Rượu Absolut vodka 12*75cl 750ml',N'RU',N'Chai',350000)
INSERT INTO GOODS VALUES('RU09',N'Rượu Wyndham bin 555 sz 12*75cl 750ml ',N'RU',N'Chai',560000)
INSERT INTO GOODS VALUES('RU10',N'Rượu Wyndham bin 888 cab merlot 12*75cl 750ml ',N'RU',N'Chai',560000)
INSERT INTO GOODS VALUES('RU11',N'Rượu Wyndham bin 999 merlot 12*75cl 750ml ',N'RU',N'Chai',560000)
INSERT INTO GOODS VALUES('RU12',N'Rượu Wyndham bin 868 cab sauv 12*75cl 750ml',N'RU',N'Chai',600000)
INSERT INTO GOODS VALUES('RU13',N'Rượu Wyndham bin 989 sz cab 12*75cl 750ml ',N'RU',N'Chai',590000)
INSERT INTO GOODS VALUES('RU14',N'Rượu Johnnie Walker Blue Label 75cl',N'RU',N'Chai',4500000)
INSERT INTO GOODS VALUES('RU15',N'Rượu Johnnie Walker XR 21 Leather box 75cl ',N'RU',N'Chai',2400000)
INSERT INTO GOODS VALUES('RU16',N'Rượu Johnnie Walker 18Y 75cl ',N'RU',N'Chai',1250000)
INSERT INTO GOODS VALUES('RU17',N'Rượu Johnnie Walker Gold Label Reserve-Gold bottle IBC 75cl ',N'RU',N'Chai',900000)
INSERT INTO GOODS VALUES('RU18',N'Rượu Johnnie Walker Gold Label Reserve 75cl ',N'RU',N'Chai',800000)
INSERT INTO GOODS VALUES('RU19',N'Rượu Johnnie Walker Double Black 75cl ',N'RU',N'Chai',800000)
INSERT INTO GOODS VALUES('RU20',N'Rượu Johnnie Walker Black Label 75cl ',N'RU',N'Chai',520000)
INSERT INTO GOODS VALUES('RU21',N'Rượu Johnnie Walker Red Label  75cl ',N'RU',N'Chai',300000)
INSERT INTO GOODS VALUES('RU22',N'Rượu Singleton 15yo 70cl',N'RU',N'Chai',1400000)
GO
-- INSERT dữ liệu khách hàng--------------------------------------------------------------------------------------------------------------------------
INSERT INTO CUSTOMER VALUES('000000',N'Chưa đăng ký thành viên',N'000000',0)
INSERT INTO CUSTOMER VALUES('027570',N'Lê Phước Bin',N'1211027570',N'4222760')
INSERT INTO CUSTOMER VALUES('027571',N'Bùi Thanh Bình',N'1211027571',N'5887892')
INSERT INTO CUSTOMER VALUES('023214',N'Nguyễn Thị Minh Diệu',N'1211023214',N'5035052')
INSERT INTO CUSTOMER VALUES('027574',N'Trần Thành Đạt',N'1211027574',N'591515')
INSERT INTO CUSTOMER VALUES('027575',N'Thân Trọng Đức',N'1211027575',N'1698070')
INSERT INTO CUSTOMER VALUES('023247',N'Lê Hải',N'1191023247',N'637372')
INSERT INTO CUSTOMER VALUES('023066',N'Lê Công Hiếu',N'1211023066',N'3374780')
INSERT INTO CUSTOMER VALUES('027580',N'Nguyễn Lương Đức Huy',N'1211027580',N'2444546')
INSERT INTO CUSTOMER VALUES('027581',N'Trần Lê Huy',N'1211027581',N'3085842')
INSERT INTO CUSTOMER VALUES('027582',N'Trương Nhựt Huy',N'1211027582',N'451141')
INSERT INTO CUSTOMER VALUES('027579',N'Nguyễn Trọng Hùng',N'1211027579',N'8297050')
INSERT INTO CUSTOMER VALUES('027584',N'Lê Bá Kha',N'1211027584',N'9908279')
INSERT INTO CUSTOMER VALUES('027591',N'Lương Tích Kim',N'1211027591',N'9667671')
INSERT INTO CUSTOMER VALUES('027202',N'Lê Đức Long',N'1211027202',N'3529462')
INSERT INTO CUSTOMER VALUES('025765',N'Dương Khả Minh',N'1211025765',N'9628164')
INSERT INTO CUSTOMER VALUES('027595',N'Nguyễn Đức Tuấn Minh',N'1211027595',N'8443601')
INSERT INTO CUSTOMER VALUES('027596',N'Nguyễn Thị Thúy Nga',N'1211027596',N'4610312')
INSERT INTO CUSTOMER VALUES('027598',N'Huỳnh Phương Thanh Phát',N'1211027598',N'5325924')
INSERT INTO CUSTOMER VALUES('027599',N'Lê Thành Phát',N'1211027599',N'9510705')
INSERT INTO CUSTOMER VALUES('027605',N'Nguyễn Hoàng Phước',N'1211027605',N'7476839')
INSERT INTO CUSTOMER VALUES('027606',N'Nguyễn Thanh Quang',N'1211027606',N'3182750')
INSERT INTO CUSTOMER VALUES('027608',N'Đào Trung Quân',N'1211027608',N'149718')
INSERT INTO CUSTOMER VALUES('027610',N'Trịnh Hữu Quân',N'1211027610',N'7910897')
INSERT INTO CUSTOMER VALUES('027294',N'Đỗ Thanh Sơn',N'1191027294',N'4537151')
INSERT INTO CUSTOMER VALUES('027611',N'Mai Công Sơn',N'1211027611',N'4686127')
INSERT INTO CUSTOMER VALUES('027612',N'Nguyễn Thành Tâm',N'1211027612',N'3711373')
INSERT INTO CUSTOMER VALUES('020489',N'Trần Thiện Tâm',N'3221020489',N'1599017')
INSERT INTO CUSTOMER VALUES('027613',N'Bùi Minh Tân',N'1211027613',N'3490762')
INSERT INTO CUSTOMER VALUES('025134',N'Lê Quốc Thịnh',N'1211025134',N'7518187')
INSERT INTO CUSTOMER VALUES('027618',N'Huỳnh Văn Tiến',N'1211027618',N'6903577')
INSERT INTO CUSTOMER VALUES('027619',N'Nguyễn Đặng Minh Toàn',N'1211027619',N'141203')
INSERT INTO CUSTOMER VALUES('027624',N'Trần Văn Tuấn',N'1211027624',N'1988562')
INSERT INTO CUSTOMER VALUES('027623',N'Võ Hoàng Tú',N'1211027623',N'6123895')
INSERT INTO CUSTOMER VALUES('027625',N'Lê Đình Nhất Vũ',N'1211027625',N'568302')
GO
--INSERT dữ liệu vào hóa đơn--------------------------------------------------------------------------------------------------------------------------
INSERT INTO BILL VALUES (N'05/01/2023',N'NV01',N'027570')
INSERT INTO BILL VALUES (N'05/01/2023',N'NV01',N'027571')
INSERT INTO BILL VALUES (N'05/02/2023',N'NV01',N'023214')
INSERT INTO BILL VALUES (N'05/02/2023',N'NV01',N'027574')
INSERT INTO BILL VALUES (N'05/03/2023',N'NV01',N'027575')
INSERT INTO BILL VALUES (N'05/03/2023',N'NV01',N'023247')
INSERT INTO BILL VALUES (N'05/04/2023',N'NV01',N'023066')
INSERT INTO BILL VALUES (N'05/04/2023',N'NV01',N'027580')
INSERT INTO BILL VALUES (N'05/05/2023',N'NV01',N'027581')
INSERT INTO BILL VALUES (N'05/05/2023',N'NV01',N'027582')
INSERT INTO BILL VALUES (N'05/06/2023',N'NV01',N'027579')
INSERT INTO BILL VALUES (N'05/06/2023',N'NV01',N'027584')
INSERT INTO BILL VALUES (N'05/07/2023',N'NV01',N'027591')
INSERT INTO BILL VALUES (N'05/07/2023',N'NV01',N'027202')
INSERT INTO BILL VALUES (N'05/08/2023',N'NV01',N'025765')
INSERT INTO BILL VALUES (N'05/08/2023',N'NV01',N'027595')
INSERT INTO BILL VALUES (N'05/09/2023',N'NV01',N'027596')
INSERT INTO BILL VALUES (N'05/09/2023',N'NV01',N'027598')
INSERT INTO BILL VALUES (N'05/10/2023',N'NV01',N'027599')
INSERT INTO BILL VALUES (N'05/10/2023',N'NV02',N'027605')
INSERT INTO BILL VALUES (N'05/11/2023',N'NV02',N'027606')
INSERT INTO BILL VALUES (N'05/11/2023',N'NV02',N'027608')
INSERT INTO BILL VALUES (N'05/12/2023',N'NV02',N'027610')
INSERT INTO BILL VALUES (N'05/12/2023',N'NV02',N'027294')
INSERT INTO BILL VALUES (N'05/13/2023',N'NV02',N'027611')
INSERT INTO BILL VALUES (N'05/13/2023',N'NV02',N'027612')
INSERT INTO BILL VALUES (N'05/14/2023',N'NV02',N'020489')
INSERT INTO BILL VALUES (N'05/14/2023',N'NV02',N'027613')
INSERT INTO BILL VALUES (N'05/15/2023',N'NV02',N'025134')
INSERT INTO BILL VALUES (N'05/15/2023',N'NV02',N'027618')
INSERT INTO BILL VALUES (N'05/16/2023',N'NV02',N'027619')
INSERT INTO BILL VALUES (N'05/16/2023',N'NV02',N'027624')
INSERT INTO BILL VALUES (N'05/17/2023',N'NV02',N'027623')
INSERT INTO BILL VALUES (N'05/17/2023',N'NV02',N'027625')
GO
--INSERT VÀO CHI TIẾT HÓA ĐƠN-------------------------------------------------------------------------------
INSERT INTO BILL_INFOR VALUES(1,'HM02','3')
INSERT INTO BILL_INFOR VALUES(1,'HM03','1')
INSERT INTO BILL_INFOR VALUES(1,'HM04','3')
INSERT INTO BILL_INFOR VALUES(1,'HM05','4')
INSERT INTO BILL_INFOR VALUES(1,'HM06','5')
INSERT INTO BILL_INFOR VALUES(2,'HM07','4')
INSERT INTO BILL_INFOR VALUES(2,'HM08','5')
INSERT INTO BILL_INFOR VALUES(2,'HM09','3')
INSERT INTO BILL_INFOR VALUES(2,'HM10','5')
INSERT INTO BILL_INFOR VALUES(3,'HM11','5')
INSERT INTO BILL_INFOR VALUES(3,'HM12','5')
INSERT INTO BILL_INFOR VALUES(3,'HM13','5')
INSERT INTO BILL_INFOR VALUES(3,'TM01','5')
INSERT INTO BILL_INFOR VALUES(3,'TM02','3')
INSERT INTO BILL_INFOR VALUES(4,'TM03','4')
INSERT INTO BILL_INFOR VALUES(4,'TM04','1')
INSERT INTO BILL_INFOR VALUES(4,'NE01','4')
INSERT INTO BILL_INFOR VALUES(4,'NE02','3')
INSERT INTO BILL_INFOR VALUES(4,'NE03','4')
INSERT INTO BILL_INFOR VALUES(4,'NE04','4')
INSERT INTO BILL_INFOR VALUES(5,'NE05','1')
INSERT INTO BILL_INFOR VALUES(5,'NE06','2')
INSERT INTO BILL_INFOR VALUES(5,'NE07','1')
INSERT INTO BILL_INFOR VALUES(5,'KE01','1')
INSERT INTO BILL_INFOR VALUES(5,'KE02','3')
INSERT INTO BILL_INFOR VALUES(5,'KE03','5')
INSERT INTO BILL_INFOR VALUES(6,'KE04','2')
INSERT INTO BILL_INFOR VALUES(6,'KE05','2')
INSERT INTO BILL_INFOR VALUES(6,'KE06','4')
INSERT INTO BILL_INFOR VALUES(6,'KE07','4')
INSERT INTO BILL_INFOR VALUES(6,'DL01','5')
INSERT INTO BILL_INFOR VALUES(7,'DL02','5')
INSERT INTO BILL_INFOR VALUES(7,'DL03','3')
INSERT INTO BILL_INFOR VALUES(7,'DL04','5')
INSERT INTO BILL_INFOR VALUES(7,'DL05','3')
INSERT INTO BILL_INFOR VALUES(7,'DL06','2')
INSERT INTO BILL_INFOR VALUES(8,'DL07','3')
INSERT INTO BILL_INFOR VALUES(8,'DL08','3')
INSERT INTO BILL_INFOR VALUES(8,'DL09','2')
INSERT INTO BILL_INFOR VALUES(8,'DL10','5')
INSERT INTO BILL_INFOR VALUES(9,'DL11','2')
INSERT INTO BILL_INFOR VALUES(9,'DL12','3')
INSERT INTO BILL_INFOR VALUES(9,'DL13','2')
INSERT INTO BILL_INFOR VALUES(9,'DL14','4')
INSERT INTO BILL_INFOR VALUES(10,'DL15','3')
INSERT INTO BILL_INFOR VALUES(10,'DL16','2')
INSERT INTO BILL_INFOR VALUES(10,'MY01','1')
INSERT INTO BILL_INFOR VALUES(10,'MY02','1')
INSERT INTO BILL_INFOR VALUES(10,'MY03','3')
INSERT INTO BILL_INFOR VALUES(10,'MY04','2')
INSERT INTO BILL_INFOR VALUES(11,'MY05','5')
INSERT INTO BILL_INFOR VALUES(11,'MY06','5')
INSERT INTO BILL_INFOR VALUES(11,'MY07','3')
INSERT INTO BILL_INFOR VALUES(11,'MY08','2')
INSERT INTO BILL_INFOR VALUES(11,'MY09','1')
INSERT INTO BILL_INFOR VALUES(11,'MY10','2')
INSERT INTO BILL_INFOR VALUES(11,'MY11','1')
INSERT INTO BILL_INFOR VALUES(11,'MY12','1')
INSERT INTO BILL_INFOR VALUES(12,'MY13','3')
INSERT INTO BILL_INFOR VALUES(12,'MY14','5')
INSERT INTO BILL_INFOR VALUES(12,'MY15','1')
INSERT INTO BILL_INFOR VALUES(12,'MY16','3')
INSERT INTO BILL_INFOR VALUES(12,'MY17','2')
INSERT INTO BILL_INFOR VALUES(12,'MY18','3')
INSERT INTO BILL_INFOR VALUES(13,'MY19','4')
INSERT INTO BILL_INFOR VALUES(13,'MY20','4')
INSERT INTO BILL_INFOR VALUES(13,'MY21','2')
INSERT INTO BILL_INFOR VALUES(13,'MY22','1')
INSERT INTO BILL_INFOR VALUES(13,'MY23','5')
INSERT INTO BILL_INFOR VALUES(13,'MY24','5')
INSERT INTO BILL_INFOR VALUES(13,'MY25','5')
INSERT INTO BILL_INFOR VALUES(13,'MY26','1')
INSERT INTO BILL_INFOR VALUES(13,'MY27','2')
INSERT INTO BILL_INFOR VALUES(13,'MY28','5')
INSERT INTO BILL_INFOR VALUES(14,'MY29','1')
INSERT INTO BILL_INFOR VALUES(14,'MY30','3')
INSERT INTO BILL_INFOR VALUES(14,'MY31','5')
INSERT INTO BILL_INFOR VALUES(14,'MY32','2')
INSERT INTO BILL_INFOR VALUES(14,'MY33','3')
INSERT INTO BILL_INFOR VALUES(14,'MY34','2')
INSERT INTO BILL_INFOR VALUES(14,'MY35','1')
INSERT INTO BILL_INFOR VALUES(14,'MY36','3')
INSERT INTO BILL_INFOR VALUES(15,'MY37','3')
INSERT INTO BILL_INFOR VALUES(15,'MY38','3')
INSERT INTO BILL_INFOR VALUES(15,'PH01','3')
INSERT INTO BILL_INFOR VALUES(15,'PH02','5')
INSERT INTO BILL_INFOR VALUES(15,'PH03','2')
INSERT INTO BILL_INFOR VALUES(15,'PH04','1')
INSERT INTO BILL_INFOR VALUES(15,'RU01','4')
INSERT INTO BILL_INFOR VALUES(16,'RU02','4')
INSERT INTO BILL_INFOR VALUES(16,'RU03','2')
INSERT INTO BILL_INFOR VALUES(16,'RU04','2')
INSERT INTO BILL_INFOR VALUES(16,'RU05','3')
INSERT INTO BILL_INFOR VALUES(16,'RU09','1')
INSERT INTO BILL_INFOR VALUES(16,'RU10','5')
INSERT INTO BILL_INFOR VALUES(17,'RU11','1')
INSERT INTO BILL_INFOR VALUES(17,'RU12','5')
INSERT INTO BILL_INFOR VALUES(18,'RU13','4')
INSERT INTO BILL_INFOR VALUES(18,'RU14','5')
INSERT INTO BILL_INFOR VALUES(19,'RU15','4')
INSERT INTO BILL_INFOR VALUES(19,'RU16','1')
INSERT INTO BILL_INFOR VALUES(20,'RU17','2')
INSERT INTO BILL_INFOR VALUES(20,'RU18','4')
INSERT INTO BILL_INFOR VALUES(20,'RU19','4')
INSERT INTO BILL_INFOR VALUES(20,'RU20','5')
INSERT INTO BILL_INFOR VALUES(21,'RU21','5')
INSERT INTO BILL_INFOR VALUES(21,'RU22','1')
INSERT INTO BILL_INFOR VALUES(22,'HM01','4')
INSERT INTO BILL_INFOR VALUES(22,'HM02','4')
INSERT INTO BILL_INFOR VALUES(22,'HM03','3')
INSERT INTO BILL_INFOR VALUES(22,'HM04','5')
INSERT INTO BILL_INFOR VALUES(22,'HM05','2')
INSERT INTO BILL_INFOR VALUES(22,'HM06','1')
INSERT INTO BILL_INFOR VALUES(22,'HM07','1')
INSERT INTO BILL_INFOR VALUES(23,'HM08','4')
INSERT INTO BILL_INFOR VALUES(23,'HM09','2')
INSERT INTO BILL_INFOR VALUES(23,'HM10','4')
INSERT INTO BILL_INFOR VALUES(23,'HM11','1')
INSERT INTO BILL_INFOR VALUES(24,'HM12','2')
INSERT INTO BILL_INFOR VALUES(24,'HM13','5')
INSERT INTO BILL_INFOR VALUES(24,'TM01','1')
INSERT INTO BILL_INFOR VALUES(24,'TM02','2')
INSERT INTO BILL_INFOR VALUES(24,'TM03','5')
INSERT INTO BILL_INFOR VALUES(24,'TM04','3')
INSERT INTO BILL_INFOR VALUES(25,'NE01','2')
INSERT INTO BILL_INFOR VALUES(25,'NE02','1')
INSERT INTO BILL_INFOR VALUES(25,'NE03','3')
INSERT INTO BILL_INFOR VALUES(25,'NE04','1')
INSERT INTO BILL_INFOR VALUES(25,'NE05','1')
INSERT INTO BILL_INFOR VALUES(25,'NE06','2')
INSERT INTO BILL_INFOR VALUES(26,'NE07','5')
INSERT INTO BILL_INFOR VALUES(26,'KE01','1')
INSERT INTO BILL_INFOR VALUES(26,'KE02','4')
INSERT INTO BILL_INFOR VALUES(27,'KE03','4')
INSERT INTO BILL_INFOR VALUES(28,'KE04','5')
INSERT INTO BILL_INFOR VALUES(29,'KE05','1')
INSERT INTO BILL_INFOR VALUES(30,'KE06','5')
INSERT INTO BILL_INFOR VALUES(31,'KE06','2')
INSERT INTO BILL_INFOR VALUES(32,'KE06','3')
GO
--#region Tạo procedure cho bảng account--------------------------------------------------------------------------------------------------------------------------
CREATE PROC USP_AccList
AS SELECT id,DisplayName as 'Nhân viên',UserName as 'Tên đăng nhập',TypeAcc as 'Loại' FROM ACCOUNT
GO

CREATE PROC USP_ChangePass
@username varchar(100),@newPass varchar(100)
AS UPDATE ACCOUNT SET UserPass=@newPass WHERE UserName=@username
GO
--#endregion-------------------------------------------------------------------------------------------------------------------------------------------------------
--#region Tạp procedure cho bảng Bill và Bill_Infor----------------------------------------------------------------------------------------------------------------
CREATE PROC USP_InsertBill
@aID char(04), @CusID char(6) NULL
AS
BEGIN
IF @CusID != NULL
	BEGIN
	INSERT INTO	BILL
				(
				DateCheck,
				aID,
				CustomerID
				)
	VALUES		(
				GETDATE(),
				@aID,
				@CusID
				)
END
ELSE
	BEGIN
	INSERT INTO	BILL
				(
				DateCheck,
				aID
				)
	VALUES		(
				GETDATE(),
				@aID
				)
	END
END

GO

CREATE PROC Insert_Bill_Infor
@BilID int, @gID char(4),@quanlity int
AS
BEGIN
	Insert into BILL_INFOR
	VALUES (@BilID,@gID,@quanlity)
END
GO

CREATE PROC USP_BillDoanhThu AS
SELECT BILL.id As 'Mã hóa đơn',ACCOUNT.DisplayName as 'Nhân viên',Customer.cName as 'Khách hàng',Bill.DateCheck as 'Ngày hóa đơn',Sum(BILL_INFOR.quanlity*GOODS.gPrice) as 'Thành tiền' FROM BILL,BILL_INFOR,GOODS,CUSTOMER,ACCOUNT
WHERE BILL.id=BILL_INFOR.bID and BILL_INFOR.gID=GOODS.id and BILL.aID=ACCOUNT.id and  BILL.CustomerID =Customer.id 
Group by Bill.id,CUSTOMER.cName,BILL.DateCheck,ACCOUNT.DisplayName,BILL.CustomerID
GO

CREATE PROC USP_BillReport AS
SELECT BILL.id ,ACCOUNT.DisplayName ,Customer.cName,Bill.DateCheck ,Sum(BILL_INFOR.quanlity*GOODS.gPrice) FROM BILL,BILL_INFOR,GOODS,CUSTOMER,ACCOUNT
WHERE BILL.id=BILL_INFOR.bID and BILL_INFOR.gID=GOODS.id and BILL.aID=ACCOUNT.id and  BILL.CustomerID =Customer.id 
Group by Bill.id,CUSTOMER.cName,BILL.DateCheck,ACCOUNT.DisplayName,BILL.CustomerID
GO
CREATE PROC USP_FindBillByDate
@date Date
AS
SELECT BILL.id,ACCOUNT.DisplayName as 'Nhân viên',Customer.cName as 'Khách hàng',Bill.DateCheck as 'Ngày hóa đơn',Sum(BILL_INFOR.quanlity*GOODS.gPrice) as 'Thành tiền'
FROM BILL,BILL_INFOR,GOODS,CUSTOMER,ACCOUNT
WHERE BILL.id=BILL_INFOR.bID and BILL_INFOR.gID=GOODS.id and BILL.aID=ACCOUNT.id and  BILL.CustomerID =Customer.id  and Bill.DateCheck=@date
Group by Bill.id,CUSTOMER.cName,BILL.DateCheck,ACCOUNT.DisplayName,BILL.CustomerID
GO
--#endregion----------------------------------------------------------------------------------------------------------------------------------------------------------------
--#region Tạo PROC cho bảng GOODS và GoodsCategory--------------------------------------------------------------------------------------------------------------------------
CREATE PROC USP_GetGoodsList
AS SELECT GOODS.id,gName as 'Tên sản phẩm',GoodsCategory.name as 'Loại',GOODS.DVT,GOODS.gPrice as 'Đơn giá'
FROM GOODS,GoodsCategory
Where GOODS.gType=GoodsCategory.id
GO
Create PROC USP_GetGoodsListByCategory
@CateName NVarChar(100)
AS SELECT GOODS.id,gName as 'Tên sản phẩm',GoodsCategory.name as 'Loại',GOODS.DVT,GOODS.gPrice as 'Đơn giá'
FROM GOODS,GoodsCategory
Where GOODS.gType=GoodsCategory.id and GoodsCategory.name like '%' +@CateName+ '%' 
GO
CREATE PROC USP_GetGood
@goodName nvarchar(100)
AS SELECT GOODS.id,gName as 'Tên sản phẩm',GoodsCategory.name as 'Loại',GOODS.DVT,GOODS.gPrice as 'Đơn giá'
FROM GOODS,GoodsCategory where gName=@goodName and GoodsCategory.id=gType
GO
CREATE PROC USP_GetGoodsListByGoodName
@goodname NVarChar(100)
AS SELECT GOODS.id,gName as 'Tên sản phẩm',GoodsCategory.name as 'Loại',GOODS.DVT,GOODS.gPrice as 'Đơn giá'
FROM GOODS,GoodsCategory
Where GOODS.gType=GoodsCategory.id and Goods.gName like '%' +@goodname+ '%'
GO
--#endregion------------------------------------------------------------------------------------------------------------------------
CREATE PROC USP_Order 
@billID int
AS
SELECT GOODS.id,GOODS.gName AS 'Tên sản phẩm',GOODS.DVT,GoodsCategory.name as 'Loại',BILL_INFOR.quanlity as 'Số lương',GOODS.gPrice as 'Đơn giá',BILL_INFOR.quanlity*GOODS.gPrice as 'Thành tiền'
FROM GoodsCategory,GOODS,BILL_INFOR
where BILL_INFOR.bID=@billID and BILL_INFOR.gID=GOODS.id and GOODS.gType=GoodsCategory.id
GO
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROC USP_TotalOrder
@bID int
as
Select Sum(BILL_INFOR.quanlity*GOODS.gPrice) as 'Thành tiền' from BILL_INFOR,GOODS Where GOODS.id=BILL_INFOR.gID and bID=@bId
GO
--------------------------------------------------------------------------------------------------------------------------
CREATE PROC USP_AddQuanlityOrder
@gID char(4), @quanlityADD int , @bID int
AS UPDATE BILL_INFOR SET quanlity = quanlity+@quanlityADD WHERE gID=@gID and bID=@bID
GO
--------------------------------------------------------------------------------------------------------------------------
CREATE PROC USP_DoanhThuPerson
@accID char(4)
AS SELECT SUM(BILL_INFOR.quanlity*GOODS.gPrice) as 'Thành tiền' 
FROM BILL_INFOR,GOODS,BILL 
Where GOODS.id=BILL_INFOR.gID and bID=BILL.id and BILL.aID=@accID
----------------------------------------------------------------------------------------------------------------------



