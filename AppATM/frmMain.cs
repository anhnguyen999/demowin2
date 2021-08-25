using AppATM.DatabaseContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppATM
{
    public partial class frmMain : Form
    {
        TaiKhoan taiKhoan = null;
        public frmMain()
        {
            InitializeComponent();
            lblSoDu.Text = "";
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            //kiem tra hợp lệ (các em tự làm)
            string tenTaiKhoan = txtTenTK.Text.Trim();
            string matKhau = MD5Hash(txtMatKhau.Text.Trim());
            using (var dbContext = new AppATMModel())
            {
                taiKhoan = dbContext.TaiKhoan.Where(s => s.TenTaiKhoan == tenTaiKhoan && s.MatKhau == matKhau).FirstOrDefault();

                if (taiKhoan != null)
                {
                    //dang nhap thanh cong
                    lblSoDu.Text = taiKhoan.SoDu.ToString();
                    btnRutTien.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Dang Nhap sai!");
                }
            }
        }

        private void BtnRutTien_Click(object sender, EventArgs e)
        {
            frmRutTien frm = new frmRutTien(taiKhoan);
            frm.rutTienThanhCong += Frm_rutTienThanhCong;
            frm.Show();
        }

        private void Frm_rutTienThanhCong(double soDuHienTai)
        {
            lblSoDu.Text = soDuHienTai.ToString();
        }
    }
}
