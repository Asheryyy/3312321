using dangki;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap1
{
    public partial class frmĐN : Form
    {
        public frmĐN()
        {
            InitializeComponent();
        }

        private void btnĐK_Click(object sender, EventArgs e)
        {
            // 12321
            frmĐK f = new frmĐK();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtDN.Text == "admin" && txtMK.Text == "admin") // thay admin = tai khoan tren database
            {
                MessageBox.Show("Đăng nhập thành công !");
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu , vui lòng nhập lại");
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHide.Checked)
            {
                txtMK.PasswordChar = '\0';
                picShow.Hide();
                picHide.Show();
            }
            else
            {
                txtMK.PasswordChar = '*';
                picShow.Show();
                picHide.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void picShow_Click(object sender, EventArgs e)
        {

        }

        private void frmĐN_Load(object sender, EventArgs e)
        {
            
        }
    }
}
