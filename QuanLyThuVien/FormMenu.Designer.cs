namespace QuanLyThuVien
{
    partial class FormMenu
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
            menuStrip1 = new MenuStrip();
            heThongToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            quảnLToolStripMenuItem = new ToolStripMenuItem();
            SachItem = new ToolStripMenuItem();
            DocGiaItem = new ToolStripMenuItem();
            NhanVienItem = new ToolStripMenuItem();
            MuonTraItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { heThongToolStripMenuItem, quảnLToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1052, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            heThongToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            heThongToolStripMenuItem.Size = new Size(85, 24);
            heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(160, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(160, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // quảnLToolStripMenuItem
            // 
            quảnLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SachItem, DocGiaItem, NhanVienItem, MuonTraItem });
            quảnLToolStripMenuItem.Name = "quảnLToolStripMenuItem";
            quảnLToolStripMenuItem.Size = new Size(93, 24);
            quảnLToolStripMenuItem.Text = "Chức năng";
            quảnLToolStripMenuItem.DropDownClosed += quảnLToolStripMenuItem_DropDownClosed;
            quảnLToolStripMenuItem.DropDownItemClicked += quảnLToolStripMenuItem_DropDownItemClicked;
            // 
            // SachItem
            // 
            SachItem.Name = "SachItem";
            SachItem.Size = new Size(224, 26);
            SachItem.Text = "Sách";
            // 
            // DocGiaItem
            // 
            DocGiaItem.Name = "DocGiaItem";
            DocGiaItem.Size = new Size(224, 26);
            DocGiaItem.Text = "Độc giả";
            // 
            // NhanVienItem
            // 
            NhanVienItem.Name = "NhanVienItem";
            NhanVienItem.Size = new Size(224, 26);
            NhanVienItem.Text = "Nhân viên";
            // 
            // MuonTraItem
            // 
            MuonTraItem.Name = "MuonTraItem";
            MuonTraItem.Size = new Size(224, 26);
            MuonTraItem.Text = "Mượn trả";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 517);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            Text = "FormMenu";
            Load += FormMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem heThongToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem quảnLToolStripMenuItem;
        private ToolStripMenuItem SachItem;
        private ToolStripMenuItem DocGiaItem;
        private ToolStripMenuItem NhanVienItem;
        private ToolStripMenuItem MuonTraItem;
    }
}
