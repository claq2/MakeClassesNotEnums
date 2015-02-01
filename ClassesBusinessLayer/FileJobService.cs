using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBusinessLayer
{
    public class FileJobService
    {
        public FileJob GetJob(int id)
        {
            return new FileJob { Id = id, Filter = "*.*", Path = "C:\\Temp" };
        }
    }
}
