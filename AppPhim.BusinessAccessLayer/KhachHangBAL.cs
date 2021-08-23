using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPhim.DataAccessLayer;
using AppPhim.DTO;

namespace AppPhim.BusinessAccessLayer
{
    public class KhachHangBAL
    {
        private readonly KhachHangDAL _khachHangDAL;

        public KhachHangBAL()
        {
            _khachHangDAL = new KhachHangDAL();
        }

        public List<KhachHangDTO> GetKhachHangs()
        {
            return _khachHangDAL.GetKhachHangs();
        }
    }
}
