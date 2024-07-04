namespace s6.con;
using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string pathfile="number.txt";
        string value=null;
        string func=null;
        if(args.Length>=2)
        {
            pathfile = args[0];
            func= args[1];
            if(args.Length>=3)
            {
                value=args[2];
            }
        }
        
        if(func=="add")
        {
            add(pathfile,value);
        }
        if(func=="removeAt")
        {
            removeAt(pathfile,int.Parse(value)); 
        }
        if(func=="removeAll")
        {
            removeAll(pathfile,value);
        }
        if(func=="remove")
        {
            remove(pathfile,value);
        }
        if(func=="max")
        {
            Console.WriteLine("Max: "+ max(pathfile));
        }
        if(func=="min")
        {
            Console.WriteLine("Min: " + min(pathfile));
        }
        if(func=="list")
        {
            List<int> numbers=list(pathfile);
            for(int i=0;i<numbers.Count;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        if(func=="sort")
        {
            sort(pathfile);
        }
        if(func=="reverse")
        {
            reverse(pathfile);
        }
        
        
    }
    static void add(string pathfile,string value)
    {
        List<string> nums=File.ReadAllLines(pathfile).ToList();
        nums.Add(value);
        File.WriteAllLines(pathfile,nums);
    }
    static void removeAt(string pathfile,int index)
    {
        List<string> nums=File.ReadAllLines(pathfile).ToList();
        nums.RemoveAt(index);
        File.WriteAllLines(pathfile,nums);
    }
    static void removeAll(string pathfile,string value)
    {
        string[] lines = File.ReadAllLines(pathfile);
        List<string> filter = new List<string>();
        for(int i=0;i<lines.Length;i++)
        {
            if(lines[i]!=(value))
            {
                filter.Add(lines[i]);
            }
        }
        File.WriteAllLines(pathfile,filter);
    }
    static void remove(string pathfile,string value)
    {
        List<string> nums=File.ReadAllLines(pathfile).ToList();
        nums.Remove(value);
        File.WriteAllLines(pathfile,nums);
    }
    static List<int> list(string pathfile)
    {
        string[] lines = File.ReadAllLines(pathfile);
        List<int> nums = new List<int>(); 
        int ex;
        for(int i = 0;i <lines.Length;i++) 
                { 
                    if(lines[i] != "") 
                    { 
                        ex = int.Parse(lines[i]); 
                        nums.Add(ex); 
                    } 
                } 
        return nums; 
    }
    static string max(string pathfile)
    {
        List<string> nums=File.ReadAllLines(pathfile).ToList();
        int max=int.Parse(nums[0]);
        for(int i=0;i<nums.Count;i++)
        {
            if(int.Parse(nums[i])>max)
            {
                max=int.Parse(nums[i]);
            }
        }
        return max.ToString();
    }
    static string min(string pathfile)
    {
        List<string> nums=File.ReadAllLines(pathfile).ToList();
        int min=int.Parse(nums[0]);
        for(int i=0;i<nums.Count;i++)
        {
            if(int.Parse(nums[i])<min)
            {
                min=int.Parse(nums[i]);
            }
        }
        return min.ToString();
    }
    static void reverse(string pathfile)
    {
        List<string> nums=File.ReadAllLines(pathfile).ToList();
        nums.Reverse();
        File.WriteAllLines(pathfile,nums);
    }
    static void sort(string pathfile)
    {
        List<string> nums=File.ReadAllLines(pathfile).ToList();
        nums.Sort();
        File.WriteAllLines(pathfile,nums);
    }
}