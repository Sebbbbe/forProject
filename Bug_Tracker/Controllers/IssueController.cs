using Bug_Tracker.Models;
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
       
        [Route("[controller]")]
        [HttpGet]
        public List<Models.Issue> GetIssue()
        {
            var context = new BugTrackerDBContext();
            
            var Issue = context.Issues.Include(x => x.User).Include(x => x.Project).ToList();
            
            return Issue; 
        }

        [HttpPost]
        public void AddIssue([FromBody] Issue issue)
        {
            var context = new BugTrackerDBContext();
            context.Issues.Add(issue);
            context.SaveChanges();


        }

      


        [HttpDelete]
        public void DeleteIssue(int post_id)
        {
            var context = new BugTrackerDBContext();
            var DeleteIssue = context.Issues.Find(post_id);
            context.Issues.Remove(DeleteIssue);
            context.SaveChanges();
        }


        

    }
}
