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
    public partial class FormChiTiet : Form
    {
        ChiTietPhieuMuon_BUS chiTietPhieuMuon = new ChiTietPhieuMuon_BUS();
        public FormChiTiet(string maPhieuMuon)
        {
            InitializeComponent();
            txtMaMuonTra.Text = maPhieuMuon;
            dTPNgayTra.Format = DateTimePickerFormat.Custom;
            dTPNgayTra.CustomFormat = "dd/MM/yyyy";
        }

        private void FormChiTiet_Load(object sender, EventArgs e)
        {
            try
            {
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu Form Con: " + ex.Message);
                this.Close(); // Nếu lỗi thì đóng form luôn cho gọn
            }
        }
        public void loadData()
        {
            dgvChiTiet.DataSource = chiTietPhieuMuon.loadChiTietPM(txtMaMuonTra.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChiTietMuonTra ob = new ChiTietMuonTra();
            ob.maMuonTra = txtMaMuonTra.Text;
            ob.maSach = Convert.ToString(cbbMaSach.SelectedValue);
            ob.ngayTra = dTPNgayTra.Value;
            ob.tienPhat = Convert.ToInt32(txtTienPhat.Text);
            ob.ghiChu = txtGhiChu.Text;
            chiTietPhieuMuon.InsertChiTietPM(ob);
            loadData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maMuonTra = txtMaMuonTra.Text;
            ChiTietMuonTra ob = new ChiTietMuonTra();

            ob.maSach = Convert.ToString(cbbMaSach.SelectedValue);
            ob.ngayTra = dTPNgayTra.Value;
            ob.tienPhat = Convert.ToInt32(txtTienPhat.Text);
            ob.ghiChu = txtGhiChu.Text;
            chiTietPhieuMuon.UpdateChiTietPM(ob, maMuonTra);
            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maMuonTra = txtMaMuonTra.Text;
            string maSach = Convert.ToString(cbbMaSach.SelectedValue);
            chiTietPhieuMuon.DeleteChiTietPM(maMuonTra, maSach);
            loadData();

        }
    }
}
