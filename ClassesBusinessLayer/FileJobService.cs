using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBusinessLayer
{
    public class FileJobService
    {
        public FileJob CreateJob(int id, string filter, string path)
        {
            return new FileJob(id, filter, path);
        }
    }
}
