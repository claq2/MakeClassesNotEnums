using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassesBusinessLayer
{
    public class Sql2014JobService
    {
        public Sql2014Job CreateJob(int id)
        {
            return new Sql2014Job(id, "MSSQLSERVER", "AdventureWorks", "sa", "Passw0rd");
        }
    }
}
