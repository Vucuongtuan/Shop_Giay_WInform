using Shop_Giay.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Shop_Giay.View.trangcon
{
    public partial class Form_TK_KhachHang : Form
    {
        private ServiceSoapClient service_banGiay;
        public Form_TK_KhachHang()
        {
            InitializeComponent();
            service_banGiay = new ServiceSoapClient();

        }

        private void Form_TK_KhachHang_Load(object sender, EventArgs e)
        {
            List<DSKH> dskh = service_banGiay.GetDSKH().ToList() ;
            data_DSKH.DataSource = dskh;
            macDinh();

        }
        public void macDinh() {
            txt_makh.Text = "";
            txt_tenkh.Text= "";
            txt_sdt.Text = "";
            txt_diachi.Text = "";
            txt_email.Text = "";
            cbo_gioitinh.Text = "Chọn Giới Tính";
            txt_timkiem.Text = "";
            data_DSKH.Refresh();
            data_DSKH.DataSource = service_banGiay.GetDSKH();

        }
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string timkiemTenKH = txt_timkiem.Text;
            List<DSKH> kqTimKiem = service_banGiay.GetTimKiemKH(timkiemTenKH).ToList();
            data_DSKH.DataSource = kqTimKiem;
 
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string MaKH = txt_makh.Text;
            string TenKH = txt_tenkh.Text;
            string SoDienThoai = txt_sdt.Text;
            string DiaChi = txt_diachi.Text;
            string Email = txt_email.Text;
            string GioiTinh = cbo_gioitinh.Text;
            if (txt_tenkh.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên khách hàng", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (txt_sdt.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ ten tài khoản", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);

            }
            else if (txt_diachi.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Địa chỉ", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (txt_email.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(GioiTinh)) {
                MessageBox.Show("Vui lòng nhập đầy đủ Giới tính", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            } else {
                List<DSKH> themKH = service_banGiay.GetThemKH(MaKH,TenKH, SoDienThoai, DiaChi, Email, GioiTinh).ToList();
                data_DSKH.DataSource = themKH;
                MessageBox.Show("Đã thêm thành công", "Thông báo");
                data_DSKH.Refresh();
                data_DSKH.DataSource = service_banGiay.GetDSKH();
                macDinh();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbaoXoa = MessageBox.Show("Bạn muốn xóa Khách hàng", "Thông báo Xóa !!!", MessageBoxButtons.YesNo);
            if (thongbaoXoa == DialogResult.Yes) {
                String MaKH = data_DSKH.CurrentRow.Cells["MaKH"].Value.ToString();
                List<DSKH> dsXoaKH = service_banGiay.GetXoaKH(MaKH).ToList();
                data_DSKH.DataSource = dsXoaKH;
                data_DSKH.Refresh();
                data_DSKH.DataSource = service_banGiay.GetDSKH();
            }
            macDinh();
        }
        void laydulieu()
        {
            txt_makh.Text = data_DSKH.CurrentRow.Cells[0].Value.ToString();
            txt_tenkh.Text = data_DSKH.CurrentRow.Cells[1].Value.ToString();
            txt_sdt.Text = data_DSKH.CurrentRow.Cells[2].Value.ToString();
            txt_diachi.Text = data_DSKH.CurrentRow.Cells[3].Value.ToString();
            txt_email.Text = data_DSKH.CurrentRow.Cells[4].Value.ToString();
            cbo_gioitinh.Text = data_DSKH.CurrentRow.Cells[5].Value.ToString();
            
        }
        private void btn_sua_Click(object sender, EventArgs e)
            {
           
            string MaKH = data_DSKH.CurrentRow.Cells["MaKH"].Value.ToString();
            string TenKH = txt_tenkh.Text;
            string SoDienThoai = txt_sdt.Text;
            string DiaChi = txt_diachi.Text;
            string Email = txt_email.Text;
            string GioiTinh = cbo_gioitinh.Text; 
        
            if (txt_tenkh.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên khách hàng", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (txt_sdt.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ ten tài khoản", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);

            }
            else if (txt_diachi.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Địa chỉ", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (txt_email.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
    
            else
            {
                List<DSKH> suaKH = service_banGiay.GetSuaKH(MaKH, TenKH, SoDienThoai, DiaChi, Email, GioiTinh).ToList();
                data_DSKH.DataSource = suaKH;
                MessageBox.Show("Đã sửa thành công", "Thông báo");
                data_DSKH.Refresh();
                data_DSKH.DataSource = service_banGiay.GetDSKH();
                macDinh();
            }
            laydulieu();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbo_gioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void data_DSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void data_DSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            laydulieu(); 
        }

        private void btn_datlai_Click(object sender, EventArgs e)
        {
            macDinh();
        }
    }
}
