using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOverEnum_Begin.Logic
{
    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public AttendanceTypes AttendanceType { get; private set; }

        public Student(string firstName, string lastName, AttendanceTypes attendanceType)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AttendanceType = attendanceType;
        }

        public int GetMinimumCreditPointsToPromote()
        {
            int minCreditPoints = 0;
            switch (this.AttendanceType)
            {
                case AttendanceTypes.Daily:
                    // compute and return credits for daily courses
                    minCreditPoints = 100;
                    break;

                case AttendanceTypes.Evening:
                    // compute and return credits for evening courses
                    minCreditPoints = 50;
                    break;

                case AttendanceTypes.Weekend:
                    // compute and return credits for weekend courses
                    minCreditPoints = 35;
                    break;
            }
            return minCreditPoints;
        }
    }
}
