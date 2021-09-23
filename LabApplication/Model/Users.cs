using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabApplication.Model
{
    /// <summary>
    /// У нас нет дб, поэтому список пользователей хранится вот так вот
    /// <para>Этот класс просто хранит список пользователей и ничего больше не делает.</para>
    /// </summary>
    public static class Users
    {
        public static List<User> UsersList = new List<User>
        {
            new User("infinity", "bqwr13", "Robert Cannon", Role.LaboratoryAssistant),
            new User("alpha", "34$ost1", "Garey Atkins", Role.SystemAdministrator),
            new User("TestLogin", "TestPassword", "FirstName LastName", Role.SystemAdministrator)
        };
    }
}
