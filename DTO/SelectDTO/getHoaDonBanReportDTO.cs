using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.SelectDTO
{
    public class getHoaDonBanReportDTO
    {
        public int ID { get; set; }
        public string KyHieu { get; set; }
        public DateTime NgayHD { get; set; }
        public Double TongTienSo { get; set; }
        public int NguoiMuaId { get; set; }
    }
}
