using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidCodeDuplication_Begin.Logic
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Person
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Gender Gender { get; private set; }

        public Person(int id, string firstName, string lastName, Gender gender)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
        }
    }
}
