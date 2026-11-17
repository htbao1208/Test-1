using QLBH.BLL;
using QLBH.DTO;

namespace QLBH.GUI
{
    public partial class frmSanPham : Form
    {
        BLLSanPham bLLSanPham = new BLLSanPham();
        BLLLoaiSanPham bLLLoaiSanPham = new BLLLoaiSanPham();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            cboMaLoaiSP.DataSource = bLLLoaiSanPham.loadLoaiSanPham();
            cboMaLoaiSP.DisplayMember = "TenLoai";
            cboMaLoaiSP.ValueMember = "MaLoai";
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTenSP_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = bLLSanPham.loadSanPham();
        }

        // Lấy dữ liệu từ các ô nhập
        private DTOSanPham LayDuLieu()
        {
            DTOSanPham sp = new DTOSanPham();
            sp.MaSP = txtMaSP.Text.Trim();
            sp.TenSP = txtTenSP.Text.Trim();
            sp.DVTinh = txtDVTinh.Text.Trim();
            sp.DonGia = (int)nudDonGia.Value;
            sp.MaLoaiSP = cboMaLoaiSP.SelectedValue?.ToString() ?? "";
            return sp;
        }

        // Xóa trống các ô nhập
        private void ClearInput()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDVTinh.Clear();
            nudDonGia.Value = 0;
            txtMaSP.Focus();
        }


        private void dgvSanPham_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtMaSP.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            txtDVTinh.Text = dgvSanPham.CurrentRow.Cells["DVTinh"].Value.ToString();
            nudDonGia.Text = dgvSanPham.CurrentRow.Cells["DonGia"].Value.ToString();
            cboMaLoaiSP.SelectedValue = dgvSanPham.CurrentRow.Cells["MaLoai"].Value.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearInput();
            txtTimKiem.Clear();
            dgvSanPham.DataSource = bLLSanPham.loadSanPham();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                bLLSanPham.ThemSanPham(LayDuLieu());
                MessageBox.Show("Thêm thành công");
                dgvSanPham.DataSource = bLLSanPham.loadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bLLSanPham.SuaSanPham(LayDuLieu());
                MessageBox.Show("Cập nhật thành công");
                dgvSanPham.DataSource = bLLSanPham.loadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (kq == DialogResult.No)
            {
                return;
            }

            try
            {
                bLLSanPham.XoaSanPham(txtMaSP.Text);
                MessageBox.Show("Xóa thành công");
                ClearInput();
                dgvSanPham.DataSource = bLLSanPham.loadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSanPham.DataSource = bLLSanPham.TimKiem(txtTimKiem.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
