using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.DAO;

namespace Main.BUS
{
    public class ProgramBUS
    {
        QuanLyHoaDonContext context = new QuanLyHoaDonContext();
        NhanVienBanBUS nhanVienBanBUS = new NhanVienBanBUS();
        public bool AddDefaultHTTT(string name)
        {
            try
            {
                var rs = DataAccess.ExcuteNonQuery("usp_AddHinhThucThanhToan", new SqlParameter[]
                {
                    new SqlParameter("@Name",name)
                });
                if (rs <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddDefaultAccount(string name, string pass)
        {
            try
            {
                context.DangNhaps.Add(new DTO.DangNhap() { TenDangNhap = name, PassWord = pass });
                if (context.SaveChanges() > 0)
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
        public int CountHTTT()
        {
            try
            {
                var rs = DataAccess.ExcuteQuery("usp_GetAllHinhThucThanhToans");
                if (rs != null && rs.Rows.Count > 0)
                {
                    return rs.Rows.Count;
                }
                return 0;
            }
            catch (System.Exception ex)
            {
                return -1;
            }
        }

    }
}
