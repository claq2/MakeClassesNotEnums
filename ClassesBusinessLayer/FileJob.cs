using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBusinessLayer
{
    public class FileJob : Job
    {
        public string Path { get; set; }

        public string Filter { get; set; }

        public FileJob()
        {

        }
    }
}
