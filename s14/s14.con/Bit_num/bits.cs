using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Bit_num;

public class NumberBitEnumerator : IEnumerable<int>
{
    
    private int number ;
    public string st{get;set;}
    public NumberBitEnumerator(int nums){
        number = nums;
        string x = st.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
    }
    public IEnumerator<int> GetEnumerator()
    {
        return  new Bit_Enumerator(this.number);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new Bit_Enumerator(this.number);
    }
}

internal class Bit_Enumerator : IEnumerator<int>
{
    public int x =-1;
    private int number;
    public Bit_Enumerator(int nums){
        this.number = nums;
    }
    public int Current => throw new NotImplementedException();

    object IEnumerator.Current => throw new NotImplementedException();

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        x += 1;
        return x<this.number;
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}