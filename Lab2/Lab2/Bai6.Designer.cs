namespace Lab2
{
    partial class Bai6
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
            this.gbFileContent = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // gbFileContent
            // 
            this.gbFileContent.Location = new System.Drawing.Point(254, 12);
            this.gbFileContent.Name = "gbFileContent";
            this.gbFileContent.Size = new System.Drawing.Size(569, 550);
            this.gbFileContent.TabIndex = 1;
            this.gbFileContent.TabStop = false;
            this.gbFileContent.Text = "File Content";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(236, 550);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 574);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.gbFileContent);
            this.Name = "Bai6";
            this.Text = "Bai6";
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gbFileContent;
        private TreeView treeView1;
    }
}