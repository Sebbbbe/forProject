using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Models
{
    public class Project
    {
        public Guid Project_id { get; set; }
        public string Project_Name { get; set; }

        public ICollection<Issue> Issues { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
