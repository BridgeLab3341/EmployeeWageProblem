using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Employee
    {
        const int  WagePerHour = 20, FullDayHour = 8, PartTimeHour = 4, FullTime = 0, PartTime = 1, Absent = 2, 
            TotalWorkingDays = 20, TotalWorkingHours=100;
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
            int wage = 0, totalworkdays=0, totalworkhours=0;
            Random random = new Random();
            while(totalworkhours <= TotalWorkingHours && totalworkdays < TotalWorkingDays) 
            {
                totalworkdays++;
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
                //int result = wage * WagePerHour;
                totalworkhours+= wage;
                Console.WriteLine("Day "+totalworkdays +"====> EmpHrs: "+wage);
            }
            Console.WriteLine("Total working Hours = "+totalworkhours);
            Console.WriteLine("Total working Days = "+totalworkdays);
            int totalEmpWage = totalworkhours * WagePerHour;
            Console.WriteLine("Employee Wage is = {0}",totalEmpWage);
        }
    }
}
