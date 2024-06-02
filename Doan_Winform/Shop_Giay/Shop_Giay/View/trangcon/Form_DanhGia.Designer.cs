namespace Shop_Giay.View
{
    partial class Form_DanhGia
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TenNgDG = new System.Windows.Forms.TextBox();
            this.txt_DG = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Timf = new System.Windows.Forms.Label();
            this.data_DG = new System.Windows.Forms.DataGridView();
            this.pic_HInhAnh = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.data_sp = new System.Windows.Forms.DataGridView();
            this.lbl_TenSP = new System.Windows.Forms.Label();
            this.lbl_srcimg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_MaSP = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HInhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_sp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đánh giá sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_MaSP);
            this.groupBox1.Controls.Add(this.lbl_srcimg);
            this.groupBox1.Controls.Add(this.lbl_TenSP);
            this.groupBox1.Controls.Add(this.data_sp);
            this.groupBox1.Controls.Add(this.txt_tim);
            this.groupBox1.Controls.Add(this.pic_HInhAnh);
            this.groupBox1.Controls.Add(this.btn_tim);
            this.groupBox1.Controls.Add(this.txt_TenNgDG);
            this.groupBox1.Controls.Add(this.txt_DG);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Timf);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 407);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn sản phẩm đánh giá";
            // 
            // txt_TenNgDG
            // 
            this.txt_TenNgDG.Location = new System.Drawing.Point(126, 38);
            this.txt_TenNgDG.Name = "txt_TenNgDG";
            this.txt_TenNgDG.Size = new System.Drawing.Size(485, 22);
            this.txt_TenNgDG.TabIndex = 7;
            // 
            // txt_DG
            // 
            this.txt_DG.Location = new System.Drawing.Point(125, 299);
            this.txt_DG.Name = "txt_DG";
            this.txt_DG.Size = new System.Drawing.Size(408, 81);
            this.txt_DG.TabIndex = 6;
            this.txt_DG.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đánh giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Khách hàng";
            // 
            // Timf
            // 
            this.Timf.AutoSize = true;
            this.Timf.Location = new System.Drawing.Point(15, 88);
            this.Timf.Name = "Timf";
            this.Timf.Size = new System.Drawing.Size(95, 16);
            this.Timf.TabIndex = 2;
            this.Timf.Text = "Tìm Sản Phẩm";
            // 
            // data_DG
            // 
            this.data_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_DG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_DG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_DG.Location = new System.Drawing.Point(0, 482);
            this.data_DG.Name = "data_DG";
            this.data_DG.Size = new System.Drawing.Size(1007, 340);
            this.data_DG.TabIndex = 3;
            // 
            // pic_HInhAnh
            // 
            this.pic_HInhAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_HInhAnh.Location = new System.Drawing.Point(672, 21);
            this.pic_HInhAnh.Name = "pic_HInhAnh";
            this.pic_HInhAnh.Size = new System.Drawing.Size(279, 255);
            this.pic_HInhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_HInhAnh.TabIndex = 4;
            this.pic_HInhAnh.TabStop = false;
            this.pic_HInhAnh.Click += new System.EventHandler(this.pic_HInhAnh_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(481, 80);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(130, 33);
            this.btn_tim.TabIndex = 8;
            this.btn_tim.Text = "Tìm Sản Phẩm\r\n";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_chonSP_Click);
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(125, 88);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(350, 22);
            this.txt_tim.TabIndex = 9;
            // 
            // data_sp
            // 
            this.data_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_sp.Location = new System.Drawing.Point(125, 119);
            this.data_sp.Name = "data_sp";
            this.data_sp.Size = new System.Drawing.Size(485, 174);
            this.data_sp.TabIndex = 10;
            this.data_sp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_sp_CellClick);
            this.data_sp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_sp_CellContentClick);
            // 
            // lbl_TenSP
            // 
            this.lbl_TenSP.AutoSize = true;
            this.lbl_TenSP.Location = new System.Drawing.Point(669, 302);
            this.lbl_TenSP.Name = "lbl_TenSP";
            this.lbl_TenSP.Size = new System.Drawing.Size(22, 16);
            this.lbl_TenSP.TabIndex = 11;
            this.lbl_TenSP.Text = ".....";
            // 
            // lbl_srcimg
            // 
            this.lbl_srcimg.AutoSize = true;
            this.lbl_srcimg.Location = new System.Drawing.Point(669, 367);
            this.lbl_srcimg.Name = "lbl_srcimg";
            this.lbl_srcimg.Size = new System.Drawing.Size(19, 16);
            this.lbl_srcimg.TabIndex = 5;
            this.lbl_srcimg.Text = "....";
            this.lbl_srcimg.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm đánh giá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_danhGia_Click);
            // 
            // lbl_MaSP
            // 
            this.lbl_MaSP.AutoSize = true;
            this.lbl_MaSP.Location = new System.Drawing.Point(669, 339);
            this.lbl_MaSP.Name = "lbl_MaSP";
            this.lbl_MaSP.Size = new System.Drawing.Size(19, 16);
            this.lbl_MaSP.TabIndex = 5;
            this.lbl_MaSP.Text = "....";
            this.lbl_MaSP.Visible = false;
            // 
            // Form_DanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 822);
            this.Controls.Add(this.data_DG);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_DanhGia";
            this.Text = "Form_DanhGia";
            this.Load += new System.EventHandler(this.Form_DanhGia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HInhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_sp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Timf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data_DG;
        private System.Windows.Forms.TextBox txt_TenNgDG;
        private System.Windows.Forms.RichTextBox txt_DG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_HInhAnh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Label lbl_TenSP;
        private System.Windows.Forms.DataGridView data_sp;
        private System.Windows.Forms.Label lbl_srcimg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_MaSP;
    }
}