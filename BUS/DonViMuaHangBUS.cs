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
   public class DonViMuaHangBUS
    {
        private Exception error;

        public Exception Error
        {
            get
            {
                return error;
            }
        }

        public List<DonViMuaHang> GetAll()
        {
            try
            {
                var dtb = DataAccess.ExcuteQuery("usp_GetAllDonViMuaHangs", null);
                return dtb.To<DonViMuaHang>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Add(DonViMuaHang donVi)
        {
            try
            {
                var rs = DataAccess.ExcuteNonQuery("usp_AddDonViMuaHang", new SqlParameter[]
                {
                    new SqlParameter("@Name",donVi.Name),
                    new SqlParameter("@DiaChiMua",donVi.DiaChiMua),
                    new SqlParameter("@MaSoThueMua",donVi.MaSoThueMua),
                    new SqlParameter("@STKMua",donVi.STKMua),
                    new SqlParameter("@SDTMua",donVi.SDTMua),
                });
                if (rs <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<DonViMuaHang> Search(string name)
        {
            try
            {

                return DataAccess.ExcuteQuery("usp_FindDVMByName", new SqlParameter[]
                {
                    new SqlParameter("@Name",name)
                }).To<DonViMuaHang>();
            }
            catch
            {
                return null;
            }
        }
        public bool Update(DonViMuaHang donVi)
        {
            try
            {
                var rs = DataAccess.ExcuteNonQuery("usp_UpdateDonViMuaHang", new SqlParameter[]
                {
                    new SqlParameter("@ID",donVi.ID), 
                    new SqlParameter("@Name",donVi.Name),
                    new SqlParameter("@DiaChiMua",donVi.DiaChiMua),
                    new SqlParameter("@MaSoThueMua",donVi.MaSoThueMua),
                    new SqlParameter("@STKMua",donVi.STKMua),
                    new SqlParameter("@SDTMua",donVi.SDTMua),
                });
                if (rs <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                var rs = DataAccess.ExcuteNonQuery("usp_DeleteDonViMuaHang", new SqlParameter[]
                {
                    new SqlParameter("@ID",id)
                });
                if (rs <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DonViMuaHangBUS()
        {
        }
        private Exception errorDVMHBUS;

        public Exception ErrorDVMHBUS
        {
            get
            {
                return errorDVMHBUS;
            }

            set
            {
                errorDVMHBUS = value;
            }
        }
        public List<DonViMuaHang>getAllDonViMuaHang()
        {
            try
            {
                var dtb = DataAccess.ExcuteQuery("usp_GetAllDonViMuaHangs", null);
                return dtb.To<DonViMuaHang>();
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
