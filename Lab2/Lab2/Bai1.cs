using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            //OpenFileDialog open = new OpenFileDialog();
            //open.ShowDialog();
            FileStream fs = new FileStream("D:\\HocC#\\FileTxtLab2\\input1.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            rtbFile.Text = content;
            fs.Close();
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D:\\HocC#\\FileTxtLab2\\output1.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(rtbFile.Text.ToUpper());
            sw.Close();
        }
    }
}
