using System.Security.Cryptography.X509Certificates;

namespace s16;
public class Administration:administration,salaries,show{
    public string A_name {  get; set; }
    public Employee Boss { get; set; }
    public List<Employee> Employees;
    public Administration(string name, Employee b_name)
    {
        Employees = new List<Employee>();
        this.A_name = name;
        this.Boss = b_name;
    }
    public void Add_Employee(Employee e)
    {
        Employees.Add(e);
    }

    public void Remove_Employee(Employee e)
    {
        Employees.Remove(e);
    }
    public double Calculate_salaries()
    {
        double sum = 0;
        foreach (Employee emp in Employees)
        {
            sum += emp.m_salary;
        }
        sum += Boss.m_salary;
        return sum;
    }
    public void show_features()
    {
        Console.WriteLine($"Administration Boss_name = {Boss.f_Name} {Boss.L_name} , Year of birth = {Boss.D_of_birth}");
        for (int i = 0; i < Employees.Count; i++)
        {
            Employee emp = Employees[i];
            Console.WriteLine($"{i} : Name = {emp.f_Name} {emp.L_name}, Year of birth = {emp.D_of_birth}");
        }
    }
}