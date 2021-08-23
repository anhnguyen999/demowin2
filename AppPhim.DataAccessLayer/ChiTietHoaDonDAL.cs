using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPhim.DataAccessLayer.Entities;
using AppPhim.DTO;

namespace AppPhim.DataAccessLayer
{
    public class ChiTietHoaDonDAL
    {
        /// <summary>
        /// Lấy danh sách hóa đơn
        /// </summary>
        /// <returns>List HoaDon</returns>
        public List<ChiTietHoaDonDTO> GetChiTietHoaDonsByMaHoaDon(int maHoaDon)
        {
            using (var dbcontext = new AppPhimModel())
            {
                var chiTietHoaDonDTO = from b in dbcontext.ChiTietHoaDon
                                       where b.MaHoaDon == maHoaDon
                                        select new ChiTietHoaDonDTO()
                                        {
                                            MaChiTiet = b.Id,
                                            SoGhe = (int)b.SoGhe,
                                            GiaTien = (double)b.GiaTien
                                        };
                return chiTietHoaDonDTO.ToList();
            }
        }

        public List<ChiTietHoaDon> GetChiTietHoaDons()
        {
            using (var dbcontext = new AppPhimModel())
            {
                return dbcontext.ChiTietHoaDon.ToList();
            }
        }

        public bool TaoMoiChiTietHoaDon(ChiTietHoaDon chiTietHoaDon, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new AppPhimModel())
                {
                    dbcontext.ChiTietHoaDon.Add(chiTietHoaDon);
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
