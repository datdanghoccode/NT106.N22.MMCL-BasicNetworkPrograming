using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Lab1_21520695
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void txtNhapSoTien_Validated(object sender, EventArgs e)
        {
            float soTien;
            if (float.TryParse(txtNhapSoTien.Text, out soTien))
            {
                lbThongBao.Text = "";
            }
            else if (txtNhapSoTien.Text == "")
            {
                lbThongBao.Text = "Nhập số tiền cần chuyển đổi";
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ. Vui lòng nhập số tiền!");
                lbThongBao.Text = "Vui lòng nhập lại!";
            }
        }

        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            if (txtNhapSoTien.Text != "") 
            {
                int index = Convert.ToInt32(cbLoaiTien.SelectedIndex);
                float soTien = float.Parse(txtNhapSoTien.Text);
                if (soTien > 0)
                {
                    switch (index)
                    {
                        case 0:
                            {
                                txtKetQuaQuyDoi.Text = (soTien * 22772).ToString("#,#", CultureInfo.InvariantCulture);
                                break;
                            }
                        case 1:
                            {
                                txtKetQuaQuyDoi.Text = (soTien * 28132).ToString("#,#", CultureInfo.InvariantCulture);
                                break;
                            }
                        case 2:
                            {
                                txtKetQuaQuyDoi.Text = (soTien * 31538).ToString("#,#", CultureInfo.InvariantCulture);
                                break;
                            }
                        case 3:
                            {
                                txtKetQuaQuyDoi.Text = (soTien * 17286).ToString("#,#", CultureInfo.InvariantCulture);
                                break;
                            }
                        case 4:
                            {
                                txtKetQuaQuyDoi.Text = (soTien * 214).ToString("#,#", CultureInfo.InvariantCulture);
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("Vui lòng chọn loại tiền tệ!");
                                break;
                            }
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị chuyển đổi không hợp lệ. Vui lòng nhập lại số tiền!");
                }    
            }
            else
            {
                MessageBox.Show("Không có giá trị nào để chuyển đổi. Vui lòng nhập số tiền!");
            }
        }
    }
}
