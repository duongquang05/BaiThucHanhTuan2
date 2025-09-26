using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2Tuan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnKq_Click(object sender, EventArgs e)
        {
            string hoTen = this.txtHoTen.Text.Trim();
            if (this.radChuThuong.Checked == true)
            {
                txtKetQua.Text = hoTen.ToLower();
            }
            if (this.radChuInHoa.Checked == true)
            {
                txtKetQua.Text = hoTen.ToUpper();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear(); 
            this.txtKetQua.Clear();
            this.radChuInHoa.Checked = true;
            this.txtHoTen.Focus();

        }
    }
}
