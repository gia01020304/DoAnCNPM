﻿using Main.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.DTO;
using System.Data.SqlClient;

namespace Main.BUS
{
    public class CTHoaDonBUS
    {
        public CTHoaDonBUS()
        {
            cthdDAO = new QuanLyHoaDonContext();
        }
        private QuanLyHoaDonContext cthdDAO;
        public Exception ErrorCTHDBUS { get; set; }

        public void insertCTHD(CTHoaDon ct)
        {
            ErrorCTHDBUS = null;
            try
            {
                DataAccess.ExcuteNonQuery("usp_insertCTHD", new SqlParameter[] {
                    new SqlParameter("@HoaDonBanId",ct.HoaDonBanId),
                     new SqlParameter("@HangHoaId",ct.HangHoaId),
                      new SqlParameter("@ThanhTien",ct.ThanhTien),
                       new SqlParameter("@SoLuongBan",ct.SoLuongBan),

                });
                //cthdDAO.CTHoaDons.Add(ct);
                //cthdDAO.SaveChanges();
            }
            catch (System.Exception ex)
            {
                ErrorCTHDBUS = ex;
            }
        }

        public List<CTHoaDon> getDsHH(int iD)
        {
            ErrorCTHDBUS = null;
            try
            {
                return DataAccess.ExcuteQuery("usp_getDsHH",new SqlParameter[] {
                    new SqlParameter("@id",iD)
                }).To<CTHoaDon>();
               // return cthdDAO.CTHoaDons.Where(x => x.HoaDonBanId == iD).ToList();

            }
            catch (System.Exception ex)
            {
                ErrorCTHDBUS = ex;
            }
            return null;
        }

        public CTHoaDon findHoaDon(int idhoadon, int idhh)
        {
            ErrorCTHDBUS = null;
            try
            {
                return cthdDAO.CTHoaDons.Find(idhoadon, idhh);

            }
            catch (System.Exception ex)
            {
                ErrorCTHDBUS = ex;
            }
            return null;
        }

        internal void updateHoaDon()
        {
            throw new NotImplementedException();
        }

        public bool deleteCtHoaDon(int idhoadon)
        {
            ErrorCTHDBUS = null;
            try
            {
                DataAccess.ExcuteNonQuery("usp_deleteCtHoaDon", new SqlParameter[] {
                    new SqlParameter("@idhoadon",idhoadon)
                });
                //cthdDAO.CTHoaDons.RemoveRange(cthdDAO.CTHoaDons.Where(x => x.HoaDonBanId == idhoadon));
                //cthdDAO.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                ErrorCTHDBUS = ex;
            }
            return false;

        }

        public bool deleteListCtHoaDon(List<object> id)
        {
            
            if (id.Count > 0)
            {
                for (int i = 0; i < id.Count; i++)
                {
                    bool kq = deleteCtHoaDon(id[i].toInt());
                    if (kq==false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
