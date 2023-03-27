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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (txtSoThuNhat.Text != "" && txtSoThuHai.Text != "")
            {
                int num1 = Int32.Parse(txtSoThuNhat.Text);
                int num2 = Int32.Parse(txtSoThuHai.Text);
                int Sum = num1 + num2;
                txtKetQua.Text = Sum.ToString();
            }    
            else
            {
                MessageBox.Show("Không thể thực hiện phép tính. Vui lòng nhập giá trị!");
            }    
        }

        private void txtSoThuNhat_Validated(object sender, EventArgs e)
        {
            int testNumber;
            if (Int32.TryParse(txtSoThuNhat.Text, out testNumber))
            {
                lbThongBao1.Text = "";
            }
            else if (txtSoThuNhat.Text == "")
            {
                lbThongBao1.Text = "Nhập số thứ nhất";
            }    
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập số nguyên!");
                lbThongBao1.Text = "Vui lòng nhập lại!";
            }
        }

        private void txtSoThuHai_Validated(object sender, EventArgs e)
        {
            int testNumber;
            if (Int32.TryParse(txtSoThuHai.Text, out testNumber))
            {
                lbThongBao2.Text = "";
            }
            else if (txtSoThuNhat.Text == "")
            {
                lbThongBao2.Text = "Nhập số thứ hai";
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập số nguyên!");
                lbThongBao2.Text = "Vui lòng nhập lại!";
            }
        } 
    }
}
