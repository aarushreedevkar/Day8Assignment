namespace EmployeeWages2
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeePresentAbsent employeePresentAbsent = new EmployeePresentAbsent();
            employeePresentAbsent.EmployeePresentOrAbsent();

            DailyEmpwage dailyEmpwage = new DailyEmpwage();
            dailyEmpwage.EmployeeDailyWage()

            PartTimeEmployeeWages partTimeEmployeeWage = new PartTimeEmployeeWages();
            partTimeEmployeeWage.PartTimeWage();

            CalculateWages calculateWages = new CalculateWages();
            calculateWages.calculateHrswages();

            SwitchCaseStatement switchCaseStatement = new SwitchCaseStatement();
            switchCaseStatement.CaseStatement();

            MonthlyEmpWages monthlyEmpWage = new MonthlyEmpWages();
            monthlyEmpWage.MontlyWageComputation();

        }
    }

    internal class DailyEmpwage
    {
    }
}
