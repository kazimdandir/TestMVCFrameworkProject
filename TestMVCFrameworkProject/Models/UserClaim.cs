using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVCFrameworkProject.Models
{
    public class UserClaim
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static List<UserClaim> Users;

        static UserClaim()
        {
            Users = new List<UserClaim>
            {
                new UserClaim { Id = 1, FirstName = "Ali", LastName = "Veli"},
                new UserClaim { Id = 2, FirstName = "Osman", LastName = "Yılmaz"},
                new UserClaim { Id = 3, FirstName = "Ayşe", LastName = "Fatma"},
            };
        }

        public static List<UserClaim> UserList()
        {
            return Users;
        }

        public static void Delete(int id)
        {
            var selected = Users.FirstOrDefault(x => x.Id == id);
            if (selected != null)
            {
                Users.Remove(selected);
            }
        }
    }
}
