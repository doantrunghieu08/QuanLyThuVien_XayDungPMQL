namespace QuanLyThuVien
{
    partial class FormNhanVien
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
            panel3 = new Panel();
            panel4 = new Panel();
            txtMaNhanVien = new TextBox();
            txtTenNhanVien = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtSoDienThoai = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            dgvNhanVien = new DataGridView();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1046, 554);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtMaNhanVien);
            panel4.Controls.Add(txtTenNhanVien);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(txtDiaChi);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtSoDienThoai);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 98);
            panel4.Name = "panel4";
            panel4.Size = new Size(1046, 226);
            panel4.TabIndex = 16;
            panel4.Paint += panel4_Paint;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(216, 34);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(202, 27);
            txtMaNhanVien.TabIndex = 2;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(216, 75);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(202, 27);
            txtTenNhanVien.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(300, 131);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 13;
            label8.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(603, 34);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(603, 75);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(202, 27);
            txtDiaChi.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(528, 82);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 11;
            label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(537, 41);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 10;
            label5.Text = "Email";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(419, 124);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(202, 27);
            txtSoDienThoai.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 82);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 9;
            label4.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 41);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 8;
            label3.Text = "Mã nhân viên";
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
            tableLayoutPanel2.Location = new Point(0, 324);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1046, 56);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(867, 13);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 18;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(83, 13);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Thêm ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(605, 13);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 17;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(344, 13);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvNhanVien);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 380);
            panel2.Name = "panel2";
            panel2.Size = new Size(1046, 174);
            panel2.TabIndex = 3;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 0);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(1046, 174);
            dgvNhanVien.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 98);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(419, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(269, 92);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(248, 38);
            label1.TabIndex = 0;
            label1.Text = "Quản lý nhân viên";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(44, 46);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 1;
            label2.Text = "HieuDT-CD233725-LTMT5";
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 554);
            Controls.Add(panel3);
            Name = "FormNhanVien";
            Text = "FormNhanVien";
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private DataGridView dgvNhanVien;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button4;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panel4;
        private TextBox txtMaNhanVien;
        private TextBox txtTenNhanVien;
        private Label label8;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private Label label6;
        private Label label5;
        private TextBox txtSoDienThoai;
        private Label label4;
        private Label label3;
    }
}