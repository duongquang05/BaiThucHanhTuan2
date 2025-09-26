using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1Tuan2
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void chkNho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "ten dang nhap la:";
            thongbao += this.txtDangNhap.Text;
            thongbao += "\n mat khau la:";
            thongbao += this.txtMatKhau.Text;
            if(this.chkNho.Checked)
                thongbao += "\n Ban da chon nho mat khau";
            else
                thongbao += "\n Ban khong chon nho mat khau";
            MessageBox.Show(thongbao, "Thong bao");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtDangNhap.Clear();
            this.txtMatKhau.Clear();
            this.txtDangNhap.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void txtDangNhap_TextChanged(object sender, EventArgs e)
        {
              
        }
    }
}
