using s16;

public class Department:department,salaries,show{
    public string Name { get; set; }
    public Teacher Boss;
    public List<Teacher> Teachers;
    public List<Student> students;
    public List<Employee> employees;
    public List<StudentGroups> studentGroups;
   
    public Department(string name, Teacher boss)
    {
        this.Name = name;
        this.Boss = boss;
        this.studentGroups = new List<StudentGroups>();
        this.students = new List<Student>();
        this.employees = new List<Employee>();
        this.Teachers = new List<Teacher>();

    }
    public void Add_Teacher(Teacher teacher)
    {
        Teachers.Add(teacher);
    }
    public void Remove_Teacher(Teacher teach)
    {
        Teachers.Remove(teach);
    }
    public void Add_Student(Student student) 
    {  
        students.Add(student); 
    }
    public void Remove_Student(Student student)
    {
        students.Remove(student);
    }
    public void Add_Groups(StudentGroups groups)
    {
        studentGroups.Add(groups);
    }
    public void Remove_Groups(StudentGroups groups)
    {
        studentGroups.Remove(groups);
    }
    public void Add_Employee(Employee employee)
    {
        employees.Add(employee);
    }

    public void Remove_Employee(Employee employee)
    {
        employees.Remove(employee);
    }
    public double Calculate_salaries()
    {
        double salary = 0;
        foreach (Teacher teacher in Teachers) {
            salary += teacher.Salary;
        }
        foreach(Employee employee in employees)
        {
            salary += employee.m_salary;
        }
        salary += this.Boss.Salary;
        return salary;
    }
    public void show_features()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"The Name of the Department_boss: {this.Boss.f_Name} {this.Boss.L_name}, The year of birth : {this.Boss.D_of_birth}");
        foreach(Teacher teacher in Teachers)
        {
            if (teacher != this.Boss)
            Console.WriteLine("The name of the professor: " + teacher.f_Name + teacher.L_name + " professor birth_year : "+ teacher.D_of_birth + " professor_id: "+ teacher.Teacher_num);
        }
        Console.ForegroundColor = ConsoleColor.Green;
        for(int i =0;i<this.students.Count;i++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Student student = this.students[i];
            Console.WriteLine($"{i} The name of the student is : {student.f_Name} {student.L_name} , student birht_year is : {student.D_of_birth} Student_id : {student.Std_id}");
        }
        Console.ForegroundColor= ConsoleColor.Green;
        foreach(Employee employee in this.employees)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{employee.Em_id} , The name of the Department_Employee is : {employee.f_Name} {employee.L_name} " +
                $"The Birth_Year of the Department employee is : {employee.D_of_birth}");
        }
    }
}