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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
        
        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            FileStream fs = new FileStream(open.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            txtFile.Text = content;
            fs.Close();

            content = content.Replace("\r\n", "\n");
            string[] lines = content.Split('\n');

            foreach (string line in lines)
            {
                string[] tokens = line.Split(' ');
                double result = 0;
                string expression = "";

                for (int i = 0; i < tokens.Length; i++)
                {
                    if (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/")
                    {
                        expression += tokens[i] + " ";
                    }
                    else if (tokens[i] == "(")
                    {
                        expression += tokens[i];
                    }
                    else if (tokens[i] == ")")
                    {
                        expression = expression.Substring(0, expression.Length - 1);
                        DataTable table = new DataTable();
                        result = Convert.ToDouble(table.Compute(expression, null));
                        expression = result.ToString() + " ";
                    }
                    else
                    {
                        expression += tokens[i] + " ";
                    }
                }

                DataTable finalTable = new DataTable();

                var outputParam = finalTable.Compute(expression, null);
                output += line + " = " + Convert.ToString(outputParam) + "\n";

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string output = ""; //khai bao chuoi chua noi dung tam
        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                FileStream fs = new FileStream(filePath as string, FileMode.CreateNew);
                string text = output;
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.WriteLine(text);
                    MessageBox.Show("Ghi file thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                fs.Close();
            }
            output = "";
        }
    }
}
