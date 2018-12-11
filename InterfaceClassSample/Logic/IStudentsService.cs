using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClassSample.Logic
{
    public interface IStudentsService
    {
        Student GetStudentById(int id);
        Student AddStudent(string firstName, string lastName);
    }
}
