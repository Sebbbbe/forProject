using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Models
{
    public class Issue
    {
        public Guid Post_id { get; set; }
        public string Asignment { get; set; }
        public string Summary { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public int Priority { get; set; }
        public string Status { get; set; }
        public string Asigned_to { get; set; }
        public string Picture { get; set; }

        public Guid Project_id { get; set; }

        public DateTime Date_created { get; set; }
        public DateTime due_date { get; set; }
        public DateTime Completed_date { get; set; }



        public User User { get; set; }

        public Project Project { get; set; }
    }
}
