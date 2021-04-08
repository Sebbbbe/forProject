using Bug_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Controllers
{
    public class UserController
    {

   
        [HttpGet]
        public List<Models.User> GetUser()
        {
            var context = new BugTrackerDBContext();

            var User = context.Users.Include(x => x.Issues).Include(x => x.Comments).ToList();

            return User;
        }

        [HttpPost]
        public ActionResult<User> AddUser([FromBody] AddUserRequest user)
        {
            var context = new BugTrackerDBContext();
            context.Users.Add(new User {Name = user.Name});
            context.SaveChanges();

            var addUser = new User
            {
                Name = user.Name
                
            };


            context.Users.Add(new User { Name = user.Name });
            context.SaveChanges();
            return Created("https://localhost:44321/user", user);
        }






        [HttpDelete]
        public void DeleteUser(int user_id)
        {
            var context = new BugTrackerDBContext();
            var DeleteIssue = context.Issues.Find(user_id);
            context.Issues.Remove(DeleteIssue);
            context.SaveChanges();
        }

    }
}
