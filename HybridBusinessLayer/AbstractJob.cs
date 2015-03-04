using System;
using System.Collections.Generic;
using System.Linq;

namespace HybridBusinessLayer
{
    public abstract class AbstractJob
    {
        public int Id { get; set; }

        protected AbstractJob(int id)
        {
            this.Id = id;
        }

        public abstract Job ToJob();
    }
}
