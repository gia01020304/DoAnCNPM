using Main.DAO;
using Main.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.BUS
{
    public class DonViBanHangBUS
    {
        private Exception error;

        public Exception Error
        {
            get
            {
                return error;
            }
        }
        public DonViBanHang GetDVMH()
        {
            try
            {
                var dtb = DataAccess.ExcuteQuery("usp_GetDonViBanHang", null);
                var rs = dtb.To<DonViBanHang>();
                if (rs.Count > 0)
                {
                    return rs[0];
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Add(DonViBanHang donVi)
        {
            try
            {
                var rs = DataAccess.ExcuteNonQuery("usp_AddDonViBanHang", new SqlParameter[]
                {
                    new SqlParameter("@Name",donVi.Name),
                    new SqlParameter("@DiaChiBan",donVi.DiaChi),
                    new SqlParameter("@MaSoThueBan",donVi.MaSoThueBan),
                    new SqlParameter("@STKBan",donVi.STKBan),
                    new SqlParameter("@SDTBan",donVi.SDTBan),
                });
                if (rs <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(DonViBanHang donVi)
        {
            try
            {
                var rs = DataAccess.ExcuteNonQuery("usp_UpdateDonViBanHang", new SqlParameter[]
                {
                    new SqlParameter("@ID",donVi.ID), 
                    new SqlParameter("@Name",donVi.Name),
                    new SqlParameter("@DiaChiBan",donVi.DiaChi),
                    new SqlParameter("@MaSoThueBan",donVi.MaSoThueBan),
                    new SqlParameter("@STKBan",donVi.STKBan),
                    new SqlParameter("@SDTBan",donVi.SDTBan),
                });
                if (rs <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
