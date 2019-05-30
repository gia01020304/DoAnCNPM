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
    public class HangHoaBUS
    {

        public HangHoaBUS()
        {
        }
        QuanLyHoaDonContext hhDAO;
        private Exception errorHHBUS;

        public Exception ErrorHHBUS
        {
            get
            {
                return errorHHBUS;
            }

            set
            {
                errorHHBUS = value;
            }
        }

        public List<HangHoa> getAllHangHoa()
        {
            errorHHBUS = null;
            List<HangHoa> hh = null;
            try
            {
                hh = DataAccess.ExcuteQuery("usp_getAllHangHoa").To<HangHoa>();
                //hh = hhDAO.HangHoas.Where(x => x.DaXoa == false).ToList();
            }
            catch (System.Exception ex)
            {
                errorHHBUS = ex;
            }
            return hh;
        }

        public bool checkSoLuongKho(int idh, int slNhap)
        {
            errorHHBUS = null;
            try
            {
                var temp = hhDAO.HangHoas.Where(x => x.ID == idh).Select(x => x.SoLuong).ToList();
                if (temp.Count > 0)
                {
                    int slk = int.Parse(temp[0].ToString());
                    if (slNhap > slk)
                    {
                        return false;
                    }
                }
            }
            catch (System.Exception ex)
            {
                errorHHBUS = ex;
            }
            return true;
        }

        public HangHoa checkHangHoaKho(object iD)
        {
            try
            {
                return DataAccess.ExcuteQuery("usp_checkHangHoaKho", new SqlParameter[] {
                    new SqlParameter("@iD",iD)
                }).To<HangHoa>().First();
                //HangHoa temp = hhDAO.HangHoas.Find(iD);
                //return temp;
            }
            catch (System.Exception ex)
            {
                errorHHBUS = ex;
            }
            return null;
        }

        public void updateHangHoa(HangHoa temp)
        {
            try
            {
                DataAccess.ExcuteNonQuery("usp_updateHangHoa", new SqlParameter[] {
                    new SqlParameter("@Name",temp.Name),
                     new SqlParameter("@DVT",temp.DVT),
                      new SqlParameter("@SoLuong",temp.SoLuong),
                       new SqlParameter("@DonGiaNhap",temp.DonGiaNhap),
                        new SqlParameter("@DonGiaBan",temp.DonGiaBan),
                         new SqlParameter("@GhiChu",temp.GhiChu),
                         new SqlParameter("@DaXoa",temp.DaXoa),
                         new SqlParameter("@ID",temp.ID)
                });
                //hhDAO.SaveChanges();

            }
            catch (System.Exception ex)
            {
                errorHHBUS = ex;
            }

        }

        public HangHoa getHangHoaByID(int hangHoaId)
        {
            try
            {
                return DataAccess.ExcuteQuery("usp_getHangHoaByID", new SqlParameter[] {
                    new SqlParameter("@hangHoaId",hangHoaId)
                }).To<HangHoa>().First();
                //HangHoa temp = hhDAO.HangHoas.Find(hangHoaId);
                //return temp;
            }
            catch (System.Exception ex)
            {
                errorHHBUS = ex;
            }
            return null;
        }
    }
}
