using AppATM.DatabaseContext;
using AppATM.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppATM
{
    
    public partial class frmRutTien : Form
    {
        TaiKhoan taiKhoan;

        public event RutTienDelegate rutTienThanhCong;

        public frmRutTien()
        {
            InitializeComponent();
        }

        public frmRutTien(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.taiKhoan = taiKhoan;
        }


        private void BtnRutTien_Click(object sender, EventArgs e)
        {
            double soTienRut = double.Parse(txtSoTienRut.Text);
            if (taiKhoan.SoDu - soTienRut <= 50000)
            {
                MessageBox.Show("Số dư không đủ!");
                return;
            }
            using (var dbContext = new AppATMModel())
            {
                TaiKhoan tk = dbContext.TaiKhoan.Find(this.taiKhoan.Id);
                tk.SoDu -= soTienRut;
                dbContext.SaveChanges();
                taiKhoan = tk;
                rutTienThanhCong((double)tk.SoDu);
            }
        }
    }
}
