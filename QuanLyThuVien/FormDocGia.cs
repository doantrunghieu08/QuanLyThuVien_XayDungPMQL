using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyThuVien
{
    public partial class FormDocGia : Form
    {
        DocGia_BUS docGia_BUS = new DocGia_BUS();
        public FormDocGia()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            dgvDocGia.DataSource = docGia_BUS.loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocGia ob = new DocGia();
            ob.ID = txtMaDocGia.Text;
            ob.Name = txtTenDocGia.Text.Trim();
            ob.SDT = txtSoDienThoai.Text.Trim();
            ob.email = txtEmail.Text.Trim();
            ob.diaChi = txtDiaChi.Text.Trim();
            docGia_BUS.InsertDocGia(ob);
            MessageBox.Show("Thêm thành công");
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maDocGia = txtMaDocGia.Text.Trim();
                DocGia ob = new DocGia();

                ob.Name = txtTenDocGia.Text.Trim();
                ob.SDT = txtSoDienThoai.Text.Trim();
                ob.email = txtEmail.Text.Trim();
                ob.diaChi = txtDiaChi.Text.Trim();

                docGia_BUS.UpdateDocGia(maDocGia, ob);
                MessageBox.Show("Sửa thành công");
                loadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maDocGia = txtMaDocGia.Text.Trim();
                docGia_BUS.DeleteDocGia(maDocGia);
                MessageBox.Show("Xóa thành công");
                loadData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0) { 
            
                DataGridViewRow row = dgvDocGia.Rows[e.RowIndex];
                txtMaDocGia.Text = row.Cells["MaDocGia_HieuDT_3725_LTMT5"].Value.ToString();
                txtTenDocGia.Text = row.Cells["TenDocGia_HieuDT_3725_LTMT5"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai_HieuDT_3725_LTMT5"].Value.ToString();
                txtEmail.Text = row.Cells["Email_HieuDT_3725_LTMT5"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi_HieuDT_3725_LTMT5"].Value.ToString();
            }
        }
    }
}
