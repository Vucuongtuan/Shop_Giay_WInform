using Grpc.Core;
using Shop_Giay.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Shop_Giay.View.trangcon
{
    public partial class Form_QL_SP : Form
    {
        private ServiceSoapClient service_banGiay;
        public Form_QL_SP()
        {
            InitializeComponent();
            service_banGiay = new ServiceSoapClient();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form_QL_SP_Load(object sender, EventArgs e)
        {
            
            List<DSSP> dssp = service_banGiay.GetDSSP().ToList();
            data_DSQL.DataSource = dssp;
            DL_combobox();
            macDinh();
     
        }
        public void DL_combobox()
        {
            List<Cbo> cbosp = service_banGiay.GetLoaiSPCBO().ToList();
            cbo_LoaiSP.DataSource = cbosp;
            cbo_LoaiSP.DisplayMember = "TenLoaiSP";
            cbo_LoaiSP.ValueMember = "MaLoaiSP";
            cbo_LoaiSP.SelectedValue = "TenLoaiSP";

        }
        public void macDinh()
        {
            txt_tenSP.Text = "";
            txt_moTa.Text = "";
            txt_gia.Text = "" + "VNĐ";
            cbo_LoaiSP.Text = "Chon LoaiSp";
            pic_hinhanhSP.Image = pic_hinhanhSP.InitialImage;
            txt_timkiem.Text = "";
        }
        void laydulieuSP()
        {
            txt_tenSP.Text = data_DSQL.CurrentRow.Cells[1].Value.ToString();
            txt_moTa.Text = data_DSQL.CurrentRow.Cells[2].Value.ToString();
            lbl_src.Text = data_DSQL.CurrentRow.Cells[3].Value.ToString();
            txt_gia.Text = data_DSQL.CurrentRow.Cells[4].Value.ToString();
            cbo_LoaiSP.Text = data_DSQL.CurrentRow.Cells[6].Value.ToString();
            pic_hinhanhSP.Image = null;
            string imagePath = lbl_src.Text;
            if (File.Exists(imagePath))
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    pic_hinhanhSP.Image = System.Drawing.Image.FromStream(fs);
                }
            }
        }
        private void btn_upimg_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = Path.Combine(System.Windows.Forms.Application.StartupPath, "~/images/");
            openFileDialog1.Title = "Chọn hình ảnh để được tải lên !!!";
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png;*.webp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;*.webp";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //string nameImage = openFileDialog1.FileName;
                //string srcImage = Path.Combine( nameImage);
                //string fullImage = Path.Combine(System.Windows.Forms.Application.StartupPath, srcImage);
                //lbl_src.Text = fullImage;
                //pic_hinhanhSP.Image = null;
                //pic_hinhanhSP.Image = System.Drawing.Image.FromFile(fullImage);
                string nameImage = Path.GetFileName(openFileDialog1.FileName);
                string srcImage = Path.Combine(nameImage);
                string fullImage = Path.Combine(System.Windows.Forms.Application.StartupPath, srcImage);
                lbl_src.Text = nameImage;
                pic_hinhanhSP.Image = null;
                pic_hinhanhSP.Image = System.Drawing.Image.FromFile(srcImage);
            }

        }

        private void data_DSNV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //e.ThrowException = false;

            //// Xử lý lỗi dữ liệu tại dòng và cột cụ thể
            //if (e.Context == DataGridViewDataErrorContexts.Formatting ||
            //    e.Context == DataGridViewDataErrorContexts.Parsing)
            //{
            //    // Xử lý lỗi định dạng hoặc phân tích cú pháp dữ liệu tại dòng e.RowIndex, cột e.ColumnIndex
            //    // Ví dụ: Đặt giá trị mặc định hoặc giá trị thay thế cho ô DataGridView đang có lỗi
            //    data_DSQL.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Lỗi";
            //    e.Cancel = true; // Đánh dấu lỗi đã được xử lý và không hiển thị lỗi nữa
            //}
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string timkiemTenSP = txt_timkiem.Text;
            List<DSSP> kqTimKiem = service_banGiay.GetTimKiemSP(timkiemTenSP).ToList();
            data_DSQL.DataSource = kqTimKiem;
        }

        private void btn_datlai_Click(object sender, EventArgs e)
        {
            macDinh();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int MaSP = Convert.ToInt32(data_DSQL.CurrentRow.Cells["MaSP"].Value);
            string TenSP = txt_tenSP.Text;
            string MoTa = txt_moTa.Text;
            string Gia = txt_gia.Text;
            string LoaiSP = cbo_LoaiSP.SelectedValue.ToString();
            string HinhAnh = lbl_src.Text;
            List<DSSP> suaSP = service_banGiay.GetSuaSP(MaSP, TenSP, MoTa, HinhAnh, Gia, LoaiSP).ToList();
            data_DSQL.DataSource = suaSP;
            MessageBox.Show("Đã sửa thành công", "Thông báo");
            data_DSQL.Refresh();
            data_DSQL.DataSource = service_banGiay.GetDSSP();
            macDinh();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbaoXoa = MessageBox.Show("Bạn muốn xóa Sản phẩm", "Thông báo Xóa !!!", MessageBoxButtons.YesNo);
            if (thongbaoXoa == DialogResult.Yes)
            {
                int MaSP = Convert.ToInt32(data_DSQL.CurrentRow.Cells["MaSP"].Value);
                List<DSSP> dsXoaSP = service_banGiay.GetXoaSP(MaSP).ToList();
                data_DSQL.DataSource = dsXoaSP;
                data_DSQL.Refresh();
                data_DSQL.DataSource = service_banGiay.GetDSSP();
            }
            macDinh();
        }

        private void data_DSQL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            laydulieuSP();
        }

        private void pic_hinhanhSP_Click(object sender, EventArgs e)
        {
            string srcImage = openFileDialog1.FileName;
            lbl_src.Text = srcImage;
            pic_hinhanhSP.Image = null;
            pic_hinhanhSP.Image = System.Drawing.Image.FromFile(srcImage);
        }

        private void cbo_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

       

        private void btn_themsanpham_Click(object sender, EventArgs e)
        {
            string TenSP = txt_tenSP.Text;
            string MoTa = txt_moTa.Text;
            string Gia = txt_gia.Text;
            string HinhAnh = lbl_src.Text;
            string LoaiSP = cbo_LoaiSP.SelectedValue.ToString();

            if (txt_tenSP.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên sản phẩm", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (txt_moTa.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ ten mô tả", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);

            }
            else if (txt_gia.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ giá", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(LoaiSP))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ loại sản phẩm", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }

                List<DSSP> themSP = service_banGiay.GetThemSP(TenSP, MoTa, HinhAnh, Gia, LoaiSP).ToList();
                data_DSQL.DataSource = themSP;
                MessageBox.Show("Đã thêm thành công", "Thông báo");
            data_DSQL.DataSource = service_banGiay.GetDSSP();
            macDinh();
            
        }
    }
}
