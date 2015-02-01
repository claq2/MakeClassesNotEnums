using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsBusinessLayer
{
    public class Job
    {
        /// <summary>
        /// Fill in for SQL job
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// Fill in for file job
        /// </summary>
        public string Filter { get; set; }

        public int Id { get; set; }

        /// <summary>
        /// Fill in for SQL job
        /// </summary>
        public string Instance { get; set; }

        public JobType JobType { get; set; }

        /// <summary>
        /// Fill in for SQL job
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Fill in for file job
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Fill in for SQL job
        /// </summary>
        public string Username { get; set; }
    }
}