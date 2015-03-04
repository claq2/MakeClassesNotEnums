using System;
using System.Collections.Generic;
using System.Linq;

namespace HybridBusinessLayer
{
    public class JobService
    {
        public Job CreateJob(int id, JobType type, string filter, string path, string database, string instance, string username, string password)
        {
            switch (type)
            {
                case JobType.FileJob:
                    return new FileJobService().CreateJob(id, filter, path).ToJob();
                case JobType.SqlJob:
                    return new SqlJobService().CreateJob(id, instance, database, username, password).ToJob();
                case JobType.Sql2014Job:
                    return new Sql2014JobService().CreateJob(id, instance, database, username, password).ToJob();
                default:
                    throw new ArgumentException("Unknown type " + type);
            }
        }
    }
}
