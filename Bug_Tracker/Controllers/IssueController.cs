using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Controllers
{
    public class IssueController
    {

        [HttpGet]
        public List<Models.Issue> Get()
        {
            var context = new BugTrackerDBContext();
            
            var Issue = context.Issues.Include(x => x.User).Include(x => x.Project).ToList();
            
            return Issue;
          
          
        }
    }
}
