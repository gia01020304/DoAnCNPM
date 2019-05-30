﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.DTO
{
    public class DonViMuaHang
    {
        [Key]
        public int ID { get; set; }
        [StringLengthAttribute(50)]
        public string Name { get; set; }
        [StringLengthAttribute(50)]
        public string DiaChiMua { get; set; }

        public string MaSoThueMua { get; set; }

        [StringLengthAttribute(20)]
        public string STKMua { get; set; }
        [StringLengthAttribute(12)]
        public string SDTMua { get; set; }
        public virtual ICollection<NguoiMua> NguoiMuas { get; set; }


    }
}
