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

namespace Shop_Giay.View
{
    public partial class Form_DanhGia : Form
    {
        private ServiceSoapClient service_banGiay;
        public Form_DanhGia()
        {
            InitializeComponent();
            service_banGiay = new ServiceSoapClient();
        }

        private void Form_DanhGia_Load(object sender, EventArgs e)
        {
            //lbl_srcimg.Visible = false;
            List<DanhGia> DSDG = service_banGiay.GetDanhGia().ToList();
            data_DG.DataSource = DSDG;
            data_DG.Columns["HinhAnh"].Visible = false;
            List<DSSP> dssp = service_banGiay.GetDSSP().ToList();
            data_sp.DataSource = dssp;
            data_sp.Columns["HinhAnh"].Visible = false;
            data_sp.Columns["LoaiSP"].Visible = false;
            data_sp.Columns["MaSP"].Visible = false;

        }

   
        private void btn_danhGia_Click(object sender, EventArgs e)
        {
            string TenNguoiDG = txt_TenNgDG.Text;
            string DanhGiaSP = txt_DG.Text;
            string MaSPtr = data_sp.CurrentRow.Cells[0].Value.ToString();
            int MaSP = int.Parse(MaSPtr);


            if (txt_TenNgDG.TextLength == 0)
            {
                MessageBox.Show("Bạn cần nhập tên người đánh giá để thêm đánh giá", "thông báo nhập thiếu thông tin", MessageBoxButtons.OK);
            }
            if (txt_DG.TextLength == 0)
            {
                MessageBox.Show("Bạn cần nhập đánh giá để thêm ", "thông báo nhập thiếu thông tin", MessageBoxButtons.OK);
            }
            List<DanhGia> themdg = service_banGiay.GetThemDG(MaSP, TenNguoiDG, DanhGiaSP).ToList();
            data_DG.DataSource = themdg;
            MessageBox.Show("Đã thêm thành công", "Thông báo");
            data_DG.DataSource = service_banGiay.GetDanhGia();
            macDinh();

        }

        private void pic_HInhAnh_Click(object sender, EventArgs e)
        {
            //string srcImage = openFileDialog1.FileName;
            //lbl_srcimg.Text = srcImage;
            //pic_HInhAnh.Image = null;
            //pic_HInhAnh.Image = System.Drawing.Image.FromFile(srcImage);
        }

        private void cbo_SP_SelectedValueChanged(object sender, EventArgs e)
        { 
        }

        private void cbo_SP_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }
        public void macDinh()
        {
            txt_TenNgDG.Text = "";
            txt_DG.Text = "";
            lbl_srcimg.Text = "";
            lbl_TenSP.Text = "";
            txt_tim.Text = "";
        }
        private void btn_chonSP_Click(object sender, EventArgs e)
        {
            string timkiemTenSP = txt_tim.Text;
            List<DSSP> kqTimKiem = service_banGiay.GetTimKiemSP(timkiemTenSP).ToList();
            data_sp.DataSource = kqTimKiem;

        }

        private void data_sp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_TenSP.Text = data_sp.CurrentRow.Cells[1].Value.ToString();
            lbl_srcimg.Text = data_sp.CurrentRow.Cells[3].Value.ToString();
            pic_HInhAnh.Image = null;
            string imagePath = lbl_srcimg.Text;
            if (File.Exists(imagePath))
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    pic_HInhAnh.Image = System.Drawing.Image.FromStream(fs);
                }
            }
        }
    }
}
