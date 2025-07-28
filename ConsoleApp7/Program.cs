using System;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        int perSmall = 25; 
        int perLarge=35;
        double taxRate = 0.06;
        Console.WriteLine("Estimate for carpet cleaning service");
        Console.Write("Number of small carpets: ");
        int smallCarpets =Convert.ToInt32(Console.ReadLine());
        Console.Write("Number of large carpets: ");
        int largeCarpets =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Price per small room: {perSmall}$");
        Console.WriteLine($"Price per large room: {perLarge}$");
        int cost = (smallCarpets * perSmall) + (largeCarpets*perLarge);
        Console.WriteLine($"Cost: {cost}$");
        double taxi = cost * 0.06;
        Console.WriteLine($"Tax: {taxi}");
        Console.WriteLine("===============================");
        Console.WriteLine($"Total estimate: {cost + taxi}");
        Console.WriteLine("This estimate is valid for 30 days");

    }
}
