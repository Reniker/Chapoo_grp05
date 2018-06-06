using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Chapoo_grp05.DAL
{
    class DAL
    {//Made By Mark Kea

        public SqlConnection dbconnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["ChapooConnectionString"].ConnectionString;
            SqlConnection sqls = new SqlConnection(connString);

            return sqls;
        }
    }
}
