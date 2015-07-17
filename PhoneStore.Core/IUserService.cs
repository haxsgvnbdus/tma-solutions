using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneStore.Model.

namespace PhoneStore.Core
{
    class IUserService
    {
        IEnumerable<User> GetAllUsers();
        bool DoesUserExist(string username, string pass);
        bool CreateUser(User user);
        bool EditUser(User user);
        bool DeleteUser(int id);
        bool SaveUser(); 
    }
}
