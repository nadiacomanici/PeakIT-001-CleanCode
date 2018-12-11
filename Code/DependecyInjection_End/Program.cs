using DependecyInjection_End.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection_End
{
    class Program
    {
        private static void DisplayStudentById(University university, int id)
        {
            Student student = university.GetStudentById(id);
            if (student != null)
            {
                Console.WriteLine($"Student with id={student.Id} is {student.FullName}");
            }
            else
            {
                Console.WriteLine($"There is no student with id={id}");
            }
        }

        static void Main(string[] args)
        {
            University university = new University(new StudentsService());

            university.AddStudent("Nadia", "Comanici");
            university.AddStudent("Vasile", "Popescu");
            university.AddStudent("Maria", "Ionescu");

            DisplayStudentById(university, 1);
            DisplayStudentById(university, 10);
        }
    }
}
