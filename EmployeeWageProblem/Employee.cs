using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Employee
    {
        const int WagePerHour = 20, FullDayHour = 8;
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
            int fullDayWage = WagePerHour * FullDayHour;
            Console.WriteLine("Daily Wage per day = {0}", fullDayWage);
        }
    }
}
