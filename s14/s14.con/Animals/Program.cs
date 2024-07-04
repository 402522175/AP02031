namespace Animals;

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
        //string x = "ali  zari  vali dali";
        
        //Console.WriteLine(a);
        
        Console.WriteLine("Hello, World!");
    }
}