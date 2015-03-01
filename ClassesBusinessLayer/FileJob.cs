using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBusinessLayer
{
    public class FileJob : AbstractJob
    {
        public string Path { get; set; }

        public string Filter { get; set; }

        public FileJob(int id, string filter, string path)
            : base(id)
        {
            if (!System.IO.Path.IsPathRooted(path))
            {
                throw new ArgumentException("Must be non-relative", "path");
            }

            this.Filter = filter;
            this.Path = path;
        }
    }
}
