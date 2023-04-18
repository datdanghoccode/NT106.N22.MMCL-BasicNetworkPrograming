namespace Lab2
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnNen = new System.Windows.Forms.Button();
            this.btnGiaiNen = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(248, 12);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(540, 426);
            this.txtFile.TabIndex = 0;
            // 
            // btnNen
            // 
            this.btnNen.Location = new System.Drawing.Point(41, 57);
            this.btnNen.Name = "btnNen";
            this.btnNen.Size = new System.Drawing.Size(164, 77);
            this.btnNen.TabIndex = 1;
            this.btnNen.Text = "Viết - Nén dữ liệu";
            this.btnNen.UseVisualStyleBackColor = true;
            this.btnNen.Click += new System.EventHandler(this.btnNen_Click);
            // 
            // btnGiaiNen
            // 
            this.btnGiaiNen.Location = new System.Drawing.Point(41, 180);
            this.btnGiaiNen.Name = "btnGiaiNen";
            this.btnGiaiNen.Size = new System.Drawing.Size(164, 77);
            this.btnGiaiNen.TabIndex = 2;
            this.btnGiaiNen.Text = "Giải nén dữ liệu";
            this.btnGiaiNen.UseVisualStyleBackColor = true;
            this.btnGiaiNen.Click += new System.EventHandler(this.btnGiaiNen_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(41, 304);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(164, 77);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiaiNen);
            this.Controls.Add(this.btnNen);
            this.Controls.Add(this.txtFile);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFile;
        private Button btnNen;
        private Button btnGiaiNen;
        private Button btnThoat;
    }
}