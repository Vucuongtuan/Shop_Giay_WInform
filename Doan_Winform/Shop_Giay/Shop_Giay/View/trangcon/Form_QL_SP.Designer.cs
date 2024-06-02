namespace Shop_Giay.View.trangcon
{
    partial class Form_QL_SP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QL_SP));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_upimgSP = new System.Windows.Forms.Button();
            this.pic_hinhanhSP = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_moTa = new System.Windows.Forms.TextBox();
            this.txt_tenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_datlai = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.data_DSQL = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_LoaiSP = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_src = new System.Windows.Forms.Label();
            this.btn_themsanpham = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinhanhSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // txt_gia
            // 
            this.txt_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.Location = new System.Drawing.Point(159, 157);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(206, 22);
            this.txt_gia.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 56;
            this.label9.Text = "Giá";
            // 
            // btn_upimgSP
            // 
            this.btn_upimgSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upimgSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_upimgSP.Image")));
            this.btn_upimgSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_upimgSP.Location = new System.Drawing.Point(758, 279);
            this.btn_upimgSP.Name = "btn_upimgSP";
            this.btn_upimgSP.Size = new System.Drawing.Size(218, 32);
            this.btn_upimgSP.TabIndex = 55;
            this.btn_upimgSP.Text = "Tải hình lên";
            this.btn_upimgSP.UseVisualStyleBackColor = true;
            this.btn_upimgSP.Click += new System.EventHandler(this.btn_upimg_Click);
            // 
            // pic_hinhanhSP
            // 
            this.pic_hinhanhSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_hinhanhSP.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_hinhanhSP.InitialImage")));
            this.pic_hinhanhSP.Location = new System.Drawing.Point(758, 29);
            this.pic_hinhanhSP.Name = "pic_hinhanhSP";
            this.pic_hinhanhSP.Size = new System.Drawing.Size(218, 212);
            this.pic_hinhanhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_hinhanhSP.TabIndex = 54;
            this.pic_hinhanhSP.TabStop = false;
            this.pic_hinhanhSP.Click += new System.EventHandler(this.pic_hinhanhSP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(397, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Mô Tả";
            // 
            // txt_moTa
            // 
            this.txt_moTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_moTa.Location = new System.Drawing.Point(513, 52);
            this.txt_moTa.Name = "txt_moTa";
            this.txt_moTa.Size = new System.Drawing.Size(206, 22);
            this.txt_moTa.TabIndex = 52;
            // 
            // txt_tenSP
            // 
            this.txt_tenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenSP.Location = new System.Drawing.Point(159, 101);
            this.txt_tenSP.Name = "txt_tenSP";
            this.txt_tenSP.Size = new System.Drawing.Size(206, 22);
            this.txt_tenSP.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // btn_datlai
            // 
            this.btn_datlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datlai.Image = ((System.Drawing.Image)(resources.GetObject("btn_datlai.Image")));
            this.btn_datlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_datlai.Location = new System.Drawing.Point(644, 317);
            this.btn_datlai.Name = "btn_datlai";
            this.btn_datlai.Size = new System.Drawing.Size(72, 32);
            this.btn_datlai.TabIndex = 63;
            this.btn_datlai.Text = "Đặt lại";
            this.btn_datlai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_datlai.UseVisualStyleBackColor = true;
            this.btn_datlai.Click += new System.EventHandler(this.btn_datlai_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(830, 317);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(72, 32);
            this.btn_sua.TabIndex = 62;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(920, 317);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(72, 32);
            this.btn_Xoa.TabIndex = 60;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // data_DSQL
            // 
            this.data_DSQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_DSQL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_DSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_DSQL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_DSQL.Location = new System.Drawing.Point(0, 355);
            this.data_DSQL.Name = "data_DSQL";
            this.data_DSQL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.data_DSQL.Size = new System.Drawing.Size(1007, 467);
            this.data_DSQL.TabIndex = 64;
            this.data_DSQL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_DSQL_CellClick);
            this.data_DSQL.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.data_DSNV_DataError);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 67;
            this.label10.Text = "Tìm tên sản phẩm";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.Image")));
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(231, 310);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(94, 32);
            this.btn_timkiem.TabIndex = 66;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_timkiem.Location = new System.Drawing.Point(30, 317);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(195, 20);
            this.txt_timkiem.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Loại sản phẩm";
            // 
            // cbo_LoaiSP
            // 
            this.cbo_LoaiSP.FormattingEnabled = true;
            this.cbo_LoaiSP.Location = new System.Drawing.Point(159, 51);
            this.cbo_LoaiSP.Name = "cbo_LoaiSP";
            this.cbo_LoaiSP.Size = new System.Drawing.Size(206, 21);
            this.cbo_LoaiSP.TabIndex = 69;
            this.cbo_LoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbo_LoaiSP_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_src
            // 
            this.lbl_src.AutoSize = true;
            this.lbl_src.Location = new System.Drawing.Point(755, 253);
            this.lbl_src.Name = "lbl_src";
            this.lbl_src.Size = new System.Drawing.Size(25, 13);
            this.lbl_src.TabIndex = 70;
            this.lbl_src.Text = "......";
            // 
            // btn_themsanpham
            // 
            this.btn_themsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themsanpham.Image = ((System.Drawing.Image)(resources.GetObject("btn_themsanpham.Image")));
            this.btn_themsanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themsanpham.Location = new System.Drawing.Point(738, 317);
            this.btn_themsanpham.Name = "btn_themsanpham";
            this.btn_themsanpham.Size = new System.Drawing.Size(72, 32);
            this.btn_themsanpham.TabIndex = 72;
            this.btn_themsanpham.Text = "Thêm";
            this.btn_themsanpham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themsanpham.UseVisualStyleBackColor = true;
            this.btn_themsanpham.Click += new System.EventHandler(this.btn_themsanpham_Click);
            // 
            // Form_QL_SP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 822);
            this.Controls.Add(this.btn_themsanpham);
            this.Controls.Add(this.lbl_src);
            this.Controls.Add(this.cbo_LoaiSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.data_DSQL);
            this.Controls.Add(this.btn_datlai);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_upimgSP);
            this.Controls.Add(this.pic_hinhanhSP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_moTa);
            this.Controls.Add(this.txt_tenSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_QL_SP";
            this.Text = "Form_QL_SP";
            this.Load += new System.EventHandler(this.Form_QL_SP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinhanhSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_DSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_upimgSP;
        private System.Windows.Forms.PictureBox pic_hinhanhSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_moTa;
        private System.Windows.Forms.TextBox txt_tenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_datlai;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView data_DSQL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_LoaiSP;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_src;
        private System.Windows.Forms.Button btn_themsanpham;
    }
}