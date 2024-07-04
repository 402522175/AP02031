public class Complexnumber
{
    public int Re;
    public int Im;
    public Complexnumber(int Re, int Im)
    {
        this.Re = Re;
        this.Im = Im;
    }
    public static Complexnumber operator -(Complexnumber a)
    {
        return new Complexnumber(-a.Re, -a.Im);
        
    }
    public static Complexnumber operator -(Complexnumber a, Complexnumber b)
    {
        return new Complexnumber(a.Re-b.Re, a.Im-b.Im);
    }
    public int this[bool index]
    {
        get
        {
            if(index==true) return this.Re;
            return this.Im;  
        }
        set
        {
            if(index==true) this.Re=value;
            else this.Im=value;
        }
    }
}