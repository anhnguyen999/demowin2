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
    public partial class frmBanVe : Form
    {
        private readonly HoaDonBAL _hoaDonBAL;
        private readonly ChiTietHoaDonBAL _chiTietHoaDonBAL;
        int soLuongGhe = 15;

        public frmBanVe()
        {
            InitializeComponent();
            _hoaDonBAL = new HoaDonBAL();
            _chiTietHoaDonBAL = new ChiTietHoaDonBAL();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            KhoiTaoGhe();
            TaiDanhSachHoaDon();
        }

        private void KhoiTaoGhe()
        {
            Button btn;
            int x;
            int y = 20, kc = 10;
            int count = 1;
            for (int i = 0; i < 3; i++)
            {
                x = 15;
                for (int j = 0; j < soLuongGhe / 3; j++)
                {
                    btn = new Button();
                    btn.Location = new System.Drawing.Point(x + 80 * j, y + 46 * i);
                    btn.Name = "btn" + count;
                    btn.Size = new System.Drawing.Size(80, 46);
                    btn.TabIndex = 0;
                    btn.Text = count.ToString();
                    btn.UseVisualStyleBackColor = true;
                    btn.BackColor = Color.White;
                    btn.Click += Btn_Click;
                    pnGhe.Controls.Add(btn);
                    count++;
                    x += kc;
                }
                y += kc;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đã được mua");
                return;
            }
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.Yellow;
            }
            else
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string error;
            //tính tiền
            //lưu thông tin bán vé vào database
            List<int> danhSachGhe = new List<int>();
            double sum = 0;
            foreach (Button btnGhe in pnGhe.Controls.OfType<Button>().Where(x => x.BackColor == Color.Blue))
            {
                int soGhe = int.Parse(btnGhe.Text);
                sum += TinhTien(soGhe);
                btnGhe.BackColor = Color.Yellow;
                danhSachGhe.Add(soGhe);
            }
            txtTongTien.Text = sum.ToString();

            HoaDon hoaDon = new HoaDon();
            hoaDon.NgayMua = DateTime.Now;
            hoaDon.TongTien = sum;
            ChiTietHoaDon chiTietHoaDon;
            if (_hoaDonBAL.LuuHoaDon(hoaDon, out error))
            {
                foreach (int soGhe in danhSachGhe)
                {
                    chiTietHoaDon = new ChiTietHoaDon();
                    chiTietHoaDon.MaHoaDon = hoaDon.Id;
                    chiTietHoaDon.SoGhe = soGhe;
                    chiTietHoaDon.GiaTien = TinhTien(soGhe);
                    if(!_chiTietHoaDonBAL.LuuChiTietHoaDon(chiTietHoaDon, out error))
                    {
                        MessageBox.Show("Lỗi lưu chi tiet hóa đơn: " + error);
                        return;
                    }
                }
                MessageBox.Show("Lưu thành công hóa đơn");
                TaiDanhSachHoaDon();
            }
            else
            {
                MessageBox.Show("Lỗi lưu hóa đơn: " + error);
            }
        }

        private void TaiDanhSachHoaDon()
        {
            List<HoaDonDTO> danhSachHoaDon = _hoaDonBAL.GetHoaDons();
            dgvHoaDon.DataSource = danhSachHoaDon;
        }

        private double TinhTien(int soGhe)
        {
            if (soGhe <= 5)
            {
                return 5000;
            }
            else if (soGhe <= 10)
            {
                return 6500;
            }
            return 8000;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ResetGhe();
        }

        private void ResetGhe()
        {
            foreach (Button btnGhe in pnGhe.Controls.OfType<Button>().Where(x => x.BackColor == Color.Yellow))
            {
                btnGhe.BackColor = Color.White;
                btnGhe.ForeColor = Color.Black;
            }
            txtTongTien.Text = "0";
        }
    }
}
