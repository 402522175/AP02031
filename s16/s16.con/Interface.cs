namespace s16;
interface university
{
    public void Add_Department(Department dep);
    public void Remove_Department(Department de);
    public void Add_Administrations(Administration admin);
    public void Remove_Administrations(Administration am);
}

interface department
{
    public void Add_Teacher(Teacher teacher);
    public void Remove_Teacher(Teacher teach);
    public void Add_Student(Student student);
    public void Remove_Student(Student student);
    public void Add_Employee(Employee employee);
    public void Remove_Employee(Employee employee);
}
interface administration
{
    public void Add_Employee(Employee e);
    public void Remove_Employee(Employee e);
}
interface courses
{
    public void Add_Courses(string course);
    public void Remove_Courses(string cours);
}
interface scores
{
    public void Add_scores(int  score); 
    public void Remove_scores(int score);
    public double Show_average_scores();
}

interface salaries
{
    public double Calculate_salaries();
}
interface show
{
    public void show_features();
}