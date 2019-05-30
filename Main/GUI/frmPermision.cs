using BUS;
using DTO;
using Main.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.GUI
{
    public partial class frmPermision : Form
    {
        private PermisionBUS permisionBus;
        public frmPermision()
        {
            InitializeComponent();
            permisionBus = new PermisionBUS();
        }

        private void frmPermision_Load(object sender, EventArgs e)
        {

            var pList = permisionBus.GetAll();
            List<PermissionDTO> test = new List<PermissionDTO>();
            if (pList!=null&&pList.Rows.Count>0)
            {
                foreach (DataRow item in pList.Rows)
                {
                    test.Add(new PermissionDTO() {
                        ActionCode = item["ActionCode"].ToString(),
                        Admin = item["Admin"].ToString() == "1" ?true:false,
                        User1 = item["User1"].ToString() == "1" ? true : false,
                        User2 = item["User2"].ToString() == "1" ? true : false
                    });
                }
            }
            gridControl1.DataSource = test;

        }


        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //save quyen admin
            List<PermissionDTO>temp=gridView1.DataSource as List<PermissionDTO>;
            if (temp.Count==8)
            {
                SqlParameter[] Per = new SqlParameter[9];
                for (int i = 0; i < 8; i++)
                {
                    Per[i] = new SqlParameter("@"+temp[i].ActionCode, temp[i].Admin);
                }
                Per[8] = new SqlParameter("@IDPermission", 1);
                DataAccess.ExcuteNonQuery("[usp_UpdatePermision]", Per);
                for (int i = 0; i < 8; i++)
                {
                    Per[i] = new SqlParameter(temp[i].ActionCode, temp[i].User1);
                }
                Per[8] = new SqlParameter("@IDPermission", 2);
                DataAccess.ExcuteNonQuery("[usp_UpdatePermision]", Per);
                for (int i = 0; i < 8; i++)
                {
                    Per[i] = new SqlParameter(temp[i].ActionCode, temp[i].User2);
                }
                Per[8] = new SqlParameter("@IDPermission", 3);
                DataAccess.ExcuteNonQuery("[usp_UpdatePermision]", Per);
            }
            //save user 1
            //save user 2

        }
    }
}
