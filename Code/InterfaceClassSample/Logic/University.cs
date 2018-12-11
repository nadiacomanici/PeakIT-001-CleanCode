using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClassSample.Logic
{
    public class University
    {
        private IStudentsService studentsService;

        public University(IStudentsService studentsService)
        {
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
