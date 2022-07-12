using Reddit2.Database;
using Reddit2.Model;

namespace Reddit2.Services
{
    public class UserService
    {
        public ApplicationDbContext Context { get; set; }
        public UserService(ApplicationDbContext context)
        {
            Context = context;
        }

        public void AddUser(string userName, string userPassword)
        {
            var us = new User { UserName = userName, UserPassword = userPassword };
            Context.Users.Add(us);
            Context.SaveChanges();
        }

        public User? Authentication(string username,string password)
        {
            return  Context.Users.FirstOrDefault(u => u.UserName == username && u.UserPassword == password);
        }
    }
}
