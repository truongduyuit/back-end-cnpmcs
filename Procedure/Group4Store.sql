Alter table Xe
ADD Xe_BaoHiemTuNguyen int NULL
Alter table Xe
ADD FOREIGN KEY (Xe_BaoHiemTuNguyen) REFERENCES BaoHiem(Ma);

go
create Proc LOAIXE_Group4Search
@Ma int= NULL,
@LoaiXe_Ten nvarchar(50)=NULL
as
	select Ma, LoaiXe_Ten from LoaiXe
	where (@Ma is null or Ma = @Ma)
	and (@LoaiXe_Ten is null or LoaiXe_Ten = @LoaiXe_Ten)
GO

create Proc XE_Group4Search
@Ma int = NULL,
@Xe_Ten nvarchar(50) = NULL,
@Xe_LoaiXe int = NULL
as
begin
	SELECT Xe.Ma,Xe.Xe_Ma, Xe.Xe_Ten, Xe.Xe_Gia, Xe.Xe_Mau, Xe.Xe_Gia, LoaiXe.LoaiXe_Ten,
	LoaiXe.LoaiXe_Hang, DangKiem.DangKiem_NgayDangKiem, DangKiem.DangKiem_Phi,
	DKDuongBo.DKDuongBo_NgayDangKi, DKDuongBo.DKDuongBo_Phi,
	BaoHiemDanSu.BaoHiem_NgayDangKi as BaoHiemDanSu_NgayDangKi, BaoHiemDanSu.BaoHiem_Phi as BaoHiemDanSu_Phi,
	BaoHiemTuNguyen.BaoHiem_NgayDangKi as BaoHiemTuNguyen_NgayDangKi, BaoHiemTuNguyen.BaoHiem_Phi as BaoHiemTuNguyen_Phi
	FROM Xe 
	LEFT JOIN DangKiem ON (Xe.Xe_PhieuDangKiem = DangKiem.Ma)
	LEFT JOIN BaoHiem as BaoHiemDanSu ON (Xe.Xe_BaoHiem = BaoHiemDanSu.Ma)
	LEFT JOIN BaoHiem as BaoHiemTuNguyen ON (Xe.Xe_BaoHiemTuNguyen = BaoHiemTuNguyen.Ma)
	LEFT JOIN DKDuongBo ON (Xe.Xe_PhieuDKDuongBo = DKDuongBo.Ma)
	INNER JOIN LoaiXe ON (@Xe_LoaiXe is NULL or Xe.Xe_LoaiXe = @Xe_LoaiXe) and (Xe.Xe_LoaiXe = LoaiXe.Ma)
	WHERE (@Ma is NULL or Xe.Ma = @Ma) and (Xe.Xe_TrangThai <> 'X') and (@Xe_Ten is NULL or @Xe_Ten = '' or Xe_Ten Like '%' + @Xe_Ten + '%')
end