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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (txtNhapSo.Text != "")
            {
                int num = Int32.Parse(txtNhapSo.Text);
                switch (num)
                {
                    case 0:
                        txtKetQua.Text = "Không";
                        break;
                    case 1:
                        txtKetQua.Text = "Một";
                        break;
                    case 2:
                        txtKetQua.Text = "Hai";
                        break;
                    case 3:
                        txtKetQua.Text = "Ba";
                        break;
                    case 4:
                        txtKetQua.Text = "Bốn";
                        break;
                    case 5:
                        txtKetQua.Text = "Năm";
                        break;
                    case 6:
                        txtKetQua.Text = "Sáu";
                        break;
                    case 7:
                        txtKetQua.Text = "Bảy";
                        break;
                    case 8:
                        txtKetQua.Text = "Tám";
                        break;
                    case 9:
                        txtKetQua.Text = "Chín";
                        break;
                    default:
                        MessageBox.Show("Giá trị nhập vượt ngoài khoảng giá trị đọc số của chương trình. Vui lòng nhập lại giá trị!");
                        break;
                }
            } 
            else
            {
                MessageBox.Show("Không có giá trị nào để đọc. Vui lòng nhập giá trị!");
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtNhapSo.Text != "")
            {
                txtNhapSo.Text = "";
                MessageBox.Show("Xóa thành công!");
                lbThongBao.Text = "Vui lòng nhập số";
            }
            else
                MessageBox.Show("Không có giá trị nào để xóa. Vui lòng nhập giá trị!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhapSo_Validated(object sender, EventArgs e)
        {
            int testNumber;
            if (Int32.TryParse(txtNhapSo.Text, out testNumber))
            {
                lbThongBao.Text = "";
            }
            else if (txtNhapSo.Text == "")
            {
                lbThongBao.Text = "Vui lòng nhập số";
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập số nguyên!");
                lbThongBao.Text = "Vui lòng nhập lại!";
            }
        }
    }
}
