using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvoidCodeDuplication_Begin.Logic
{
    public class RegistrationBook
    {
        private int nextId;
        private List<Person> persons;

        public RegistrationBook()
        {
            this.persons = new List<Person>();
            this.nextId = 0;
        }

        public void RegisterPerson(string firstName, string lastName, Gender gender)
        {
            Person person = new Person(nextId++, firstName, lastName, gender);
            this.persons.Add(person);
        }

        public int CountFemales()
        {
            int count = 0;
            foreach (var person in this.persons)
            {
                if (person.Gender == Gender.Female)
                {
                    count++;
                }
            }
            return count;
        }

        public int CountMales()
        {
            int count = 0;
            foreach (var person in this.persons)
            {
                if (person.Gender == Gender.Male)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
