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
    public partial class FormMuonTra : Form
    {
        MuonTra_BUS muonTra_BUS = new MuonTra_BUS();
        public FormMuonTra()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra mã trước
                if (string.IsNullOrEmpty(txtMaMuonTra.Text))
                {
                    MessageBox.Show("Mã mượn trả đang trống! Vui lòng chọn dòng dữ liệu.");
                    return;
                }

                // 2. Gọi Form
                FormChiTiet frmChiTiet = new FormChiTiet(txtMaMuonTra.Text);
                frmChiTiet.ShowDialog();
            }
            catch (Exception ex)
            {
                // QUAN TRỌNG: Dòng này sẽ hiện ra lỗi cụ thể là gì
                MessageBox.Show("Lỗi khi mở form: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void FormMuonTra_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            dgvMuonTra.DataSource = muonTra_BUS.LoadMuonTra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MuonTra ob = new MuonTra();
            ob.maMuonTra = txtMaMuonTra.Text;
            ob.maNhanVien = Convert.ToString(cbbMaNhanVien.SelectedValue);
            ob.maDocGia = Convert.ToString(cbbMaDocGia.SelectedValue);
            ob.ngayMuon = dTPNgayMuon.Value;
            ob.ngayHenTra = dTPNgayTra.Value;
            ob.tienCoc = Convert.ToInt32(txtTienCoc.Text);
            muonTra_BUS.InsertMuonTra(ob);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maMuonTra = txtMaMuonTra.Text;

            MuonTra ob = new MuonTra();
            ob.maNhanVien = Convert.ToString(cbbMaNhanVien.SelectedValue);
            ob.maDocGia = Convert.ToString(cbbMaDocGia.SelectedValue);
            ob.ngayMuon = dTPNgayMuon.Value;
            ob.ngayHenTra = dTPNgayTra.Value;
            ob.tienCoc = Convert.ToInt32(txtTienCoc.Text);
            muonTra_BUS.UpdateMuonTra(maMuonTra, ob);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maMuonTra = txtMaMuonTra.Text;
            muonTra_BUS.DeleteMuonTra(maMuonTra);
        }

        private void dgvMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMuonTra.Rows[e.RowIndex];
                txtMaMuonTra.Text = row.Cells["MaMuonTra_HieuDT_3725_LTMT5"].Value.ToString();
                cbbMaNhanVien.Text = row.Cells["MaNhanVien_HieuDT_3725_LTMT5"].Value.ToString();
                cbbMaDocGia.Text = row.Cells["MaDocGia_HieuDT_3725_LTMT5"].Value.ToString();
                dTPNgayMuon.Value = Convert.ToDateTime(row.Cells["NgayMuon_HieuDT_3725_LTMT5"].Value);
                dTPNgayTra.Value = Convert.ToDateTime(row.Cells["NgayHenTra_HieuDT_3725_LTMT5"].Value);
                txtTienCoc.Text = row.Cells["TienCoc_HieuDT_3725_LTMT5"].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
