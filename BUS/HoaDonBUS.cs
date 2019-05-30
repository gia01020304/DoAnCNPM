using DTO.SelectDTO;
using Main.DAO;
using Main.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.BUS
{
    public class HoaDonBUS
    {
        QuanLyHoaDonContext hdDAO;
        public HoaDonBUS()
        {
            hdDAO = new QuanLyHoaDonContext();
        }
        private Exception errorHDBUS;

        public Exception ErrorHDBUS
        {
            get
            {
                return errorHDBUS;
            }

            set
            {
                errorHDBUS = value;
            }
        }
        public int getIDCurrent()
        {
            errorHDBUS = null;
            try
            {
                DataTable temp = DataAccess.ExcuteQuery("[usp_getIDCurrent]", new SqlParameter[] {
                   new SqlParameter("@nameTable","HoaDonBans")
               });
                if (temp != null && temp.Rows.Count > 0)
                {
                    return temp.Rows[0]["ID"].toInt();
                }
            }
            catch (Exception ex)
            {

                errorHDBUS = ex;
            }
            return -1;
        }
        public int getIDHDB()
        {
            errorHDBUS = null;

            try
            {
                DataTable tbl = DataAccess.ExcuteQuery("usp_getIDHDB");
                if (tbl != null && tbl.Rows.Count > 0)
                {
                    int id = tbl.Rows[0]["ID"].toInt();
                    var tblHoaDonBan = DataAccess.ExcuteQuery("usp_GetAllHoaDonBans");
                    if (id == 1 && tblHoaDonBan.Rows.Count == 0)
                    {
                        return id;
                    }
                    else
                    {
                        return id + 1;
                    }
                }
                //var temp = hdDAO.Database.SqlQuery<decimal>(@"SELECT IDENT_CURRENT('HoaDonBans')").ToList();
                //if (temp.Count > 0)
                //{
                //    int id = int.Parse(temp[0].ToString());
                //    if (id == 1 && hdDAO.HoaDonBans.ToList().Count == 0)
                //    {
                //        return id;
                //    }
                //    else
                //    {
                //        return id + 1;
                //    }

                //}
            }
            catch (System.Exception ex)
            {
                errorHDBUS = ex;
            }

            return -1;

        }

        public object getHoaDonBanReport()
        {
            errorHDBUS = null;
            try
            {
                
                var temp = DataAccess.ExcuteQuery("[usp_getHoaDonBanReport]").To<getHoaDonBanReportDTO>();

                //var temp = hdDAO.HoaDonBans.AsEnumerable().Where(x => x.DaXoa == false).Select(x =>
                //new { ID = x.ID, KyHieu = x.KyHieu, NgayHD = x.NgayHD, TongTienSo = x.TongTienSo.toDoubleString(), }).ToList();
                return temp.Cast<object>().ToList();
            }
            catch (System.Exception ex)
            {
                errorHDBUS = ex;
            }
            return null;
        }

        public void insertHoaDonBan(HoaDonBan hdb)
        {
            errorHDBUS = null;
            try
            {
                DataAccess.ExcuteNonQuery("usp_insertHoaDonBan", new SqlParameter[] {
                    new SqlParameter("@ThueSuat",hdb.ThueSuat),
                     new SqlParameter("@KyHieu",hdb.KyHieu),
                      new SqlParameter("@NgayHD",hdb.NgayHD),
                       new SqlParameter("@HinhThucThanhToanId",hdb.HinhThucThanhToanId),
                        new SqlParameter("@NguoiMuaId",hdb.NguoiMuaId),
                         new SqlParameter("@NhanVienBanId",hdb.NhanVienBanId),
                          new SqlParameter("@DaXoa",hdb.DaXoa),
                           new SqlParameter("@TongTienSo",hdb.TongTienSo),
                           new SqlParameter("@TongTienChu",hdb.TongTienChu)
                });
                //                 hdDAO.HoaDonBans.Add(hdb);
                //                 hdDAO.SaveChanges();
            }
            catch (Exception ex)
            {

                errorHDBUS = ex;
            }
        }

        public List<object> getHoaDonBan()
        {
            errorHDBUS = null;
            try
            {
                var temp = DataAccess.ExcuteQuery("[usp_getHoaDonBan]").To<getHoaDonBanDTO>();

                //var temp = hdDAO.HoaDonBans.AsEnumerable().Where(x => x.DaXoa == false).Select(x =>
                //new { ID = x.ID, KyHieu = x.KyHieu, NgayHD = x.NgayHD, TongTienSo = x.TongTienSo.toDoubleString(), }).ToList();
                return temp.Cast<object>().ToList();
            }
            catch (System.Exception ex)
            {
                errorHDBUS = ex;
            }
            return null;
        }
        public List<object> GetByDate(DateTime dateFrom, DateTime dateTo)
        {
            if (dateFrom.Date == dateTo.Date)
            {
                dateFrom = new DateTime(1970, 1, 1);
            }
            try
            {
                var rs = DataAccess.ExcuteQuery("usp_GetByDate", new SqlParameter[] {
                    new SqlParameter("@dateFrom",dateFrom),
                    new SqlParameter("@dateTo",dateTo)
                }).To<GetHoaDonByDonViMuaDTO>();
                //var rs = hdDAO.HoaDonBans.AsEnumerable().ToList().Where(item => item.NgayHD >= dateFrom && item.NgayHD <= dateTo).ToList().Select(hd => new
                //{
                //    ID = hd.ID,
                //    KiHieu = hd.KyHieu,
                //    MaKhachHang = hd.NguoiMua.DonViMuaHangId,
                //    TenDonViMua = hd.NguoiMua.DonViMuaHang.Name,
                //    MaSoThue = hd.NguoiMua.DonViMuaHang.MaSoThueMua,
                //    TenNguoiMua = hd.NguoiMua.Name,
                //    DiaChi = hd.NguoiMua.DonViMuaHang.DiaChiMua,
                //    STK = hd.NguoiMua.DonViMuaHang.STKMua,
                //    NgayXuat = hd.NgayHD,
                //    HinhThuc = hd.HinhThucThanhToan.Name,
                //    ThanhTien = hd.TongTienSo
                //}).ToList();
                return rs.Cast<object>().ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<object> GetHoaDonByDonViMua(int id)
        {
            try
            {
                var rs = DataAccess.ExcuteQuery("usp_GetHoaDonByDonViMua", new SqlParameter[] {
                    new SqlParameter("@DonViMuaHangId",id)
                }).To<GetHoaDonByDonViMuaDTO>();
                //var rs = hdDAO.HoaDonBans.AsEnumerable().ToList().Where(item => item.NguoiMua.DonViMuaHangId == id).ToList().Select(hd => new
                //{
                //    ID = hd.ID,
                //    KiHieu = hd.KyHieu,
                //    MaKhachHang = hd.NguoiMua.DonViMuaHangId,
                //    TenDonViMua = hd.NguoiMua.DonViMuaHang.Name,
                //    MaSoThue = hd.NguoiMua.DonViMuaHang.MaSoThueMua,
                //    TenNguoiMua = hd.NguoiMua.Name,
                //    DiaChi = hd.NguoiMua.DonViMuaHang.DiaChiMua,
                //    STK = hd.NguoiMua.DonViMuaHang.STKMua,
                //    NgayXuat = hd.NgayHD,
                //    HinhThuc = hd.HinhThucThanhToan.Name,
                //    ThanhTien = hd.TongTienSo
                //}).ToList();
                return rs.Cast<object>().ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<object> getHoaDonByFind(string noidungtimkiem)
        {
            errorHDBUS = null;
            try
            {
                double test;
                bool kq = double.TryParse(noidungtimkiem, out test);
                if (!kq)
                {
                    test = -1;
                }


                var temp = DataAccess.ExcuteQuery("usp_getHoaDonByFind", new SqlParameter[] {
                    new SqlParameter("@noidungtimkiem",test)
                }).To<getHoaDonBanDTO>();
                //var temp = hdDAO.HoaDonBans.AsEnumerable().Where(
                //                                hd => hd.ID == test ||
                //                                 hd.ThueSuat == test ||
                //                                 hd.KyHieu.Contains(noidungtimkiem) ||
                //                                 hd.TongTienSo.Contains(noidungtimkiem) ||
                //                                 hd.TongTienChu.Contains(noidungtimkiem)
                //                                 ).Select(x =>
                //new { ID = x.ID, KyHieu = x.KyHieu, NgayHD = x.NgayHD, TongTienSo = x.TongTienSo.toDoubleString(), }).ToList();
                return temp.Cast<object>().ToList();
            }
            catch (System.Exception ex)
            {
                errorHDBUS = ex;
            }
            return null;
        }

        public HoaDonBan findHoaDon(int iD)
        {
            errorHDBUS = null;
            try
            {
                return DataAccess.ExcuteQuery("usp_findHoaDon", new SqlParameter[] {
                    new SqlParameter("id",iD)
                }).To<HoaDonBan>().First();
                //return hdDAO.HoaDonBans.Find(iD);

            }
            catch (System.Exception ex)
            {
                errorHDBUS = ex;
            }
            return null;
        }

        public bool removeHoaDon(int idhoadon)
        {
            errorHDBUS = null;
            try
            {
                hdDAO.HoaDonBans.Remove(hdDAO.HoaDonBans.Find(idhoadon));
                return true;
            }
            catch (System.Exception ex)
            {
                errorHDBUS = ex;
            }
            return false;
        }

        public void updateHoaDon(HoaDonBan hdTemp)
        {
            errorHDBUS = null;
            try
            {
                DataAccess.ExcuteNonQuery("usp_updateHoaDon", new SqlParameter[] {
                    new SqlParameter("@ThueSuat",hdTemp.ThueSuat),
                     new SqlParameter("@KyHieu",hdTemp.KyHieu),
                      new SqlParameter("@NgayHD",hdTemp.NgayHD),
                       new SqlParameter("@HinhThucThanhToanId",hdTemp.HinhThucThanhToanId),
                        new SqlParameter("@NguoiMuaId",hdTemp.NguoiMuaId),
                          new SqlParameter("@NhanVienBanId",hdTemp.NhanVienBanId),
                            new SqlParameter("@DaXoa",hdTemp.DaXoa),
                              new SqlParameter("@TongTienSo",hdTemp.TongTienSo),
                               new SqlParameter("@TongTienChu",hdTemp.TongTienChu),
                                new SqlParameter("@ID",hdTemp.ID),
                });
                //hdDAO.SaveChanges();
            }
            catch (System.Exception ex)
            {
                errorHDBUS = ex;
            }

        }

        public bool deleteHoaDon(int idhoadon)
        {
            ErrorHDBUS = null;
            try
            {
                DataAccess.ExcuteNonQuery("usp_deleteHoaDon", new SqlParameter[] {
                    new SqlParameter("@idhoadon",idhoadon)
                });
                //hdDAO.HoaDonBans.RemoveRange(hdDAO.HoaDonBans.Where(x => x.ID == idhoadon));
                //hdDAO.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                errorHDBUS = ex;
            }
            return false;

        }

        public bool deleteListHoaDonBUS(List<object> id)
        {
            if (id.Count > 0)
            {
                for (int i = 0; i < id.Count; i++)
                {
                    bool kq = deleteHoaDon(id[i].toInt());
                    if (kq == false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
