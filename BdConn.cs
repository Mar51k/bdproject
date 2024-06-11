using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace bdproject
{
    internal class BdConn
    {

        public SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["bdproject.Properties.Settings.airportDB"].ConnectionString);
        
        public BdConn()
        {
            this.conn.Open();
        }


    }
}
