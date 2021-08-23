using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRapPhim
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void OpenBanVe_Click(object sender, EventArgs e)
        {
            //kiểm tra sự tồn tại của frmBanVe trước khi tạo form mới
            Form frm = this.MdiChildren.OfType<frmBanVe>().FirstOrDefault();
            if (frm == null)
            {
                frmBanVe frmBanVe = new frmBanVe();
                frmBanVe.MdiParent = this;
                frmBanVe.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void ĐĂNGNHẬPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kiểm tra sự tồn tại của frmBanVe trước khi tạo form mới
            Form frm = this.MdiChildren.OfType<frmLogin>().FirstOrDefault();
            if (frm == null)
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.MdiParent = this;
                frmLogin.loginSucess += FrmLogin_loginSucess;
                frmLogin.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void FrmLogin_loginSucess()
        {
            InitMenu(true);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitMenu(false);
        }

        private void InitMenu(bool v)
        {
            menuDangXuat.Enabled = v;
            menuDangNhap.Enabled = !v;
            menuBaoCao.Enabled = v;
            menuQuanLy.Enabled = v;
        }

        private void MenuDangXuat_Click(object sender, EventArgs e)
        {
            InitMenu(false);
        }

        private void QUẢNLÝKHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kiểm tra sự tồn tại của frmBanVe trước khi tạo form mới
            Form frm = this.MdiChildren.OfType<frmKhachHang>().FirstOrDefault();
            if (frm == null)
            {
                frmKhachHang frmKhachHang = new frmKhachHang();
                frmKhachHang.MdiParent = this;
                frmKhachHang.Show();
            }
            else
            {
                frm.Activate();
            }
        }
    }
}
