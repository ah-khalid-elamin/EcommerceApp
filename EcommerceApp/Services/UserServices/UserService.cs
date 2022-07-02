using EcommerceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApp.Services
{
    public class UserService : IUserService
    {
        private readonly DBContext _dbContext;

        public UserService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User AddUser(User user)
        {
            var entry = _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return entry.Entity;
        }

        public void DeleteUser(User user)
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }

        public User GetUser(Guid Id)
        {
            var usr = _dbContext.Users.AsNoTracking().Where(x=> x.Id == Id).FirstOrDefault();
            return usr;
        }

        public List<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public User UpdateUser(User user)
        {
            var entry = _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return entry.Entity;
        }
    }
}
