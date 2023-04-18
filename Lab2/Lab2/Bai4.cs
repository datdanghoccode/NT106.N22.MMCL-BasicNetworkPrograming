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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            txtName_input.Text = txtName_output.Text;
            txtID_input.Text = txtID_output.Text;
            txtPhone_input.Text = txtPhone_output.Text;
            txtCourse1_input.Text = txtCourse1_output.Text;
            txtCourse2_input.Text = txtCourse2_output.Text;
            txtCourse3_input.Text = txtCourse3_output.Text;
            
            var filepath = "D:\\HocC#\\FileTxtLab2\\input4.txt";
            FileStream fs = new FileStream(filepath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(rtbFile.Text + "\r\n");
            sw.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID_input.Text.Length != 8)
            {
                MessageBox.Show("MSSV phải có 8 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPhone_input.Text.Length != 10 || txtPhone_input.Text[0] != '0')
            {

                MessageBox.Show("Điện thoại phải có 10 chữ số và phải bắt đầu bằng chữ số 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float Course1, Course2, Course3;
            if ((!float.TryParse(txtCourse1_input.Text, out Course1)) || (Course1 < 0) || (Course1 > 10) ||
                (!float.TryParse(txtCourse2_input.Text, out Course2)) || (Course2 < 0) || (Course2 > 10) ||
                (!float.TryParse(txtCourse3_input.Text, out Course3)) || (Course3 < 0) || (Course3 > 10))
            {
                MessageBox.Show("Điểm phải là số thực từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Name = txtName_input.Text;
            string ID = txtID_input.Text;
            string Phone = txtPhone_input.Text;
            float course1 = float.Parse(txtCourse1_input.Text.Trim());
            float course2 = float.Parse(txtCourse2_input.Text.Trim());
            float course3 = float.Parse(txtCourse3_input.Text.Trim());

            string file = "D:\\HocC#\\FileTxtLab2\\input4.txt";
            if (!File.Exists(file))
            {
                File.WriteAllText(file, Name);
            }
            else
            {
                if (File.ReadAllLines(file).Length == 0)
                {
                    File.WriteAllText(file, Name);
                }
                else
                {
                    File.AppendAllText(file, "\r\n" + Name);

                }
            }

            rtbFile.Text += Name + "\r\n";
            rtbFile.Text += ID + "\r\n";
            rtbFile.Text += Phone + "\r\n";
            rtbFile.Text += course1 + "\r\n";
            rtbFile.Text += course2 + "\r\n";
            rtbFile.Text += course3;


        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string file = "D:\\HocC#\\FileTxtLab2\\output4.txt";
            File.WriteAllText(file, "");

            string[] lines = rtbFile.Lines;
            int CountLine = rtbFile.Lines.Count();
            float course1, course2, course3;
            for (int i = 0; i < (CountLine / 6); i++)
            {
                if (!File.Exists(file))
                {
                    File.WriteAllText(file, lines[6 * i + 0]);
                }
                else
                {
                    if (File.ReadAllLines(file).Length == 0)
                    {
                        File.WriteAllText(file, lines[6 * i + 0]);
                    }
                    else
                    {
                        File.AppendAllText(file, "\r\n" + lines[6 * i + 0]);

                    }
                }

                File.AppendAllText(file, "\r\n" + lines[6 * i + 1]);
                File.AppendAllText(file, "\r\n" + lines[6 * i + 2]);
                File.AppendAllText(file, "\r\n" + lines[6 * i + 3]);
                File.AppendAllText(file, "\r\n" + lines[6 * i + 4]);
                File.AppendAllText(file, "\r\n" + lines[6 * i + 5]);
                course1 = float.Parse(lines[6 * i + 3].Trim());
                course2 = float.Parse(lines[6 * i + 4].Trim());
                course3 = float.Parse(lines[6 * i + 5].Trim());
                float average = (course1 + course2 + course3) / 3;
                File.AppendAllText(file, "\r\n" + average.ToString());
            }


            //hien thi ben phan doc file, mac dinh hien thi sinh vien dau tien
            txtName_output.Text = lines[0];
            txtID_output.Text = lines[1];
            txtPhone_output.Text = lines[2];
            txtCourse1_output.Text = lines[3];
            txtCourse2_output.Text = lines[4];
            txtCourse3_output.Text = lines[5];
            txtAverage_output.Text = ((float.Parse(lines[3].Trim()) + float.Parse(lines[4].Trim()) + float.Parse(lines[5].Trim())) / 3).ToString();
            txtSTT.Text = "1";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int page = Int32.Parse(txtSTT.Text.Trim());
            page--;
            if (page > 0)
            {
                txtSTT.Text = page.ToString();

                string file = "D:\\HocC#\\FileTxtLab2\\output4.txt";
                string[] lines = File.ReadAllLines(file);

                txtName_output.Text = lines[7 * (page - 1) + 0];
                txtID_output.Text = lines[7 * (page - 1) + 1];
                txtPhone_output.Text = lines[7 * (page - 1) + 2];
                txtCourse1_output.Text = lines[7 * (page - 1) + 3];
                txtCourse2_output.Text = lines[7 * (page - 1) + 4];
                txtCourse3_output.Text = lines[7 * (page - 1) + 5];
                txtAverage_output.Text = lines[7 * (page - 1) + 6];

            }

            else
                MessageBox.Show("Đang ở trang đầu, không thể quay lại trang trước!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int page = Int32.Parse(txtSTT.Text.Trim());

            string file = "D:\\HocC#\\FileTxtLab2\\output4.txt";
            string[] lines = File.ReadAllLines(file);
            int CountLine = lines.Count();

            page++;
            if (page <= (CountLine / 7))
            {
                txtName_output.Text = lines[7 * (page - 1) + 0];
                txtID_output.Text = lines[7 * (page - 1) + 1];
                txtPhone_output.Text = lines[7 * (page - 1) + 2];
                txtCourse1_output.Text = lines[7 * (page - 1) + 3];
                txtCourse2_output.Text = lines[7 * (page - 1) + 4];
                txtCourse3_output.Text = lines[7 * (page - 1) + 5];
                txtAverage_output.Text = lines[7 * (page - 1) + 6];
                txtSTT.Text = page.ToString();
            }
            else
                MessageBox.Show("Đang ở trang cuối, không thể sang trang tiếp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
