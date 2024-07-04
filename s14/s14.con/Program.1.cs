using Animals;

namespace split_byte;

class Program
{
    static void Main(string[] args)
    {

        SPlitStr  st = new SPlitStr("ali  zari  vali dali",3);
        IEnumerator <string> std = st.GetEnumerator();
        while(std.MoveNext())
        {
            Console.WriteLine(std.Current);
        }
        
    }
}
