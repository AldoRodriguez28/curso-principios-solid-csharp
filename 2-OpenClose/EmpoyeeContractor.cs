namespace OpenClose
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalaryMonthlly()
        {
            decimal hourValue = 40000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
            //Console.WriteLine($"Empleado: {employeeFullTime.Fullname}, Pago: {salary:C1} ");
        }
    }
}