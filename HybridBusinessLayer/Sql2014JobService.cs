using System;
using System.Collections.Generic;
using System.Linq;

namespace HybridBusinessLayer
{
    public class Sql2014JobService
    {
        public Sql2014Job CreateJob(int id, string instance, string database, string username, string password)
        {
            return new Sql2014Job(id, instance, database, username, password);
        }
    }
}
