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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void txtNhapA_Validated(object sender, EventArgs e)
        {
            int testNumber;
            if (Int32.TryParse(txtNhapA.Text, out testNumber))
            {
                lbThongBao1.Text = "";
            }
            else if (txtNhapA.Text == "")
            {
                lbThongBao1.Text = "Nhập số nguyên A";
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập số nguyên!");
                lbThongBao1.Text = "Vui lòng nhập lại!";
            }
        }

        private void txtNhapB_Validated(object sender, EventArgs e)
        {
            int testNumber;
            if (Int32.TryParse(txtNhapB.Text, out testNumber))
            {
                lbThongBao2.Text = "";
            }
            else if (txtNhapB.Text == "")
            {
                lbThongBao2.Text = "Nhập số nguyên B";
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập số nguyên!");
                lbThongBao2.Text = "Vui lòng nhập lại!";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtNhapA.Text != "" || txtNhapB.Text != "")
            {
                txtNhapA.Text = txtNhapB.Text = "";
                MessageBox.Show("Xóa thành công!");
                lbThongBao1.Text = "Nhập số nguyên A";
                lbThongBao2.Text = "Nhập số nguyên B";
            }
            else
            {
                MessageBox.Show("Không có giá trị nào để xóa. Vui lòng nhập giá trị!");
            }
        }
      
        private void btnTinh_Click(object sender, EventArgs e)
        {           
            if (txtNhapA.Text != "" && txtNhapB.Text != "")
            {
                int soA, soB;
                long GiaiThuaA = 1, GiaiThuaB = 1, tongA = 0, tongB = 0;
                double tongALuyThuaB = 0;
                if (Int32.TryParse(txtNhapA.Text, out soA) && (Int32.TryParse(txtNhapB.Text, out soB)))
                {
                    for (int i = 1; i <= soA; i++)
                    {
                        GiaiThuaA = GiaiThuaA * i;
                        tongA = tongA + i;
                    }

                    for (int j = 1; j <= soB; j++)
                    {
                        GiaiThuaB = GiaiThuaB * j;
                        tongB = tongB + j;
                        tongALuyThuaB = tongALuyThuaB + Math.Pow(soA, j);
                    }
                    lbKetQua.Text = lbKetQua.Text + "A! = " + GiaiThuaA.ToString() + "              ";
                    lbKetQua.Text = lbKetQua.Text + "B! = " + GiaiThuaB.ToString() + "\r\n";
                    lbKetQua.Text = lbKetQua.Text + "S1 = 1 + 2 + 3 + ... + A = " + tongA.ToString() + "\r\n";
                    lbKetQua.Text = lbKetQua.Text + "S2 = 1 + 2 + 3 + ... + B = " + tongB.ToString() + "\r\n";
                    lbKetQua.Text = lbKetQua.Text + "S3 = A^1 + A^2 + A^3 + ... + A^B = " + tongALuyThuaB.ToString() + "\r\n";
                }
            }    
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên A và B");
            }    
        }
    }
}
