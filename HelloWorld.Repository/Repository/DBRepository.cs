using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace HelloWorld.Repository
{
    public class DBRepository : IRepository
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["localDB"].ConnectionString); 
        public DBRepository()
        {
        }
        public void Write(string message)
        {
            throw new NotImplementedException();
        }
    }
}
