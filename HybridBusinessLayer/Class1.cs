using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridBusinessLayer
{
    public class Class1
    {
    }

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

    public class JobService
    {
        public Job CreateJob(int id, JobType type, string filter, string path, string database, string instance, string username, string password)
        {
            // Create factory instance
            // Call appropriate factory method
            // Return result of ToJob method
            switch(type)
            {
                case JobType.FileJob:
                    return new FileJobService().CreateJob(id, filter, path).ToJob();
                case JobType.SqlJob:
                    return new SqlJobService().CreateJob(id, instance, database, username, password).ToJob();
                case JobType.Sql2014Job:
                default:
                    throw new ArgumentException("Unknown type " + type);
            }

            switch (type)
            {
                case JobType.FileJob:
                    if (!System.IO.Path.IsPathRooted(path))
                    {
                        throw new ArgumentException("Must be non-relative", "path");
                    }

                    return new Job { JobType = type, Id = id, Filter = filter, Path = path };
                case JobType.SqlJob:
                case JobType.Sql2014Job:
                    var newJob = new Job { JobType = type, Id = id, Database = database, Instance = instance, Username = username, Password = password };
                    if (type == JobType.Sql2014Job)
                    {
                        newJob.Instance += "2014";
                    }

                    return newJob;
                default:
                    throw new ArgumentException("Unknown type " + type);
            }
        }
    }

    public enum JobType
    {
        FileJob,
        SqlJob,
        Sql2014Job,
    }

    public class FileJob: AbstractJob
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

        public Job ToJob()
        {
            return new Job { Filter = this.Filter, JobType = JobType.FileJob, Path = this.Path, Id = this.Id };
        }
    }

    public abstract class AbstractJob
    {
        public int Id { get; set; }

        protected AbstractJob(int id)
        {
            this.Id = id;
        }
    }

    public class FileJobService
    {
        public FileJob CreateJob(int id, string filter, string path)
        {
            return new FileJob(id, filter, path);
        }
    }

    public class SqlJobService
    {
        public SqlJob CreateJob(int id, string instance, string database, string username, string password)
        {
            return new SqlJob(id, instance, database, username, password);
        }
    }

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

        public Job ToJob()
        {
            return new Job { Id = this.Id, Database = this.Database, Instance = this.Instance, Password = this.Password, Username = this.Username };
        }
    }

    public class Sql2014Job : SqlJob
    {
        public Sql2014Job(int id, string instance, string database, string username, string password)
            : base(id, instance, database, username, password)
        {
            this.Instance += "2014";
        }
    }

    public class Sql2014JobService
    {
        public Sql2014Job CreateJob(int id, string instance, string database, string username, string password)
        {
            return new Sql2014Job(id, instance, database, username, password);
        }
    }
}
