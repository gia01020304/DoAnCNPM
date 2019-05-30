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
    public class ProductBus
    {
        public List<HangHoa> GetAll()
        {
            try
            {
                var dtb = DataAccess.ExcuteQuery("usp_GetAllProducts", null);
                return dtb.To<HangHoa>();
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public bool Add(HangHoa hangHoa)
        {

            try
            {
                var rs = DataAccess.ExcuteNonQuery("usp_AddProduct", new SqlParameter[]
                {
                    new SqlParameter("@Name",hangHoa.Name),
                    new SqlParameter("@DVT",hangHoa.DVT),
                    new SqlParameter("@SoLuong",hangHoa.SoLuong),
                    new SqlParameter("@DonGiaNhap",hangHoa.DonGiaNhap),
                    new SqlParameter("@DonGiaBan",hangHoa.DonGiaBan),
                    new SqlParameter("@GhiChu",hangHoa.GhiChu)
                });
                if (rs <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(HangHoa hs)
        {
            try
            {
                var rs = DataAccess.ExcuteNonQuery("usp_UpdateProduct", new SqlParameter[]
                {
                    new SqlParameter("@ID",hs.ID),
                    new SqlParameter("@Name",hs.Name),
                    new SqlParameter("@DVT",hs.DVT),
                    new SqlParameter("@SoLuong",hs.SoLuong),
                    new SqlParameter("@DonGiaNhap",hs.DonGiaNhap),
                    new SqlParameter("@DonGiaBan",hs.DonGiaBan),
                    new SqlParameter("@GhiChu",hs.GhiChu)
                });
                if (rs <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(HangHoa hs)
        {
            try
            {
                var rs = DataAccess.ExcuteNonQuery("usp_DeleteProduct", new SqlParameter[]
                {
                    new SqlParameter("@ID",hs.ID),
                });
                if (rs <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }

        }
        public List<HangHoa> FindByName(string name)
        {
            try
            {

                return DataAccess.ExcuteQuery("usp_FindHangHoaByName", new SqlParameter[]
                {
                    new SqlParameter("@Name",name)
                }).To<HangHoa>();
            }
            catch
            {
                return null;
            }

        }
    }
}
