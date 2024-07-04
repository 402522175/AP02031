public class Arrey
{
    public int X;
    public Arrey(int x)
    {
        this.X= x;
        int [][] arr = new int [X][];
        int [] list = new int [X+1];
        int c = 1;
        list[0] = 1;
        int num = 2;
        while (c < X+1)
        {
            bool IsPrime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                list[c] = num;
                c++;
            }

            num++;
        }
        for(int i = 0; i < X; i++)
        {
            arr[i] = new int [i+2];
        }
        for (int i = 0; i<X; i++)
        {
            for (int j = 0; j< i+2 ; j++)
            {
               arr[i][j] = list[j];
               Console.WriteLine(arr[i][j]);
            }
        }
    }
}