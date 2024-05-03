public class Employee
{
    public int EmpID;
    public string name;
    public string surename;
    public string position;
    public string address;
    public string sex;
    public int SalaryPerHour;
    public int NoOfWorkingHours;
    public static int employeesNumber;
    public const string TypeOfEmployee = "Contract Based";
    public readonly string DepartmentName;

    public Employee()
    {
        DepartmentName = "Development Department";
        Employee.employeesNumber++;
    }
}