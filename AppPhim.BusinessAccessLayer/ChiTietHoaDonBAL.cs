using AppPhim.DataAccessLayer;
using AppPhim.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPhim.BusinessAccessLayer
{
    public class ChiTietHoaDonBAL
    {
        private readonly ChiTietHoaDonDAL _chiTietHoaDonDAL;
        public ChiTietHoaDonBAL()
        {
            _chiTietHoaDonDAL = new ChiTietHoaDonDAL();
        }

        public bool LuuChiTietHoaDon(ChiTietHoaDon chiTietHoaDon, out string error)
        {
            return _chiTietHoaDonDAL.TaoMoiChiTietHoaDon(chiTietHoaDon, out error);
        }
    }
}
