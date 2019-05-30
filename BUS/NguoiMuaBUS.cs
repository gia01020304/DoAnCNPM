using Main.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.DTO;
using System.Data;

namespace Main.BUS
{
    public class NguoiMuaBUS
    {
        public NguoiMuaBUS()
        {
            nmDAO = new QuanLyHoaDonContext();
        }
        private QuanLyHoaDonContext nmDAO;
        public Exception ErrorNMBUS { get; set; }
        public object getIdByCMND(string cmnd)
        {
            ErrorNMBUS = null;
            try
            {
                DataTable test = DataAccess.ExcuteQuery("usp_checkCMND", new SqlParameter[] {
                    new SqlParameter("@cmnd",cmnd)
                });
                if (test != null && test.Rows.Count > 0)
                {
                    return test.Rows[0]["ID"];
                }
                //var temp = nmDAO.NguoiMuas.Where(x => string.Compare(cmnd, x.CMND) == 0).Select(x=>x.ID).ToList();
                //if (temp.Count>0)
                //{
                //    return temp[0];
                //}
            }
            catch (System.Exception ex)
            {
                ErrorNMBUS = ex;
            }
            return null;
        }
        public bool checkCMND(string cmnd)
        {
            ErrorNMBUS = null;
            try
            {
                DataTable test = DataAccess.ExcuteQuery("usp_checkCMND", new SqlParameter[] {
                    new SqlParameter("@cmnd",cmnd)
                });
                if (test != null && test.Rows.Count > 0)
                {
                    return true;
                }
                // int temp = nmDAO.NguoiMuas.Count(x => string.Compare(cmnd, x.CMND) == 0);
                //if (temp > 0)
                //{
                //    return true;
                //}

            }
            catch (System.Exception ex)
            {
                ErrorNMBUS = ex;
            }
            return false;
        }
        public int checkCMND2(string cmnd)
        {
            ErrorNMBUS = null;
            try
            {
                return nmDAO.NguoiMuas.Where(x => x.CMND == cmnd).SingleOrDefault().ID;

            }
            catch (System.Exception ex)
            {
                ErrorNMBUS = ex;
            }
            return -1;
        }

        public void insertNguoiMua(NguoiMua objectNM)
        {
            try
            {
                var rs = DataAccess.ExcuteNonQuery("usp_AddNguoiMua", new SqlParameter[]
                {
                    new SqlParameter("@Name",objectNM.Name),
                    new SqlParameter("@DonViMuaHangId",objectNM.DonViMuaHangId),
                    new SqlParameter("@CMND",objectNM.CMND),
                });
            }
            catch (Exception ex)
            {
                ErrorNMBUS = ex;
            }
        }

        public NguoiMua getNguoiMua(int nguoiMuaId)
        {
            try
            {

                var rs = DataAccess.ExcuteQuery("usp_GetNguoiMuaById", new SqlParameter[]
                {
                    new SqlParameter("@ID",nguoiMuaId)
                }).To<NguoiMua>();
                if (rs.Count > 0)
                {
                    return rs[0];
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        public void updateNguoiMua(NguoiMua nmTemp)
        {
            ErrorNMBUS = null;
            try
            {
                DataAccess.ExcuteNonQuery("usp_updateNguoiMua", new SqlParameter[] {
                    new SqlParameter("@ID",nmTemp.ID),
                     new SqlParameter("@Name",nmTemp.Name),
                      new SqlParameter("@DonViMuaHangId",nmTemp.DonViMuaHangId),
                       new SqlParameter("@DaXoa",nmTemp.DaXoa),
                        new SqlParameter("@CMND",nmTemp.CMND),
                });
                //nmDAO.SaveChanges();
            }
            catch (System.Exception ex)
            {
                ErrorNMBUS = ex;
            }

        }

        public int getIDNM()
        {
            ErrorNMBUS = null;
            try
            {
                DataTable temp = DataAccess.ExcuteQuery("usp_getIDNM");
                if (temp != null && temp.Rows.Count > 0)
                {
                    return temp.Rows[0]["ID"].toInt();
                }
            }
            catch (System.Exception ex)
            {
                ErrorNMBUS = ex;
            }
            return -1;
        }
    }
}
