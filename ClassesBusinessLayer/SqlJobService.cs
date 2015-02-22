using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBusinessLayer
{
    public class SqlJobService
    {
        public SqlJob CreateJob(int id)
        {
            return new SqlJob(id, "MSSQLSERVER", "AdventureWorks", "sa", "Passw0rd");
        }
    }
}