using EcommerceApp.Models;

namespace EcommerceApp.Services
{
    public interface IUserService
    {
        List<User> GetUsers();

        User GetUser(Guid Id);

        User AddUser(User user);

        void DeleteUser(User user);

        User UpdateUser(User user);
    }


}
