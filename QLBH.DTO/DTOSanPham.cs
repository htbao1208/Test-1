using System;
using System.Collections.Generic;
using System.Text;

namespace QLBH.DTO
{
    public class DTOSanPham
    {
        public string MaSP { get; set; } = "";
        public string TenSP { get; set; } = "";
        public string DVTinh { get; set; } = "";
        public string LoaiSP { get; set; } = "";
        public int DonGia { get; set; } = 0;
        public string MaLoaiSP { get; set; } = "";
        public DTOSanPham()
        {

        }
        public DTOSanPham(string maSP, string tenSP, string dVTinh, string loaiSP, int donGia)
        {
            if (string.IsNullOrEmpty(maSP))
            {
                throw new ArgumentException("Mã sản phẩm không được để trống.", nameof(maSP));
            }
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.DVTinh = dVTinh;
            this.LoaiSP = loaiSP;
            this.DonGia = donGia;
        }
    }
}
