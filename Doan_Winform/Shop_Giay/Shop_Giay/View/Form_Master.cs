using Shop_Giay.ServiceReference1;
using Shop_Giay.View.trangcon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shop_Giay.View
{
    public partial class Form_Master : Form
    {
    
        private ServiceSoapClient service_banGiay;
        private string LoaiTKDN { get; set; }
        private string ID { get; set; }
        //private string TenDn { get; set; }

        //private string TenNV;

        public Form_Master(string loaiTKDN,string TenDN,string Ma)
        {
            InitializeComponent();
            LoaiTKDN = loaiTKDN;
            if (loaiTKDN == "User") {
                btn_qlTK.Visible = false;
                btn_QLAD.Visible = false;
                btn_QLSP.Visible = false;
            }
            if (loaiTKDN == "Admin") {
                btn_qlTK.Visible = true;
                btn_QLAD.Visible = true;
                btn_QLSP.Visible = true;
            }
            ID = Ma;
            //TenDn = TenDN;
            lbl_tenDN.Text ="Hello : " + TenDN + $"(Id : {Ma} )" ;
            service_banGiay = new ServiceSoapClient();
            Form_Home form_Home = new Form_Home(loaiTKDN, ID);
            OpenFormCon(form_Home);
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            //lbl_tenDN.Text = tendn;
        }

        private Form activeChildForm;

 

        private void OpenFormCon(Form childForm) {
            if (activeChildForm != null) {
                activeChildForm.Close();
            }
            activeChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(childForm);
            panel_Content.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            Form_Home frm_home = new Form_Home(LoaiTKDN, ID);
            OpenFormCon(frm_home);

        }

        private void btn_danhgia_Click(object sender, EventArgs e)
        {
            OpenFormCon(new Form_DanhGia());
        }

        private void btn_qlTK_Click(object sender, EventArgs e)
        {
            OpenFormCon(new Form_TK_KhachHang());
        }

        private void btn_QLAD_Click(object sender, EventArgs e)
        {
            OpenFormCon(new Form_TK_Admin());
        }

        private void btn_QLSP_Click(object sender, EventArgs e)
        {
            OpenFormCon(new Form_QL_SP());
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            OpenFormCon(new Form_Hoa_Don());
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất khỏi ứng dụng không ???", "Đăng Xuất", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {

                Login lg = new Login();
                this.Hide();
                lg.Show();
            }
           
        
        }
    }
}
