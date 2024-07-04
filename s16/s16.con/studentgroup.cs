namespace s16;
public class StudentGroups {
    public string sG_name { get; set; }
    public Student std { get; set; }
    public List<Student> students { get; set; }
    public StudentGroups(string SG_name, Student m_Std)
    {
        this.sG_name = SG_name;
        this.std = m_Std;
        students = new List<Student>();
    }
    public void Add_member(Student stu)
    {
        students.Add(stu);
    }
    public void Remove_members(Student stud)
    {
        students.Remove(stud);
    }

}