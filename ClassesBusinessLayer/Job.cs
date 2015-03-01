using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBusinessLayer
{
    public abstract class AbstractJob
    {
        public int Id { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractJob"/> class.
        /// </summary>
        /// <param name="id"></param>
        protected AbstractJob(int id)
        {
            Id = id;
        }
    }
}