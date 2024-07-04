using System.Globalization;

namespace s16;
public class Human
{
    
    public string f_Name { get; set; }
    public string L_name { get; set; }
    public int D_of_birth { get; set; }
    public Human(string f_Name, string l_name, int d_of_birth)
    {
        this.f_Name = f_Name;
        this.L_name = l_name;
        D_of_birth = d_of_birth;
    }
}
public class Teacher: Human,courses{
    public int Teacher_num {  get; set; }
    public int T_nums
    {
        get
        {
            return Teacher_num;
        }
        set
        {
            Teacher_num= value;
        }
    }
    private static int Teacher_id =0;
    public double Salary {  get; set; }
    public List<string> lessons;
    public Teacher(double Salary,string f_name,string l_name, int dOfBirth):base(f_name,l_name, dOfBirth)
    {
        Teacher_id++;
        this.Salary = Salary;
        this.lessons = new List<string>();
        T_nums += Teacher_id;
    }
    public void Add_Courses(string course)
    {
        lessons.Add(course);
    }

    public void Remove_Courses(string cours)
    {
        lessons.Remove(cours);
    }
    public void Show_lessons()
    {
        for (int i=0;i<lessons.Count;i++)
        {
            Console.WriteLine(lessons[i]);
        }
    }
}