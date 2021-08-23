using AppPhim.DataAccessLayer.Entities;
using AppPhim.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPhim.DataAccessLayer
{
    public class KhachHangDAL
    {
        public List<KhachHangDTO> GetKhachHangs()
        {
            using (var dbcontext = new AppPhimModel())
            {
                var khachHangDTO = from b in dbcontext.KhachHang
                                select new KhachHangDTO()
                                {
                                    MaKhachHang = b.Id,
                                    TenKhachHang = b.TenKhachHang
                                };
                return khachHangDTO.ToList();
            }

        }
    }
}
