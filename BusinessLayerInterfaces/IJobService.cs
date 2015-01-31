using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerInterfaces
{
    public interface IJobService
    {
        List<IJob> GetJobs();
        IJob GetJob(int id);
    }
}
