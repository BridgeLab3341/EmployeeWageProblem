using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Employee
    {
        const int WagePerHour = 20, FullDayHour = 8, PartTimeHour = 4, FullTime = 0, PartTime = 1, Absent = 2;
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
        public void DailyWage()
        {
            int wage = 0;
            Random random = new Random();
            int wages = random.Next(0, 3);
            switch (wages)
            {
                case FullTime:
                    wage = FullDayHour;
                    break;
                    case PartTime:
                    wage = PartTimeHour;
                    break;
                    case Absent: 
                    wage = 0;
                    break;                   
            }
            int result = wage * WagePerHour;
            Console.WriteLine("Employee Wage = {0}",result);
        }
    }
}
