using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_cs
{
    public abstract class Dbconnection
    {
        private readonly string connectionString;
        public Dbconnection() {
            connectionString = "Server=(local); DataBase=..\\..\\result2.db; Integrated Security=true";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
