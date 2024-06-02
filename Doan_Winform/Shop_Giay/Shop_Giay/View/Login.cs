using Shop_Giay.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Linq;
using Shop_Giay.View.trangcon;
using Shop_Giay.View;

namespace Shop_Giay
{
    public partial class Login : Form
    {
        private ServiceSoapClient service_banGiay;

        private string TenDN { get; set; }
        public Login()
        {
            InitializeComponent();
            service_banGiay = new ServiceSoapClient();
        

        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
          
        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (check_pass.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else {
                txt_pass.PasswordChar = '*';
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát !!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No) {
                Close();
            }
        }
      
        private void btn_DN_Click(object sender, EventArgs e)
        {
            string TK = txt_TK.Text;
            string Pass = txt_pass.Text;
            string loaiTK = KiemtraTK(TK, Pass);
            //if(loaiTK == "Admin" || loaiTK == "User")
            //{
            //    Form_Master frm_ms = new Form_Master(loaiTK);
            //    frm_ms.Show();
            //    this.Hide();

            //    MessageBox.Show($"Đăng nhập thành công {loaiTK} : {loaiTK}", "Thông báo đăng nhập", MessageBoxButtons.OK);
            //}
            if (loaiTK == "Admin")
            {
               

                List<QLTK> admin = service_banGiay.GetLoginAdmin(TK, Pass).ToList();
                string TenDN = admin[0].TenNV;
                string Ma = Convert.ToInt32(admin[0].MaNV).ToString();
                Form_Master frm_mas = new Form_Master(loaiTK, TenDN,Ma);

                frm_mas.Show();
                this.Hide();
                MessageBox.Show($"Đăng nhập thành công :{TenDN} ", "Thông báo", MessageBoxButtons.OK);
            }
            else if (loaiTK == "User")
            {


                List<QLTK> KH = service_banGiay.GetLoginKH(TK, Pass).ToList();
                string TenDN = KH[0].TenKH;
                string Ma = KH[0].MaKH;
                Form_Master frm_mas = new Form_Master(loaiTK,TenDN, Ma);
                frm_mas.Show();
                this.Hide();
                MessageBox.Show($"Đăng nhập thành công : {TenDN}", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo");
            }
        }
        private string KiemtraTK(string TK,string Pass) {
            List<QLTK> admin = service_banGiay.GetLoginAdmin(TK, Pass).ToList();
            List<QLTK> kh = service_banGiay.GetLoginKH(TK, Pass).ToList();
            if (admin.Count > 0 ) {
                //username = new List<string> { admin[0].TenNV };
                return "Admin";
            }
            else if (kh.Count > 0 ) {
                //username = new List<string> { kh[0].TenKH };
                return "User";
            }
           
            return "";
        }
        private void linkDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_register_KH frDK = new Form_register_KH();
            frDK.ShowDialog();
            frDK.BringToFront();
        }
    }
    
    


    }
