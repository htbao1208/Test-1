namespace QLBH.GUI
{
    partial class frmSanPham
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboMaLoaiSP = new ComboBox();
            lbMaLoai = new Label();
            lbMaSP = new Label();
            lbTenSP = new Label();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            lbDVT = new Label();
            txtDVTinh = new TextBox();
            lbDonGia = new Label();
            nudDonGia = new NumericUpDown();
            groupBox1 = new GroupBox();
            btnLoad = new Button();
            btnSearch = new Button();
            txtTimKiem = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            btnReset = new Button();
            dgvSanPham = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudDonGia).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // cboMaLoaiSP
            // 
            cboMaLoaiSP.FormattingEnabled = true;
            cboMaLoaiSP.Location = new Point(489, 74);
            cboMaLoaiSP.Margin = new Padding(2, 3, 2, 3);
            cboMaLoaiSP.Name = "cboMaLoaiSP";
            cboMaLoaiSP.Size = new Size(124, 28);
            cboMaLoaiSP.TabIndex = 0;
            // 
            // lbMaLoai
            // 
            lbMaLoai.AutoSize = true;
            lbMaLoai.Location = new Point(430, 82);
            lbMaLoai.Margin = new Padding(2, 0, 2, 0);
            lbMaLoai.Name = "lbMaLoai";
            lbMaLoai.Size = new Size(62, 20);
            lbMaLoai.TabIndex = 1;
            lbMaLoai.Text = "Mã Loại";
            // 
            // lbMaSP
            // 
            lbMaSP.AutoSize = true;
            lbMaSP.Location = new Point(12, 33);
            lbMaSP.Margin = new Padding(2, 0, 2, 0);
            lbMaSP.Name = "lbMaSP";
            lbMaSP.Size = new Size(50, 20);
            lbMaSP.TabIndex = 2;
            lbMaSP.Text = "Mã SP";
            // 
            // lbTenSP
            // 
            lbTenSP.AutoSize = true;
            lbTenSP.Location = new Point(250, 33);
            lbTenSP.Margin = new Padding(2, 0, 2, 0);
            lbTenSP.Name = "lbTenSP";
            lbTenSP.Size = new Size(52, 20);
            lbTenSP.TabIndex = 3;
            lbTenSP.Text = "Tên SP";
            lbTenSP.Click += lbTenSP_Click;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(70, 27);
            txtMaSP.Margin = new Padding(2, 3, 2, 3);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(159, 27);
            txtMaSP.TabIndex = 4;
            txtMaSP.TextChanged += txtMaSP_TextChanged;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(303, 27);
            txtTenSP.Margin = new Padding(2, 3, 2, 3);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(310, 27);
            txtTenSP.TabIndex = 5;
            // 
            // lbDVT
            // 
            lbDVT.AutoSize = true;
            lbDVT.Location = new Point(12, 77);
            lbDVT.Margin = new Padding(2, 0, 2, 0);
            lbDVT.Name = "lbDVT";
            lbDVT.Size = new Size(37, 20);
            lbDVT.TabIndex = 6;
            lbDVT.Text = "ĐVT";
            // 
            // txtDVTinh
            // 
            txtDVTinh.Location = new Point(70, 74);
            txtDVTinh.Margin = new Padding(2, 3, 2, 3);
            txtDVTinh.Name = "txtDVTinh";
            txtDVTinh.Size = new Size(120, 27);
            txtDVTinh.TabIndex = 7;
            // 
            // lbDonGia
            // 
            lbDonGia.AutoSize = true;
            lbDonGia.Location = new Point(201, 82);
            lbDonGia.Margin = new Padding(2, 0, 2, 0);
            lbDonGia.Name = "lbDonGia";
            lbDonGia.Size = new Size(63, 20);
            lbDonGia.TabIndex = 8;
            lbDonGia.Text = "Đơn Giá";
            // 
            // nudDonGia
            // 
            nudDonGia.Location = new Point(261, 74);
            nudDonGia.Margin = new Padding(2, 3, 2, 3);
            nudDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudDonGia.Name = "nudDonGia";
            nudDonGia.Size = new Size(154, 27);
            nudDonGia.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnInsert);
            groupBox1.Controls.Add(cboMaLoaiSP);
            groupBox1.Controls.Add(lbMaLoai);
            groupBox1.Controls.Add(nudDonGia);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(lbDonGia);
            groupBox1.Controls.Add(lbMaSP);
            groupBox1.Controls.Add(txtDVTinh);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(lbDVT);
            groupBox1.Controls.Add(lbTenSP);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Location = new Point(10, 38);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(621, 217);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Group Sản phẩm";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(335, 126);
            btnLoad.Margin = new Padding(2, 3, 2, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(62, 28);
            btnLoad.TabIndex = 15;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(554, 172);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(62, 28);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(12, 172);
            txtTimKiem.Margin = new Padding(2, 3, 2, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(538, 27);
            txtTimKiem.TabIndex = 13;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(268, 126);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(62, 28);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(201, 126);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(62, 28);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(137, 126);
            btnInsert.Margin = new Padding(2, 3, 2, 3);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(62, 28);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(70, 126);
            btnReset.Margin = new Padding(2, 3, 2, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(62, 28);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(10, 261);
            dgvSanPham.Margin = new Padding(2, 3, 2, 3);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(621, 388);
            dgvSanPham.TabIndex = 11;
            dgvSanPham.CellClick += dgvSanPham_CellClick_1;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(640, 662);
            Controls.Add(dgvSanPham);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản Phẩm";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)nudDonGia).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
        }

        /*private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private ComboBox cboMaLoaiSP;
        private Label lbMaLoai;
        private Label lbMaSP;
        private Label lbTenSP;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private Label lbDVT;
        private TextBox txtDVTinh;
        private Label lbDonGia;
        private NumericUpDown nudDonGia;
        private GroupBox groupBox1;
        private Button btnReset;
        private Button btnSearch;
        private TextBox txtTimKiem;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridView dgvSanPham;
        private Button btnLoad;
    }
}
