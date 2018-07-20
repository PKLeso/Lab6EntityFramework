using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Lab6EntityFramework.Models
{
    class TrainingDBContext : DbContext
    {
        public DbSet<Delegate> Delegates { get; set; }
        public DbSet<Dietary> Dietaries { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Training> Trainings { get; set; }
    }
}
