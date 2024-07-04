namespace s16;

public class University:university,salaries,show{
    public string U_name{get;set;}
    public string Country{get;}
    public Teacher U_boss;
    public List<Department> departments;
    public List<Administration> administrations;

    public University(string name,string country,Teacher boss){
        this.departments = new List<Department>();
        this.administrations = new List<Administration>();
        this.U_boss = boss;
        this.U_name = name;
        this.Country = country;
    }

    
    public void Remove_Department(Department d)
    {
        departments.Remove(d);
    }

    public void Add_Administrations(Administration admin)
    {
        administrations.Add(admin);
    }

    public void Remove_Administrations(Administration adm)
    {
        administrations.Remove(adm);
    }
    public void Add_Department(Department dep)
    {
        departments.Add(dep);
    }

    public double Calculate_salaries()
    {
        double s = 0;
        foreach (Department department in departments)
        {
            s += department.Calculate_salaries();
        }
        foreach (Administration admin in administrations)
        {
            s += admin.Calculate_salaries();
        }
        s += this.U_boss.Salary;
        return s;
    }
    public void show_features()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"The name of the University_Boss is : {this.U_boss.f_Name} {this.U_boss.L_name} , the" +
            $" Birth year of the University_Boss is : {this.U_boss.D_of_birth}");
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (Department department in departments)
        {
            Console.WriteLine(department.show_features);
        }
        foreach (Administration admin in administrations)
        {
            Console.WriteLine(admin.show_features);
        }
    }
}