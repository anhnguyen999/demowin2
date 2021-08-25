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
                                    TenKhachHang = b.TenKhachHang,
                                    SoDienThoai = b.DienThoai
                                };
                return khachHangDTO.ToList();
            }

        }

        public bool CapNhatKhachHang(KhachHang khachHang, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new AppPhimModel())
                {
                    var khachHangUpdate = dbcontext.KhachHang.Find(khachHang.Id);
                    if (khachHangUpdate == null)
                    {
                        error = "Khong tim thay khach hang";
                        return false;
                    }
                    khachHangUpdate.TenKhachHang = khachHang.TenKhachHang;
                    khachHangUpdate.DienThoai = khachHang.DienThoai;
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

        public bool TaoMoiKhachHang(KhachHang khachHang, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new AppPhimModel())
                {
                    dbcontext.KhachHang.Add(khachHang);
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
        public bool XoaKhachHang(KhachHang khachHang, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new AppPhimModel())
                {
                    var khachHangUpdate = dbcontext.KhachHang.Find(khachHang.Id);
                    if (khachHangUpdate == null)
                    {
                        error = "Khong tim thay khach hang";
                        return false;
                    }
                    dbcontext.KhachHang.Remove(khachHangUpdate);
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
