using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBusinessLayer
{
    public class SqlJobService
    {
        public SqlJob GetJob(int id)
        {
            return new SqlJob { Id = id, Database = "AdventureWorks", Instance = "MSSQLSERVER", Username = "sa", Password = "Passw0rd" };
        }
    }
}
