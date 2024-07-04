namespace s16;
public class Employee: Human{
    public int Em_id {  get; set; }
    public double m_salary {  get; set; }
    
    public Employee(double salary, string f_name, string l_name, int dob) : base(f_name, l_name, dob)
    {
        m_salary = salary;
        this.Em_id++;
        
    }
}