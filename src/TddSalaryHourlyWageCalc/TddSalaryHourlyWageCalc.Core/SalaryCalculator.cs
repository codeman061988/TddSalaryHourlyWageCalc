using System;

namespace TddSalaryHourlyWageCalc.Core
{
    public class SalaryCalculator
    {
        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            const int HoursInYear = 2080;
            decimal annualSalary = hourlyWage * HoursInYear;
            return annualSalary;
        }
    }
}
