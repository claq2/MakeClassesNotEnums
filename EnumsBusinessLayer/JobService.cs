using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsBusinessLayer
{
    public class JobService
    {
        public Job CreateJob(int id, JobType type, string filter, string path, string database, string instance, string username, string password)
        {
            switch (type)
            {
                case JobType.FileJob:
                    if (!System.IO.Path.IsPathRooted(path))
                    {
                        throw new ArgumentException("Must be non-relative", "path");
                    }

                    return new Job { JobType = type, Id = id, Filter = filter, Path = path };
                case JobType.SqlJob:
                case JobType.Sql2014Job:
                    var newJob = new Job { JobType = type, Id = id, Database = database, Instance = instance, Username = username, Password = password };
                    if (type == JobType.Sql2014Job)
                    {
                        newJob.Instance += "2014";
                    }

                    return newJob;
                default:
                    throw new ArgumentException("Unknown type " + type);
            }
        }
    }
}
