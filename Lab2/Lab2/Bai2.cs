using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            FileStream fs = new FileStream(open.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            rtbFile.Text = content;

            //Get FileName
            txtFileName.Text = open.SafeFileName.ToString();

            //Get URL
            txtURL.Text = fs.Name.ToString();

            //Size
            FileInfo info = new FileInfo(txtURL.Text);
            txtSize.Text = info.Length.ToString() + " bytes";

            //Line
            txtLine.Text = rtbFile.Lines.Count().ToString();

            //Word
            char[] separator = { ' ', '.', '?', '!', ';', ':', ',' };
            txtWord.Text = content.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length.ToString();

            //Character
            txtCharacter.Text = content.Length.ToString();

            fs.Close();
        }
    }
}
