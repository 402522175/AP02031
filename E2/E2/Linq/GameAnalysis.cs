namespace E2;
using System;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

public class GameAnalysis
{
    public GameData[] GameDatas;
    public GameAnalysis(string path)
    {
        string[] lines = File.ReadAllLines(path);
        List<GameData> Games = new List<GameData>();
        for (int i = 1; i < lines.Length - 1; i++)
            try
            {
                var t = new GameData(lines[i].Replace(" ", "").Split(','));
                Games.Add(t);
            }
            catch
            {
            }
        GameDatas = Games.ToArray();
    }
    public long AllDataCount()
    {
        return GameDatas.Length;
    }
    public (string,long)[] MostFrequent()
    {
    
       //GameDatas.OrderBy(x=>x.genre).Take(5);
       //for(int i = 0; i < GameDatas.Length; i++)
       //{
       //    
       //}

        //return (gener:GameDatas[3],)   
        //TODO2
        throw new NotImplementedException();
    }
    public double[] BestPublisher()
    {
        //var BestPublisher = GameDatas.GroupBy(t=>t.Publisher).Where(x=>x.Year>=2000&&x=>x.Year<=2010).Select(g=>(global_sales:Math.Round(t=>t.Global_sales),3)).Take(5).;
        //IEnumerable<GameData> Games = GameDatas.GroupBy(t=>t.publisher).Select(g=>(global_sales:Math.Round(g.Average(t=>t.Global_sales),3))).ToList();
        // TODO3
        throw new NotImplementedException();
    }
    public string[] WestGamers(int limit1, int limit2)
    {
        //TODO4
        throw new NotImplementedException();
    }
    public string FaultyDatas()
    {
        //TODO5
        throw new NotImplementedException();
    }
}
