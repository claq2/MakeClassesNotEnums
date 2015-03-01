using System;
using System.Collections.Generic;
using System.Linq;

namespace HybridBusinessLayer
{
    public class Sql2014Job : SqlJob
    {
        public Sql2014Job(int id, string instance, string database, string username, string password)
            : base(id, instance, database, username, password)
        {
            this.Instance += "2014";
        }
    }
}
