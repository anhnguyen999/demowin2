using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppPhim.BusinessAccessLayer;
using AppPhim.DataAccessLayer;

namespace AppRapPhim
{
    public partial class frmLogin : Form
    {
        private readonly TaiKhoanBAL _taiKhoanBAL;

        public frmLogin()
        {
            InitializeComponent();
            _taiKhoanBAL = new TaiKhoanBAL();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            //kiem tra thông tin hợp lệ
            string userName = txtUserName.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            if (userName == "" || password == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ Tên đăng nhập & Mật khẩu!");

                return;
            }
            string error;
            if (_taiKhoanBAL.KiemTraDangNhap(userName, password, out error))
            {
                MessageBox.Show("đăng nhập thành công!");

            }
            else
            {
                MessageBox.Show("Đăng nhập sai\n"+ error);
            }
        }

        private void TxtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput(sender);
        }

        private bool ValidateInput(object sender)
        {
            TextBox txtInput = (TextBox)sender;
            if (txtInput.Text == "")
            {
                errorProvider1.SetError(txtInput, "Vui lòng nhập thông tin!");
                return false;
            }
           
            errorProvider1.SetError(txtInput, "");
            return true;
        }
    }
}
