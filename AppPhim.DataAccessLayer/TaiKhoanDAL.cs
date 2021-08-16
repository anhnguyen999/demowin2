using AppPhim.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPhim.DataAccessLayer
{
    public class TaiKhoanDAL
    {
        public bool KiemTraDangNhap(string username, string password, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbcontext = new AppPhimModel())
                {
                    return dbcontext.TaiKhoan.Any(tk=>tk.UserName == username && tk.PassWord == password);
                }
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }
    }
}
