using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeClassesNotEnumsWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sqlJobEnumButton_Click(object sender, EventArgs e)
        {
            var jobService = new EnumsBusinessLayer.JobService();
            var job = jobService.CreateJob(42, EnumsBusinessLayer.JobType.SqlJob, null, null, "AdventureWorks", "Default", "sa", "Passw0rd");
        }

        private void fileJobEnumButton_Click(object sender, EventArgs e)
        {
            var jobService = new EnumsBusinessLayer.JobService();
            var job = jobService.CreateJob(42, EnumsBusinessLayer.JobType.FileJob, "*.*", "C:\\Temp", null, null, null, null);
        }

        private void sqlJobClassButton_Click(object sender, EventArgs e)
        {
            var jobService = new ClassesBusinessLayer.SqlJobService();
            var job = jobService.CreateJob(42, "AdventureWorks", "Default", "sa", "Passw0rd");
        }

        private void fileJobClassEnum_Click(object sender, EventArgs e)
        {
            var jobService = new ClassesBusinessLayer.FileJobService();
            var job = jobService.CreateJob(42, "*.*", "C:\\Temp");
        }
    }
}
