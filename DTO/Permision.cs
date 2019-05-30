using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Action
    {
        private string actionCode;
        private bool checkAction;
        public string ActionCode { set; get; }
        public bool CheckAction { get; set; }
    }

    public class Role
    {
        private int iD;
        public int ID { set; get; }
        private string name;
        public string Name { get; set; }

    }
}
