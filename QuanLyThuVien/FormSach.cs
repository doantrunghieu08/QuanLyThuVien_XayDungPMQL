using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAL;

namespace QuanLyThuVien
{


    public partial class FormSach : Form
    {
        Sach_BUS sach_bus = new Sach_BUS();

        public FormSach()
        {
            InitializeComponent();
        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            dgvSach.DataSource = sach_bus.LoadDataSach();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sach ob = new Sach();
            ob.maSach = txtMaSach.Text;
            ob.tenSach = txtTenSach.Text;
            ob.nhaXuatBan = txtNhaXuatBan.Text;
            ob.theLoai = txtTheLoai.Text;
            ob.tacGia = txtTacGia.Text;
            ob.namXuatBan = txtNamXuatBan.Text.Trim();
            sach_bus.InsertSach(ob);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells["MaSach_HieuDT_3725_LTMT5"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach_HieuDT_3725_LTMT5"].Value.ToString();
                txtNhaXuatBan.Text = row.Cells["NhaXuatBan_HieuDT_3725_LTMT5"].Value.ToString();
                txtNamXuatBan.Text = row.Cells["NamXuatBan_HieuDT_3725_LTMT5"].Value.ToString();
                txtTheLoai.Text = row.Cells["TheLoai_HieuDT_3725_LTMT5"].Value.ToString();
                txtTacGia.Text = row.Cells["TacGia_HieuDT_3725_LTMT5"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maSach = txtMaSach.Text;
                Sach ob = new Sach();
                ob.tenSach = txtTenSach.Text;
                ob.nhaXuatBan = txtNhaXuatBan.Text;
                ob.theLoai = txtTheLoai.Text;
                ob.tacGia = txtTacGia.Text;
                ob.namXuatBan = txtNamXuatBan.Text.Trim();
                sach_bus.UpdateSach(maSach, ob);
                MessageBox.Show("Sửa thành công");
                loadData();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maSach = txtMaSach.Text;
                sach_bus.DeleteSach(maSach);
                MessageBox.Show("Xóa thành công");
                loadData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
