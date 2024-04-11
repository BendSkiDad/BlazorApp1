using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class JobTrackerDevContext : DbContext
    {
        public JobTrackerDevContext(DbContextOptions<JobTrackerDevContext> options)
            : base(options)
        {
        }

        public DbSet<JobProcess> JobProcesses { get; set; }
        //public DbSet<Job> Jobs { get; set; }
    }
}
