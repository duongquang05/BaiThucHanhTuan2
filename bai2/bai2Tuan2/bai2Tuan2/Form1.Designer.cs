namespace bai2Tuan2
{
    partial class Form1
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
            this.lblNhap = new System.Windows.Forms.Label();
            this.btnKq = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.radChuThuong = new System.Windows.Forms.RadioButton();
            this.radChuInHoa = new System.Windows.Forms.RadioButton();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.grbKieuChu = new System.Windows.Forms.GroupBox();
            this.grbKieuChu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhap.Location = new System.Drawing.Point(157, 117);
            this.lblNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(142, 23);
            this.lblNhap.TabIndex = 0;
            this.lblNhap.Text = "Nhập họ và tên:";
            this.lblNhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKq
            // 
            this.btnKq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKq.Location = new System.Drawing.Point(114, 412);
            this.btnKq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKq.Name = "btnKq";
            this.btnKq.Size = new System.Drawing.Size(153, 32);
            this.btnKq.TabIndex = 1;
            this.btnKq.Text = "Kết Quả";
            this.btnKq.UseVisualStyleBackColor = true;
            this.btnKq.Click += new System.EventHandler(this.btnKq_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(336, 117);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(354, 30);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(671, 220);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(162, 138);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // radChuThuong
            // 
            this.radChuThuong.AutoSize = true;
            this.radChuThuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChuThuong.Location = new System.Drawing.Point(15, 47);
            this.radChuThuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radChuThuong.Name = "radChuThuong";
            this.radChuThuong.Size = new System.Drawing.Size(124, 26);
            this.radChuThuong.TabIndex = 5;
            this.radChuThuong.TabStop = true;
            this.radChuThuong.Text = "chữ thường ";
            this.radChuThuong.UseVisualStyleBackColor = true;
            this.radChuThuong.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radChuInHoa
            // 
            this.radChuInHoa.AutoSize = true;
            this.radChuInHoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radChuInHoa.Location = new System.Drawing.Point(15, 78);
            this.radChuInHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radChuInHoa.Name = "radChuInHoa";
            this.radChuInHoa.Size = new System.Drawing.Size(146, 26);
            this.radChuInHoa.TabIndex = 6;
            this.radChuInHoa.TabStop = true;
            this.radChuInHoa.Text = "CHỮ IN HOA";
            this.radChuInHoa.UseVisualStyleBackColor = true;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(309, 412);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(443, 30);
            this.txtKetQua.TabIndex = 7;
            this.txtKetQua.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // grbKieuChu
            // 
            this.grbKieuChu.Controls.Add(this.radChuThuong);
            this.grbKieuChu.Controls.Add(this.radChuInHoa);
            this.grbKieuChu.Location = new System.Drawing.Point(76, 212);
            this.grbKieuChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbKieuChu.Name = "grbKieuChu";
            this.grbKieuChu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbKieuChu.Size = new System.Drawing.Size(600, 146);
            this.grbKieuChu.TabIndex = 8;
            this.grbKieuChu.TabStop = false;
            this.grbKieuChu.Text = "Chọn kiểu chữ ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 513);
            this.Controls.Add(this.grbKieuChu);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btnKq);
            this.Controls.Add(this.lblNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbKieuChu.ResumeLayout(false);
            this.grbKieuChu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.Button btnKq;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.RadioButton radChuThuong;
        private System.Windows.Forms.RadioButton radChuInHoa;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.GroupBox grbKieuChu;
    }
}

