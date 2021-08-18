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
    public class HoaDonBAL
    {
        private readonly HoaDonDAL _hoaDonDAL;

        public HoaDonBAL()
        {
            _hoaDonDAL = new HoaDonDAL();
        }

        public List<HoaDonDTO> GetHoaDons()
        {
            return _hoaDonDAL.GetHoaDons();
        }
        public bool LuuHoaDon(HoaDon hoaDon, out string error)
        {
            return _hoaDonDAL.TaoMoiHoaDon(hoaDon, out error);
        }
    }
}
