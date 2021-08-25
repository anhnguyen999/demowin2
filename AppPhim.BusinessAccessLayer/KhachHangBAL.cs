using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPhim.DataAccessLayer;
using AppPhim.DataAccessLayer.Entities;
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

        public bool XoaKhachHang(KhachHang khachHang, out string error)
        {

            try
            {

                if (!_khachHangDAL.XoaKhachHang(khachHang, out error))
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }

        public bool LuuKhachHang(KhachHang khachHang, out string error)
        {
            error = string.Empty;
            if (khachHang.TenKhachHang == "")
            {
                error = "Nhập tên khách hàng";
            }
            if (khachHang.DienThoai == "")
            {
                error += "\nNhập số điện thoại";
            }
            if (error != string.Empty)
            {
                return false;
            }
            try
            {
                //cập nhật
                if (khachHang.Id > 0)
                {
                    if (!_khachHangDAL.CapNhatKhachHang(khachHang, out error))
                    {
                        return false;
                    }
                }
                //tạo mới
                else
                {
                    if (!_khachHangDAL.TaoMoiKhachHang(khachHang, out error))
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
    }
}
