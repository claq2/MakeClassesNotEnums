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
            var job = jobService.GetJob(42, EnumsBusinessLayer.JobType.SqlJob);
        }

        private void fileJobEnumButton_Click(object sender, EventArgs e)
        {
            var jobService = new EnumsBusinessLayer.JobService();

        }

        private void sqlJobClassButton_Click(object sender, EventArgs e)
        {
            var jobService = new ClassesBusinessLayer.SqlJobService();

        }

        private void fileJobClassEnum_Click(object sender, EventArgs e)
        {
            var jobService = new ClassesBusinessLayer.FileJobService();

        }
    }
}
