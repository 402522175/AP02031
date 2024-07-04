namespace s8;
using System;
using System.IO;
using System.Collections.Generic;




class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> pb = new Dictionary<string, string>();
        pb.Add("09380616588", "matin");
        pb.Add("09925393890","mryosefi");
        pb.Add("09123547821","mani");
        pb.Add("09037541657","farahbakhsh");
        string pathfile="phone_book.csv";
        string[] lines = new string[pb.Count];
        int index=0;
        for(int i=0;i<pb.Keys.Count;i++)
        {
            string phonenumber = pb.Keys.ElementAt(i);
            string Name = pb[phonenumber];
            lines[index]=$"{phonenumber}:{Name}";
            index++;
        }
        File.WriteAllLines(pathfile, lines);
        string phone=null;
        string name=null;
        string func=null;
        string value=null;
        if(args.Length>=2)
        {
            pathfile = args[0];
            func=args[1];
            if(args.Length==4)
            {
                pathfile = args[0];
                phone= args[1];
                name=args[2];
                func=args[3];
            }
            else if(args.Length==3)
            {
                pathfile = args[0];
                value=args[1];
                func=args[2];
            }
        }
        if(func=="add")
        {
            add(pb,pathfile,phone,name);
        }
        if(func=="removeAt")
        {
            removeAt(pathfile,int.Parse(value)); 
        }
        if(func=="remove")
        {
            remove(pathfile,phone,name);
        }
        if(func=="list")
        {
            List<string> numbers=list(pathfile);
            for(int i=0;i<numbers.Count;i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        if(func=="reverse")
        {
            reverse(pathfile);
        }
    }
    static void add(Dictionary<string,string> pb,string pathfile,string phone,string name)
    {
        pb.Add( phone, name);
        File.AppendAllText(pathfile,$"{phone}:{name}\n");
    }
    static void removeAt(string pathfile,int index)
    {
        List<string> phob=File.ReadAllLines(pathfile).ToList();
        phob.RemoveAt(index);
        File.WriteAllLines(pathfile,phob);
    }
    static void remove(string pathfile,string phone,string name)
    {
        List<string> list=File.ReadAllLines(pathfile).ToList();
        list.Remove($"{phone}:{name}");
        File.WriteAllLines(pathfile,list);
    }
    static List<string> list(string pathfile)
    {
        string[] lines = File.ReadAllLines(pathfile);
        List<string> nums = new List<string>(); 
        for(int i = 0;i <lines.Length;i++) 
                { 
                    if(lines[i] != "") 
                    {  
                        nums.Add(lines[i]); 
                    } 
                } 
        return nums; 
    }
    static void reverse(string pathfile)
    {
        List<string> nums=File.ReadAllLines(pathfile).ToList();
        nums.Reverse();
        File.WriteAllLines(pathfile,nums);
    }
    
}
