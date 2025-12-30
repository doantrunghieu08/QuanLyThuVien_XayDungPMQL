namespace QuanLyThuVien
{
    partial class FormChiTiet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtGhiChu = new RichTextBox();
            label7 = new Label();
            txtTienPhat = new TextBox();
            label3 = new Label();
            dTPNgayTra = new DateTimePicker();
            label6 = new Label();
            cbbMaSach = new ComboBox();
            label4 = new Label();
            txtMaMuonTra = new TextBox();
            label5 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel4 = new Panel();
            dgvChiTiet = new DataGridView();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1072, 644);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1072, 644);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 98);
            panel5.Name = "panel5";
            panel5.Size = new Size(1072, 285);
            panel5.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.2688828F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.73112F));
            tableLayoutPanel3.Controls.Add(txtGhiChu, 1, 4);
            tableLayoutPanel3.Controls.Add(label7, 0, 4);
            tableLayoutPanel3.Controls.Add(txtTienPhat, 1, 3);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(dTPNgayTra, 1, 2);
            tableLayoutPanel3.Controls.Add(label6, 0, 3);
            tableLayoutPanel3.Controls.Add(cbbMaSach, 1, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 1);
            tableLayoutPanel3.Controls.Add(txtMaMuonTra, 1, 0);
            tableLayoutPanel3.Controls.Add(label5, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(1072, 285);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Anchor = AnchorStyles.Left;
            txtGhiChu.Location = new Point(338, 231);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(250, 51);
            txtGhiChu.TabIndex = 5;
            txtGhiChu.Text = "";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(274, 246);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 5;
            label7.Text = "Ghi chú";
            // 
            // txtTienPhat
            // 
            txtTienPhat.Anchor = AnchorStyles.Left;
            txtTienPhat.Location = new Point(338, 186);
            txtTienPhat.Name = "txtTienPhat";
            txtTienPhat.Size = new Size(250, 27);
            txtTienPhat.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(237, 18);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã mượn trả";
            // 
            // dTPNgayTra
            // 
            dTPNgayTra.Anchor = AnchorStyles.Left;
            dTPNgayTra.Format = DateTimePickerFormat.Custom;
            dTPNgayTra.Location = new Point(338, 129);
            dTPNgayTra.Name = "dTPNgayTra";
            dTPNgayTra.Size = new Size(250, 27);
            dTPNgayTra.TabIndex = 3;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(261, 189);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 4;
            label6.Text = "Tiền phạt";
            // 
            // cbbMaSach
            // 
            cbbMaSach.Anchor = AnchorStyles.Left;
            cbbMaSach.FormattingEnabled = true;
            cbbMaSach.Location = new Point(338, 71);
            cbbMaSach.Name = "cbbMaSach";
            cbbMaSach.Size = new Size(250, 28);
            cbbMaSach.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(269, 75);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã sách";
            // 
            // txtMaMuonTra
            // 
            txtMaMuonTra.Anchor = AnchorStyles.Left;
            txtMaMuonTra.Location = new Point(338, 15);
            txtMaMuonTra.Name = "txtMaMuonTra";
            txtMaMuonTra.ReadOnly = true;
            txtMaMuonTra.Size = new Size(250, 27);
            txtMaMuonTra.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(262, 132);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 3;
            label5.Text = "Ngày trả ";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(button4, 3, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 383);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1072, 56);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(891, 13);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 18;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(87, 13);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Thêm ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(623, 13);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 17;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(355, 13);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvChiTiet);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 439);
            panel4.Name = "panel4";
            panel4.Size = new Size(1072, 205);
            panel4.TabIndex = 6;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.Location = new Point(0, 0);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.Size = new Size(1072, 205);
            dgvChiTiet.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1072, 98);
            panel3.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(428, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(250, 92);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 8);
            label1.Name = "label1";
            label1.Size = new Size(117, 38);
            label1.TabIndex = 0;
            label1.Text = "Chi tiết ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(34, 46);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 1;
            label2.Text = "HieuDT-CD233725-LTMT5";
            // 
            // FormChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 644);
            Controls.Add(panel1);
            Name = "FormChiTiet";
            Text = "FormChiTiet";
            Load += FormChiTiet_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Panel panel4;
        private DataGridView dgvChiTiet;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button4;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panel5;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtMaMuonTra;
        private ComboBox cbbMaSach;
        private DateTimePicker dTPNgayTra;
        private TextBox txtTienPhat;
        private RichTextBox txtGhiChu;
    }
}