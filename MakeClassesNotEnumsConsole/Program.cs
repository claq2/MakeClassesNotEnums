using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeClassesNotEnumsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Enums");
            Console.WriteLine("2. Classes");
            int enumOrClass = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. File Job");
            Console.WriteLine("2. SQL Job");
            int jobType = Convert.ToInt32(Console.ReadLine());

            if (enumOrClass == 1)
            {
                var jobService = new EnumsBusinessLayer.JobService();

                // Enums
                if (jobType == 1)
                {
                    // File
                    var job = jobService.CreateJob(42, EnumsBusinessLayer.JobType.FileJob, "*.*", "C:\\Temp", null, null, null, null);
                    Console.WriteLine("Enum file job - filter = {0}, path = {1}", job.Filter, job.Path);
                }
                else if (jobType == 2)
                {
                    var job = jobService.CreateJob(42, EnumsBusinessLayer.JobType.SqlJob, null, null, "AdventureWorks", "Default", "sa", "Passw0rd");
                    Console.WriteLine("Enum SQL job - database = {0}, instance = {1}, username = {2}", job.Database, job.Instance, job.Username);
                }
            }
            else if (enumOrClass == 2)
            {
                // Classes
                if (jobType == 1)
                {
                    // File
                    var jobService = new ClassesBusinessLayer.FileJobService();
                    var job = jobService.CreateJob(42);
                    Console.WriteLine("Enum file job - filter = {0}, path = {1}", job.Filter, job.Path);
                }
                else if (jobType == 2)
                {
                    // SQL
                    var jobService = new ClassesBusinessLayer.SqlJobService();
                    var job = jobService.CreateJob(42);
                    Console.WriteLine("Enum SQL job - database = {0}, instance = {1}, username = {2}", job.Database, job.Instance, job.Username);
                }
            }
        }
    }
}
