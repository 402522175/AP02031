namespace E1;

public partial class Basics
{
    #region TODO
    // Q0_Reverse
    // Q1_Reverse
    // Q2_Reverse
    // Q5_CalculateSum
    // Q6_TryCalculateSum
    #endregion

    public static void Q0_Reverse(int[] nums)
    {
        if (nums.Length > 3)
        for (int i = 1; i < (nums.Length -1)/2 ; i++)
        {
            int temp = nums[i];
            nums[i] = nums[nums.Length - i - 1];
            nums[nums.Length - i - 1] = temp;
        }
    }

    public static int[] Q1_Reverse(int[] nums)
    {
        int[] result = new int[nums.Length];
        if (nums.Length != 0)
        {
        result[0] = nums[0];
        result[nums.Length-1] = nums[nums.Length-1];
        if (nums.Length > 3)
        for (int i = 1; i < nums.Length -1 ; i++)
        {
            result[i] = nums[nums.Length - i-1];
        }
        }
        return result;
    }

    public static void Q2_Reverse<T>(T[] nums)
    {
        if (nums.Length > 3)
        for (int i = 1; i < (nums.Length -1)/2 ; i++)
        {
            T temp = nums[i];
            nums[i] = nums[nums.Length - i - 1];
            nums[nums.Length - i - 1] = temp;
        }
    }

    public static int Q5_CalculateSum(string s)
    {
        try
        {
        if (s[s.Length - 1] == '+')
        {
            throw new InvalidDataException();
        }
        int sum = 0;
        string[] ss =  s.Split('+');
        foreach (string s2 in ss)
        {
            sum += int.Parse(s2);
        }
        return sum;
        }
        catch (FormatException)
        {
            throw new FormatException("");
        }
    }

    public static bool Q6_TryCalculateSum(string s, out int value)
    {
        value = 0;
        if (s[s.Length - 1] == '+')
        return false;
        string[] a = s.Split('+');
        for (int i = 0; i < a.Length; i++)
        {
            if(!(int.TryParse(a[i], out int x)))
            {
                return false;
            }
            value += int.Parse(a[i]);
        }
        return true;
    }
}

#region TODO
// IHasAge
// Human
#endregion

public interface IHasAge
{
    public int GetAge();
}

public class Human : IHasAge
{
    public string Name;
    public int Age;

    public Human(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int GetAge()
    {
        return Age;
    }
}