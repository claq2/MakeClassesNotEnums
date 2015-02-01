using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsBusinessLayer
{
    public class JobService
    {
        public Job GetJob(int id, JobType type)
        {
            switch (type)
            {
                case JobType.FileJob:
                    return new Job { JobType = type, Id = id, Filter = "*.*", Path = "C:\\Temp" };
                case JobType.SqlJob:
                    return new Job { JobType = type, Id = id, Database = "AdventureWorks", Instance = "MSSQLSERVER", Username = "sa", Password = "Passw0rd" };
                default:
                    throw new ArgumentException("Unknown type " + type);
            }
        }
    }
}
