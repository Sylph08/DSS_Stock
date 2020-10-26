create database ChungKhoan
use ChungKhoan
--điền dữ liệu của bảng congty trước, bảng cophieu sau
create table congty
(
	IDcongty int identity primary key, --không phải điền
	tencty nvarchar(200) not null,
	LNST float not null, --lợi nhuận sau thuế (đv: nghìn đồng)
	luongCP float not null, -- lượng Cp phát hành 
	tongTS float not null,--Tổng tài sản (đv: nghìn đồng)
	vonCSH float not null--Vốn chủ sở hữu (đv: nghìn đồng)
)
create table Cophieu
(
	macp char(5) not null primary key, --mã giao dịch CP
	tenCP nvarchar(200), --tên CP
	giaCP float not null, --Giá cổ phiếu (đv: nghìn đồng)
	tilecotuc float not null, --0<tilecotuc<1
	IDcongty int not null, --kết nối với IDcongty của bảng congty
	constraint fk_IDcongty foreign key (IDcongty) references congty(IDcongty)
)


insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Ngân hàng TMCP Công Thương Việt Nam',6015000000,3723404556,1239556783000,81019441000)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Ngân hàng Thương mại cổ phần Đầu tư và Phát triển Việt Nam',3493000000,4022018040,1489957293000,74522544000)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Ngân hàng Thương mại Cổ phần Á Châu',3059000000,2161558460,383514439000,27765359000)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'CTCP Ống thép Việt Đức VG PIPE',10807978,42111589,1666855254,685034151)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Công ty Cổ phần Bao bì Nhựa Tân Tiến',33784998,13517770,1416392015,930422639)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Tổng CTCP Bưu chính Viettel',102645174,83047926,3855584836,1053336182)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Công ty cổ phần Tập đoàn FLC',-837830777,709997807,34289324096,10381568374)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Công ty cổ phần Tập đoàn Hòa Phát',2755561748,3313282659,112644200673,52580576274)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Ngân hàng Thương mại Cổ phần Việt Nam Thịnh Vượng',5265000000,2437748366,399473000000,42209742000)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Công ty Cổ phần Hoàng Anh Gia Lai',-64619759,927399283,40317639598,15977905176)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Công ty cổ phần Tập đoàn Quản lý Tài sản Trí Việt',43055960,43857725,1935887986,713933723)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Công ty Cổ phần Tập đoàn Hapaco',6645687,55471151,829705892,703831647)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Công ty Cổ phần Tập đoàn MaSan',54408000,1174683246,105003862000,31218283000)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Ngân hàng Thương mại Cổ phần Quân đội',4173000000,2773140752,421636000000,37997849000)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Công ty Cổ phần Dược phẩm Hà Nội',7889458,6290900,107088647,71993041)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Công ty Cổ phần Sông Đà 1',-569527,5000000,66233791,-90461142)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Công ty Cổ phần Tập đoàn Sao Mai',161277781,258867849,16308634656,6607871432)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Công ty TNHH Chứng khoán Ngân hàng Thương mại Cổ phần Ngoại thương Việt Nam',51974975,70000000,3553409041,1546522963)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Công ty cổ phần Gang thép Thái Nguyên',14906514,284000000,9775627709,1932144463)
insert into congty (tencty,LNST,luongCP,tongTS,vonCSH) values (N'Công ty Cổ phần FPT',1084221988,783905110,35912808664,17903725993)

insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('CTG',N'Cổ phiếu CTG',30.15,0.07,1)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('BID',N'Cổ phiếu BID',42.20,0.07,2)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('ACB',N'Cổ phiếu ACB',24.7,0.07,3)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('VGS',N'Cổ phiếu VGS',8.3,0.15,4)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('TTP',N'Cổ phiếu TTP',40.0,0.05,5)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('VTP',N'Cổ phiếu VTP',108.3,0.17,6)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('FLC',N'Cổ phiếu FLC',4.23,0.03,7)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('HPG',N'Cổ phiếu HPG',29.1,0.05,8)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('VPB',N'Cổ phiếu VPB',24.6,0.3,9)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('HAG',N'Cổ phiếu HAG',4.9,0.5,10)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('TVC',N'Cổ phiếu TVC',9.9,0.06,11)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('HAP',N'Cổ phiếu HAP',5.59,0.03,12)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('MSN',N'Cổ phiếu MSN',80.0,0.3,13)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('MBB',N'Cổ phiếu MBB',17.85,0.06,14)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('DHN',N'Cổ phiếu DHN',10.3,0.11,15)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('SD1',N'Cổ phiếu SD1',0.7,0.00,16)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('ASM',N'Cổ phiếu ASM',9.45,0.1,17)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('VCB',N'Cổ phiếu VCB',88.2,0.08,18)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('TIS',N'Cổ phiếu TIS',8.00,0.06,19)
insert into Cophieu(macp,tenCP,giaCP,tilecotuc,IDcongty) values ('FPT',N'Cổ phiếu FPT',53.2,0.1,20)