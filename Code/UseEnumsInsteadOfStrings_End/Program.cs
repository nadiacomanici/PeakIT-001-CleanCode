using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseEnumsInsteadOfStrings_End.Logic;

namespace UseEnumsInsteadOfStrings_End
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("nadia", "comanici", UserRoles.Employee);

            DashboardPage page = new DashboardPage();
            page.LogUser(user);
        }
    }
}
