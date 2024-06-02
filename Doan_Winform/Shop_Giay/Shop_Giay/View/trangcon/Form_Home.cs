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
using System.Web.Services.Description;
using System.Windows.Forms;

namespace Shop_Giay.View
{
    public partial class Form_Home : Form
    {
        private string loaiTK { get; set; }
        private string ID { get; set; }
        private ServiceSoapClient service_banGiay;
        public Form_Home( string loaiTKDN,string Ma)
        {
            InitializeComponent();
            service_banGiay = new ServiceSoapClient();
            ID = Ma;
            loaiTK = loaiTKDN;
            if (loaiTKDN == "Admin") {
                lblTenMaKH.Visible = false;
                lblMaKH.Visible=false;
            }
            lblMaKH.Text =  Ma;
            
            //if (loaiTKDN == "Admin")
            //{

            //    MessageBox.Show("Bạn là admin nên khogno thể mua !!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //}

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            List<DSBAN> dsban = service_banGiay.GetDSBAN().ToList();
            dataDSBAN.DataSource = dsban;
            dataDSBAN.Columns["MoTa"].Visible = false;
            dataDSBAN.Columns["HinhAnh"].Visible = false;
            dataDSBAN.Columns["MaLoaiSP"].Visible = false;
            dataDSBAN.Columns["LoaiSP"].Visible = false;
            DataGridViewColumn column = dataDSBAN.Columns[0];
            column.Width = 40;
           
            lbl_srcc.Visible = false;

        }
        void laydulieuBan()
        {
            lbl_maSP.Text = dataDSBAN.CurrentRow.Cells[0].Value.ToString();
            lbl_tensp.Text = dataDSBAN.CurrentRow.Cells[1].Value.ToString();
            richTextBox1.Text = dataDSBAN.CurrentRow.Cells[2].Value.ToString();
            lbl_srcc.Text = dataDSBAN.CurrentRow.Cells[3].Value.ToString();
            lbl_Gia.Text = dataDSBAN.CurrentRow.Cells[4].Value.ToString();
            lbl_hang.Text = dataDSBAN.CurrentRow.Cells[6].Value.ToString();
            string imageSRC = lbl_srcc.Text;
            if (File.Exists(imageSRC))
            {
                using (FileStream fs = new FileStream(imageSRC, FileMode.Open, FileAccess.Read))
                {
                    pic_hinhBan.Image = System.Drawing.Image.FromStream(fs);
                }
            }
        }

        private void dataDSBAN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            laydulieuBan();
        }

        private void cbo_loaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
        

           
        }

        private void pic_hinhBan_Click(object sender, EventArgs e)
        {
            lbl_srcc.Text = dataDSBAN.CurrentRow.Cells[3].Value.ToString();
            string imageSRC = lbl_srcc.Text;
            if (File.Exists(imageSRC))
            {
                using (FileStream fs = new FileStream(imageSRC, FileMode.Open, FileAccess.Read))
                {
                    pic_hinhBan.Image = System.Drawing.Image.FromStream(fs);
                }
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string timkiemTenSPBan = txt_tim.Text;
            List<DSBAN> kqTimKiem = service_banGiay.GetTimKiemSPBan(timkiemTenSPBan).ToList();
            dataDSBAN.DataSource = kqTimKiem;
        }

        private void pic_hinhBan_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
       
        private void btn_mua_Click(object sender, EventArgs e)
        {
                string loaiTKDN = loaiTK;

            if (loaiTKDN == "Admin")
            {
                MessageBox.Show("Bạn là admin nên khogno thể mua !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
            
                DateTime NgayDat = DateTime.Now;
                int Soluong = (int)num_soluong.Value;
                string MaSanPham = lbl_maSP.Text.Trim();
                string TongTien = lbl_Gia.Text;
                string MaKH = lblMaKH.Text.ToString();
                if (int.TryParse(MaSanPham, out int MaSP)) { MaSP = int.Parse(MaSanPham); }
                    
                DialogResult log = MessageBox.Show("Bạn có muốn mua sản phảm này không !!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (log == DialogResult.Yes)
                {
                    List<MuaHang> muah = service_banGiay.GetMua(NgayDat, TongTien, Soluong, MaKH, MaSP).ToList();
                    MessageBox.Show("Bạn đã mua hàng thành công ", "Thông báo mua thành công", MessageBoxButtons.OK);
                }
            }
           
            
        }
    }

}

