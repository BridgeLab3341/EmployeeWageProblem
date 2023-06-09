using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Employee
    {
        const int FullDayHour = 8, PartTimeHour = 4, FullTime = 0, PartTime = 1, Absent = 2;
        public void DailyWage(string companyName, int WagePerHour, int TotalWorkingDays, int TotalWorkingHours)
        {
            int emHrs = 0, totalworkdays=0, totalworkhours=0;
            while(totalworkhours < TotalWorkingHours && totalworkdays < TotalWorkingDays) 
            {
                totalworkdays++;
                Random random = new Random();
                int wages = random.Next(0, 3);
                switch (wages)
                {
                    case FullTime:
                        emHrs = FullDayHour;
                        break;
                    case PartTime:
                        emHrs = PartTimeHour;
                        break;
                    case Absent:
                        emHrs = 0;
                        break;
                }
                //int result = wage * WagePerHour;
                totalworkhours+= emHrs;
                Console.WriteLine("Company Name "+companyName +"====> EmpHrs: "+ emHrs);
            }
            Console.WriteLine("Total working Hours = "+totalworkhours);
            Console.WriteLine("Total working Days = "+totalworkdays);
            int totalEmpWage = totalworkhours * WagePerHour;
            Console.WriteLine("Employee Wage is = {0}",totalEmpWage);
        }
    }
}
