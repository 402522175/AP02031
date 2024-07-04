namespace E1
{
    public class MyString
    {
        public string Value;

        public MyString(string s)
        {
            Value = s;
        }

        public static explicit operator MyString(string s)
        {
            return new MyString(s);
        } 

        public static explicit operator string(MyString s)
        {
            return s.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is string)
            {
                string s = (string)obj;
                return s == Value;
            }
            if (obj is MyString)
            {
                MyString s = (MyString)obj;
                return s.Value == Value;
            }
            return false;
        }

        public static bool operator == (MyString s1, string s2)
        {
            return s1.Value == s2;
        }

        public static bool operator != (MyString s1, string s2)
        {
            return !(s1 == s2);
        }

        public static MyString operator ++ (MyString s)
        {
            string str = s.Value.ToUpper();
            return new MyString(str);
        }

        public static MyString operator -- (MyString s)
        {
            string str = s.Value.ToLower();
            return new MyString(str);
        }
    }
}