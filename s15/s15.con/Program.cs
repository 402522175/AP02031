namespace s15.con;

public interface Shapeinterface
{
    public double Area();
    public double p();
    public bool isPointinside(double x, double y);
}
public class ShapeClass
{
    public string Name { get; set; }
    public string Color { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public ShapeClass(string name, double x, double y, string color)
    {
        Name = name;
        X = x;
        Y = y;
        Color = color;
    }
}

public class Circle : ShapeClass ,Shapeinterface
{
    public double Radius { get; set; }
    public Circle(double radius,string name, string color, double X, double Y):base(name,X,Y,color)
    {
        this.Radius = radius;
    }

    public double Area()
    {
        return this.Radius * this.Radius *Math.PI;
    }

    public double p()
    {
        return this.Radius*2*Math.PI;
    }

    public bool isPointinside(double x, double y)
    {
        double a = Math.Sqrt(Math.Pow((x-X),2) + Math.Pow((y-Y),2));
        if (a>this.Radius)
        {
            return true;
        }
        else { return false; }
    }
}

public class Rectangle : ShapeClass, Shapeinterface
{
    public double width { get; set; }
    public double height { get; set; }
    public Rectangle(double Width, double Height, string name, string color, double X, double Y) : base(name, X, Y, color)
    {
        this.width = Width;
        this.height = Height;
    }
    public void ScaleWidth(double scalefactor)
    {
        this.width *= scalefactor;
    }
    public void ScaleHeight(double scalefactor)
    {
        this.height *= scalefactor;
    }

    public double Area()
    {
        return this.height * this.width;
    }

    public double p()
    {
        return 2 * (this.width + this.height);
    }

    public bool isPointinside(double x, double y)
    {
        if ((x < X + 0.5 * (this.width) && x > X - 0.5 * (this.width) && (y < Y + 0.5 * (this.height) && y > Y - 0.5 * this.height)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Square : ShapeClass, Shapeinterface
{
    public double side { get; set; }
    public Square(double Side, string name, string color, double X, double Y) : base(name, X, Y, color)
    {
        this.side = Side;
    }
    public void ScaleSide(double scalefactor)
    {
        this.side *= scalefactor;
    }

    public double Area()
    {
        return (this.side * this.side);
    }

    public double p()
    {
        return 4 * this.side;
    }

    public bool isPointinside(double x, double y)
    {
        if ((x < X + 0.5 * (this.side) && x > X - 0.5 * (this.side) && (y < Y + 0.5 * (this.side) && y > Y - 0.5 * this.side)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
