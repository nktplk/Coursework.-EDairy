using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.EDairy
{
    public class CheckUser
    {
        public string Login
        {
            get; set;
        }

        public bool IsAdmin
        {
            get;
        }

        public string Status => IsAdmin ? "Administrator" : "User";

        public CheckUser(string login, bool isAdmin)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
        }
    }
}
