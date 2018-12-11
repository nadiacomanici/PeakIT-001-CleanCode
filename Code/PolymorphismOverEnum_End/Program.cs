using PolymorphismOverEnum_End.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOverEnum_End
{
    class Program
    {
        static void Main(string[] args)
        {
            Student nadia = new DailyStudent("Nadia", "Comanici");
            Student ionel = new EveningStudent("Ionel", "Ionescu");
            Student maria = new WeekendStudent("Maria", "Popescu");

            List<Student> students = new List<Student>();
            students.Add(nadia);
            students.Add(ionel);
            students.Add(maria);

            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} are nevoie de {student.GetMinimumCreditPointsToPromote()} credite.");
            }
        }
    }
}
