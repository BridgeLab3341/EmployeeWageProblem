using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Employee
    {
        public void CheckEmployeeAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(0, 2);
            if (attendance == 0)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
