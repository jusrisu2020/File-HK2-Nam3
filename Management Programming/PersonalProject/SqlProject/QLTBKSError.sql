--BoPhan --> FNhanVien
--NhaCungCap
--DanhMuc
--ChucVu
--NhanVien
--TaiKhoan
--HoaDonMuaTB
--ChiTietHDMuaTB
--ThietBi
--BaoCaoTBHong
--XuLyTB
--ChiTietXuLyTB
--PhieuBanGiao
USE TSTBKhachSan
------------------------Xử lí Load dữ liệu thiết bị trong từng bộ phận
--HoaDonMuaTB
--ChiTietHDMuaTB

--Form thiết bị -> Danhmuc
GO



SELECT * FROM dbo.BoPhan WHERE dbo.fuConvertToUnsign1(TenBP) LIKE N'%'+dbo.fuConvertToUnsign1(N'a')+'%'

DELETE dbo.TaiKhoan WHERE MaNV = N'NV02' OR MaNV = N'NV01'
DELETE dbo.NhanVien WHERE MaNV = N'NV04'
DELETE dbo.BoPhan WHERE MaBP = N'BP02'

SELECT * FROM dbo.TaiKhoan
SELECT * FROM dbo.NhanVien
SELECT * FROM dbo.BoPhan


DELETE dbo.TaiKhoan WHERE MaTK = 'TK06';
--DELETE BoPhan - NhanVien - TaiKhoan



