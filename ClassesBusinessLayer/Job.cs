using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBusinessLayer
{
    public abstract class Job
    {
        public int Id { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Job"/> class.
        /// </summary>
        /// <param name="id"></param>
        protected Job(int id)
        {
            Id = id;
        }
    }
}