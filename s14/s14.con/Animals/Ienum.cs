using System.Collections;
using System.Globalization;

namespace Animals;
public class SPlitStri: IEnumerator<string>{
    private string m_str;
    private int m_nums  ;
    //public string [] m_3 = new string[7];
    private string m_std =null;
    
    
    public SPlitStri(string str, int nums){
        m_str = str;
        m_nums = nums;
        
        
    }

    public string Current => m_std;//m_3[x];

    object IEnumerator.Current => m_std;//m_3[x];

    public void Dispose()
    {
        
    }

    public bool MoveNext()
    {
        
        int count = 0;
        for (int i= m_nums-3;i<m_nums;i++){
            m_std += m_str[i];
            if(i%3 ==0){
                if (i!=0){
                    Console.WriteLine(m_std);
                    m_std = null;
                    count =+1;
                }
            }
        }
        //string m_str2 =null;
        //for (int i = m_nums -3;i< m_nums ; i++)
        //{
        //    m_str2 += m_str[i];
        //}
        //m_3[x]=(m_str2);
        //if(x<(m_str.Length/3)+1){
        //    x+=1;
        //}
        m_nums += 3;
        
        return m_nums < m_str.Length;
    }

    public void Reset()
    {
        m_nums = -3;

    }
}
public class SPlitStr: IEnumerable<string>
{
    private int m_std;
    private string m_str;
    private int m_nums ;
    public SPlitStr(string str, int nums)
    {
        m_str = str;
        m_nums = nums;
    }

    public IEnumerator<string> GetEnumerator()
    {
        return new SPlitStri(this.m_str, this.m_nums);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new SPlitStri(this.m_str, this.m_nums);
    }
}
