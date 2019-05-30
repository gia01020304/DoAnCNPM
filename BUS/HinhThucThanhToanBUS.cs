using Main.DAO;
using Main.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.BUS
{
    public class HinhThucThanhToanBUS
    {
        public HinhThucThanhToanBUS()
        {
        }
        public List<HinhThucThanhToan> getAllListHTTT()
        {
            try
            {
                var dtb = DataAccess.ExcuteQuery("usp_GetAllHinhThucThanhToans", null);
                return dtb.To<HinhThucThanhToan>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}
