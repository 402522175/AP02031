using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ_EX;

enum LifeExpectancyType {AtBirth, At60}
enum DataGender { Male, Female, Both}
class Data
{
    public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
    {
        LEType = leType;
        Year = year;
        Territory = territory;
        Country = country;
        DataGender = dg;
        Value = value;
    }

    public LifeExpectancyType LEType {get;}
    public int Year {get;}
    public string Territory {get;}
    public string Country {get;}
    public DataGender DataGender {get;}
    public double Value {get;}

    public override string ToString() =>
        $"{Country},{Year},{LEType},{DataGender},{Value}";

    public static Data Parse(string line)
    {
        var toks = line.Split(',').Select(t => t.Trim('"')).ToArray();        
        LifeExpectancyType leType = toks[0].Contains("60") ? 
                LifeExpectancyType.At60 :
                LifeExpectancyType.AtBirth;
        int year = int.Parse(toks[1]);
        string territory = toks[2].ToLower();
        string country = toks[3].ToLower();
        DataGender dg = toks[4].Contains("Both") ?
            DataGender.Both :
            (
                toks[4].Contains("Male") ? 
                    DataGender.Male :
                    DataGender.Female
            );
        double value = double.Parse(toks[5]);
        return new Data(leType, year, territory, country, dg, value);
    }
}

class Program
{    
    static void Main(string[] args)
    {
        var lines = File.ReadAllLines("data.csv").Skip(1);
        var data = lines.Select(Data.Parse).ToList();
        
        //Query 1
        Console.WriteLine("Query 1");
        var query1 = data
        .Where(d => d.Country=="iran" && 
                    d.LEType== LifeExpectancyType.AtBirth &&
                    d.DataGender==DataGender.Both)
        .OrderBy(d => d.Value);

        foreach (var line in query1){
            Console.WriteLine(line);
        }

        Console.WriteLine();

        //Query 2
        Console.WriteLine("Query 2");
        if(query1.Any())
        {
            double MinLifeExpectancy = query1.Min(d=>d.Value);
            double MaxLifeExpectancy = query1.Max(d=>d.Value);
            double Difference = MaxLifeExpectancy - MinLifeExpectancy;
            Console.WriteLine($"The LifeExpectancy difference:{Difference}");
        }

        Console.WriteLine();

        
        //Query 3
        Console.WriteLine("Query 3");
        int rank = 1;
        var filters = data
        .Where(d => d.DataGender==DataGender.Both &&
                    d.LEType==LifeExpectancyType.AtBirth);

        var grouping = filters
        .GroupBy(d => d.Country)
        .Select(g => new{
            Country = g.Key,
            MinValue = g.OrderBy(d => -(d.Value)).First(),
            MaxValue = g.OrderBy(d => d.Value).First(),
        })
        .Select(g => new{
            g.Country,
            YearWithMinValue=g.MinValue.Year,
            MinValue=g.MinValue.Value,
            Difference = g.MaxValue.Value - g.MinValue.Value
        })
        .OrderBy(g => -(g.Difference))
        .ToList();

        foreach(var item in grouping){
            Console.WriteLine($"{rank}-{item.Country}, Year With MinValue:{item.YearWithMinValue}, MinValue:{item.MinValue}, Improvement:{item.Difference}");
            Console.WriteLine();
            rank++;
        }

        Console.WriteLine();

        //Query 4
        Console.WriteLine("Query 4");
        rank = 1;
        var Filteres = data
                .Where(d => d.LEType == LifeExpectancyType.AtBirth);

            var Grouping = Filteres
                .GroupBy(d => new { d.Country, d.Year });

            var CY = Grouping
                .Select(g =>
                {
                    var maleData = g.First(d => d.DataGender == DataGender.Male);
                    var femaleData = g.First(d => d.DataGender == DataGender.Female);
                    return new
                    {
                        g.Key.Country,
                        g.Key.Year,
                        MaleLE = maleData.Value,
                        FemaleLE = femaleData.Value,
                        Difference = (femaleData.Value) - (maleData.Value)
                    };
                })
                .Where(d => d.MaleLE > 0 && d.FemaleLE > 0)
                .ToList();

            var MaxDif = CY
                .GroupBy(d => d.Country)
                .Select(g => g.OrderBy(d => -(d.Difference)).First());

            var Result = MaxDif
                .OrderBy(d => -(d.Difference))
                .ToList();

            
            foreach (var item in Result)
            {
                Console.WriteLine($"{rank}. {item.Country}, Year: {item.Year}, Male Life Expectancy: {item.MaleLE}, Female Life Expectancy: {item.FemaleLE}, Difference: {item.Difference}");
                Console.WriteLine();
                rank++;
            }
            
        Console.WriteLine();

    }
}
