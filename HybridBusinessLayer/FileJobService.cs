using System;
using System.Collections.Generic;
using System.Linq;

namespace HybridBusinessLayer
{
    public class FileJobService
    {
        public FileJob CreateJob(int id, string filter, string path)
        {
            return new FileJob(id, filter, path);
        }
    }
}
