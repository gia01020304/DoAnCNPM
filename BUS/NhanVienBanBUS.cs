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
    public class NhanVienBanBUS
    {
        public NhanVienBanBUS()
        {
        }
        private Exception errorNVBBUS;

        public Exception ErrorNVBBUS
        {
            get
            {
                return errorNVBBUS;
            }

            set
            {
                errorNVBBUS = value;
            }
        }
        public List<NhanVienBan> getAllNhanVienBan(string username)
        {
            try
            {
                var dtb = DataAccess.ExcuteQuery("usp_GetAllNhanVienGia", new SqlParameter[] {
                    new SqlParameter("@UserName",username)
                });
                return dtb.To<NhanVienBan>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<NhanVienBan> getAllNhanVienBan()
        {
            try
            {
                var dtb = DataAccess.ExcuteQuery("usp_GetAllNhanVien", null);
                return dtb.To<NhanVienBan>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<NhanVienBan> GetAll()
        {
            try
            {
                //return context.NhanVienBans.Where(item => item.DaXoa == false).ToList();
                var dtb = DataAccess.ExcuteQuery("usp_GetAllNhanVien", null);
                return dtb.To<NhanVienBan>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Add(NhanVienBan nhanVien)
        {
            try
            {
                var rs = DataAccess.ExcuteNonQuery("usp_AddNhanVien", new SqlParameter[]
                {
                    new SqlParameter("@Name",nhanVien.Name),
                    new SqlParameter("@GioiTinh",nhanVien.GioiTinh),
                    new SqlParameter("@SDT",nhanVien.SDT),
                    new SqlParameter("@DOB",nhanVien.DOB),
                    new SqlParameter("@TTLamViec",nhanVien.TTLamViec),
                    new SqlParameter("@HinhAnh",nhanVien.HinhAnh),
                    new SqlParameter("@DiaChi",nhanVien.DiaChi),
                    new SqlParameter("@CMND",@nhanVien.CMND),
                    new SqlParameter("@NgayCap",@nhanVien.NgayCap),
                    new SqlParameter("@NoiCap",@nhanVien.NoiCap),
                    new SqlParameter("@HonNhan",@nhanVien.HonNhan == false ? 0: 1),
                    new SqlParameter("@UserName",@nhanVien.UserName),
                    new SqlParameter("@PassWord",@nhanVien.PassWord),
                    new SqlParameter("@RoleID",@nhanVien.RoleID),
                });
                if (rs <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Update(NhanVienBan nhanVien)
        {
            try
            {
                var rs = DataAccess.ExcuteNonQuery("usp_UpdateNhanVien", new SqlParameter[]
                {
                    new SqlParameter("@ID",nhanVien.ID),
                    new SqlParameter("@Name",nhanVien.Name),
                    new SqlParameter("@GioiTinh",nhanVien.GioiTinh),
                    new SqlParameter("@SDT",nhanVien.SDT),
                    new SqlParameter("@DOB",nhanVien.DOB),
                    new SqlParameter("@TTLamViec",nhanVien.TTLamViec),
                    new SqlParameter("@HinhAnh",nhanVien.HinhAnh),
                    new SqlParameter("@DiaChi",nhanVien.DiaChi),
                    new SqlParameter("@CMND",@nhanVien.CMND),
                    new SqlParameter("@NgayCap",@nhanVien.NgayCap),
                    new SqlParameter("@NoiCap",@nhanVien.NoiCap),
                    new SqlParameter("@HonNhan",@nhanVien.HonNhan == false ? 0: 1),
                    new SqlParameter("@PassWord",@nhanVien.PassWord),
                    new SqlParameter("@RoleID",@nhanVien.RoleID),
                });
                if (rs <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Delete(NhanVienBan nv)
        {
            try
            {
                var rs = DataAccess.ExcuteNonQuery("usp_DeleteNhanVien", new SqlParameter[]
                {
                    new SqlParameter("@ID",nv.ID)
                });
                if (rs <= 0) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<NhanVienBan> FindByName(string name)
        {
            try
            {
                //return context.NhanVienBans.Where(item => item.Name.Contains(name) && item.DaXoa == false).ToList();
                return DataAccess.ExcuteQuery("usp_FindNhanVienByName", new SqlParameter[]
                {
                    new SqlParameter("@Name",name)
                }).To<NhanVienBan>();
            }
            catch
            {
                return null;
            }
        }
    }
}
