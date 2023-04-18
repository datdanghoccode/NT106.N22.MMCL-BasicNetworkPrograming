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
using System.IO.Compression;
using System.Xml.Linq;

namespace Lab2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNen_Click(object sender, EventArgs e)
        {
            string file = "D:\\HocC#\\FileTxtLab2\\output5.txt";
            File.WriteAllText(file, "");// Xoá hết nội dung trong file cũ trước khi cập nhật lại/ghi đè

            string content = txtFile.Text;
            File.WriteAllText(file, content);// Ghi nội dung vào file


            // Tạo một file nén ZIP với tên file mặc định
            string zipFileName = "output5.zip";
            string zipFilePath = "D:\\HocC#\\FileTxtLab2\\" + zipFileName;

            // Nén tập tin được chọn và lưu vào file ZIP
            using (FileStream zipToCreate = new FileStream(zipFilePath, FileMode.Create))
            {
                using (ZipArchive archive = new ZipArchive(zipToCreate, ZipArchiveMode.Create))
                {
                    // Tạo một entry trong file ZIP với tên "output5.txt"
                    ZipArchiveEntry entry = archive.CreateEntry("output5.txt");
                    using (FileStream sourceStream = new FileStream(file, FileMode.Open))
                    {
                        using (Stream targetStream = entry.Open())
                        {
                            sourceStream.CopyTo(targetStream);
                        }
                    }
                }
            }

            // Hiển thị thông báo khi quá trình nén hoàn tất
            MessageBox.Show(string.Format("Nội dung đã được nén và lưu vào {0}.", zipFilePath), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            File.Delete(file);// Xoá file sau khi nén
        }

        private void btnGiaiNen_Click(object sender, EventArgs e)
        {
            string zipFilePath = "D:\\HocC#\\FileTxtLab2\\output5.zip";
            string extractPath = "D:\\HocC#\\FileTxtLab2\\";
            string entryName = "output5.txt";

            // Giải nén file ZIP
            using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
            {
                // Tìm entry có tên entryName
                ZipArchiveEntry entry = archive.GetEntry(entryName);
                if (entry != null)
                {
                    // Giải nén entry vào file văn bản
                    ZipFile.ExtractToDirectory(zipFilePath, extractPath);
                    MessageBox.Show(string.Format("File {0} đã được giải nén và lưu vào {1}.", entryName, extractPath), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(string.Format("Không tìm thấy entry {0} trong file ZIP.", entryName), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
