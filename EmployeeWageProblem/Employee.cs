using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Employee
    {
        const int WagePerHour = 20, FullDayHour = 8, PartTimeHour = 4, Absent=0;
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
            Random random = new Random();
            int wages = random.Next(0, 3);
            if (wages == 0)
            {
                int dailywage = WagePerHour * FullDayHour;
                Console.WriteLine("Daily Wage per Day = {0}",dailywage);
            }  
            if(wages == 1)
            {  
                int partime=WagePerHour * PartTimeHour;
                Console.WriteLine("Part Time Wage Per Day = {0}",partime);
            }
            if(wages == 2)
            {
                int absent = WagePerHour * Absent;
                Console.WriteLine("Absent = {0}",absent);
            }             
        }
    }
}
