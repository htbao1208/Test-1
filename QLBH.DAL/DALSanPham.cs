using Microsoft.Data.SqlClient;
using QLBH.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLBH.DAL
{
    public class DALSanPham : DBConnection
    {
        public DataTable loadSanPham()
        {
           try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from SanPham", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public bool TonTai(string maSP)
        {
            try
            {
                conn.Open();
                using SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE MaSP = @MaSP", conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kiểm tra sản phẩm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Thêm sản phẩm
        public int Them(DTOSanPham sp)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO SanPham (MaSP, TenSP, DVTinh, DonGia, MaLoai) " +
                             "VALUES (@MaSP, @TenSP, @DVTinh, @DonGia, @MaLoai)";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                cmd.Parameters.AddWithValue("@DVTinh", sp.DVTinh);
                cmd.Parameters.AddWithValue("@DonGia", sp.DonGia);
                cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoaiSP);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                throw new Exception("Mã sản phẩm đã tồn tại.");
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new Exception("Loại sản phẩm không tồn tại.");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm sản phẩm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Sửa sản phẩm (theo MaSP)
        public int Sua(DTOSanPham sp)
        {
            try
            {
                conn.Open();
                string sql = "UPDATE SanPham SET TenSP = @TenSP, DVTinh = @DVTinh, " +
                             "DonGia = @DonGia, MaLoai = @MaLoai WHERE MaSP = @MaSP";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                cmd.Parameters.AddWithValue("@DVTinh", sp.DVTinh);
                cmd.Parameters.AddWithValue("@DonGia", sp.DonGia);
                cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoaiSP);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new Exception("Loại sản phẩm không tồn tại.");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi sửa sản phẩm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Xóa sản phẩm
        public int Xoa(string maSP)
        {
            try
            {
                conn.Open();
                using SqlCommand cmd = new SqlCommand("DELETE FROM SanPham WHERE MaSP = @MaSP", conn);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new Exception("Không thể xóa: sản phẩm này đã được sử dụng ở bảng khác (ví dụ hóa đơn).");
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi xóa sản phẩm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Tìm kiếm theo mã hoặc tên sản phẩm
        public DataTable TimKiem(string tuKhoa)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM SanPham WHERE MaSP LIKE @kw OR TenSP LIKE @kw";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@kw", "%" + EscapeLike(tuKhoa) + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tìm kiếm sản phẩm: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        // Thoát các ký tự đặc biệt của LIKE: [ % _
        private static string EscapeLike(string s)
        {
            return s.Replace("[", "[[]").Replace("%", "[%]").Replace("_", "[_]");
        }
    }
}
