using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSample.Logic
{
    public abstract class AbstractStudentsService
    {
        protected List<Student> students;
        protected int nextId;

        public AbstractStudentsService()
        {
            this.students = new List<Student>();
            this.nextId = 1;
        }

        internal Student AddStudent(string firstName, string lastName)
        {
            Student student = new Student(nextId++, firstName, lastName);
            this.students.Add(student);
            return student;
        }

        public abstract Student GetStudentById(int id);
    }
}
