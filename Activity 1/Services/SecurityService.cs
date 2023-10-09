using System.Collections.Generic;
using Activity_1.Models;

namespace Activity_1.Services
{
    public class SecurityService
    {
        UsersDAO usersDAO = new UsersDAO();
        public SecurityService()
        {
            
        }
        public bool isValid(UserModel user)
        {
            return usersDAO.FindUserByNameAndPassword(user);
        }
    }
}
