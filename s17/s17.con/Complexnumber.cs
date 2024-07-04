public class Complexnumber
{
    public int Re;
    public int Im;
    public Complexnumber (int re , int im)
    {
        this.Re = re;
        this.Im = im;
    }
    public static Complexnumber operator + (Complexnumber a , Complexnumber b)
    {
        Complexnumber z =  new Complexnumber (a.Re + b.Re , a.Im + b.Im);
        Console.WriteLine(z.Re + "+" + z.Im + "i");
        return z ;
    }
    public static Complexnumber operator - (Complexnumber a , Complexnumber b)
    {
        Complexnumber z =  new Complexnumber (a.Re - b.Re , a.Im - b.Im);
        Console.WriteLine(z.Re + "+" + z.Im + "i");
        return z ;
    }
    public static Complexnumber operator - (Complexnumber a )
    {
        Complexnumber z =  new Complexnumber (-a.Re  , -a.Im);
        Console.WriteLine(z.Re + "+" + z.Im + "i");
        return z ;
    }
    public static Complexnumber operator * (Complexnumber a , int b)
    {
        Complexnumber z =  new Complexnumber (a.Re * b , a.Im * b);
        Console.WriteLine(z.Re + "+" + z.Im + "i");
        return z ;
    }
    public static Complexnumber operator / (Complexnumber a , int b)
    {
        Complexnumber z =  new Complexnumber (a.Re / b , a.Im / b);
        Console.WriteLine(z.Re + "+" + z.Im + "i");
        return z ;
    }
}