using QLBH.DAL;
using QLBH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLBH.BLL
{
    public class BLLSanPham
    {
        DALSanPham dAL = new DALSanPham();
        public DataTable loadSanPham()
        {
            return dAL.loadSanPham();

        }
        public void ThemSanPham(DTOSanPham sp)
        {
            KiemTraDuLieu(sp);
            if (dAL.TonTai(sp.MaSP))
            {
                throw new Exception("Mã sản phẩm '" + sp.MaSP + "' đã tồn tại.");
            }
            dAL.Them(sp);
        }

        public void SuaSanPham(DTOSanPham sp)
        {
            KiemTraDuLieu(sp);
            if (!dAL.TonTai(sp.MaSP))
            {
                throw new Exception("Không tìm thấy sản phẩm có mã '" + sp.MaSP + "' để sửa.");
            }
            dAL.Sua(sp);
        }

        public void XoaSanPham(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP))
            {
                throw new Exception("Vui lòng chọn sản phẩm cần xóa.");
            }
            if (dAL.Xoa(maSP.Trim()) == 0)
            {
                throw new Exception("Không tìm thấy sản phẩm có mã '" + maSP + "' để xóa.");
            }
        }

        public DataTable TimKiem(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                return dAL.loadSanPham();
            }
            return dAL.TimKiem(tuKhoa.Trim());
        }

        // Kiểm tra dữ liệu hợp lệ 
        private static void KiemTraDuLieu(DTOSanPham sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP))
                throw new Exception("Mã sản phẩm không được để trống.");
            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new Exception("Tên sản phẩm không được để trống.");
            if (string.IsNullOrWhiteSpace(sp.DVTinh))
                throw new Exception("Đơn vị tính không được để trống.");
            if (sp.DonGia < 0)
                throw new Exception("Đơn giá không được âm.");
            if (string.IsNullOrWhiteSpace(sp.MaLoaiSP))
                throw new Exception("Vui lòng chọn loại sản phẩm.");
        }
    }

}
