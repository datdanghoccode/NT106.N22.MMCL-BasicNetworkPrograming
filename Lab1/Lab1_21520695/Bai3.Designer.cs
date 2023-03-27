namespace Lab1_21520695
{
    partial class Bai3
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
            this.lbNhapSo = new System.Windows.Forms.Label();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNhapSo
            // 
            this.lbNhapSo.AutoSize = true;
            this.lbNhapSo.Location = new System.Drawing.Point(68, 92);
            this.lbNhapSo.Name = "lbNhapSo";
            this.lbNhapSo.Size = new System.Drawing.Size(226, 20);
            this.lbNhapSo.TabIndex = 0;
            this.lbNhapSo.Text = "Nhập Vào Số Nguyên Từ 0 Đến 9";
            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(68, 203);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(94, 29);
            this.btnDoc.TabIndex = 1;
            this.btnDoc.Text = "Đọc";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(232, 203);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(397, 203);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(232, 285);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(62, 20);
            this.lbKetQua.TabIndex = 4;
            this.lbKetQua.Text = "Kết Quả";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(300, 89);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(191, 27);
            this.txtNhapSo.TabIndex = 5;
            this.txtNhapSo.Validated += new System.EventHandler(this.txtNhapSo_Validated);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(300, 282);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(191, 27);
            this.txtKetQua.TabIndex = 6;
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao.Location = new System.Drawing.Point(300, 119);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(120, 20);
            this.lbThongBao.TabIndex = 7;
            this.lbThongBao.Text = "Vui lòng nhập số";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đọc số";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.lbNhapSo);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNhapSo;
        private Button btnDoc;
        private Button btnXoa;
        private Button btnThoat;
        private Label lbKetQua;
        private TextBox txtNhapSo;
        private TextBox txtKetQua;
        private Label lbThongBao;
        private Label label1;
    }
}