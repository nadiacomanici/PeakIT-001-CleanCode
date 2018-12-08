using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOverEnum_End.Logic
{
    public abstract class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public abstract int GetMinimumCreditPointsToPromote();
    }
}
