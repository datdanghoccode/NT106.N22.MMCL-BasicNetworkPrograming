namespace Lab1_21520695
{
    partial class Bai5
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
            this.lbNhapA = new System.Windows.Forms.Label();
            this.lbNhapB = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.txtNhapB = new System.Windows.Forms.TextBox();
            this.lbThongBao1 = new System.Windows.Forms.Label();
            this.lbThongBao2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNhapA
            // 
            this.lbNhapA.AutoSize = true;
            this.lbNhapA.Location = new System.Drawing.Point(50, 93);
            this.lbNhapA.Name = "lbNhapA";
            this.lbNhapA.Size = new System.Drawing.Size(59, 20);
            this.lbNhapA.TabIndex = 0;
            this.lbNhapA.Text = "Nhập A";
            // 
            // lbNhapB
            // 
            this.lbNhapB.AutoSize = true;
            this.lbNhapB.Location = new System.Drawing.Point(400, 93);
            this.lbNhapB.Name = "lbNhapB";
            this.lbNhapB.Size = new System.Drawing.Size(58, 20);
            this.lbNhapB.TabIndex = 1;
            this.lbNhapB.Text = "Nhập B";
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTinh.Location = new System.Drawing.Point(50, 181);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(209, 29);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính các giá trị";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(317, 181);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 29);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(486, 181);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 29);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtNhapA
            // 
            this.txtNhapA.Location = new System.Drawing.Point(129, 90);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(125, 27);
            this.txtNhapA.TabIndex = 5;
            this.txtNhapA.Validated += new System.EventHandler(this.txtNhapA_Validated);
            // 
            // txtNhapB
            // 
            this.txtNhapB.Location = new System.Drawing.Point(466, 90);
            this.txtNhapB.Name = "txtNhapB";
            this.txtNhapB.Size = new System.Drawing.Size(125, 27);
            this.txtNhapB.TabIndex = 6;
            this.txtNhapB.Validated += new System.EventHandler(this.txtNhapB_Validated);
            // 
            // lbThongBao1
            // 
            this.lbThongBao1.AutoSize = true;
            this.lbThongBao1.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao1.Location = new System.Drawing.Point(129, 124);
            this.lbThongBao1.Name = "lbThongBao1";
            this.lbThongBao1.Size = new System.Drawing.Size(130, 20);
            this.lbThongBao1.TabIndex = 7;
            this.lbThongBao1.Text = "Nhập số nguyên A";
            // 
            // lbThongBao2
            // 
            this.lbThongBao2.AutoSize = true;
            this.lbThongBao2.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao2.Location = new System.Drawing.Point(466, 124);
            this.lbThongBao2.Name = "lbThongBao2";
            this.lbThongBao2.Size = new System.Drawing.Size(129, 20);
            this.lbThongBao2.TabIndex = 8;
            this.lbThongBao2.Text = "Nhập số nguyên B";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbKetQua);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(50, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 194);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KẾT QUẢ";
            // 
            // lbKetQua
            // 
            this.lbKetQua.Location = new System.Drawing.Point(38, 41);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(466, 123);
            this.lbKetQua.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tính và xuất kết quả phù hợp với biểu thức";
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbThongBao2);
            this.Controls.Add(this.lbThongBao1);
            this.Controls.Add(this.txtNhapB);
            this.Controls.Add(this.txtNhapA);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lbNhapB);
            this.Controls.Add(this.lbNhapA);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNhapA;
        private Label lbNhapB;
        private Button btnTinh;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox txtNhapA;
        private TextBox txtNhapB;
        private Label lbThongBao1;
        private Label lbThongBao2;
        private GroupBox groupBox1;
        private Label lbKetQua;
        private Label label1;
    }
}