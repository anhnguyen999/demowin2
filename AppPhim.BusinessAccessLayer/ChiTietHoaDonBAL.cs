using AppPhim.DataAccessLayer;
using AppPhim.DataAccessLayer.Entities;
using AppPhim.DTO;
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

        public List<ChiTietHoaDon> GetChiTietHoaDons() {
            return _chiTietHoaDonDAL.GetChiTietHoaDons();
        }


        public List<ChiTietHoaDonDTO> GetChiTietHoaDonsByMaHoaDon(int maHoaDon)
        {
            return _chiTietHoaDonDAL.GetChiTietHoaDonsByMaHoaDon(maHoaDon);
        }

        public bool LuuChiTietHoaDon(ChiTietHoaDon chiTietHoaDon, out string error)
        {
            return _chiTietHoaDonDAL.TaoMoiChiTietHoaDon(chiTietHoaDon, out error);
        }
    }
}
