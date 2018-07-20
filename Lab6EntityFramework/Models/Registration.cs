using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6EntityFramework.Models
{
    class Registration
    {
        public int RegistrationID { get; set; }
        public DateTime? DateRegistered { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int TrainingID { get; set; }

        public List<Delegate> Delegates { get; set; }
        public Training Training { get; set; }
    }
}
