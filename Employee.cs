namespace Builder;

public class Employee
{
    public Employee(string name, string email, decimal salary)
    {
        Name = name;
        Email = email;
        Salary = salary;
    }
    public string Name { get; }
    public string Email { get; }
    public decimal Salary { get; }
}