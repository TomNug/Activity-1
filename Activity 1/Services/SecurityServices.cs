using System.Collections.Generic;
using Activity_1.Models;

namespace Activity_1.Services
{
    public class SecurityServices
    {
        List<UserModel> knownUsers = new List<UserModel>();

        public SecurityServices()
        {
            knownUsers.Add(new UserModel { Id = 0, Username = "Ban O'Bannon", Password = "screenplay" });
            knownUsers.Add(new UserModel { Id = 1, Username = "Jerry Goldsmith", Password = "music" });
            knownUsers.Add(new UserModel { Id = 2, Username = "Yaphet Kotto", Password = "Parker" });
        }
        public bool isValid(UserModel user)
        {
            return knownUsers.Any(x => x.Id == user.Id && x.Username == user.Username && x.Password == user.Password);
        }
    }
}
