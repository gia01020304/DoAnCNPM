using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PermissionDTO
    {
        public string ActionCode { get; set; }
        public bool Admin { get; set; }
        public bool User1 { get; set; }
        public bool User2 { get; set; }


    }
}
