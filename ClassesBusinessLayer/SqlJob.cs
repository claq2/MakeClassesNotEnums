using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBusinessLayer
{
    public class SqlJob : AbstractJob
    {
        public string Instance { get; set; }

        public string Database { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlJob"/> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="instance"></param>
        /// <param name="database"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public SqlJob(int id, string instance, string database, string username, string password)
            : base(id)
        {
            this.Instance = instance;
            this.Database = database;
            this.Username = username;
            this.Password = password;
        }
    }
}