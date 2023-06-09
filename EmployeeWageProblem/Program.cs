namespace EmployeeWageProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem");
            Console.WriteLine("--------------------------------");
            Employee employee = new Employee();
            employee.DailyWage("TCS",25,30,9);
            employee.DailyWage("Infosys", 24, 29, 8);
            employee.DailyWage("Google",20,30,9);
        }
    }
}
