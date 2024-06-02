using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_Giay.ServiceReference1;
using Shop_Giay.View;

namespace Shop_Giay.View.trangcon
{
    public partial class Form_register_KH : Form
    {
        private ServiceSoapClient service_banGiay;
        public Form_register_KH()
        {
            InitializeComponent();
            service_banGiay = new ServiceSoapClient();
        }

        private void Form_register_KH_Load(object sender, EventArgs e)
        {
            macDinh();
        }
        public void macDinh()
        {
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            cboGioiTinh.Text = "Chọn Giới Tính";
            txtTkKH.Text = "";
            txtMK.Text = "";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string MaKH = txtTkKH.Text;
            string TenKH = txtTenKH.Text;
            string SoDienThoai = txtSDT.Text;
            string DiaChi = txtDiachi.Text;
            string Email = txtEmail.Text;
            string GioiTinh = cboGioiTinh.Text;
            string TK_KH = txtTkKH.Text;
            string Pass = txtMK.Text;
            if (txtTenKH.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên khách hàng", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (txtSDT.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ sô điện thoại", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);

            }
            else if (txtDiachi.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Địa chỉ", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (txtEmail.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (string.IsNullOrEmpty(GioiTinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Giới tính", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);
            }
            else if (txtTkKH.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên tài khoản", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);

            }
            else if (txtMK.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu tài khoản", "Thông báo nhập thiếu thông tin !!!", MessageBoxButtons.OK);

            }
            else
            {
                List<DSKH> themKH = service_banGiay.GetThemKH(MaKH,TenKH, SoDienThoai, DiaChi, Email, GioiTinh).ToList();
                List<QLTK> themTKKH = service_banGiay.ThemTKKH(TK_KH,Pass).ToList();
                
               MessageBox.Show("Bạn đã đăng ký thành công", "Thông báo");
                
                macDinh();
            }
        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pass.Checked)
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn muốn hủy bỏ đăng ký?", "Thông báo", MessageBoxButtons.YesNo);
            if (tb == DialogResult.Yes)
            {
                macDinh();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn muốn thoát đăng ký?", "Thông báo", MessageBoxButtons.YesNo);
            if (tb == DialogResult.Yes)
            {
                Close();

                
            }
        }
    }
}
