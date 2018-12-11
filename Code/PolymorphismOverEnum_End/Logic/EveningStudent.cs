using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOverEnum_End.Logic
{
    public class EveningStudent : Student
    {
        public EveningStudent(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public override int GetMinimumCreditPointsToPromote()
        {
            // compute and return credits for evening courses
            return 50;
        }
    }
}
