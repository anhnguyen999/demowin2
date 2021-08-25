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
        private readonly HoaDonBAL _hoaDonBAL;
        int maKhachHang;
        public frmKhachHang()
        {
            InitializeComponent();
            _khachHangBAL = new KhachHangBAL();
            _hoaDonBAL = new HoaDonBAL();
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
            else
            {
                MessageBox.Show("luu khong thanh cong! " + error);
            }

        }

        private void DgvDanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            maKhachHang = int.Parse(dgvDanhSachKH.Rows[rowIndex].Cells[0].Value.ToString());
            string tenKhachHang = dgvDanhSachKH.Rows[rowIndex].Cells[1].Value.ToString();
            string soDienThoai = dgvDanhSachKH.Rows[rowIndex].Cells[2].Value.ToString();

            txtTenKhachHang.Text = tenKhachHang;
            txtSDT.Text = soDienThoai;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            //sua thong tin khach hang
            if (maKhachHang == 0)
            {
                MessageBox.Show("Vui long chon mot khach hang!");
                return;
            }
            string error;
            KhachHang khachHang = new KhachHang();
            khachHang.TenKhachHang = txtTenKhachHang.Text;
            khachHang.DienThoai = txtSDT.Text;
            khachHang.Id = maKhachHang;
            if (_khachHangBAL.LuuKhachHang(khachHang, out error))
            {
                MessageBox.Show("luu thanh cong!");
                TaiDanhSachKhachHang();
                txtTenKhachHang.Text = "";
                txtSDT.Text = "";
            }
            else
            {
                MessageBox.Show("luu khong thanh cong! " + error);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            //sua thong tin khach hang
            if (maKhachHang == 0)
            {
                MessageBox.Show("Vui long chon mot khach hang!");
                return;
            }
            if (_hoaDonBAL.KiemTraHoaDonByMaKhachHang(maKhachHang))
            {
                MessageBox.Show("Khong the xoa\nKhach hang da co hoa don!");
                return;
            }
            string error;
            KhachHang khachHang = new KhachHang();
            khachHang.TenKhachHang = txtTenKhachHang.Text;
            khachHang.DienThoai = txtSDT.Text;
            khachHang.Id = maKhachHang;
            if (_khachHangBAL.XoaKhachHang(khachHang, out error))
            {
                MessageBox.Show("luu thanh cong!");
                TaiDanhSachKhachHang();
                txtTenKhachHang.Text = "";
                txtSDT.Text = "";
            }
            else
            {
                MessageBox.Show("luu khong thanh cong! " + error);
            }
        }
    }
}
