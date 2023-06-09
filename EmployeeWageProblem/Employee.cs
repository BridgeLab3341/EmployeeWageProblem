using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Employee
    {
        public class CompanyWage
        {
            public string CompanyName { get; set; }
            public int TotalWage { get; set; }
            public List<int> DailyWages { get; set; }
        }

        public List<CompanyWage> companyWages = new List<CompanyWage>();

        private const int FullDayHour = 8;
        private const int PartTimeHour = 4;
        private const int FullTime = 0;
        private const int PartTime = 1;
        private const int Absent = 2;

        public void DailyWage(string companyName, int wagePerHour, int totalWorkingDays, int totalWorkingHours)
        {
            List<int> dailyWages = new List<int>();
            int empHrs = 0;
            int totalWorkDays = 0;
            int totalWorkHours = 0;

            while (totalWorkHours < totalWorkingHours && totalWorkDays < totalWorkingDays)
            {
                totalWorkDays++;
                int wages = GetEmployeeWage();
                switch (wages)
                {
                    case FullTime:
                        empHrs = FullDayHour;
                        break;
                    case PartTime:
                        empHrs = PartTimeHour;
                        break;
                    case Absent:
                        empHrs = 0;
                        break;
                }
                totalWorkHours += empHrs;
                int dailyWage = empHrs * wagePerHour;
                dailyWages.Add(dailyWage);
                Console.WriteLine("Company Name: {0} ===> EmpHrs: {1}", companyName, empHrs);
            }

            Console.WriteLine("Total working Hours = {0}", totalWorkHours);
            Console.WriteLine("Total working Days = {0}", totalWorkDays);
            int totalEmpWage = totalWorkHours * wagePerHour;
            Console.WriteLine("Employee Wage is = {0}", totalEmpWage);

            CompanyWage companyWage = new CompanyWage()
            {
                CompanyName = companyName,
                TotalWage = totalEmpWage,
                DailyWages = dailyWages
            };
            companyWages.Add(companyWage);
        }

        private int GetEmployeeWage()
        {
            Random random = new Random();
            return random.Next(0, 3);
        }

        public void DisplayCompanyWages()
        {
            Console.WriteLine("Company Wages");
            Console.WriteLine("==============");
            foreach (var companyWage in companyWages)
            {
                Console.WriteLine("Company Name: {0}, Total Wage: {1}", companyWage.CompanyName, companyWage.TotalWage);
                Console.WriteLine("Daily Wages:");
                foreach (var dailyWage in companyWage.DailyWages)
                {
                    Console.WriteLine(dailyWage);
                }
            }
        }
    }
}

