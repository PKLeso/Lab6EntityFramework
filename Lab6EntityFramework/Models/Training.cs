using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6EntityFramework.Models
{
    class Training
    {
        public int TrainingID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Venue { get; set; }
        public string Seats { get; set; }
        public DateTime? RegistrationEndDate { get; set; }
        public float Cost { get; set; }

        public List<Course> Courses { get; set; }
    }
}
