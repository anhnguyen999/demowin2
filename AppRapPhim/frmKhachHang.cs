using AppPhim.BusinessAccessLayer;
using AppPhim.DataAccessLayer.Entities;
using AppPhim.DTO;
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
    public partial class frmKhachHang : Form
    {
        private readonly KhachHangBAL _khachHangBAL;
        public frmKhachHang()
        {
            InitializeComponent();
            _khachHangBAL = new KhachHangBAL();
            this.Load += FrmKhachHang_Load;
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            TaiDanhSachKhachHang();
        }

        private void TaiDanhSachKhachHang()
        {
            List<KhachHangDTO> danhSachKhachHang = _khachHangBAL.GetKhachHangs();
            dgvDanhSachKH.DataSource = danhSachKhachHang;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string error;
            KhachHang khachHang = new KhachHang();
            khachHang.TenKhachHang = txtTenKhachHang.Text;
            khachHang.DienThoai = txtSDT.Text;
            if (_khachHangBAL.LuuKhachHang(khachHang, out error))
            {
                MessageBox.Show("luu thanh cong!");
                TaiDanhSachKhachHang();
            }
            else{
                MessageBox.Show("luu khong thanh cong! " + error);
            }

        }
    }
}
