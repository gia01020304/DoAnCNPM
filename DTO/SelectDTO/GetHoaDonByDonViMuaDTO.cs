using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.SelectDTO
{
    public class GetHoaDonByDonViMuaDTO
    {
        public int ID { get; set; }

        public string KyHieu { get; set; }
        public int MaKhachHang { get; set; }
        public string TenDonViMua { get; set; }
        public string MaSoThue { get; set; }
        public string TenNguoiMua { get; set; }
        public string DiaChi { get; set; }
        public string STK { get; set; }
        public DateTime NgayXuat { get; set; }
        public string HinhThuc { get; set; }
        public string ThanhTien { get; set; }
       

    }
}
