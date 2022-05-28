using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pabdexe3
{
    class Class1
    {
        public SqlConnection Getconn()
        {
            SqlConnection kon = new SqlConnection();
            kon.ConnectionString = "Data Source= LAPTOP-BCV032MA; Initial Catalog =admin;Persist Security Info=True; User ID=sa; Password=123456789";
            return kon;
        }
    }
}
