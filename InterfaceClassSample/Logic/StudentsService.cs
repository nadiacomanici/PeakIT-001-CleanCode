using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClassSample.Logic
{
    public class StudentsService : IStudentsService
    {
        private List<Student> students;
        private int nextId;

        public StudentsService()
        {
            this.students = new List<Student>();
            this.nextId = 1;
        }

        public Student AddStudent(string firstName, string lastName)
        {
            Student student = new Student(nextId++, firstName, lastName);
            this.students.Add(student);
            return student;
        }

        public Student GetStudentById(int id)
        {
            return students.SingleOrDefault(s => s.Id == id);
        }
    }
}
