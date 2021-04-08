using Bug_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private BugTrackerDBContext _bugTrackerDBContext;
        public UserController(BugTrackerDBContext bugTrackerDBContext)
        {
            _bugTrackerDBContext = bugTrackerDBContext;
        }

        [HttpGet]

        public List<Models.User> GetUser()
        {

            var User = _bugTrackerDBContext.Users.Include(x => x.Issues).Include(x => x.Comments).ToList();
            return User;
        }

     
        [HttpPost]
        public ActionResult<int> AddUser([FromBody] AddUserRequest user)
        {

            _bugTrackerDBContext.Users.Add(new User {Name = user.Name});
            _bugTrackerDBContext.SaveChanges();

         
            return Created("https://localhost:44321/user", user);
        }






        [HttpDelete]
        public void DeleteUser(int user_id)
        {
        
            var DeleteIssue = _bugTrackerDBContext.Issues.Find(user_id);
            _bugTrackerDBContext.Issues.Remove(DeleteIssue);
            _bugTrackerDBContext.SaveChanges();
        }

    }
}
