using System.ComponentModel.Design.Serialization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Complexnumber x = new Complexnumber(1,4);
        Complexnumber y = new Complexnumber(3,7);
        Complexnumber a = x + y;
        Complexnumber b = x - y;
        Complexnumber c = - x;
        Complexnumber d = x * 2;
        Complexnumber e = y / 2;  
        Arrey  f= new Arrey (4);
    }
        
}
