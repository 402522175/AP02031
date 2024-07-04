using System;
using System.Diagnostics;

class Autostopwatch : IDisposable
{
    private Stopwatch m_task;

    public Autostopwatch(string task)
    {
        Console.WriteLine($"Start: {task}");
        m_task = Stopwatch.StartNew();
    }

    public void Dispose()
    {
        m_task.Stop();
        Console.WriteLine($"Task completed in {m_task.Elapsed}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        using (Autostopwatch asw = new Autostopwatch("task"))
        {
            for(int i = 0; i <= 10 ; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

