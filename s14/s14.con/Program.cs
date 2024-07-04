using System.Data.Common;
using System.Threading.Channels;

namespace s14.animal;
interface Ianimal
{
    public string Move { get; }
    public string MakeSound { get; }
}

internal class Dog : Ianimal
{
    private string m_Name;
    private string m_type;

    public Dog(string name, string type)
    {
        m_Name = name;
        m_type = type;
    }
    public string Move =>$"The Dog :{m_Name} with the type of {m_type} walks like a cat .";

    public string MakeSound => $" The dog :{m_Name} with the type of {m_type} makes hophop sound. ";
}
internal class Cat : Ianimal
{
    private string m_Name;
    private string m_type;

    private string m_color;
    public Cat(string name, string type, string color)
    {
        this.m_Name = name;
        this.m_type = type;
        this.m_color = color;
    }

    public string Move => $"The cat {m_Name} with the type :{m_type} and color: {m_color} walks like a child";

    public string MakeSound => $"the {m_Name} with the type of {m_type} makes sound as miu miu.";
}
class Program
{
    static void Main(string[] args)
    {
        Ianimal[] animals = new Ianimal[2]
        {
            new Dog("a", "white"),
            new Cat("b", "gorbesan","Black")

        };
        for (int i = 0; i < animals.Length; i++)
        {
            Console.WriteLine(animals[i].Move);
            Console.WriteLine(animals[i].MakeSound);
        }
    }
}
