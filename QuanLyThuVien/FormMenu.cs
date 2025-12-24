namespace QuanLyThuVien
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void quảnLToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void quảnLToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form frm = new Form();
            switch (e.ClickedItem.Name)
            {
                case "SachItem":
                    FormSach formSach = new FormSach();
                    frm = formSach;
                    break;
                case "NhanVienItem":
                    FormNhanVien formNhanVien = new FormNhanVien();
                    frm = formNhanVien;
                    break;
                case "DocGiaItem":
                    FormDocGia formDocGia = new FormDocGia();   
                    frm = formDocGia;
                    break;

                case "MuonTraItem":
                    FormMuonTra formMuonTra = new FormMuonTra();
                    frm = formMuonTra;
                    break;
            }
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.BringToFront();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
