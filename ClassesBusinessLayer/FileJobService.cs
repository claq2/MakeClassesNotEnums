using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBusinessLayer
{
    public class FileJobService
    {
        public FileJob CreateJob(int id)
        {
            return new FileJob(id, "*.*", "C:\\Temp");
        }
    }
}
