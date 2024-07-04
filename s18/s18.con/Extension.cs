public static class EXT 
{
    public static int Number_Count(this string str)
    {
        int count=0;
        foreach(var c in str)
        {
            if(char.IsNumber(c))
            {
                count++;
            }
        }
        return count;
    }

    public static string Ceasar(this string str)
    {
        int shift=5;
        char[] buffer = str.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            
            letter = (char)(letter + shift);
            if (letter > 'z')
            {
                letter = (char)(letter - 20);
            }
            else if (letter < 'a')
            {
                letter = (char)(letter + 20);
            }
            buffer[i] = letter;
        }
        return new string(buffer);
    }


}