using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPhim.DataAccessLayer.Entities;
using AppPhim.DTO;

namespace AppPhim.DataAccessLayer
{
    public class HoaDonDAL
    {
        /// <summary>
        /// Lấy danh sách hóa đơn
        /// </summary>
        /// <returns>List HoaDon</returns>
        public List<HoaDonDTO> GetHoaDons()
        {
            using (var dbcontext = new AppPhimModel())
            {
                var hoaDonDTO = from b in dbcontext.HoaDon
                                select new HoaDonDTO()
                                {
                                    MaHoaDon = b.Id,
                                    NgayMua = (DateTime)b.NgayMua,
                                    TongTien = (double)b.TongTien,
                                    TenKhachHang = b.KhachHang.TenKhachHang
                            };
                return hoaDonDTO.ToList();
            }
            
        }

        public bool TaoMoiHoaDon(HoaDon hoaDon, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new AppPhimModel())
                {
                    dbcontext.HoaDon.Add(hoaDon);
                    dbcontext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
