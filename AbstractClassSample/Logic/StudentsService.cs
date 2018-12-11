using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSample.Logic
{
    public class StudentsService : AbstractStudentsService
    {
        public override Student GetStudentById(int id)
        {
            return students.SingleOrDefault(s => s.Id == id);
        }
    }
}
