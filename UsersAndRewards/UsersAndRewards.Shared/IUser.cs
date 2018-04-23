using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndRewards.Shared
{
    public interface IUser
    {
        List<User> GetUsers();

        User GetUserById(int userId);

        void AddUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int userId);
    }
}
