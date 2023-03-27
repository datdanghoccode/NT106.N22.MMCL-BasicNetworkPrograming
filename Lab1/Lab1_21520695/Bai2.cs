using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_21520695
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtSoThuNhat.Text != "" && txtSoThuHai.Text != "" && txtSoThuBa.Text != "")
            {
                float num1 = float.Parse(txtSoThuNhat.Text);
                float num2 = float.Parse(txtSoThuHai.Text);
                float num3 = float.Parse(txtSoThuBa.Text);
                txtSoLonNhat.Text = Math.Max(num1, Math.Max(num2, num3)).ToString();
                txtSoNhoNhat.Text = Math.Min(num1, Math.Min(num2, num3)).ToString();
            }
            else
            {
                MessageBox.Show("Không thể thực hiện tác vụ tìm. Vui lòng nhập giá trị!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtSoThuNhat.Text != "" || txtSoThuHai.Text != "" || txtSoThuBa.Text != "")
            {
                txtSoThuNhat.Text = txtSoThuHai.Text = txtSoThuBa.Text = "";
                MessageBox.Show("Xóa thành công!");
                lbThongBao1.Text = "Nhập số thứ nhất";
                lbThongBao2.Text = "Nhập số thứ hai";
                lbThongBao3.Text = "Nhập số thứ ba";
            }
            else
            {
                MessageBox.Show("Không có giá trị nào để xóa. Vui lòng nhập giá trị!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSoThuNhat_Validated(object sender, EventArgs e)
        {
            float testNumber;
            if (float.TryParse(txtSoThuNhat.Text, out testNumber))
            {
                lbThongBao1.Text = "";
            }
            else if (txtSoThuNhat.Text == "")
            {
                lbThongBao1.Text = "Nhập số thứ nhất";
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập giá trị số!");
                lbThongBao1.Text = "Vui lòng nhập lại!";
            }
        }

        private void txtSoThuHai_Validated(object sender, EventArgs e)
        {
            float testNumber;
            if (float.TryParse(txtSoThuHai.Text, out testNumber))
            {
                lbThongBao2.Text = "";
            }
            else if (txtSoThuHai.Text == "")
            {
                lbThongBao2.Text = "Nhập số thứ hai";
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập giá trị số!");
                lbThongBao2.Text = "Vui lòng nhập lại!";
            }
        }

        private void txtSoThuBa_Validated(object sender, EventArgs e)
        {
            float testNumber;
            if (float.TryParse(txtSoThuBa.Text, out testNumber))
            {
                lbThongBao3.Text = "";
            }
            else if (txtSoThuBa.Text == "")
            {
                lbThongBao3.Text = "Nhập số thứ ba";
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập giá trị số!");
                lbThongBao3.Text = "Vui lòng nhập lại!";
            }
        }
    }
}
