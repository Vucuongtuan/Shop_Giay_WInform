using Grpc.Core;
using Shop_Giay.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Shop_Giay.View.trangcon
{
    public partial class Form_TK_Admin : Form
    {
        private ServiceSoapClient service_banGiay;
        public Form_TK_Admin()
        {
            InitializeComponent();
            service_banGiay = new ServiceSoapClient();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form_TK_Admin_Load(object sender, EventArgs e)
        {
            List<DSNV> dsnv = service_banGiay.GetDSNV().ToList();
            data_DSNV.DataSource = dsnv;
            macDinh();
        }
        public void macDinh()
        {
            txt_tennv.Text = "";
            txt_sdt.Text = "";
            txt_tenTK.Text = "";
            txt_pass.Text = "";
            txt_email.Text = "";
            cbo_gioitinh.Text = "Chọn Giới Tính";
            pic_hinhad.Image = pic_hinhad.InitialImage;
            txt_timkiem.Text = "";

        }
        private void btn_upimg_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Path.Combine(System.Windows.Forms.Application.StartupPath, "images");
            openFileDialog1.Title = "Chọn hình ảnh để được tải lên !!!";
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png;*.webp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;*.webp";
            openFileDialog1.FilterIndex = 1;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string nameImage = openFileDialog1.FileName;
                string srcImage = Path.Combine("images", nameImage);
                string fullImage = Path.Combine(System.Windows.Forms.Application.StartupPath, srcImage);
                lbl_src.Text = srcImage;
                pic_hinhad.Image = null;
                pic_hinhad.Image = System.Drawing.Image.FromFile(fullImage);
                }
              

        }

        private void btn_datlai_Click(object sender, EventArgs e)
        {
            macDinh();
        }
        void laydulieuNV()
        {
            txt_tennv.Text = data_DSNV.CurrentRow.Cells[1].Value.ToString();
            txt_tenTK.Text = data_DSNV.CurrentRow.Cells[2].Value.ToString();
            txt_pass.Text = data_DSNV.CurrentRow.Cells[3].Value.ToString();
            txt_sdt.Text = data_DSNV.CurrentRow.Cells[4].Value.ToString();
            date_ngaySInh.Text = data_DSNV.CurrentRow.Cells[5].Value.ToString();
            txt_email.Text = data_DSNV.CurrentRow.Cells[6].Value.ToString();
            lbl_src.Text = data_DSNV.CurrentRow.Cells[7].Value.ToString();
            cbo_gioitinh.Text = data_DSNV.CurrentRow.Cells[8].Value.ToString();
            pic_hinhad.Image = null;
            string imagePath = lbl_src.Text;
            if (File.Exists(imagePath))
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    pic_hinhad.Image = System.Drawing.Image.FromStream(fs);
                }
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {

            string TenNV = txt_tennv.Text;
            string SoDienThoai = txt_sdt.Text;
            string Email = txt_email.Text;
            string GioiTinh = cbo_gioitinh.Text;
            DateTime NgaySinh = date_ngaySInh.Value;
            string Ten_TK = txt_tenTK.Text;
            string Pass= txt_pass.Text;
            string HinhAnh = lbl_src.Text; 

            if (txt_tennv.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên khách hàng", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (txt_sdt.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ ten tài khoản", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);

            }
            else if (txt_tenTK.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên tài khoản", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (txt_email.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (txt_pass.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(GioiTinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Giới tính", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else
            {
                List<DSNV> themNV = service_banGiay.GetThemNV(TenNV, SoDienThoai, Ten_TK, Pass, Email, GioiTinh, HinhAnh, NgaySinh).ToList();
                data_DSNV.DataSource = themNV;

                MessageBox.Show("Đã thêm thành công", "Thông báo");
                data_DSNV.Refresh();
                data_DSNV.DataSource = service_banGiay.GetDSNV();
                macDinh();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbaoXoa = MessageBox.Show("Bạn muốn xóa Khách hàng", "Thông báo Xóa !!!", MessageBoxButtons.YesNo);
            if (thongbaoXoa == DialogResult.Yes)
            {
                int MaNV = Convert.ToInt32(data_DSNV.CurrentRow.Cells["MaNV"].Value);
                List<DSNV> dsXoaKH = service_banGiay.GetXoaNV(MaNV).ToList();
                data_DSNV.DataSource = dsXoaKH;
                data_DSNV.Refresh();
                data_DSNV.DataSource = service_banGiay.GetDSNV();
            }
            macDinh();
        }

        private void data_DSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            laydulieuNV(); 
           }

        private void data_DSNV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
           
        }

        

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int MaNV = Convert.ToInt32(data_DSNV.CurrentRow.Cells["MaNV"].Value);
            string TenNV = txt_tennv.Text;
            string SoDienThoai = txt_sdt.Text;
            string Email = txt_email.Text;
            string GioiTinh = cbo_gioitinh.Text;
            DateTime NgaySinh = date_ngaySInh.Value;
            string Ten_TK = txt_tenTK.Text;
            string Pass = txt_pass.Text;
            string HinhAnh = lbl_src.Text;
            List<DSNV> suaNV = service_banGiay.GetSuaNV(MaNV,TenNV, SoDienThoai,Ten_TK, Pass,  Email,  GioiTinh, HinhAnh, NgaySinh).ToList();
            data_DSNV.DataSource = suaNV;
            MessageBox.Show("Đã sửa thành công", "Thông báo");
            data_DSNV.Refresh();
            data_DSNV.DataSource = service_banGiay.GetDSNV();
            macDinh();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string timkiemTenNV = txt_timkiem.Text;
            List<DSNV> kqTimKiem = service_banGiay.GetTimKiemNV(timkiemTenNV).ToList();
            data_DSNV.DataSource = kqTimKiem;
        }

        private void pic_hinhad_Click(object sender, EventArgs e)
        {
            string srcImage = openFileDialog1.FileName;
            lbl_src.Text = srcImage;
            pic_hinhad.Image = null;
            pic_hinhad.Image = System.Drawing.Image.FromFile(srcImage);
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
