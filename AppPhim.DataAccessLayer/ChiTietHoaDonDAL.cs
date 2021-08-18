using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPhim.DataAccessLayer.Entities;

namespace AppPhim.DataAccessLayer
{
    public class ChiTietHoaDonDAL
    {
        /// <summary>
        /// Lấy danh sách hóa đơn
        /// </summary>
        /// <returns>List HoaDon</returns>
        public List<ChiTietHoaDon> GetChiTietHoaDonsTuHoaDon(int maHoaDon)
        {
            using (var dbcontext = new AppPhimModel())
            {
                return dbcontext.ChiTietHoaDon.Where(s => s.MaHoaDon == maHoaDon).ToList();
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
