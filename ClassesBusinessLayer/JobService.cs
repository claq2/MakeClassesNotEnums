using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBusinessLayer
{
    public class JobService
    {
        public SqlJob GetSqlJob(int id)
        {
            return new SqlJob() { Id = id };
        }

        public FileJob GetFileJob(int id)
        {
            return new FileJob() { Id = id };
        }
    }
}
