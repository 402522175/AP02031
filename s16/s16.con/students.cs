namespace s16;
public class Student: Human, courses,scores{
    public int Std_id
    { 
        get
        {
            return s_id;

        }
        set
        {
            s_id = value;
        }
    }
    public static int endscore=0;
    private int s_id;
    public List<int> std_scores { get; set; }
    public List<string>std_courses { get; set; }
    public Student(string f_name, string l_name, int Dof_birth):base(f_name, l_name, Dof_birth) 
    {
        endscore++;
        Std_id = endscore;
        this.std_courses = new List<string>();
        this.std_scores = new List<int>();

    }
    public void Add_Courses(string course)
    {
        std_courses.Add(course);
    }

    public void Remove_Courses(string cours)
    {
        std_courses.Remove(cours);
    }
    public void Add_scores(int scores)
    {
        std_scores.Add(scores);
    }
    public void Remove_scores(int scor)
    {
        std_scores.Remove(scor);
    }
    public void show_courses()
    {
        Console.WriteLine($"The courses of {this.f_Name} {this.L_name} is :");
        foreach(string s in std_courses)
        {
            Console.WriteLine(s);
        }
    }
    public void show_scores()
    {
        Console.WriteLine($"The scores of the {this.f_Name} {this.L_name} is :");
        for(int i = 0;i < std_scores.Count; i++)
        {
            Console.WriteLine(std_scores[i]);
        }
    }
    public double Show_average_scores()
    {
        double sum = 0;
        foreach (double score in std_scores)
        {
            sum += score;
        }
        return sum / std_scores.Count;
    }
}