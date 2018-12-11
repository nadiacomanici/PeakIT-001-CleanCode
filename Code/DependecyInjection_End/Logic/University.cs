using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection_End.Logic
{
    public class University
    {
        // StudentsService is a dependency for University class
        private StudentsService studentsService;

        public University(StudentsService studentsService)
        {
            // The university class is no longer in control
            // and no longer responsable for creating the dependency
            // Instead, it assumes it receives it and can use it
            // Inversion of Control & Dependency Injection
            this.studentsService = studentsService;
        }

        public Student GetStudentById(int id)
        {
            return studentsService.GetStudentById(id);
        }

        public Student AddStudent(string firstName, string lastName)
        {
            return studentsService.AddStudent(firstName, lastName);
        }
    }
}
