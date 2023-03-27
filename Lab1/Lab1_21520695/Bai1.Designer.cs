namespace Lab1_21520695
{
    partial class Bai1
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
            this.lbSoThuNhat = new System.Windows.Forms.Label();
            this.lbSoThuHai = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lbThongBao1 = new System.Windows.Forms.Label();
            this.lbThongBao2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSoThuNhat
            // 
            this.lbSoThuNhat.AutoSize = true;
            this.lbSoThuNhat.Location = new System.Drawing.Point(88, 119);
            this.lbSoThuNhat.Name = "lbSoThuNhat";
            this.lbSoThuNhat.Size = new System.Drawing.Size(85, 20);
            this.lbSoThuNhat.TabIndex = 0;
            this.lbSoThuNhat.Text = "Số thứ nhất";
            // 
            // lbSoThuHai
            // 
            this.lbSoThuHai.AutoSize = true;
            this.lbSoThuHai.Location = new System.Drawing.Point(88, 202);
            this.lbSoThuHai.Name = "lbSoThuHai";
            this.lbSoThuHai.Size = new System.Drawing.Size(76, 20);
            this.lbSoThuHai.TabIndex = 1;
            this.lbSoThuHai.Text = "Số thứ hai";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(88, 358);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(60, 20);
            this.lbKetQua.TabIndex = 2;
            this.lbKetQua.Text = "Kết quả";
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(223, 116);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(205, 27);
            this.txtSoThuNhat.TabIndex = 3;
            this.txtSoThuNhat.Validated += new System.EventHandler(this.txtSoThuNhat_Validated);
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(223, 195);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(205, 27);
            this.txtSoThuHai.TabIndex = 4;
            this.txtSoThuHai.Validated += new System.EventHandler(this.txtSoThuHai_Validated);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(223, 355);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(205, 27);
            this.txtKetQua.TabIndex = 5;
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.SystemColors.Control;
            this.btnTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTinh.Location = new System.Drawing.Point(122, 279);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(244, 29);
            this.btnTinh.TabIndex = 6;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lbThongBao1
            // 
            this.lbThongBao1.AutoSize = true;
            this.lbThongBao1.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao1.Location = new System.Drawing.Point(223, 146);
            this.lbThongBao1.Name = "lbThongBao1";
            this.lbThongBao1.Size = new System.Drawing.Size(123, 20);
            this.lbThongBao1.TabIndex = 7;
            this.lbThongBao1.Text = "Nhập số thứ nhất";
            // 
            // lbThongBao2
            // 
            this.lbThongBao2.AutoSize = true;
            this.lbThongBao2.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao2.Location = new System.Drawing.Point(223, 225);
            this.lbThongBao2.Name = "lbThongBao2";
            this.lbThongBao2.Size = new System.Drawing.Size(114, 20);
            this.lbThongBao2.TabIndex = 8;
            this.lbThongBao2.Text = "Nhập số thứ hai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tính tổng 2 số nguyên (Có điều kiện)";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbThongBao2);
            this.Controls.Add(this.lbThongBao1);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.txtSoThuNhat);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lbSoThuHai);
            this.Controls.Add(this.lbSoThuNhat);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSoThuNhat;
        private Label lbSoThuHai;
        private Label lbKetQua;
        private TextBox txtSoThuNhat;
        private TextBox txtSoThuHai;
        private TextBox txtKetQua;
        private Button btnTinh;
        private Label lbThongBao1;
        private Label lbThongBao2;
        private Label label1;
    }
}