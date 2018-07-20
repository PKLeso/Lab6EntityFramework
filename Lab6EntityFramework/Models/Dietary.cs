using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6EntityFramework.Models
{
    class Dietary
    {
        public int DietaryID { get; set; }
        public int Description { get; set; }

        public List<Delegate> Delegates { get; set; }
    }
}
