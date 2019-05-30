using Main.DAO;
using Main.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Main.BUS
{
    public class DangNhapBUS
    {
        QuanLyHoaDonContext context = new QuanLyHoaDonContext();
        private Exception error;

        public Exception Error
        {
            get
            {
                return error;
            }
        }
        public bool TestAccount(DangNhap dangnhap)
        {
            try
            {
                var dtb = DataAccess.ExcuteQuery("usp_CheckLogin", new SqlParameter[]
                {
                    new SqlParameter("@UserName",dangnhap.TenDangNhap),
                    new SqlParameter("@Password",dangnhap.PassWord), 
                });
                var rs = dtb.To<DonViBanHang>();
                if (rs.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
    }
}
