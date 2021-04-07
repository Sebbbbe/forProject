using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Models
{
    public class Comment
    {
        public Guid comment_id{ get; set; }
        public string Comments { get; set; }

        public User User { get; set; }
        public Issue Issues { get; set; }
    }
}
