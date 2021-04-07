using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Models
{
    public class User
    {
        public int user_id { get; set; }
        public string Name { get; set; }

        public ICollection<Issue> Issues { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
