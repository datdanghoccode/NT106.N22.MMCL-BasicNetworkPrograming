namespace Lab1_21520695
{
    partial class Bai4
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
            this.lbSoTienCanDoi = new System.Windows.Forms.Label();
            this.lbSoTienDaDoi = new System.Windows.Forms.Label();
            this.btnChuyenDoi = new System.Windows.Forms.Button();
            this.txtNhapSoTien = new System.Windows.Forms.TextBox();
            this.txtKetQuaQuyDoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLoaiTien = new System.Windows.Forms.ComboBox();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSoTienCanDoi
            // 
            this.lbSoTienCanDoi.AutoSize = true;
            this.lbSoTienCanDoi.Location = new System.Drawing.Point(30, 104);
            this.lbSoTienCanDoi.Name = "lbSoTienCanDoi";
            this.lbSoTienCanDoi.Size = new System.Drawing.Size(108, 20);
            this.lbSoTienCanDoi.TabIndex = 0;
            this.lbSoTienCanDoi.Text = "Số tiền cần đổi";
            // 
            // lbSoTienDaDoi
            // 
            this.lbSoTienDaDoi.AutoSize = true;
            this.lbSoTienDaDoi.Location = new System.Drawing.Point(30, 292);
            this.lbSoTienDaDoi.Name = "lbSoTienDaDoi";
            this.lbSoTienDaDoi.Size = new System.Drawing.Size(102, 20);
            this.lbSoTienDaDoi.TabIndex = 1;
            this.lbSoTienDaDoi.Text = "Số tiền đã đổi";
            // 
            // btnChuyenDoi
            // 
            this.btnChuyenDoi.Location = new System.Drawing.Point(30, 188);
            this.btnChuyenDoi.Name = "btnChuyenDoi";
            this.btnChuyenDoi.Size = new System.Drawing.Size(325, 29);
            this.btnChuyenDoi.TabIndex = 3;
            this.btnChuyenDoi.Text = "Chuyển đổi";
            this.btnChuyenDoi.UseVisualStyleBackColor = true;
            this.btnChuyenDoi.Click += new System.EventHandler(this.btnChuyenDoi_Click);
            // 
            // txtNhapSoTien
            // 
            this.txtNhapSoTien.Location = new System.Drawing.Point(151, 101);
            this.txtNhapSoTien.Name = "txtNhapSoTien";
            this.txtNhapSoTien.Size = new System.Drawing.Size(204, 27);
            this.txtNhapSoTien.TabIndex = 4;
            this.txtNhapSoTien.Validated += new System.EventHandler(this.txtNhapSoTien_Validated);
            // 
            // txtKetQuaQuyDoi
            // 
            this.txtKetQuaQuyDoi.Location = new System.Drawing.Point(151, 285);
            this.txtKetQuaQuyDoi.Name = "txtKetQuaQuyDoi";
            this.txtKetQuaQuyDoi.Size = new System.Drawing.Size(204, 27);
            this.txtKetQuaQuyDoi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(77, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "1 USD = 22,772 VND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chuyển đổi tiền tệ";
            // 
            // cbLoaiTien
            // 
            this.cbLoaiTien.FormattingEnabled = true;
            this.cbLoaiTien.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "SGD",
            "JPY"});
            this.cbLoaiTien.Location = new System.Drawing.Point(375, 101);
            this.cbLoaiTien.Name = "cbLoaiTien";
            this.cbLoaiTien.Size = new System.Drawing.Size(151, 28);
            this.cbLoaiTien.TabIndex = 8;
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao.Location = new System.Drawing.Point(152, 136);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(149, 20);
            this.lbThongBao.TabIndex = 9;
            this.lbThongBao.Text = "Vui lòng nhập số tiền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(30, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 215);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tỷ giá quy đổi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(75, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "1 JPY = 214 VND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(75, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "1 SGD = 17,286 VND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "1 GBP = 31,538 VND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "1 EUR = 28,132 VND";
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.cbLoaiTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKetQuaQuyDoi);
            this.Controls.Add(this.txtNhapSoTien);
            this.Controls.Add(this.btnChuyenDoi);
            this.Controls.Add(this.lbSoTienDaDoi);
            this.Controls.Add(this.lbSoTienCanDoi);
            this.Name = "Bai4";
            this.Text = "Bai4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSoTienCanDoi;
        private Label lbSoTienDaDoi;
        private Button btnChuyenDoi;
        private TextBox txtNhapSoTien;
        private TextBox txtKetQuaQuyDoi;
        private Label label4;
        private Label label5;
        private ComboBox cbLoaiTien;
        private Label lbThongBao;
        private GroupBox groupBox1;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}