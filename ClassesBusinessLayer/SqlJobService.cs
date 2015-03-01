using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBusinessLayer
{
    public class SqlJobService
    {
        public SqlJob CreateJob(int id, string instance, string database, string username, string password)
        {
            return new SqlJob(id, instance, database, username, password);
        }
    }
}