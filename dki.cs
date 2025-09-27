using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dangki
{
    public partial class frmĐK : Form
    {
        public frmĐK()
        {
            InitializeComponent();
        }

        private void btnĐK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtDKTK.Text == "")
            {
                errorProvider1.SetError(txtDKTK, "Vui lòng nhập tài khoản");
            }
            if (txtMK.Text == "")
            {
                errorProvider1.SetError(txtMK, "Vui lòng nhập mật khẩu");
            }
            if (txtNLMK.Text == "")
            {
                errorProvider1.SetError(txtNLMK, "Vui lòng nhập lại mật khẩu");
            }
            if (txtMK.MaxLength < 8)
            {
                errorProvider1.SetError(txtMK, "Mật khẩu phải lớn hơn 8 ký tự");
            }
            if (txtMK.Text != txtNLMK.Text)
            {
                errorProvider1.SetError(txtNLMK, "Mật khẩu không khớp");
            }
            if(txtMK.Text.Length < 8)
            {
                errorProvider1.SetError(txtMK, "Mật khẩu phải lớn hơn 8 ký tự");
            }
            if (txtDKTK.Text != "" && txtMK.Text != "" && txtNLMK.Text != "" && txtMK.Text == txtNLMK.Text && txtMK.Text.Length >=8)
            {
                MessageBox.Show("Đăng kí thành công");
                this.Hide();
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '*';

        }

        private void txtNLMK_TextChanged(object sender, EventArgs e)
        {
            txtNLMK.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMK.Checked)
            {
                txtMK.PasswordChar = '\0';
                picShow1.Hide();
                picHide1.Show();
            }
            else
            {
                txtMK.PasswordChar = '*';
                picShow1.Show();
                picHide1.Hide();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNLMK.Checked)
            {
                txtNLMK.PasswordChar = '\0';
                picShow2.Hide();
                picHide2.Show();
            }
            else
            {
                txtNLMK.PasswordChar = '*';
                picShow2.Show();
                picHide2.Hide();
            }
        }

        private void frmĐK_Load(object sender, EventArgs e)
        {
        }

        private void lblTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void lblMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}
