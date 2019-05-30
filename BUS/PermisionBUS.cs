using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Main;
using Main.DAO;
using Main.DTO;
using Action = DTO.Action;

namespace BUS
{
    public class PermisionBUS
    {
        public DataTable GetAll()
        {
            try
            {
                //2018/11/21 gnguyen start modifi
                return DataAccess.ExcuteQuery("[usp_GetPermision]", null);

                //2018/11/21 gnguyen end modifi 

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Action> GetActionByUserName(string userName)
        {
            try
            {
                var dtb = DataAccess.ExcuteQuery("usp_GetActionByUserName", new SqlParameter[]
                {
                    new SqlParameter("@UserName",userName) 
                });
                return dtb.To<Action>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Role> GetAllRoles()
        {
            try
            {
                return DataAccess.ExcuteQuery("usp_GetRoles", null).To<Role>();

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
