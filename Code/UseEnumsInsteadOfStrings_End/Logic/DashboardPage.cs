using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseEnumsInsteadOfStrings_End.Logic
{
    public class DashboardPage
    {
        //public void LogUser(User user)
        //{
        //    if (user.Role == UserRoles.Manager)
        //    {
        //        GiveAdminRights();
        //    }
        //    else
        //    {
        //        if (user.Role == UserRoles.Employee)
        //        {
        //            GiveEditRights();
        //        }
        //        else
        //        {
        //            GiveReadOnlyRights();
        //        }
        //    }
        //}

        public void LogUser(User user)
        {
            switch (user.Role)
            {
                case UserRoles.Manager:
                    GiveAdminRights();
                    break;
                case UserRoles.Employee:
                    GiveEditRights();
                    break;
                default:
                    GiveReadOnlyRights();
                    break;
            }
        }

        private void GiveReadOnlyRights()
        {
            Console.WriteLine("Has ReadOnly Rights");
        }

        private void GiveEditRights()
        {
            Console.WriteLine("Has Edit Rights");
        }

        private void GiveAdminRights()
        {
            Console.WriteLine("Has Admin Rights");
        }
    }
}
