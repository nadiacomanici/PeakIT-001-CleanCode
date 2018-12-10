using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection_Begin.Logic
{
    public class University
    {
        // StudentsService is a dependency for University class
        private StudentsService studentsService;

        public University()
        {
            // The university class is in control
            // because it is responsable for creating
            // the service inside its constructor
            this.studentsService = new StudentsService();
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
