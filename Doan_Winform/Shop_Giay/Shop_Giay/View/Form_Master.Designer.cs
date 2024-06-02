namespace Shop_Giay.View
{
    partial class Form_Master
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Master));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.lbl_tenDN = new System.Windows.Forms.Label();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_QLAD = new System.Windows.Forms.Button();
            this.btn_qlTK = new System.Windows.Forms.Button();
            this.btn_QLSP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_danhgia = new System.Windows.Forms.Button();
            this.btn_TrangChu = new System.Windows.Forms.Button();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.lbl_tenDN);
            this.panel_Menu.Controls.Add(this.btn_dangxuat);
            this.panel_Menu.Controls.Add(this.panel1);
            this.panel_Menu.Controls.Add(this.btn_QLAD);
            this.panel_Menu.Controls.Add(this.btn_qlTK);
            this.panel_Menu.Controls.Add(this.btn_QLSP);
            this.panel_Menu.Controls.Add(this.pictureBox1);
            this.panel_Menu.Controls.Add(this.btn_HoaDon);
            this.panel_Menu.Controls.Add(this.btn_danhgia);
            this.panel_Menu.Controls.Add(this.btn_TrangChu);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(261, 861);
            this.panel_Menu.TabIndex = 1;
            // 
            // lbl_tenDN
            // 
            this.lbl_tenDN.AutoSize = true;
            this.lbl_tenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenDN.Location = new System.Drawing.Point(7, 75);
            this.lbl_tenDN.Name = "lbl_tenDN";
            this.lbl_tenDN.Size = new System.Drawing.Size(42, 25);
            this.lbl_tenDN.TabIndex = 10;
            this.lbl_tenDN.Text = ".....";
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.Location = new System.Drawing.Point(12, 805);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(232, 44);
            this.btn_dangxuat.TabIndex = 9;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 797);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 2);
            this.panel1.TabIndex = 8;
            // 
            // btn_QLAD
            // 
            this.btn_QLAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLAD.Location = new System.Drawing.Point(0, 433);
            this.btn_QLAD.Name = "btn_QLAD";
            this.btn_QLAD.Size = new System.Drawing.Size(261, 59);
            this.btn_QLAD.TabIndex = 4;
            this.btn_QLAD.Text = "Quản lý tài khoản ADmin";
            this.btn_QLAD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLAD.UseVisualStyleBackColor = true;
            this.btn_QLAD.Click += new System.EventHandler(this.btn_QLAD_Click);
            // 
            // btn_qlTK
            // 
            this.btn_qlTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlTK.Location = new System.Drawing.Point(0, 368);
            this.btn_qlTK.Name = "btn_qlTK";
            this.btn_qlTK.Size = new System.Drawing.Size(261, 59);
            this.btn_qlTK.TabIndex = 3;
            this.btn_qlTK.Text = "Quản lý tài khoản";
            this.btn_qlTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlTK.UseVisualStyleBackColor = true;
            this.btn_qlTK.Click += new System.EventHandler(this.btn_qlTK_Click);
            // 
            // btn_QLSP
            // 
            this.btn_QLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLSP.Location = new System.Drawing.Point(0, 498);
            this.btn_QLSP.Name = "btn_QLSP";
            this.btn_QLSP.Size = new System.Drawing.Size(261, 59);
            this.btn_QLSP.TabIndex = 5;
            this.btn_QLSP.Text = "Quản lý sản phẩm";
            this.btn_QLSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLSP.UseVisualStyleBackColor = true;
            this.btn_QLSP.Click += new System.EventHandler(this.btn_QLSP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.Location = new System.Drawing.Point(0, 304);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(261, 59);
            this.btn_HoaDon.TabIndex = 6;
            this.btn_HoaDon.Text = "Hóa đơn";
            this.btn_HoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoaDon.UseVisualStyleBackColor = true;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // btn_danhgia
            // 
            this.btn_danhgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_danhgia.Location = new System.Drawing.Point(0, 239);
            this.btn_danhgia.Name = "btn_danhgia";
            this.btn_danhgia.Size = new System.Drawing.Size(261, 59);
            this.btn_danhgia.TabIndex = 2;
            this.btn_danhgia.Text = "Đánh giá";
            this.btn_danhgia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_danhgia.UseVisualStyleBackColor = true;
            this.btn_danhgia.Click += new System.EventHandler(this.btn_danhgia_Click);
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu.Location = new System.Drawing.Point(0, 174);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(261, 59);
            this.btn_TrangChu.TabIndex = 1;
            this.btn_TrangChu.Text = "Trang chủ";
            this.btn_TrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TrangChu.UseVisualStyleBackColor = true;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // panel_Content
            // 
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Content.Location = new System.Drawing.Point(261, 0);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1023, 861);
            this.panel_Content.TabIndex = 2;
            // 
            // Form_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 861);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel_Menu);
            this.MaximumSize = new System.Drawing.Size(1300, 900);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form_Master";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.Form_Home_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.Button btn_QLSP;
        private System.Windows.Forms.Button btn_QLAD;
        private System.Windows.Forms.Button btn_qlTK;
        private System.Windows.Forms.Button btn_danhgia;
        private System.Windows.Forms.Button btn_TrangChu;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_tenDN;
    }
}